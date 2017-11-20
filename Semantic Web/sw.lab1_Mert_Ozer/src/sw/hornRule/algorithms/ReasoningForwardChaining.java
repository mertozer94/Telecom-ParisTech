/**
 * 
 */
package sw.hornRule.algorithms;

import sw.hornRule.models.*;
import java.util.HashSet;


/**
 * @author  <Mert Ozer>
 *
 */
public class ReasoningForwardChaining extends AlogrithmChaining {
 
	/**
	 * @param a knowledge base kb (in a given formalism)
	 * @param facts (in a given formalism)
	 * @return forwardChaining(ruleBase,factBase), also called the saturation of ruleBase w.r.t. factBase, 
	 * mathematically it computes the minimal fix point of KB from facts)
	 */
	//It's your turn to implement the algorithm, including the methods match() and eval()
	public FactBase forwardChaining(Formalism ruleBase, Formalism factBase){
		// s(FB) ← FB init
		FactBase sfb = (FactBase) factBase;
		FactBase fb = new FactBase();
		HornRuleBase rules = (HornRuleBase) ruleBase;

		// repeat until s(FB) = FB
		while (!fb.getFact().equals(sfb.getFact()))
		{
			// FB ← s(FB)
			fb = sfb;
			HashSet<HornRule> set = new HashSet<HornRule>();
			// for all rules
			for (HornRule r: rules.getRules()){
				// for all Rule R is not yet applied do
					if(!set.contains(r)){
						set.add(r);
						// if eval(R, FB)
						if (eval(r,fb)){
							//then s(FB) ← s(FB) ∪ conclusions(R)
							HashSet<Variable> facts = sfb.getFact();
							for (Variable var:r.getConclusions()){
								facts.add(var);
							}
							sfb.setFact(facts);
						}
					}
			}
		}
		return sfb;
	};
	public boolean match (String l, FactBase factBase){
		if (factBase.contains(l))
			return true;
		else
			return false;
	}
	public boolean eval (HornRule r, FactBase factBase){
		Object[] array = r.getConditions().toArray();

		for (Object a:array){
			if (match(a.toString(),factBase)){
			}
			else return false;
		}
		return true;
	}

	public boolean entailment(Formalism ruleBase, Formalism factBase, Formalism query) {
		FactBase allInferredFacts = forwardChaining(ruleBase, factBase);
		if(allInferredFacts.contains(query.toString()))
			return true;
		else
			return false;
	}

	@Override
	//It's your turn to implement this method
	public int countNbMatches() {
		// TODO Auto-generated method stub
		return 0;
	}

}
