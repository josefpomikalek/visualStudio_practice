namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. číslo: ");
            int cislo1 = Int32.Parse(Console.ReadLine());
            Console.Write("2. číslo: ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            int soucet = Soucet(cislo1, cislo2);
            Console.WriteLine("{0} + {1} = {2}", cislo1, cislo2, soucet);
            Console.ReadKey();
        }

        static int Soucet(int x, int y)
        {
            return x + y;
        }
    }
}