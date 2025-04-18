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
            Console.WriteLine();

            string retezec2 = "Kvetoslava";
            Console.Write("Výpis znaků v řetězci '{0}' na pozicicích 0, 4 a 5: ", retezec2);
            Console.Write(retezec2[0]);
            Console.Write(retezec2[4]);
            Console.WriteLine(retezec2[5]);
            Console.WriteLine("retezec2.IndexOf(\"a\"): {0}", retezec2.IndexOf("a"));
            Console.WriteLine("retezec2.IndexOf(\"a\", 8): {0}", retezec2.IndexOf("a", 8));
            Console.WriteLine(retezec2.Remove(7));
            Console.WriteLine(retezec2.Remove(7, 1));
            Console.WriteLine(retezec2.Substring(5));
            Console.WriteLine(retezec2.Substring(5, 3));
            Console.WriteLine(retezec2.ToUpper());
            Console.WriteLine(retezec2.ToLower());

            Console.WriteLine("retezec2.Replace(\"slava\", \"slav\"): {0}", retezec2.Replace("slava", "slav"));
            string retezec10 = "  Petr  ";
            string retezec11 = retezec10.Trim();
            Console.WriteLine("retezec10 je {0}", retezec10);
            Console.WriteLine("retezec11 je {0}", retezec11);
            bool porovnani = retezec11 == "Petr";
            Console.WriteLine(porovnani);

            DateTime aktualniDatumCas = DateTime.Now;
            Console.WriteLine(aktualniDatumCas);
            Console.WriteLine("aktualniDatumCas.Year = {0}", aktualniDatumCas.Year);
            Console.WriteLine("aktualniDatumCas.Month = {0}", aktualniDatumCas.Month);
            Console.WriteLine("aktualniDatumCas.Day = {0}", aktualniDatumCas.Day);
            Console.WriteLine("aktualniDatumCas.Hour");
            Console.WriteLine(aktualniDatumCas.Date);
            Console.WriteLine();
            DateTime datumNarozeni = new DateTime(1975, 11, 20);
            DateTime datumNakupu = new DateTime(2025, 3, 19, 14, 45, 10);
            Console.WriteLine(datumNarozeni);
            Console.WriteLine(datumNakupu);
            Console.WriteLine(datumNarozeni.ToShortDateString());
            Console.WriteLine(datumNakupu.ToShortTimeString());
            Console.WriteLine();
            DateTime datumNastupu = new DateTime(2025, 3, 19);
            Console.WriteLine(datumNastupu.ToShortDateString());
            Console.WriteLine(datumNastupu.AddYears(-1).ToShortDateString());
            Console.WriteLine();

            DateTime datumStart = new DateTime(2025, 3, 10);
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(datumStart.AddDays(i).ToShortDateString());
            }

            DateTime dnesnidatum = DateTime.Now;
            Console.WriteLine(dnesnidatum);
            Console.WriteLine("*****************************");
            Console.WriteLine();

            
            double[] mzdyZamestnancu = { 15500, 18500, 23000, 14000, 38000, 20000 };
            Console.WriteLine("Mzdy: {0}", string.Join(", ", mzdyZamestnancu));
            Console.WriteLine("Průměrná mzda je {0}", PrumernaMzda(mzdyZamestnancu));
            Console.WriteLine("Nejnižší mzda je {0}", MinimalniMzda(mzdyZamestnancu));
            Console.WriteLine("Nejvyšší mzda je {0}", MaximalniMzda(mzdyZamestnancu));
            Console.WriteLine("*****************************");
            Console.WriteLine();


            string[] uzivatelskaJmena = { "jan", "petr", "LUCIE", "jana" };
            Console.WriteLine("Jan: {0}", ExistujeJmeno(uzivatelskaJmena, "Jan"));
            Console.WriteLine("pEtR: {0}", ExistujeJmeno(uzivatelskaJmena, "pEtR"));
            Console.WriteLine("lucka: {0}", ExistujeJmeno(uzivatelskaJmena, "lucka"));
            Console.WriteLine("jan a: {0}", ExistujeJmeno(uzivatelskaJmena, "jan a"));
            
        }
        
        // ***** EXERCISE *****
        static bool ExistujeJmeno(string[] jmena, string hledaneJmeno)
        {
            foreach (string jmeno in jmena)
            {
                if (jmeno.ToLower() == hledaneJmeno.ToLower())
                {
                    return true;
                }
            }
            return false;
        }


        static double PrumernaMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double soucet = 0;
                foreach (double mzda in mzdy)
                {
                    soucet += mzda;
                }
                return soucet / mzdy.Length;
            }
            else
            {
                return 0;
            }
        }

        static double MinimalniMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double min = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda < min)
                    {
                        min = mzda;
                    }
                }
                return min;
            }
            else
            {
                return 0;
            }
        }

        static double MaximalniMzda(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                double max = mzdy[0];
                foreach (double mzda in mzdy)
                {
                    if (mzda > max)
                    {
                        max = mzda;
                    }
                }
                return max;
            }
            else
            {
                return 0;
            }
        }

    }
}