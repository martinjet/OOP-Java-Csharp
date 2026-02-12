using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktniTrida
{
    internal abstract class Clovek
    {
        public static int PocetLidi { get; private set; }


        //vlastnosti
        public string Jmeno { get; protected set; }

        protected int vek;
        public int Vek
        {
            get { return vek; }
            set
            {
                vek = value;
                jeDospely = value >= 18;
            }
        }

        //atributy (promenne nalezici tride)
        protected bool jeDospely;

        public abstract string VratPovolani();

        //konstruktor
        public Clovek(string jmeno, int vek)
        {
            this.Jmeno = jmeno;
            this.Vek = vek;
            PocetLidi++;
        }

        //metody (funkce nalezici tride)
        public virtual void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {Jmeno} ve veku {Vek} je dospely {jeDospely} ze tridy Clovek");
        }

        public override string ToString()
        {
            return $"{Jmeno} + {Vek}";
        }
    }
}
