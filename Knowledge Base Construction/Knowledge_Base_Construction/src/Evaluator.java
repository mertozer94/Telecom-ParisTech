import java.io.*;
import java.util.HashMap;
import java.util.LinkedHashSet;
import java.util.Map;
import java.util.Set;

/**
 * Skeleton for an evaluator
 */
public class Evaluator {

	/**
	 * Takes as arguments (1) the gold standard and (2) the output of a program.
	 * Prints to the screen one line with the precision
	 * and one line with the recall.
	 */
	public final Map<String, Set<String>> goldStandart = new HashMap<>();

	public final Map<String, Set<String>> results = new HashMap<>();


	public Evaluator (File gs, File res) throws IOException {
		load(gs, goldStandart, false);
		load(res, results, false);
	}
	public double getCommon (){
		int count = 0;
		for (String str:goldStandart.keySet()){
			if(results.get(str).equals(goldStandart.get(str))){
				count ++;
			}
		}
		return count;
	}
	public double getPrecisionDivision (){
		int presicionDivision = 0;
		for (String str:results.keySet()){
			if(goldStandart.containsKey(str)){
				presicionDivision ++;
			}
		}
		return presicionDivision;
	}
	public double getResultSize(){return (double)results.size();}
	public double getGoldStandartSize(){return (double) goldStandart.size();}
	public static void load(File f, Map<String, Set<String>> container, boolean reverse) throws IOException {
		BufferedReader reader = new BufferedReader(new InputStreamReader(new FileInputStream(f), "UTF-8"));
		String line;
		while ((line = reader.readLine()) != null && line != "") {
			String[] split = line.split("\t");
			if (split.length != 2) {
				System.err.println("Error while loading");
				break;
			}
			String s = split[0].trim();
			String o = split[1].trim().replaceAll("^\"", "").replaceAll("\"$", "");
			if (reverse) {
				String t = s;
				s = o;
				o = t;
			}
			// If there are memory problems, try this:
			//s = s.intern();
			//o = o.intern();
			Set<String> l = container.get(s);
			if (l == null) {
				l = new LinkedHashSet<String>();
				container.put(s, l);
			}
			l.add(o);
		}
		reader.close();
	}


	public static void main(String[] args) throws Exception {
		File gs = new File("src/goldstandard-sample.tsv");
		File results = new File("results.tsv");
		Evaluator db = new Evaluator(gs, results);

		System.out.println("Recall = "+ Double.toString( db.getCommon()/db.getGoldStandartSize()));
		System.out.println("Presicion = "+ Double.toString( db.getCommon()/ db.getPrecisionDivision()));
	}
}
