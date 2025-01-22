using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }

        public Produkt(string nazwa, decimal cena, int ilosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Ilosc = ilosc;
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Cena: {Cena:C}, Ilosc: {Ilosc}";
        }
    }
}
