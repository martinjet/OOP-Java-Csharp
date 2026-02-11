package org.example;

public class Main {
    public static void main(String[] args) {

        //instance
        Clovek karel = new Clovek("Karel II", 42);
        Clovek katka = new Clovek("Katka", 25);


        //katka.vek = 14;
        katka.setVek(14);

        //katka.setJmeno("Jarmila");

        karel.pozdrav();
        katka.pozdrav();

        //pristup k atributum
        System.out.println("Jmeno " + karel.getJmeno() + " vek " + karel.getVek());
    }
}