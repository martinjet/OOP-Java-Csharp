package org.example;

public class Main {
    public static void main(String[] args) {

        System.out.println("Tohle je vstupni brana do aplikace");

        //instance
        Clovek karel = new Clovek();
        Clovek katka = new Clovek();

        System.out.println("Jmeno prvni osoby: " + karel.jmeno);

        karel.jmeno = "Karel II";
        katka.jmeno = "Katka";

        //nejde - vek je private
        //karel.vek = 42;

        System.out.println("** Jednoduche vypsani public atributu **");
        System.out.println("Jmeno prvni osoby: " + karel.jmeno);
        System.out.println("Jmeno druhe osoby: " + katka.jmeno);


        //metody
        System.out.println("** Volam metodu **");
        karel.pozdrav("Dobry den");
        katka.pozdrav();

        //metoda s navratovou hodnotou
        String pozdrav = karel.vratPozdrav("Krasny den");
        System.out.println(pozdrav);
    }
}