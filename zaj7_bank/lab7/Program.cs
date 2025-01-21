using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektów Osoba
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Osoba osoba2 = new Osoba("Anna", "Nowak");

            // Tworzenie obiektów Konto
            Konto konto1 = new Konto(osoba1, 1000m, 1234);
            Konto konto2 = new Konto(osoba2, 500m, 5678);

            // Operacje na koncie1
            Console.WriteLine(konto1.InformacjeOKoncie(1234));
            konto1.Wplata(200m);
            Console.WriteLine(konto1.Wyplata(150m, 1234));
            Console.WriteLine(konto1.InformacjeOKoncie(1234));
            konto1.Wplata(100000m);

            // Zmiana PIN
            if (konto1.ZmienPin(1234, 4321))
            {
                Console.WriteLine("PIN zmieniony pomyślnie.");
            }
            else
            {
                Console.WriteLine("Nie udało się zmienić PIN-u.");
            }

            Console.WriteLine(konto1.InformacjeOKoncie(4321));

            // Operacje na koncie2
            Console.WriteLine(konto2.InformacjeOKoncie(5678));
            Console.WriteLine(konto2.Wyplata(600m, 5678)); // Przekroczenie salda
            Console.WriteLine(konto2.Wyplata(200m, 1111)); // Błędny PIN

            Console.ReadKey();
        }
    }
}
