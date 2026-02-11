using System;
using System.Collections.Generic;
using System.Text;

namespace Dedicnost
{
    internal class Urednik: Clovek
    {
        public int Uroven { get; set; }

        public Urednik(string jmeno, int vek, int uroven) : base(jmeno, vek) {
        
            Uroven = uroven;
        }

        public override void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {Jmeno} ve veku {Vek} je dospely {jeDospely} ze tridy Urednik urovne {Uroven}");
        }
    }
}
