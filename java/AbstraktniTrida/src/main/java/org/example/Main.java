package org.example;

public class Main {
    public static void main(String[] args) {

        //Clovek karel = new Clovek("karel", 26, "python");

        Clovek jana = new Programator("jana", 26, JazykTyp.CSHARP);
        Clovek karolina = new Programator("karolina", 32, JazykTyp.PYTHON);

        System.out.println(jana);

        System.out.println("Pocet Lidi " + Clovek.getPocetLidi());
    }
}