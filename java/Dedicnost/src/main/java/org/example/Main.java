package org.example;

public class Main {
    public static void main(String[] args) {
        Clovek osoba = new Clovek("Karel", 34);

        osoba.Pozdrav();

        Clovek programator = new Programator("Kuba", 25, "Pascal");
        Clovek urednik = new Urednik("Klara", 32, 10);

        programator.Pozdrav();
        urednik.Pozdrav();

        System.out.println("************************************");

        Clovek[] lide = {
                new Clovek("Clovicek", 14),
                programator,
                urednik
        };

        for(Clovek clovek : lide)
        {
            clovek.Pozdrav();
        }
        System.out.println(((Programator)lide[1]).getJazyk());

        System.out.println("******  ToString  ***********");

        System.out.println(programator);
    }
}