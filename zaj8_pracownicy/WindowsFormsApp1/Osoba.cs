using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NumerEwidencyjny { get; private set; }
        public Adres Adres { get; set; }
        public DateTime DataUrodzenia { get; private set; }
        public Umowa Umowa { get; set; }
        public Osoba(string imie, string nazwisko, string numerEwidencyjny, Adres adres, DateTime dataUrodzenia, Umowa umowa)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerEwidencyjny = numerEwidencyjny;
            Adres = adres;
            DataUrodzenia = dataUrodzenia;
            Umowa = umowa;
        }

        public override string ToString()
        {
            //return "d";
            return $"{this.Imie} {this.Nazwisko} Nr.ewidencyjny: {this.NumerEwidencyjny} Adres: {this.Adres} Data Urodzenia: {this.DataUrodzenia.ToString("dd/MM/yyyy")} Umowa: {this.Umowa}";
        }
    }
}
