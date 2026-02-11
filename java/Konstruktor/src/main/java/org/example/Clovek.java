package org.example;

public class Clovek {
    //atributy (promenne nalezici tride)
    private String jmeno;
    private int vek;
    private Boolean jeDospely;

    public String getJmeno()
    {
        return jmeno;
    }
    public int getVek()
    {
        return vek;
    }
    private void setJmeno(String jmeno)
    {
        this.jmeno = jmeno;
    }
    public void setVek(int vek)
    {
        this.vek = vek;
        this.jeDospely = vek >= 18;
    }

    //konstruktor
    public Clovek(String jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
        this.jeDospely = vek >= 18;
    }

    //metody (funkce nalezici tride)
    public void pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno + " ve veku " + vek + " je dospely " + jeDospely);
    }
}
