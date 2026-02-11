package org.example;

public class Main {
    public static void main(String[] args) {

        Kalkulacka kalk = new Kalkulacka();

        try {
            double vysledek = kalk.vydel(5, 0);
            System.out.println("Vysledek deleni je: " + vysledek);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        } finally {
            System.out.println("Toto se provede vzdy");
        }


        System.out.println("Zde pokracuje kod");
    }
}