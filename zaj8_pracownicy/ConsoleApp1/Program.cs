using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kadry kadry = new Kadry();
            while (true)
            {
                Console.WriteLine("\nMenu Kadry:");
                Console.WriteLine("1. Zatrudnij pracownika");
                Console.WriteLine("2. Wyszukaj pracownika");
                Console.WriteLine("3. Wyszukaj pracowników");
                Console.WriteLine("4. Wyświetl pracowników");
                Console.WriteLine("5. Zmień adres pracownika");
                Console.WriteLine("6. Zmień dane osobowe pracownika");
                Console.WriteLine("7. Zmień umowę pracownika");
                Console.WriteLine("8. Usuń pracownika");
                Console.WriteLine("9. Wyjdź");

                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        kadry.ZatrudnijPracownika();
                        break;
                    case "2":
                        kadry.WyszukajPracownika();
                        break;
                    case "3":
                        kadry.WyszukajPracownikow();
                        break;
                    case "4":
                        kadry.WyswietlPracownikow();
                        break;
                    case "5":
                        kadry.ZmienAdres();
                        break;
                    case "6":
                        kadry.ZmienDaneOsobowe();
                        break;
                    case "7":
                        kadry.ZmienUmowe();
                        break;
                    case "8":
                        kadry.UsunPracownika();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}
