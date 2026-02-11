using System;
using System.Collections.Generic;
using System.Text;

namespace Vlastnosti
{
    internal class Clovek
    {

        //vlastnosti
        public string Jmeno { get; private set; }

        //private string jmeno;
        //public string GetJmeno()
        //{
        //    return jmeno;
        //}
        //protected void SetJmeno(string jmeno)
        //{
        //    this.jmeno = jmeno;
        //}



        private int vek;
        public int Vek {
            get { return vek; }
            set {
                vek = value;
                jeDospely = value >= 18; }
        }

        //private int vek;
        //public int GetVek()
        //{
        //    return vek;
        //}

        //public void SetVek(int vek)
        //{
        //    this.vek = vek;
        //    this.jeDospely = vek >= 18;
        //}


        //atributy (promenne nalezici tride)
        private bool jeDospely;

        //konstruktor
        public Clovek(string jmeno, int vek)
        {
            this.Jmeno = jmeno;
            this.Vek = vek;
            //this.jeDospely = vek >= 18;
        }

        //metody (funkce nalezici tride)
        public void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {Jmeno} ve veku {Vek} je dospely {jeDospely}");
        }
    }
}
