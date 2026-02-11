namespace PrvniObjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tohle je vstupni brana do aplikace");


            //instance
            Clovek karel = new Clovek();
            Clovek katka = new Clovek();

            Console.WriteLine($"Jmeno prvni osoby: {karel.jmeno}");
            
            karel.jmeno = "Karel II";
            katka.jmeno = "Katka";

            //nejde - vek je private
            //karel.vek = 42;

            Console.WriteLine("** Jednoduche vypsani public atributu **");
            Console.WriteLine($"Jmeno prvni osoby: {karel.jmeno}");
            Console.WriteLine($"Jmeno druhe osoby: {katka.jmeno}");


            //metody
            Console.WriteLine("** Volam metodu **");
            karel.Pozdrav("Dobry den");
            katka.Pozdrav();

            //metoda s navratovou hodnotou
            string pozdrav = karel.VratPozdrav("Krasny den");
            Console.WriteLine(pozdrav);
        }
    }
}
