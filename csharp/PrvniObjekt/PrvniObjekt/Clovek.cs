using System;
using System.Collections.Generic;
using System.Text;

namespace PrvniObjekt
{
    internal class Clovek
    {

        //atributy (promenne nalezici tride)
        public string jmeno;
        private int vek;

        //metody (funkce nalezici tride)
        public void Pozdrav()
        {
            Console.WriteLine($"Ahoj posila {jmeno}");
        }

        //pretizeni metody
        public void Pozdrav(string pozdrav)
        {
            Console.WriteLine($"{pozdrav} posila {jmeno}");
        }

        public string VratPozdrav(string pozdrav)
        {
            //Console.WriteLine($"Vraceny pozdrav: {pozdrav} posila {jmeno}");
            return $"Vraceny pozdrav: {pozdrav} posila {jmeno}";
        }
    }
}
