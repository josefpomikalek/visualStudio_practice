namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const string testLoginAdmin = "admin";
            //const string testPasswordAdmin = "csharp";

            //Console.WriteLine("Vítejte v programu na procvičování podmínek");
            //Console.Write("Zadejte uživatelské jméno: ");
            //string login = Console.ReadLine();
            //Console.Write("Zadejte heslo: ");
            //string password = Console.ReadLine();

            //if (login == testLoginAdmin && password == testPasswordAdmin)
            //{
            //    Console.WriteLine("Jste přihlášeni jako administrátor.");
            //}
            //else if (login == testLoginAdmin && password != testPasswordAdmin)
            //{
            //    Console.WriteLine("Zadali jste neplatné přihlašovací údaje administrátora.");
            //}
            //else
            //{
            //    Console.WriteLine("Jste přihlášeni jako běžný uživatel.");
            //}

            Console.WriteLine("*** Vítejte v naší restauraci! ***");
            Console.WriteLine("Vyberte si prosím z následující nabídky:");
            Console.WriteLine("1. Polévky");
            Console.WriteLine("2. Předkrmy");
            Console.WriteLine("3. Hlavní jídla");
            Console.WriteLine("4. Dezerty");
            Console.WriteLine("5. Nápoje");
            Console.Write("Vyberte možnost 1 až 5: ");

            int vybranaKategorie = Int32.Parse(Console.ReadLine());

            switch (vybranaKategorie)
            {
                case 1:
                    Console.WriteLine("POLÉVKY:");
                    Console.WriteLine("1. Domácí výbar s nudlemi");
                    Console.WriteLine("2. Gulášová v chlebu");
                    break;
                case 2:
                    Console.WriteLine("PŘEDKRMY:");
                    Console.WriteLine("1. Šunková role s krémem");
                    Console.WriteLine("2. Topinka s pikantní směsí");
                    break;
                case 3:
                    Console.WriteLine("HLAVNÍ JÍDLA:");
                    Console.WriteLine("1. Kuřecí řízek s bramborem");
                    Console.WriteLine("2. Svíčková s knedlíkem");
                    Console.WriteLine("3. Vepřo knedlo zelo");
                    break;
                case 4:
                    Console.WriteLine("DEZERTY:");
                    Console.WriteLine("1. Zmrzlinový pohár");
                    Console.WriteLine("2. Jablečný závin");
                    break;
                case 5:
                    Console.WriteLine("NÁPOJE:");
                    Console.WriteLine("1. Sodovka");
                    Console.WriteLine("2. Minerální voda Mattoni");
                    Console.WriteLine("3. Jablečný džus");
                    Console.WriteLine("4. Pivo 10°");
                    Console.WriteLine("5. Turecká káva");
                    break;
                default:
                    Console.WriteLine("Vybrali jste neznámou volbu.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
