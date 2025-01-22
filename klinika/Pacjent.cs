using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Pacjent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }

        DateTime now = DateTime.Now;
        public static DateTime DataRejestracji { get; set; }



        public Pacjent(string imie, string nazwisko, long pesel, DateTime data)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            DataRejestracji = data; 
        }

        public string InfoPacjent()
        {
            return $"Pacjent: {Imie} {Nazwisko}, PESEL: {Pesel}, Zarejestrowany: {DataRejestracji}";
        }
    }

}
