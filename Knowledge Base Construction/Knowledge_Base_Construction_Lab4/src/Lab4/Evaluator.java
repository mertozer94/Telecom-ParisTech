package Lab4;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.util.Set;
import java.util.stream.Collectors;


public class Evaluator {
    public static void main(String[] args) throws IOException {
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab4/problems"};
        File argument = new File(args[0]);
        for (File file : argument.isDirectory() ? argument.listFiles(f -> f.getName().endsWith(".txt"))
                : new File[] { argument }) {
            File result = new File(file.getName().replaceAll("\\.txt$", ".res"));
            if (!result.exists()) continue;
            Set<Atom> trueAtoms = Files.readAllLines(result.toPath()).stream().map(l -> new Atom(l))
                    .collect(Collectors.toSet());
            double weight = 0;
            System.out.println(file.getName() + ":");
            //System.out.println("  Unhappy clauses:");
            for (Clause rule : Clause.readFrom(file)) {
                if (rule.isSatisfiedIn(trueAtoms)) {
                    weight += rule.weight;
                } else {
                    //System.out.println("    " + rule);
                }
            }
            System.out.println("  Weight: " + weight);
        }
    }
}
