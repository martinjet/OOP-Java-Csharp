namespace Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instance
            Clovek karel = new Clovek("Karel II", 42);
            Clovek katka = new Clovek("Katka", 25);


            //katka.vek = 14;
            katka.SetVek(14);
            
            //katka.SetJmeno("Jarmila");
            
            karel.Pozdrav();
            katka.Pozdrav();

            //pristup k atributum
            Console.WriteLine($"Jmeno { karel.GetJmeno()} vek {karel.GetVek()}");
            
        }
    }
}
