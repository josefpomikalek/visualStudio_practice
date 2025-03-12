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

            //************************************************************************
            //************************************************************************


            //Console.WriteLine("*** Vítejte v naší restauraci! ***");
            //Console.WriteLine("Vyberte si prosím z následující nabídky:");
            //Console.WriteLine("1. Polévky");
            //Console.WriteLine("2. Předkrmy");
            //Console.WriteLine("3. Hlavní jídla");
            //Console.WriteLine("4. Dezerty");
            //Console.WriteLine("5. Nápoje");
            //Console.Write("Vyberte možnost 1 až 5: ");

            //int vybranaKategorie = Int32.Parse(Console.ReadLine());

            //switch (vybranaKategorie)
            //{
            //    case 1:
            //        Console.WriteLine("POLÉVKY:");
            //        Console.WriteLine("1. Domácí výbar s nudlemi");
            //        Console.WriteLine("2. Gulášová v chlebu");
            //        break;
            //    case 2:
            //        Console.WriteLine("PŘEDKRMY:");
            //        Console.WriteLine("1. Šunková role s krémem");
            //        Console.WriteLine("2. Topinka s pikantní směsí");
            //        break;
            //    case 3:
            //        Console.WriteLine("HLAVNÍ JÍDLA:");
            //        Console.WriteLine("1. Kuřecí řízek s bramborem");
            //        Console.WriteLine("2. Svíčková s knedlíkem");
            //        Console.WriteLine("3. Vepřo knedlo zelo");
            //        break;
            //    case 4:
            //        Console.WriteLine("DEZERTY:");
            //        Console.WriteLine("1. Zmrzlinový pohár");
            //        Console.WriteLine("2. Jablečný závin");
            //        break;
            //    case 5:
            //        Console.WriteLine("NÁPOJE:");
            //        Console.WriteLine("1. Sodovka");
            //        Console.WriteLine("2. Minerální voda Mattoni");
            //        Console.WriteLine("3. Jablečný džus");
            //        Console.WriteLine("4. Pivo 10°");
            //        Console.WriteLine("5. Turecká káva");
            //        break;
            //    default:
            //        Console.WriteLine("Vybrali jste neznámou volbu.");
            //        break;
            //}

            //************************************************************************
            //************************************************************************

            //string telefonKlient;
            //string telefonNeklient;
            //string telefonProdukt;

            //Console.WriteLine("Vítejte v našem informačním rozcestníku.");
            //Console.WriteLine();
            //Console.Write("Jste klientem Komerční banky? (ano / ne): ");
            //string jeKlientem = Console.ReadLine();

            //if ((jeKlientem != "ano") && (jeKlientem != "ne"))
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Vaše volba nebyla rozpoznána.");
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("S jakým produktem potřebujete poradit?");
            //    Console.WriteLine();
            //    Console.WriteLine("Vyberte si z následující nabídky:");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Hypotéky");
            //    Console.WriteLine("2. Spořicí účty");
            //    Console.WriteLine("3. Podílové fondy");
            //    Console.WriteLine();
            //    Console.Write("Vaše volba (1, 2 nebo 3): ");
            //    string volba = Console.ReadLine();
            //    Console.WriteLine();

            //    if (jeKlientem == "ano")
            //    {
            //        telefonKlient = "+420 100 200";

            //        switch (volba)
            //        {
            //            case "1":
            //                telefonProdukt = "500";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonKlient, telefonProdukt);
            //                break;
            //            case "2":
            //                telefonProdukt = "600";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonKlient, telefonProdukt);
            //                break;
            //            case "3":
            //                telefonProdukt = "700";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonKlient, telefonProdukt);
            //                break;
            //            default:
            //                Console.WriteLine("Vybrali jste neznámou volbu.");
            //                break;
            //        }
            //    }
            //    else if (jeKlientem == "ne")
            //    {
            //        telefonNeklient = "+420 100 300";

            //        switch (volba)
            //        {
            //            case "1":
            //                telefonProdukt = "500";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonNeklient, telefonProdukt);
            //                break;
            //            case "2":
            //                telefonProdukt = "600";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonNeklient, telefonProdukt);
            //                break;
            //            case "3":
            //                telefonProdukt = "700";
            //                Console.WriteLine("Zavolejte na číslo {0} {1}", telefonNeklient, telefonProdukt);
            //                break;
            //            default:
            //                Console.WriteLine("Vybrali jste neznámou volbu.");
            //                break;
            //        }
            //    }
            //}

            //************************************************************************
            //************************************************************************

            //string provestVypocet = "ano";
            //while (provestVypocet == "ano")
            //{
            //    Console.Write("Zadejte první číslo: ");
            //    int x = Int32.Parse(Console.ReadLine());
            //    Console.Write("Zadejte druhé číslo: ");
            //    int y = Int32.Parse(Console.ReadLine());
            //    Console.Write("Zadejte požadovanou operaci (+ - * /): ");
            //    string operace = Console.ReadLine();

            //    switch (operace)
            //    {
            //        case "+":
            //            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //            break;
            //        case "-":
            //            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            //            break;
            //        case "*":
            //            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            //            break;
            //        case "/":
            //            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            //            break;
            //    }
            //    Console.Write("Chcete provést další výpočet (ano / ne): ");
            //    provestVypocet = Console.ReadLine();
            //}

            //************************************************************************
            //************************************************************************

            //int soucet = 0;
            //Console.Write("Zadejte celé číslo: ");
            //int cislo = int.Parse(Console.ReadLine());
            //while (cislo > 0)
            //{
            //    Console.WriteLine("Součet = {0} + {1}", soucet, cislo);
            //    soucet += cislo;
            //    cislo -= 1;         // šlo by napsat i cislo--; nebo cislo = cislo - 1;
            //}
            //Console.WriteLine("Součet = {0}", soucet);

            //************************************************************************
            //************************************************************************

            //string provestVypocet;
            //do
            //{
            //    Console.Write("Zadejte první číslo: ");
            //    int x = Int32.Parse(Console.ReadLine());
            //    Console.Write("Zadejte druhé číslo: ");
            //    int y = Int32.Parse(Console.ReadLine());
            //    Console.Write("Zadejte požadovanou operaci (+ - * /): ");
            //    string operace = Console.ReadLine();

            //    switch (operace)
            //    {
            //        case "+":
            //            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //            break;
            //        case "-":
            //            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            //            break;
            //        case "*":
            //            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            //            break;
            //        case "/":
            //            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            //            break;
            //        default:
            //            Console.WriteLine("Byla zadána neplatná operace!");
            //            break;
            //    }
            //    Console.Write("Chcete provést další výpočet (ano / ne): ");
            //    provestVypocet = Console.ReadLine();
            //} while (provestVypocet == "ano");

            //************************************************************************
            //************************************************************************

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //************************************************************************
            //************************************************************************

            Console.Write("Zadejte počet čísel: ");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            int soucet = 0;
            for (int i = 1; i <= pocetCisel; i++)
            {
                Console.Write("Zadejte {0}. číslo: ", i);
                soucet += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Součet zadaných čísel = {0}", soucet);

            Console.ReadKey();
        }
    }
}