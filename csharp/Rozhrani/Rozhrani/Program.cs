namespace Rozhrani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IClovek karel = new Clovek();

            karel.Pozdrav();
        }
    }
}
