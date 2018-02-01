import java.util.ArrayList;
import java.util.HashSet;
import java.util.Random;
import java.util.Set;


public class SudokuSolver {					// SUDOKU COZME VE OLUSTURMA CLASI

	public static ArrayList<Integer> listrow ;		// SUDOKU OLUSTURURKEN  BIR SIRA (9) TANE BIRBIRINDEN FARKLI SAYI TUTMAK ICIN VAR
	public  int[][] board ;							// TAHTA MATRISI OLUSTURULDU.
	    private static Set<Integer> getNumber(int[][] board, int row, int col) {
	        final Set<Integer> intsToAvoid = new HashSet<Integer>();

	        //SIRA KONTROLU
	        for (int i = 0; i < board[0].length; i++) {
	            if (board[row][i] > 0) {
	                intsToAvoid.add(board[row][i]);
	            }
	        }

	        // SUTUN KONTROLU
	        for (int i = 0; i < board.length; i++) {
	            if (board[i][col] > 0) {
	                intsToAvoid.add(board[i][col]);
	            }
	        }

	        // KUTUCUK KONTROLI
	        int lowerRowIndex = (row / 3) * 3;
	        int lowerColumnIndex =  (col / 3) * 3;

	        for (int i = lowerRowIndex; i < lowerRowIndex + 3; i++) {
	            for (int j = lowerColumnIndex; j < lowerColumnIndex + 3; j++) {
	                if (board[i][j] > 0) {
	                    intsToAvoid.add(board[i][j]);
	                }
	            }
	        }

	        final Set<Integer> candidateInts = new HashSet<Integer>();
	        for (int i = 1; i <= board.length; i++) {
	            if (!intsToAvoid.contains(i)) { 
	                candidateInts.add(i);
	            }
	        }
	        return candidateInts;
	    }

	    private static boolean solveSudoku (int[][] board, int row, int col) { // MATRISI DOLASMA.SIMDIKI SATIRDAKI BUTUN SUTUNLAR DOLASILDIKTAN SONRA DIGER SATIRA GECER
	        if (col == board[0].length) {
	            row++;
	            if (row == board.length) {
	                return true;
	            }
	            col = 0;
	        }
	        if (board[row][col] > 0) {
	            return solveSudoku(board, row, col + 1);
	        } else {
	            for (int i : getNumber(board, row, col)) {
	                board[row][col] = i;
	                if (solveSudoku(board, row, col + 1)) return true;
	                board[row][col] = 0;
	            }
	        }
	        return false;
	    }

	    public static boolean solve (int[][] sudoku) {			// SUDOKU COZME VE OLUSTURMA
	        return solveSudoku(sudoku, 0, 0);
	    }
	    public  void solver() {							// RASTGELE BIR SATIR OLUSTUR VE SUDOKUYU COZER.9! TANE FARKLI SUDOKU TAHTASI VAR.DAHA FAZLA YAPILABILIRDI.AMA GEREK DUYMADIM.
	    	int random;
	    	listrow = new ArrayList<Integer>() ;
	    	 board = new int [9][9];
	    	 for (int  i = 0; i < board.length; i++) 
		            for (int j = 0; j < board[0].length; j++) 
		               board[i][j] = 0;
	    	
	    	 for(int i = 0 ; i <9 ; i++)
	    	 {
	    	do
	    	{
	    		Random r = new Random();
	    		random = r.nextInt(9)+1;
	    	}while(listrow.contains(random)==true);
	    		
	    		listrow.add(random);
	    		board[0][i] = random;
	    		
	    	 }
	    	 
	      solve (board);       //SUDOKU COZ VE OLUSTUR
	        
	    }
	    public void converter(int number)				//ZORLUGA GORE TAHTADA DEGERLERI KAPATIR.
	    {
	    	ArrayList<Integer> list = new ArrayList<Integer>();
	    	int random ;
	    	for(int i = 0 ; i < number ;i++)
	    	{
	    		Random r = new Random();
	    		random = r.nextInt(81);
	    		list.add(random);   		
	    	}
	    	for(int j = 0 ; j < number ;j++)
	    	{
	    		int num = list.get(j);
	    		int row = num / 9;
	    		int column = num % 9 ;
	    		board[column][row] = 0 ;
	    		
	    		
	    	}
	    	
	    	
	    	
	    }
	    
	    
	    
	
}
