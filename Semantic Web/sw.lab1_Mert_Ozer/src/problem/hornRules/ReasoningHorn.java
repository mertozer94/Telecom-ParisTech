package problem.hornRules;
 
import java.io.OutputStream;
import java.util.HashSet;
import java.util.prefs.Preferences;

import sw.hornRule.algorithms.*;
import sw.hornRule.models.*;

public class ReasoningHorn {

	public static void main(String[] args) {
		
		ReasoningForwardChaining reasoner = new ReasoningForwardChaining();
		Tutorial1 pb = new Tutorial1();
		HornRuleBase kb = pb.getRuleBase();
		FactBase fb = pb.getFactBase();

		for(HornRule r: kb.getRules()){
			System.out.println(r);
		}
		System.out.print("\nThe fact base is: \n");
		System.out.print(fb);
		// forward
		HashSet<Variable> inferredAllFacts = reasoner.forwardChaining(kb,fb).getFact();
		System.out.println("All the inferred facts are:");
		for(Variable s: inferredAllFacts){
			System.out.println(s);
		}

		System.out.println("\nForward");
		Variable q = new Variable("transoceanic_race");
		if(reasoner.entailment(kb, fb, q))
			System.out.println("\nYes, the query is entailed by the given rules and facts");
		else
			System.out.println("\nNo, the query is not entailed based on the given rules and facts");
		// backward
		ReasoningBackwardChaining backward = new ReasoningBackwardChaining();
		System.out.println("\nBackward");
		Variable q_back = new Variable("transoceanic_race");
		if(backward.entailment(kb, fb, q_back))
			System.out.println("\nYes, the query is entailed by the given rules and facts");
		else
			System.out.println("\nNo, the query is not entailed based on the given rules and facts");
		// backward questions

		ReasoningBackwardChainingwithQuestions baseQuestionsChaining = new ReasoningBackwardChainingwithQuestions();
		System.out.println("\nBackward Questions");
		Variable backward_Questions = new Variable("sailboat_cruise");
		FactBase baseQuestions = new FactBase();
		HashSet<Variable> varQuestions = new HashSet<Variable>();
		Variable one = new Variable("boat");
		Variable two = new Variable("sail");
		varQuestions.add(one);
		varQuestions.add(two);
		baseQuestions.setFact(varQuestions);
		if(baseQuestionsChaining.entailment(kb, baseQuestions, backward_Questions))
			System.out.println("\nYes, the query is entailed by the given rules and facts");
		else
			System.out.println("\nNo, the query is not entailed based on the given rules and facts");

		//forward optimized
		/*
		ReasoningForwardChainingOptimised f_optimized = new ReasoningForwardChainingOptimised();
		System.out.println("\nForward Optimized");
		Variable q_optimized = new Variable("transoceanic_race");
		if(f_optimized.entailment(kb, fb, q_optimized))
			System.out.println("\nYes, the query is entailed by the given rules and facts");
		else
			System.out.println("\nNo, the query is not entailed based on the given rules and facts");
		*/

	}
}
