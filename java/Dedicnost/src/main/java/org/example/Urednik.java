package org.example;

public class Urednik extends Clovek{

    public int uroven;

    public Urednik(String jmeno, int vek, int uroven) {

        super(jmeno, vek);
        this.uroven = uroven;
    }

    @Override
    public void Pozdrav()
    {
        System.out.println("Ahoj posila " + jmeno + " ve veku " + vek + " je dospely " + jeDospely + " ze tridy Urednik urovne " + uroven);
    }
}
