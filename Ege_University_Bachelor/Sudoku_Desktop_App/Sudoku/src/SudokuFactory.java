
public class SudokuFactory {
	 public Difficulty getType(String diffucultyType){			// FACTORY PATTERN
	      if(diffucultyType == null){
	         return null;
	      }
	      if(diffucultyType.equalsIgnoreCase("EASY")){
	         return new Easy();
	      } else if(diffucultyType.equalsIgnoreCase("NORMAL")){
	         return new Normal();
	      } else if(diffucultyType.equalsIgnoreCase("HARD")){
	         return new Hard();
	      }
	      return null;
	   }
	
	
	
}
