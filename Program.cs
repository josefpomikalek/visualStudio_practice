namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string testLoginAdmin = "admin";
            const string testPasswordAdmin = "csharp";

            Console.WriteLine("Vítejte v programu na procvičování podmínek");
            Console.Write("Zadejte uživatelské jméno: ");
            string login = Console.ReadLine();
            Console.Write("Zadejte heslo: ");
            string password = Console.ReadLine();

            if (login == testLoginAdmin && password == testPasswordAdmin)
            {
                Console.WriteLine("Jste přihlášeni jako administrátor.");
            }
            else if (login == testLoginAdmin && password != testPasswordAdmin)
            {
                Console.WriteLine("Zadali jste neplatné přihlašovací údaje administrátora.");
            }
            else
            {
                Console.WriteLine("Jste přihlášeni jako běžný uživatel.");
            }

        }
    }
}
