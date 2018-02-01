
public class Singleton {					// KLASIK SINGLETON PATTERN
   private static Board instance = null;	
   protected Singleton() {
      // Exists only to defeat instantiation.
   }
   public static Board getInstance(int number,String difficulty) {
      if(instance == null) {
         instance = new Board(number,difficulty);
      }
      return instance;
   }
}
