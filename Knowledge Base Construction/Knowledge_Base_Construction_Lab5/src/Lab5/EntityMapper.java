package Lab5;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.Writer;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;

public class EntityMapper {

    /**
     * Takes as input (1) one knowledge base (2) another knowledge base.
     * 
     * Prints "entity1 TAB entity2 NEWLINE" to the file results.tsv, if the first
     * entity from the first knowledge base is the same as the second entity
     * from the second knowledge base. Output 0 or 1 line per entity1.
     */

    public int calculateScore(Map<String, Set<String>> map1, Map<String, Set<String>> map2){
        int score = 0;

        for (Set<String> set1:map1.values()){
            for(String str1:set1){
                for (Set<String> set2:map2.values()){
                    for (String str2:set2){
                        String[] toMatch = str2.split("^^");
                        if (str1.equals(toMatch[0]))
                            score++;
                    }
                }
            }
        }

        return score;
    }
    public static void main(String[] args) throws IOException {
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/dbpedia.tsv", "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/yago.tsv"};
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/yago-anonymous.tsv", "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/yago.tsv"};
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/yago-anonymous.tsv", "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab5/dbpedia.tsv"};
        EntityMapper main = new EntityMapper();

        KnowledgeBase kb1 = new KnowledgeBase(new File(args[0]));
        KnowledgeBase kb2 = new KnowledgeBase(new File(args[1]));
        try (Writer out = new OutputStreamWriter(new FileOutputStream("results.tsv"), "UTF-8")) {
            for (String entity1 : kb1.facts.keySet()) {
                String mostLikelyCandidate = null;

                Map<String, Set<String>> map1 = new TreeMap<>();
                Map<String, Set<String>> map2 = new TreeMap<>();
                if (kb2.facts.containsKey(entity1)) {
                    mostLikelyCandidate = entity1;
                }
                else {
                    int bestScore = 0;
                    map1 = kb1.facts.get(entity1);
                    for (String entity2 : kb2.facts.keySet()) {
                        map2 = kb2.facts.get(entity2);
                        int score = main.calculateScore(map1, map2);
                        if (score > bestScore){
                            bestScore = score;
                            mostLikelyCandidate = entity2;
                        }
                    }
                }

                if (mostLikelyCandidate != null) {
                    out.write(entity1 + "\t" + mostLikelyCandidate + "\n");
                }
            }
        }
    }
}
