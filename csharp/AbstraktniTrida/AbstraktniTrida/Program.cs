namespace AbstraktniTrida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Clovek karel = new Clovek("karel", 26, "python");

            Clovek jana = new Programator("jana", 16, JazykTyp.JAVA);
            
            Clovek karolina = new Programator("karolina", 32, JazykTyp.PYTHON);

            Console.WriteLine(jana);

            //jana.PocetLidi;
            Console.WriteLine("Pocet lidi " + Clovek.PocetLidi);
        }
    }
}
