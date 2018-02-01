
import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.border.Border;
import javax.swing.border.LineBorder;
public class Board extends JFrame{
	/**
	 * 
	 */

	private static final long serialVersionUID = 1L;
	public Board(final int number,final String difficulty){		
		SudokuSolver table = new SudokuSolver();		//SUDOKU TAHTASINA SAYILARI YERLESTIRMEK ICIN TAHTANIN HER ELEMANINI 0 ESITLER
		table.solver();									// RASTGELE OLARAK O . SIRAYA SAYILAR YERLESTIRIR.SUDOKU COZEN FONKSIYON OLDUGU ICIN GERI KALAN BOSLUKLARI TAMAMLAR.
		final int [][] solution = new int[9][9];		
		for (int k =0; k<9; k++)
			for(int i =0; i <=8; i++)
			{
				solution[k][i] = table.board[k][i];			// TAHTANIN ICINDEKI DEGERLERI DIGER BIR DEGISKENE AKTARIR.
			}
		table.converter(number);							// ZORLUGA GORE TAHTANIN ICINDEKI DEGERLERI RASTGELE OLARAK 0 A ESITLER.
		setTitle(difficulty);
		setSize(900,300);
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		
		final JTextField[][] allField = new JTextField [9][9];			//9 A 9 LUK. KULLANICIN GIRMESI ICIN TEXT FIELD OLUSTURULMASI.
		for (int k =0; k<9; k++)
			for(int i =0; i <=8; i++)
			{
				allField[k][i] = new JTextField(1);
				
				
			}
		setLayout(new GridLayout(1,2));
		Border lineBorder = new LineBorder(Color.BLACK,2);			// HER PARCASI  3 E 3 TEN OLUSAN 3 E 3 LUK BIR ALAN YARATIR.KISACASI BIR GORSEL SUDOKUYU OLUSTURUR.
		JPanel p2 = null;
		final JPanel p1 =  new JPanel(new GridLayout(3,3));

		for (int k =0; k<9; k++)
		{
			p2 = new JPanel(new GridLayout(3,3));
			p2.setBorder(lineBorder);
			for(int i =0; i <=8; i++){
				if(table.board[k][i]==0)					//ZORLUGA GORE ICERSINDEKI DEGERLER SIFIRLANMISTI.SIMDI KULLANICIYA SUNULACAK GORSEL SUDOKUDA DA DEGERLER KAPATILIYOR.
				{
					allField[k][i].setText(String.valueOf(""));
					p2.add(allField[k][i]);
				}
				else
				{
					allField[k][i].setEditable(false);		// KULLANICI VERILEN DEGERLERI DEGISTIREMEZ.SADECE BOSLUKLARI DEGISTIREBILIR.
					allField[k][i].setText(String.valueOf(table.board[k][i]));
					p2.add(allField[k][i]);
				}		
				
			}
			for(int i = 0; i <=8; i++){
				p1.add(p2);
			}
		}													// SUDOKU OLUSTU.
		JPanel Buttons = new JPanel(new GridLayout(2,3));
		JButton solve = new JButton("SOLVE");				//BUTONLARIN OLUSTURULMASI.
		JButton resetButton = new JButton("RESET");
		JButton newButton = new JButton("NEW PUZZLE");
		JButton checkButton = new JButton("CHECK");
		solve.setToolTipText("Solves the board");
		resetButton.setToolTipText("Resets all inputs from user");
		newButton.setToolTipText("Makes a new sudoku.");
		checkButton.setToolTipText("Checks if sudoku is correct.");
		Buttons.add(checkButton);
		Buttons.add(newButton);
		Buttons.add(resetButton);
		Buttons.add(solve);
		add(p1);	
		add(Buttons);
		resetButton.addActionListener(new ActionListener() {		// BUTONLARIN ISLEVLERI.BU BUTON KULLANICININ GIRDIGI BUTUN DEGERLERI SIFIRLAR.
			 
            public void actionPerformed(ActionEvent e)
            {
            	
            	for (int k =0; k<9; k++)
        			for(int i =0; i <=8; i++)
        			{
        				if(allField[k][i].isEditable())				// EGER KULLANICI GIRDIYSE
        				allField[k][i].setText(String.valueOf(""));		// ALANI BOSALTIR
        				if(allField[k][i].getBackground()==Color.YELLOW)		// HATALI GIRIS YAPILDIYSA NORMAL RENGINE DONDURUR.
    					{
    						allField[k][i].setBackground(Color.WHITE);
    					}
        				
        			}
            	
            }
        });	
		newButton.addActionListener(new ActionListener() {			// AYNI SEVIYE ZORLUGUNDA BIR SUDOKU OLUSTURUR.
			 
            public void actionPerformed(ActionEvent e)
            {
            	dispose();         	
            	Board board = new Board(number,difficulty);
            	board.setVisible(true);
    	
            }
        });
		checkButton.addActionListener(new ActionListener() {		// KONTROL BUTONU
			 
            public void actionPerformed(ActionEvent e)
            {
            	String message = "Congratulations";
            	String error = "Wrong number";
            	boolean flag[][] = new boolean [9][9] ;
            	int counter = 0 ;
            	for (int k =0; k<9; k++)
            		for(int i =0; i <=8; i++)
            		{
            			flag[k][i] =  false;
            		}
            	
        		for (int k =0; k<9; k++)
        		{
        			for(int i =0; i <=8; i++)
        			{				
        				if(Integer.toString(solution[k][i]).equals(allField[k][i].getText()))		// KUTUCUKLARDAKI DEGERLERLE ASIL DEGERLER ESITSE SAYAC ARTTIRIR VEDE FLAGI TRUE YAPAR
        				{
        					flag[k][i] =  true;
        					counter++;
        					if(allField[k][i].getBackground()==Color.YELLOW)				//DAHA ONCE HATALI SAYI YERINE DOGRU GIRIS YAPILIRSA RENK DUZELIR
        					{
        						allField[k][i].setBackground(Color.WHITE);
        					}
        				}      			
        					
        			}       			
        		}	
        		if(counter == 81)
        		{
        			 JOptionPane.showMessageDialog(new JFrame(), message, "Congratulations",  JOptionPane.ERROR_MESSAGE);		//KULLANICI HEPSINI DOGRU GIRDIYSE TEBRIK MESAJI VERIR
        		}
        		
        		for (int k =0; k<9; k++)
        		{
        			for(int i =0; i <=8; i++)
        			{				
        				if(!Integer.toString(solution[k][i]).equals(allField[k][i].getText()))
        				{
        					JOptionPane.showMessageDialog(new JFrame(), error, "Error",  JOptionPane.ERROR_MESSAGE);       		// HATALI KUTUCUKLARI BOYAR VE HATA MESAJI VERIR
        					allField[k][i].setBackground(Color.YELLOW);
        				}      			
        					
        			}       			
        		}	           	
            }
        });
		solve.addActionListener(new ActionListener() {					// KULLANICIYA SUDOKUNUN COZUMUNU GOSTERIR
			 
            public void actionPerformed(ActionEvent e)
            {
            	for (int k =0; k<9; k++)
        			for(int i =0; i <=8; i++)
        			{
        				if(allField[k][i].isEditable())
        				allField[k][i].setText(Integer.toString(solution[k][i]));
        			}       	
            	
            }
        });

}	
}