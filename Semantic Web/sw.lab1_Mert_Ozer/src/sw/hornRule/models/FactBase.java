package sw.hornRule.models;

import java.util.HashSet; 

public class FactBase extends Formalism{
	HashSet<Variable> facts;

	public FactBase(HashSet<Variable> facts) {
		super();
		this.facts = facts;
	}
	public boolean contains(String l){
		for (Variable r: facts){
			if (r.toString().equals(l)){
				return true;
			}
		}
		return false;
	}

	public FactBase() {
		this.facts = new HashSet<Variable>(); 
	}

	public HashSet<Variable> getFact() {
		return facts;
	}

	public void setFact(HashSet<Variable> facts) {
		this.facts = facts;
	}

	@Override
	public String toString() {
		return "facts=" + facts +"\n";
	}
	
}
