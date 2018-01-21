package Lab3;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.Writer;
import java.util.ArrayList;

/**
 * Skeleton code for a type extractor.
 */
public class TypeExtractor {

    /**
     * Given as argument a Wikipedia file, the task is to run through all Wikipedia articles,
     * and to extract for each article the type (=class) of which the article
     * entity is an instance. For example, from a page starting with "Leicester is a city",
     * you should extract "city".
     * <p>
     * - extract just the head noun ("American rock star" -> "star")
     * - if the type cannot reasonably be extracted ("Mathematics was invented in the 19th century"),
     * skip the article (do not output anything)
     * - take only the first item of a conjunction ("and")
     * - do not extract too general words ("type of", "way", "form of")
     * - keep the plural
     * <p>
     * The output shall be printed to file "result.tsv" in the form
     * entity TAB type NEWLINE
     * with one or zero lines per entity.
     */
    public String getPageType(Page nextPage) {

        int firstOccurence = -1;
        int count = 0;
        ArrayList<String> words = new ArrayList<String>();
        ArrayList<String> tags = new ArrayList<String>();
        String[] fSplit = nextPage.content.split(" ");
        for (String word : fSplit) {
            String[] sSplit = word.split("/");
            words.add(sSplit[0]);
            tags.add(sSplit[1]);
            if (sSplit[1].startsWith("V") && firstOccurence==-1)
                firstOccurence = count;
            count++;
        }
        String str = null;
        String last = null;
        int k = 0;
        String startingWithNN = null;
        if (firstOccurence != -1) {
            for (int j = firstOccurence; j < tags.size(); j++) {
                if (tags.get(j).equals("NN") || tags.get(j).equals("NNS")) {
                    if ((words.get(j + 1).equals("of") )&& (tags.get(j+2).equals("NN")  )) { //|| tags.get(j+2).equals("NNS")
                                startingWithNN = tags.get(k);
                                k = j+2;
                                break;
                    }
                    else {
                        k = j;
                        startingWithNN = tags.get(k);
                        break;
                    }
                }
            }
        }
        if (startingWithNN!=null){
            if (firstOccurence != -1){
                str = words.get(k);
                if (tags.get(k).equals("NN")) {
                    for (int i = k; i < tags.size(); i++) {
                        if (tags.get(i).equals("NN"))
                            last = words.get(i);
                        else break;
                    }
                }
                else last = str;
            }
        }
        return last;
        }
    public static void main(String args[]) throws IOException {

        args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab3/wikipedia-first-pos.txt"};
        try (Writer out = new OutputStreamWriter(new FileOutputStream("results.tsv"), "UTF-8")) {
            try (Parser parser = new Parser(new File(args[0]))) {
                while (parser.hasNext()) {
                    TypeExtractor extractor = new TypeExtractor();
                    Page nextPage = parser.next();
                    String type = extractor.getPageType(nextPage);
                    if (type != null) out.write(nextPage.title + "\t" + type + "\n");
                }
            }
        }
    }

}