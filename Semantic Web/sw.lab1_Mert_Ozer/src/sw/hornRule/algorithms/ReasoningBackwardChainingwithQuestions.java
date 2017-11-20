/**
 * 
 */
package sw.hornRule.algorithms;

import sw.hornRule.models.*;

import java.util.HashSet;
import java.util.Scanner;

/**
 * @author  <Mert Ozer>
 *
 */
public class ReasoningBackwardChainingwithQuestions extends AlogrithmChaining {

	@Override
	public boolean entailment(Formalism ruleBase, Formalism factBase, Formalism Query) {
		// When a literal (i.e. a variable or its negation) cannot be replied by deductive reasoning,
		// it will be asked to users to give an answer (if the liter holds according to the user)
		return backwardChaining(ruleBase,factBase,Query);
	}

	public boolean backwardChaining(Formalism ruleBase, Formalism factBase, Formalism query) {
		//FB ← FB init
		FactBase fb = (FactBase) factBase;
		HornRuleBase rules = (HornRuleBase) ruleBase;
		//if match(Q, FB) then
		if (match(query.toString(),fb))
			return true;
		else
		{
			// for all Rule r : If l 1 And l 2 And ... And l n
			for (HornRule r: rules.getRules()){
				// match(Q, Conc)
				Object[] objects = r.getConclusions().toArray();
				for (Object var: objects){
					if(var.toString().equals(query.toString())){
						boolean bool = true;
						int i = 1;
						Object[] array = r.getConditions().toArray();
						int n = array.length;
						//while bool And i ≤ n do
						while (bool == true && i <= n ){
							Formalism condition = (Formalism) array[i-1];
							bool = backwardChaining(ruleBase,fb,condition);
							i++;
						}
						if (bool){
							return true;
						}
					}
				}
			}
			if (demandable(query.toString())){
				HashSet<Variable> facts = fb.getFact();
				Variable var = new Variable(query.toString());
				facts.add(var);
				fb.setFact(facts);
				return true;
			}
			//else return false;
			return false;
		}
	}

	public boolean match (String l, FactBase factBase){
		if (factBase.contains(l))
			return true;
		else
			return false;
	}

	public boolean demandable(String query){
		System.out.println("Is query "+query+" True or False?");
		Scanner reader = new Scanner(System.in);
		boolean bn = reader.nextBoolean();
		return bn;
	}


	@Override
	public int countNbMatches() {
		// TODO To complete
		return 0;
	}

}
