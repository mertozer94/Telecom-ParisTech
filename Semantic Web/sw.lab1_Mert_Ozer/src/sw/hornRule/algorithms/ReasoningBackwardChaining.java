/**
 * 
 */
package sw.hornRule.algorithms;

import sw.hornRule.models.FactBase;
import sw.hornRule.models.Formalism;
import sw.hornRule.models.HornRule;
import sw.hornRule.models.HornRuleBase;

import java.io.ObjectStreamException;
import java.lang.reflect.Array;

/**
 * @author  <Mert Ozer>
 *
 */
public class ReasoningBackwardChaining extends AlogrithmChaining {

	public boolean entailment(Formalism ruleBase, Formalism factBase, Formalism query) {
		return backwardChaining(ruleBase,factBase,query);
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
			return false;
		}
	}
	public boolean match (String l, FactBase factBase){
		if (factBase.contains(l))
			return true;
		else
			return false;
	}
	@Override
	public int countNbMatches() {
		// TODO To complete
		return 0;
	}

}
