using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    public class Sklep
    {
        private List<Produkt> produkty = new List<Produkt>();

        public void DodajProdukt(Produkt produkt)
        {
            produkty.Add(produkt);
            Console.WriteLine($"Dodano produkt: {produkt.Nazwa}");
        }

        public void WyswietlProdukty()
        {
            Console.WriteLine("Lista produktów:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine(produkt);
            }
        }

        public void ZmienCene(string nazwa, decimal nowaCena)
        {
            var produkt = produkty.FirstOrDefault(p => p.Nazwa == nazwa);
            if (produkt != null)
            {
                produkt.Cena = nowaCena;
                Console.WriteLine($"Zmieniono cenę produktu {nazwa} na {nowaCena:C}");
            }
            else
            {
                Console.WriteLine($"Produkt {nazwa} nie znaleziony.");
            }
        }

        public void ZmienIlosc(string nazwa, int nowaIlosc)
        {
            var produkt = produkty.FirstOrDefault(p => p.Nazwa == nazwa);
            if (produkt != null)
            {
                produkt.Ilosc = nowaIlosc;
                Console.WriteLine($"Zmieniono ilość produktu {nazwa} na {nowaIlosc}");
            }
            else
            {
                Console.WriteLine($"Produkt {nazwa} nie znaleziony.");
            }
        }

        public void KupProdukt(string nazwa, int ilosc)
        {
            var produkt = produkty.FirstOrDefault(p => p.Nazwa == nazwa);
            if (produkt != null)
            {
                if (produkt.Ilosc >= ilosc)
                {
                    produkt.Ilosc -= ilosc;
                    Console.WriteLine($"Zakupiono {ilosc} szt. produktu {nazwa}");
                }
                else
                {
                    Console.WriteLine($"Nie ma wystarczającej ilości produktu {nazwa} na stanie.");
                }
            }
            else
            {
                Console.WriteLine($"Produkt {nazwa} nie znaleziony.");
            }
        }
    }

}
