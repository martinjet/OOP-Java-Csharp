package org.example;

public class Clovek {

    //atributy (promenne nalezici tride)
    public String jmeno;
    private int vek;

    //metody (funkce nalezici tride)
    public void pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno);
    }

    //pretizeni metody
    public void pozdrav(String pozdrav)
    {
        System.out.println(pozdrav + " posila " + jmeno);
    }

    public String vratPozdrav(String pozdrav)
    {
        //Console.WriteLine($"Vraceny pozdrav: {pozdrav} posila {jmeno}");
        return "Vraceny pozdrav: " + pozdrav + " posila " + jmeno;
    }

}
