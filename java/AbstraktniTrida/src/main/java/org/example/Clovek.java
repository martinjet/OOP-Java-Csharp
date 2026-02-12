package org.example;

public abstract class Clovek {

    private static int pocetLidi;

    public static int getPocetLidi() {
        return pocetLidi;
    }

    //atributy (promenne nalezici tride)
    protected String jmeno;
    protected int vek;
    protected Boolean jeDospely;

    public abstract String vratPovolani();

    //konstruktor
    public Clovek(String jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
        jeDospely = vek >= 18;
        pocetLidi++;
    }

    //metody (funkce nalezici tride)
    public void Pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno + " ve veku " + vek + " je dospely " + jeDospely + " ze tridy Clovek");
    }

    @Override
    public String toString()
    {
        return jmeno + " " + vek;
    }

    public int getVek() {
        return vek;
    }

    public void setVek(int vek) {
        jeDospely = vek >= 18;
        this.vek = vek;
    }

    public String getJmeno() {
        return jmeno;
    }

    public void setJmeno(String jmeno) {
        this.jmeno = jmeno;
    }
}
