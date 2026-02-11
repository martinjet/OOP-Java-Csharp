using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktor
{
    internal class Clovek
    {

        //atributy (promenne nalezici tride)
        private string jmeno;
        private int vek;
        private bool jeDospely;

        public string GetJmeno()
        {
            return jmeno;
        }
        public int GetVek()
        {
            return vek;
        }
        private void SetJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public void SetVek(int vek)
        {
            this.vek = vek;
            this.jeDospely = vek >= 18;
        }

        //konstruktor
        public Clovek(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.jeDospely = vek >= 18;
        }

        //metody (funkce nalezici tride)
        public void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {jmeno} ve veku {vek} je dospely {jeDospely}");
        }
    }
}
