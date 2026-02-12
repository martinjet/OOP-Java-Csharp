package org.example;

public class Programator extends Clovek {

    //private String jazyk;
    private JazykTyp jazyk;

    public Programator(String jmeno, int vek, JazykTyp jazyk) {

        super(jmeno, vek);
        this.jazyk = jazyk;
    }

    @Override
    public String vratPovolani() {
        return "Programator";
    }

    @Override
    public void Pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno + " ve veku " +  vek + " je dospely " + jeDospely + " ze tridy Programator programuje v " + jazyk);
    }

    @Override
    public String toString()
    {
        return jmeno + " " + vek + " " + jazyk;
    }

    public JazykTyp getJazyk() {
        return jazyk;
    }

    public void setJazyk(JazykTyp jazyk) {
        this.jazyk = jazyk;
    }
}
