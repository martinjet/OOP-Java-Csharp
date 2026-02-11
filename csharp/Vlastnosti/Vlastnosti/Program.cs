using Konstruktor;

namespace Vlastnosti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instance
            Clovek karel = new Clovek("Karel II", 42);
            Clovek katka = new Clovek("Katka", 25);


            //katka.vek = 14;
            //katka.Jmeno = "Jarmila";
            katka.Vek = 14;

            karel.Pozdrav();
            katka.Pozdrav();

            //pristup k atributum
            Console.WriteLine($"Jmeno {karel.Jmeno} vek {karel.Vek}");

        }
    }
}
