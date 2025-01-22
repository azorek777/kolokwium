using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Klinika klinika = new Klinika();

            // DODAWANIE
            klinika.DodajPacjenta(new Pacjent("Mariusz", "Tarantula", 98015852711, DateTime.Now));
            klinika.DodajPacjenta(new Pacjent("Tomasz", "Maszto", 66678257190, DateTime.Now));
            klinika.DodajPacjenta(new Pacjent("Jadwiga", "Pytanko", 56712395736, DateTime.Now));


            // WYŚWIETLANIE
            Console.WriteLine();
            klinika.WyswietlPacjentow();

            // ZMIANA DANYCH
            klinika.ZmienDane(98015852711, 12345678901, "Bartosz", "Kapustka");
            Console.WriteLine();
            klinika.WyswietlPacjentow();

            // USUWANIE
            Console.WriteLine();
            klinika.UsunPacjenta(12345678901);
            klinika.WyswietlPacjentow();

            // SZUKANIE
            Console.WriteLine();
            klinika.SzukajPacjenta(66678257190);
            Console.ReadLine();



        }






    }




}