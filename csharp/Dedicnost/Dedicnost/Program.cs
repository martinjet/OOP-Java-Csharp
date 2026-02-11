
namespace Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek osoba = new Clovek("Karel", 34);

            osoba.Pozdrav();

            Clovek programator = new Programator("Kuba", 25, "Pascal");
            Clovek urednik = new Urednik("Klara", 32, 10);

            programator.Pozdrav();
            urednik.Pozdrav();

            Console.WriteLine("************************************");

            Clovek[] lide = {
                    new Clovek("Clovicek", 14),
                    programator,
                    urednik
                };

            foreach(Clovek clovek in lide)
            {
                clovek.Pozdrav();
            }
            Console.WriteLine(((Programator)lide[1]).Jazyk);

            Console.WriteLine("******  ToString  ***********");
           
            Console.WriteLine(programator);

        }
    }
}
