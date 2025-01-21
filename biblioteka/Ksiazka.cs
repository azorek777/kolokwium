using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Library_CSharp
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string Gatunek { get; set; }
        public bool Dostepna { get; set; } = true;

        public Ksiazka(string tytul, string autor, string gatunek)
        {
            Tytul = tytul;
            Autor = autor;
            Gatunek = gatunek;
        }

        public string InfoKsiazka()
        {
            string status = Dostepna ? "Dostępna" : "Niedostępna";
            return $"Książka: {Tytul}, Autor: {Autor}, Gatunek: {Gatunek}, Status: {status}";
        }
    }
}
