import java.util.logging.Logger;		

import junit.framework.Assert;
import junit.framework.TestCase;
@SuppressWarnings("deprecation")
public class SingletonTest extends TestCase {		// KLASIK SINGLETON CLASSININ J BIRIMLER ILE KONTROLU
   private Board sone = null, stwo = null;
   private static Logger logger = Logger.getAnonymousLogger();
   public SingletonTest(String name) {
      super(name);
   }
   public void setUp() {
      logger.info("getting singleton...");
      sone = Singleton.getInstance(0,"");
      logger.info("...got singleton: " + sone);
      logger.info("getting singleton...");
      stwo = Singleton.getInstance(0,"");
      logger.info("...got singleton: " + stwo);
   }
   public void testUnique() {
      logger.info("checking singletons for equality");
      Assert.assertEquals(true, sone == stwo);
   }
}
