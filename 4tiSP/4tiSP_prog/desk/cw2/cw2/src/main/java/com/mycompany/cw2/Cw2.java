/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */
package com.mycompany.cw2;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.stream.Collectors;

/**
 *
 * @author prof
 */
public class Cw2 {

    public static void main(String[] args) {
        //cw2_1();
        cw3_1();
    }

    public static void cw2_1() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Podaj imie: ");
        String firstname = sc.next();
        System.out.print("Podaj nazwisko: ");
        String lastname = sc.next();
        System.out.println("i tak dalej.....");
    }

    public static void cw3_1() {
        List<User> users = new ArrayList<>(Arrays.asList(new User("rybka", "qaz"),
                new User("romek", "123", true), new User("bomek", "567", true)));
        List<User> loginUsers = users.stream().filter(u -> u.isIsLogin())
                .collect(Collectors.toList());
        for (User u : users) {
            System.err.println(u);
        }
        System.err.println("\nTylko zalogowani ----------------");
        for (User u : loginUsers) {
            System.err.println(u);
        }

        //do pliku
        //FileOperations.SaveToFile("dane.txt", users);
        List<User> result = FileOperations.GetFromFile("dane.txt");
        System.out.println(" ================= z pliku ====================");
        for (User u : result) {
            System.err.println(u);
        }

    }
}

class User {

    private String login;
    private String password;
    private boolean isLogin = false;

    public User(String login, String password, boolean isLogin) {
        this.login = login;
        this.password = password;
        this.isLogin = isLogin;
    }

    public boolean isIsLogin() {
        return isLogin;
    }

    public User(String login, String password) {
        this.login = login;
        this.password = password;
    }

    @Override
    public String toString() {
        return login + "|" + password
                + (isLogin ? "|zalogowany" : "|niezalogowany");
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public void setIsLogin(boolean isLogin) {
        this.isLogin = isLogin;
    }
}

enum Languages {
    english,
    polish,
    spanish,
    russian,
    czech
}

class Film {

    private Languages lang;
    private String title;
    private String author;

    private int length;

    public Film(Languages lang, String title, String author, int length) {
        this.lang = lang;
        this.title = title;
        this.author = author;
        this.length = length;
    }

    public Languages getLang() {
        return lang;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return author;
    }

    public int getLength() {
        return length;
    }

}
