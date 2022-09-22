/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.cw2;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author prof
 */
public class FileOperations {

    /**
     *
     * @param filename
     * @param users
     */
    public static void SaveToFile(String filename,List<User> users){
        FileWriter fw;
        try {
            fw = new FileWriter(filename);
            PrintWriter pw = new PrintWriter(fw);
            for (User u : users) {
                pw.print(u + "\n");
            }
            pw.close();
        } catch (IOException ex) {
            Logger.getLogger(Cw2.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    static List<User> GetFromFile(String filename) {
        BufferedReader reader;
        List<User> result = new ArrayList<>();
        try{
            reader = new BufferedReader(new FileReader(filename));
            String line;
            do{
                line = reader.readLine();
                if(line.isBlank()) continue;
                String fromLine[] = line.split("\\|");
                Boolean isLogged = fromLine[2].equals("zalogowany");
                result.add(new User(fromLine[0], fromLine[1],isLogged));
            }while(line != null);
            reader.close();
            
        }catch(IOException e){
            e.printStackTrace();
        }
        return result;
    }
}
