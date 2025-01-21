using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Library_CSharp
{
    public class Biblioteka
    {
        private List<Ksiazka> ksiazki = new List<Ksiazka>();

        public void DodajKsiazke(Ksiazka ksiazka)
        {
            ksiazki.Add(ksiazka);
            Console.WriteLine($"Dodano książkę: {ksiazka.Tytul}");
        }

        public void WyswietlKsiazki()
        {
            Console.WriteLine("Lista książek w bibliotece:");
            foreach (var ksiazka in ksiazki)
            {
                Console.WriteLine(ksiazka.InfoKsiazka());
            }
        }

        public void WypozyczKsiazke(string tytul)
        {
            var ksiazka = ksiazki.FirstOrDefault(k => k.Tytul.Equals(tytul, StringComparison.OrdinalIgnoreCase));
            if (ksiazka != null && ksiazka.Dostepna)
            {
                ksiazka.Dostepna = false;
                Console.WriteLine($"Książka '{tytul}' została wypożyczona.");
            }
            else
            {
                Console.WriteLine($"Książka '{tytul}' jest niedostępna lub nie istnieje.");
            }
        }

        public void ZwrocKsiazke(string tytul)
        {
            var ksiazka = ksiazki.FirstOrDefault(k => k.Tytul.Equals(tytul, StringComparison.OrdinalIgnoreCase));
            if (ksiazka != null && !ksiazka.Dostepna)
            {
                ksiazka.Dostepna = true;
                Console.WriteLine($"Książka '{tytul}' została zwrócona.");
            }
            else
            {
                Console.WriteLine($"Książka '{tytul}' jest już dostępna lub nie istnieje.");
            }
        }

        public void WyszukajKsiazki(string fraza)
        {
            var znalezioneKsiazki = ksiazki.Where(k =>
                k.Tytul.IndexOf(fraza, StringComparison.OrdinalIgnoreCase) >= 0 ||
                k.Autor.IndexOf(fraza, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (znalezioneKsiazki.Any())
            {
                Console.WriteLine("Znalezione książki:");
                foreach (var ksiazka in znalezioneKsiazki)
                {
                    Console.WriteLine(ksiazka.InfoKsiazka());
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono książek pasujących do podanej frazy.");
            }
        }

    }
}

