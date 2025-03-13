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

            //Console.Write("Zadejte počet čísel: ");
            //int pocetCisel = Int32.Parse(Console.ReadLine());
            //int soucet = 0;
            //for (int i = 1; i <= pocetCisel; i++)
            //{
            //    Console.Write("Zadejte {0}. číslo: ", i);
            //    soucet += Int32.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Součet zadaných čísel = {0}", soucet);

            //************************************************************************
            //************************************************************************

            //Console.Write("Zadejte počet čísel: ");
            //int pocetCisel = Int32.Parse(Console.ReadLine());
            //int[] poleCisel = new int[pocetCisel];
            //int soucet = 0;
            //for (int i = 0; i < poleCisel.GetLength(0); i++)
            //{
            //    Console.Write("Zadejte {0}. číslo: ", i + 1);
            //    int cislo = Int32.Parse(Console.ReadLine());
            //    poleCisel[i] = cislo;
            //    soucet += cislo;
            //}
            //Console.WriteLine("Součet je {0}", soucet);
            //Console.WriteLine("Druhé číslo je {0}", poleCisel[1]);
            //Console.WriteLine("Počet čísel v poli je {0}", poleCisel.GetLength(0));

            //************************************************************************
            //************************************************************************

            //Console.Write("Zadejte počet čísel: ");
            //int pocetCisel = Int32.Parse(Console.ReadLine());
            //int[] poleCisel = new int[pocetCisel];

            //for (int i = 0; i < pocetCisel; i++)
            //{
            //    Console.Write("{0}. číslo: ", i + 1);
            //    poleCisel[i] = Int32.Parse(Console.ReadLine());
            //}

            //int minimum = poleCisel[0];
            //for (int i = 0; i < poleCisel.GetLength(0); i++)
            //{
            //    if (poleCisel[i] < minimum)
            //    {
            //        minimum = poleCisel[i];
            //    }
            //}

            //int maximum = poleCisel[0];
            //for (int i = 0; i < poleCisel.GetLength(0); i++)
            //{
            //    if (poleCisel[i] > maximum)
            //    {
            //        maximum = poleCisel[i];
            //    }
            //}

            //Console.WriteLine("Nejmenší číslo je {0}", minimum);
            //Console.WriteLine("Největší číslo je {0}", maximum);

            //************************************************************************
            //************************************************************************

            //int volba = 0;
            //do
            //{
            //    Console.WriteLine("Vyberte z následující nabídky:");
            //    Console.WriteLine("1. Položka A");
            //    Console.WriteLine("2. Položka B");
            //    Console.WriteLine("3. Položka C");
            //    Console.Write("Vaše volba (napište číslo): ");
            //    volba = Int32.Parse(Console.ReadLine());
            //} while (volba < 1 || volba > 3);
            //Console.WriteLine("Zvolená možnost: {0}", volba);

            //************************************************************************
            //************************************************************************

            //// Připravíme si pole čísel
            //int[] poleCisel = new int[3];
            //poleCisel[0] = 3;
            //poleCisel[1] = 7;
            //poleCisel[2] = 17;

            //// Připravíme si pole řetězců
            //string[] poleRetezcu = new string[4];
            //poleRetezcu[0] = "jedna";
            //poleRetezcu[1] = "dva";
            //poleRetezcu[2] = "tři";
            //poleRetezcu[3] = "čtyři";

            //Console.WriteLine("Pole čisel obsahuje následující prvky:");
            //foreach (int item in poleCisel)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Pole řetězců obsahuje následující prvky:");
            //foreach (string item in poleRetezcu)
            //{
            //    Console.WriteLine(item);
            //}

            //************************************************************************
            //************************************************************************

            //for (int i = 1; i <= 10; i++)
            //{
            //    // V každém běhu cyklu se vykoná tento vnořený cyklus
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        // Vypisuje násobky čísla na jeden řádek
            //        Console.Write("{0} ", i * j);
            //    }
            //    // Odřádkujeme, abychom násobky dalšího čísla vypsali na samostatný řádek
            //    // a cyklus jede znovu
            //    Console.WriteLine();
            //}

            //************************************************************************
            //************************************************************************

            //string dalsiStudent;
            //do
            //{
            //    double soucetZnamek = 0;
            //    int pocetZnamek = 0;
            //    int zadanaZnamka = 0;

            //    do
            //    {
            //        Console.WriteLine("Zadejte známku studenta (pokud chcete zadávání ukončit, zadejte nulu):");
            //        zadanaZnamka = Int32.Parse(Console.ReadLine());
            //        if (zadanaZnamka != 0)
            //        {
            //            soucetZnamek += zadanaZnamka;
            //            pocetZnamek += 1;
            //        }
            //        // Cyklus skončí, když uživatel zadá nulu.
            //    } while (zadanaZnamka != 0);

            //    // Vypočteme aritmetický průměr známek studenta.
            //    double prumer = soucetZnamek / pocetZnamek;
            //    Console.WriteLine("Průměr známek studenta je {0}", prumer);

            //    Console.WriteLine("Chcete vypočítat průměr známek pro dalšího studenta? (A/N)");
            //    dalsiStudent = Console.ReadLine();

            //} while (dalsiStudent == "A");

            //************************************************************************
            //************************************************************************

            int soucet = 0;
            Console.WriteLine("Kolik budete chtít zadat čísel:");
            int pocetCisel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadávejte čísla. Pro předčasné ukončení zadejte K");
            for (int i = 0; i < pocetCisel; i++)
            {
                string zadane = Console.ReadLine();
                if (zadane == "K")
                {
                    break;
                }
                soucet += Int32.Parse(zadane);
            }
            Console.WriteLine("Součet čísel je {0}", soucet);

            Console.ReadKey();
        }
    }
}