using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Klinika
    {
        private List<Pacjent> pacjenci = new List<Pacjent>();

        public void DodajPacjenta(Pacjent pacjent)
        {
            pacjenci.Add(pacjent);
            Console.WriteLine($"Dodano Pacjenta: {pacjent.Imie} {pacjent.Nazwisko} ");
        }

        public void WyswietlPacjentow()
        {
            Console.WriteLine("Lista wszystkich pacjentow:");
            foreach (var pacjent in pacjenci)
            {
                Console.WriteLine(pacjent.InfoPacjent());
            }
        }
        public void ZmienDane(long pesel, long nowypesel, string noweImie, string noweNazwisko)
        {
            var osoba = pacjenci.FirstOrDefault(p => p.Pesel == pesel);

            osoba.Imie = noweImie;
            osoba.Pesel = nowypesel;
            osoba.Nazwisko = noweNazwisko;
            Console.WriteLine($"Zmieniono dane osoby na: {noweImie} {noweNazwisko}, {nowypesel}");
        }

        public void UsunPacjenta(long pesel)
        {
            var wszyscy = pacjenci.ToList();
            var osoba = wszyscy.Single(r => r.Pesel == pesel);
            pacjenci.Remove(osoba);
        }

        public void SzukajPacjenta(long pesel)
        {
            var wszyscy = pacjenci.ToList();
            var osoba = wszyscy.Single(r => r.Pesel == pesel);
            Console.WriteLine(osoba.InfoPacjent());
        }
    }
}
