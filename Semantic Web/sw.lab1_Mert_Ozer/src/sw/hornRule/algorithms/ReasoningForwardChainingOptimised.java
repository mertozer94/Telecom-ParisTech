/**
 * 
 */
package sw.hornRule.algorithms;

import sw.hornRule.models.*;

import java.util.ArrayList;
import java.util.HashSet;

/**
 * @author  <Mert Ozer>
 *
 */
public class ReasoningForwardChainingOptimised extends AlogrithmChaining {
	
	/**
	 * @param a knowledge base ruleBase (in a given formalism)
	 * @param a base of facts : factBase (in a given formalism)
	 * @return the saturation of KB w.r.t. facts (the minimal fix point of KB from facts)
	 */
	public FactBase forwardChainingOptimise(Formalism ruleBase, Formalism factBase){
		//It's your turn to implement the algorithm
		HornRuleBase rules = (HornRuleBase) ruleBase;
		// FB ← FB init
		FactBase fb = (FactBase) factBase;
		// for all fact F ∈ FB init do
		for (Variable var:((FactBase) factBase).getFact()){
			// FB ← FB ∪ Propagate(F , RB)
			HashSet<Variable> facts = fb.getFact();
			FactBase result = Propagate(fb,rules);
			for (Variable r: result.getFact()){
				facts.add(r);
			}
			fb.setFact(facts);
		}
		return fb;
	};

	public FactBase Propagate(Formalism ruleBase, Formalism factBase){
		HornRuleBase rules = (HornRuleBase) ruleBase;
		FactBase fb = (FactBase) factBase;

		//∆F ← ∅
		FactBase deltaF = null;
		//for all rule R ∈ InRuleConditions(F ) do
		for (Variable r:rules.getConditions()){
			//Delete from conditions(R) the atom l such that match(l, condition(R))
			if(r.toString().isEmpty()){
				// RB ← RB \ {R}
				ArrayList<HornRule> list = rules.getRules();
				list.remove(r);
				rules.setRules(list);
				// ∆F ← ∆F ∪ conclusions(R)
				HashSet<Variable> facts = deltaF.getFact();
				FactBase result = Propagate(deltaF,rules);
				for (Variable var: result.getFact()){
					facts.add(var);
				}
				deltaF.setFact(facts);
			}
		}
		fb = deltaF;
		for (Variable a:fb.getFact()){
			// FB ← FB ∪ Propagate(F , RB)
			HashSet<Variable> facts = fb.getFact();
			FactBase result = Propagate(fb,rules);
			for (Variable r: result.getFact()){
				facts.add(r);
			}
			fb.setFact(facts);
		}
		return (FactBase) factBase;
	}

	public boolean match (String l, FactBase factBase){
		if (factBase.contains(l))
			return true;
		else
			return false;
	}


	public boolean entailment(Formalism ruleBase, Formalism factBase, Formalism query) {
		FactBase allInferredFacts = forwardChainingOptimise(ruleBase, factBase);
		if(allInferredFacts.getFact().contains(query))
			return true;
		else
			return false;
	}

	@Override
	public int countNbMatches() {
		// TODO Auto-generated method stub
		return 0;
	}

}
