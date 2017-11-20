/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.io.Writer;
import java.util.HashMap;
import java.util.Map;
import java.util.Stack;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Issa Memari
 */
public class TestGenerator {
    
    private String DTD = "";
    public TestGenerator(String DTD)
    {
        this.DTD = DTD.trim();
    }
    
    public void generate(Writer fileName)
    {
        Map<Character, String> DTDStuff = new HashMap<>();
        String DTDLines[] = DTD.split("\\r?\\n");
        
        Character rootElement = DTDLines[0].split("\\s+")[0].charAt(0);
        
        for (String DTDLine : DTDLines) {
            String[] stuff = DTDLine.split("\\s+");
            DTDStuff.put(stuff[0].charAt(0), stuff[1]);
        }
        
        Map<Character, Xeger> DTDRules = new HashMap<>();
        DTDStuff.keySet().forEach((c) -> {
            if (!"_".equals(DTDStuff.get(c)))
                DTDRules.put(c, new Xeger(DTDStuff.get(c)));
            else
                DTDRules.put(c, null);
        });
        
        BufferedWriter sw = new BufferedWriter(fileName);
        Stack<String> strings = new Stack<>();
        Stack<Integer> positions = new Stack<>();
        Stack<Character> elements = new Stack<>();
        
        String rootString = DTDRules.get(rootElement).generate();
        
        try {
            sw.write("0 " + rootElement+ "\n");
        } catch (IOException ex) {
            Logger.getLogger(TestGenerator.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        strings.push(rootString);
        elements.push(rootElement);
        positions.push(0);
        
        try
        {
            while(!strings.empty())
            {
                String currentString = strings.peek();
                Integer currentPosition = positions.peek();
                Character currentElement = elements.peek();
                
                if (currentPosition == currentString.length())
                {
                    sw.write("1 " + currentElement + "\n");
                    strings.pop();
                    elements.pop();
                    positions.pop();
                }
                else
                {
                    if (!"_".equals(currentString))
                    {
                        sw.write("0 " + currentString.charAt(currentPosition)+ "\n");
                        positions.push(positions.pop() + 1);
                        if (DTDRules.get(currentString.charAt(currentPosition)) != null)
                        {
                            String newString = DTDRules.get(currentString.charAt(currentPosition)).generate();
                            strings.push(newString);
                            positions.push(0);
                            elements.push(currentString.charAt(currentPosition));
                        }
                        else
                        {
                            strings.push("_");
                            positions.push(0);
                            elements.push(currentString.charAt(currentPosition));
                        }
                    }
                    else
                    {
                        positions.push(positions.pop() + 1);
                    }
                }
            }
        }
        catch (IOException e) {  }
        try {
            sw.close();
        } catch (IOException ex) {
            Logger.getLogger(TestGenerator.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static String readFile(String filePath) throws FileNotFoundException
    {
        BufferedReader br = new BufferedReader(new FileReader(filePath));
        StringBuilder sb = new StringBuilder();
        
        try {
            String line = br.readLine();

            while (line != null) {
                sb.append(line);
                sb.append(System.lineSeparator());
                line = br.readLine();
            }            
        } 
        catch (IOException e) {}
        
        return sb.toString();
    }
    
    public static void main(String[] args) throws IOException {
		TestGenerator tg = new TestGenerator(readFile("src/example_tmp.dtd"));
		
		for (int i = 0; i < 1000; i++) {
			String filename = "src/generated/example_" + i + ".xml";
			tg.generate(new FileWriter(filename));
		}
		
		
	}
}