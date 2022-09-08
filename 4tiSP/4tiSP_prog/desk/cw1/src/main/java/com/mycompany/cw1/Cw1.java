/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.cw1;
import java.util.Scanner;

/**
 *
 * @author prof
 */
public class Cw1 {

    public static void main(String[] args) {
        //cw1();
       // cw2();
       cw3();
    }
    public static void cw3() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Podaj imie: ");
        String firstname = sc.nextLine();
        System.out.print("Podaj nazwisko: ");
        String lastname = sc.nextLine();
        System.out.println(String.format("Witaj %s %s",firstname,lastname));
       
    }
    public static void cw2() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Podaj a: ");
        int a = sc.nextInt();
         System.out.print("Podaj b: ");
        int b = sc.nextInt();
         System.out.println(a+ " + "+b + " = "+(a+b));
        System.out.println(a+ " - "+b + " = "+(a-b));
        System.out.println(a+ " * "+b + " = "+(a*b));
        System.out.println(a+ " / "+b + " = "+(b!=0 ? (double)a/b : "nie dzielimy przez zero"));
    }
    public static void cw1() {
        int a = 36;
        int b = 12;
        System.out.println(a+ " + "+b + " = "+(a+b));
        System.out.println(a+ " - "+b + " = "+(a-b));
        System.out.println(a+ " * "+b + " = "+(a*b));
        System.out.println(a+ " / "+b + " = "+(b!=0 ? (double)a/b : "nie dzielimy przez zero"));
    }
}
