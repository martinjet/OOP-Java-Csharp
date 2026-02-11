namespace Vyjimky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kalkulacka kalk = new Kalkulacka();

            try
            {
                double vysledek = kalk.Vydel(5, 0);
                Console.WriteLine("Vysledek deleni je: " + vysledek);
            }
            catch (Exception e) { 

                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("Provede se vzdy");
            }
            


            //Console.WriteLine(double.IsInfinity(vysledek));
            Console.WriteLine("Zde pokracuji v kodu");
        }
    }
}
