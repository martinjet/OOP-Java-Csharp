package org.example;

public class Kalkulacka {

    public double vydel(double a, double b) throws Exception {

        if (b == 0)
            throw new Exception("Nelze delit 0");

        return a / b;
    }
}
