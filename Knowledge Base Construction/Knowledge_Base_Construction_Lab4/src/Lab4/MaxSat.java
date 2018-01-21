package Lab4;

import java.io.File;
import java.io.IOException;
import java.io.Writer;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;

/**
 * Takes as argument a Max-Sat-file or a folder of Max-Sat-files, 
 * writes a KB to the corresponding output file(s).
 * Does not take longer than 5 minutes.
 */
public class MaxSat {

    /** Start time*/
    public static long startTime;

    /** TRUE if we have to stop*/
    public static boolean haveToStop() {
        return (System.currentTimeMillis() - startTime > 5 * 60 * 1000);
    }
    public List<Clause> getRulesWithSizeOne(Set<Atom> bestKB, List<Clause> rules){
        List<Clause> newRules = new ArrayList<Clause>();
        for (Clause rule:rules){
            Clause clause = new Clause(rule.atoms,rule.weight);
            for (Atom atom:rule.atoms){
                if (rule.atoms.size() == 1) {
                    bestKB.add(atom);
                    newRules.add(clause);
                }
            }
        }
        return newRules;
    }
    public List<Atom> getRulesWithNegations(List<Clause> ruleWithSizeOne, List<Clause> rules) {
        List<Atom> atoms = new ArrayList<>();

        for (Clause clause:ruleWithSizeOne){
            for (Atom atom:clause.atoms){
                for (Clause allClauses:rules){
                 for (Atom allAtoms:allClauses.atoms){
                     if (atom.negation().equals(allAtoms) )
                        atoms.add(allAtoms);
                 }
                }
            }

        }
        return atoms;
    }
    public void removeRulesWithSizeOne (List<Clause> ruleWithSizeOne, List<Clause> rules){

        for (Clause clauseWithSizeOne:ruleWithSizeOne){
            Iterator<Clause> iterator = rules.iterator();

            while (iterator.hasNext()){
                Clause clause = iterator.next();
                if (clauseWithSizeOne.atoms.equals(clause.atoms)){
                    iterator.remove();
                }
                else if (clause.atoms.size() == 0)
                    iterator.remove();
            }
        }
    }
    public void removeNegationOfAtoms(List<Atom> negationOfAtoms, List<Clause> rules){
        for (Atom negatedAtom:negationOfAtoms){

            //Iterator<Clause> iteratorRules = rules.iterator();

            //while (iteratorRules.hasNext()){
            for (Clause clause:rules){
                //Clause clause = iteratorRules.next();
                if (clause.atoms.contains(negatedAtom)){
                    Iterator<Atom> iteratorAtoms = clause.atoms.iterator();
                    //for (Atom atom: clause.atoms){
                    while (iteratorAtoms.hasNext()){
                        Atom atom = iteratorAtoms.next();
                        if (negatedAtom.equals(atom)){ // maybe change this to smt else
                            iteratorAtoms.remove();
                        }
                    }
                }
            }
        }
    }
    public void removeClausesContainingAtoms(List<Clause> ruleWithSizeOne, List<Clause> rules){
        for (Clause clauseWithSizeOne:ruleWithSizeOne){
            Iterator<Clause> iterator = rules.iterator();

            while (iterator.hasNext()){
                Clause clause = iterator.next();
                // simple contains not working ?

                for (Atom atom:clause.atoms){
                    //if (atom.predicate.equals(clauseWithSizeOne.atoms.get(0).predicate) && atom.isPositive == clauseWithSizeOne.atoms.get(0).isPositive)
                    if (atom.equals(clauseWithSizeOne.atoms.get(0)))
                        iterator.remove();
                }
                //if (clause.atoms.contains(clauseWithSizeOne)){
                  //  iterator.remove();
                //}
            }
        }
    }
    public boolean hasOneClause (List<Clause> rules){
        for (Clause clause:rules){
            if(clause.atoms.size() == 1)
                return true;
        }
        return false;
    }

        public static void main(String[] args) throws IOException {
        MaxSat maxSat = new MaxSat();
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab4/problems"};
        File argument = new File(args[0]);
        for (File file : argument.isDirectory() ? argument.listFiles() : new File[] { argument }) {
            startTime = System.currentTimeMillis();
            List<Clause> rules = Clause.readFrom(file);
            List<Clause> ruleWithSizeOne = new ArrayList<>();
            List<Atom> negationOfAtoms = new ArrayList<>();
            // if it outputs positive always then add
            Set<Atom> bestKB = new HashSet<>();

            while(true){
            do {
                ruleWithSizeOne = maxSat.getRulesWithSizeOne(bestKB, rules);
                maxSat.removeRulesWithSizeOne(ruleWithSizeOne, rules);
                maxSat.removeClausesContainingAtoms(ruleWithSizeOne, rules);
                negationOfAtoms = maxSat.getRulesWithNegations(ruleWithSizeOne, rules);
                maxSat.removeNegationOfAtoms(negationOfAtoms, rules);
            } while (maxSat.hasOneClause(rules));


                if (!maxSat.haveToStop()){break;}
            }
            try (Writer out = Files.newBufferedWriter(Paths.get(file.getName().replaceAll("\\.[a-z]+$", ".res")),
                    Charset.forName("UTF-8"))) {
                for (Atom var : bestKB)
                    if (var.isPositive()) out.write(var + "\n");
            }
        }
    }
}
