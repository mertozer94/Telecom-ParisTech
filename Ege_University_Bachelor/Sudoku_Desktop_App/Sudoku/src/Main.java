
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;


public class Main extends JFrame{		 

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JPanel Buttons = new JPanel(new GridLayout(3,1));				// MENU OLUSTURMA
		JButton buttonEasy = new JButton("EASY SUDOKU");					// DEGISKENLERI OLUSTURMA
		JButton buttonNormal = new JButton("NORMAL SUDOKU");
		JButton buttonHard = new JButton("HARD SUDOKU");
		buttonEasy.setToolTipText("For Beginners.");
		buttonNormal.setToolTipText("For Regular Players.");
		buttonHard.setToolTipText("For Real Players.");
		Buttons.add(buttonEasy);
		Buttons.add(buttonNormal);
		Buttons.add(buttonHard);
		final JFrame frame = new JFrame("Mert Ozer 05-12-296 ");			
		frame.add(Buttons);
		frame.setSize(300, 300);
		frame.setVisible(true);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SudokuFactory sudokuFactory = new SudokuFactory();				// KULLANICININ SECTIGI ZORLUK SEVIYESINE  GORE KULLANICIYA BIR SUDOKU SUNAR
		final Difficulty easy = sudokuFactory.getType("EASY");
		final Difficulty normal = sudokuFactory.getType("NORMAL");
		final Difficulty hard = sudokuFactory.getType("HARD");
		
		buttonEasy.addActionListener(new ActionListener() {				//HANGI BUTONA BASILIRSA ONA GORE YENI BIR SUDOKU URETIR
			 
	            public void actionPerformed(ActionEvent e)
	            {
	            	frame.dispose();
	            	easy.draw();
	            	 
	            }
	        });
		
		buttonNormal.addActionListener(new ActionListener() {
			 
            public void actionPerformed(ActionEvent e)
            {
            	frame.dispose();
            	normal.draw();
            	
            }
        });
		
		
		buttonHard.addActionListener(new ActionListener() {
			 
            public void actionPerformed(ActionEvent e)
            {
            	frame.dispose();
            	hard.draw();
                
            }
        });

		
}

}
