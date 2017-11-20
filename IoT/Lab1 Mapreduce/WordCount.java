import java.io.IOException;
import java.util.StringTokenizer;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapreduce.Job;
import org.apache.hadoop.mapreduce.Mapper;
import org.apache.hadoop.mapreduce.Reducer;
import org.apache.hadoop.mapreduce.lib.input.FileInputFormat;
import org.apache.hadoop.mapreduce.lib.output.FileOutputFormat;

public class WordCount {

    public static class TokenizerMapper extends Mapper<Object, Text, Text, IntWritable>{

        private final static IntWritable one = new IntWritable(1);
        private Text word = new Text();

        public void map(Object key, Text value, Context context) throws IOException, InterruptedException {
            StringTokenizer itr = new StringTokenizer(value.toString(),",");
            List<String> itemsets = new ArrayList<>();

            while (itr.hasMoreTokens()) {
                String str = itr.nextToken();
                itemsets.add(str);
            }
            Collections.sort(itemsets.subList(1, itemsets.size()));

            List<List<String>> outer = new ArrayList<>();
            outer = getSubsets(itemsets);

            for (List<String> inner:outer) {
                String subset = "";
                for (String s:inner) {
                    subset += s + ",";
                }
                //remove last ','
                if (subset.length() > 2){
                    //if support > 2 .. then
                    subset = subset.substring(0, subset.length() - 1);
                    word.set(subset);
                    context.write(word, one);
                }
            }

        }
    }
    static List<List<String>> getSubsets( List<String> set) {

        List<List<String>> outer = new ArrayList<>();
        int n = set.size();
        // Run a loop for all 2^n

        for (int i = 0; i < (1 << n); i++) {
            List<String> inner = new ArrayList<>();
            for (int j = 0; j < n; j++){

                if ((i & (1 << j)) > 0){
                    inner.add(set.get(j));
                }
            }
            outer.add(inner);
        }
        return outer;
    }
    public static class IntSumReducer extends Reducer<Text,IntWritable,Text,IntWritable> {
        private IntWritable result = new IntWritable();

        public void reduce(Text key, Iterable<IntWritable> values, Context context) throws IOException, InterruptedException {
            int sum = 0;
            for (IntWritable val : values) {
                sum += val.get();
            }
            result.set(sum);
            // remove pairs with only one element.
            if (key.toString().contains(",")){
                context.write(key, result);
            }

        }
    }

    public static void main(String[] args) throws Exception {
        Configuration conf = new Configuration();
        Job job = Job.getInstance(conf, "word count");
        job.setJarByClass(WordCount.class);
        job.setMapperClass(TokenizerMapper.class);
        job.setCombinerClass(IntSumReducer.class);
        //job.setNumReduceTasks(0);
        job.setReducerClass(IntSumReducer.class);
        job.setOutputKeyClass(Text.class);
        job.setOutputValueClass(IntWritable.class);
        FileInputFormat.addInputPath(job, new Path(args[0]));
        FileOutputFormat.setOutputPath(job, new Path(args[1]));
        System.exit(job.waitForCompletion(true) ? 0 : 1);
    }
}