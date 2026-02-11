using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Programator: Clovek
    {
        public string Jazyk { get; set; }

        public Programator(string jmeno, int vek, string jazyk): base(jmeno, vek) {

            Jazyk = jazyk;        
        }

        public override void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {Jmeno} ve veku {Vek} je dospely {jeDospely} ze tridy Programator programuje v {Jazyk}");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Jmeno} + {Vek} + {Jazyk}";
        }
    }
}
