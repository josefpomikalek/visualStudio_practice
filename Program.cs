namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math.Abs(-5.5) = {0}", Math.Abs(-5.5));
            Console.WriteLine("Math.Ceiling(3.1) = {0}", Math.Ceiling(3.1));
            Console.WriteLine("Math.Floor(3.7) = {0}", Math.Floor(3.7));
            Console.WriteLine("Math.Pow(2, 3) = {0}", Math.Pow(2, 3));
            Console.WriteLine("Math.Round(2.50001) = {0}", Math.Round(2.50001));
            Console.WriteLine("Math.Sqrt(100) = {0}", Math.Sqrt(100));
            Console.WriteLine();

            string[] poleRetezcu = { "Jedna", "Dva", "Tři" };
            Console.WriteLine("String.Concat(poleRetezcu): {0}", String.Concat(poleRetezcu));

            Console.WriteLine("String.IsNullOrEmpty(\"\"): {0}", String.IsNullOrEmpty(""));
            Console.WriteLine("String.IsNullOrEmpty(\" \"): {0}", String.IsNullOrEmpty(" "));

            Console.WriteLine("String.IsNullOrWhiteSpace(\"\"): {0}", String.IsNullOrWhiteSpace(""));
            Console.WriteLine("String.IsNullOrWhiteSpace(\" \"): {0}", String.IsNullOrWhiteSpace(" "));
            Console.WriteLine();

            string retezec1 = "a,b,c,d,e,f";
            Console.WriteLine("Řetězec '{0}' obsahuje řetězec 'a': {1}", retezec1, retezec1.Contains("a"));
            Console.WriteLine("Řetězec '{0}' obsahuje řetězec 'a,b,c': {1}", retezec1, retezec1.Contains("a,b,c"));
            Console.WriteLine("Řetězec '{0}' obsahuje řetězec 'a,b,c ': {1}", retezec1, retezec1.Contains("a,b,c "));
            Console.WriteLine("Řetězec '{0}' má délku {1} znaků.", retezec1, retezec1.Length);
            Console.WriteLine("Řetězec '{0}' začíná na 'a': {1}", retezec1, retezec1.StartsWith("a"));
            Console.WriteLine("Řetězec '{0}' začíná na 'A': {1}", retezec1, retezec1.StartsWith("A"));
            Console.WriteLine("Řetězec '{0}' končí na 'f': {1}", retezec1, retezec1.EndsWith("f"));
            Console.WriteLine("Řetězec '{0}' končí na 'b': {1}", retezec1, retezec1.EndsWith("b"));


        }


    }
}