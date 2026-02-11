package org.example;

public class Programator extends Clovek {

    private String jazyk;

    public Programator(String jmeno, int vek, String jazyk) {

        super(jmeno, vek);
        this.jazyk = jazyk;
    }

    @Override
    public void Pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno + " ve veku " +  vek + " je dospely " + jeDospely + " ze tridy Programator programuje v " + jazyk);
    }

    @Override
    public String toString()
    {
        return super.toString() + " " + jmeno + " " + vek + " " + jazyk;
    }

    public String getJazyk() {
        return jazyk;
    }

    public void setJazyk(String jazyk) {
        this.jazyk = jazyk;
    }
}
