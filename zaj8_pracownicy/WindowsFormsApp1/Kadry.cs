using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kadry
    {
        List<Osoba> ListaPracownikow = new List<Osoba>();
        public Kadry() { }
        public void ZatrudnijPracownika(Osoba O)
        {            
            ListaPracownikow.Add(O);
        }
        public Osoba WyszukajPracownika(string numerEwidencyjny)
        {
            Osoba znaleziony_pracownik = ListaPracownikow.Find(o => o.NumerEwidencyjny == numerEwidencyjny);
            return znaleziony_pracownik;
        }

        public List<Osoba> WyszukajPracownikow()
        {
            List<Osoba> Wyszukany = new List<Osoba>();
            return Wyszukany;
        }




        public List<Osoba> WyswietlPracownikow(List<Osoba> lista = null)
        {
            var pracownicy = lista ?? ListaPracownikow;

            if (pracownicy.Count == 0)
                Console.WriteLine("Brak pracowników.");
            else
                pracownicy.ForEach(Console.WriteLine);
            return pracownicy;
        }

        public void ZmienAdres()
        {
            Console.Write("Podaj numer ewidencyjny pracownika: ");
            string numerEwidencyjny = Console.ReadLine();
            Osoba pracownik = ListaPracownikow.FirstOrDefault(p => p.NumerEwidencyjny == numerEwidencyjny);

            if (pracownik != null)
            {
                Console.Write("Podaj nową ulicę: ");
                pracownik.Adres.Ulica = Console.ReadLine();
                Console.Write("Podaj nowy numer domu: ");
                pracownik.Adres.NumerDomu = Console.ReadLine();
                Console.Write("Podaj nowy kod pocztowy: ");
                pracownik.Adres.KodPocztowy = Console.ReadLine();
                Console.Write("Podaj nowe miasto: ");
                pracownik.Adres.Miasto = Console.ReadLine();
                Console.WriteLine("Adres został zmieniony.");
            }
            else
            {
                Console.WriteLine("Pracownik nie został znaleziony.");
            }
        }

        public void ZmienDaneOsobowe()
        {
            Console.Write("Podaj numer ewidencyjny pracownika: ");
            string numerEwidencyjny = Console.ReadLine();
            Osoba pracownik = ListaPracownikow.FirstOrDefault(p => p.NumerEwidencyjny == numerEwidencyjny);

            if (pracownik != null)
            {
                Console.Write("Podaj nowe imię: ");
                pracownik.Imie = Console.ReadLine();
                Console.Write("Podaj nowe nazwisko: ");
                pracownik.Nazwisko = Console.ReadLine();
                Console.WriteLine("Dane osobowe zostały zmienione.");
            }
            else
            {
                Console.WriteLine("Pracownik nie został znaleziony.");
            }
        }

        public void ZmienUmowe()
        {
            Console.Write("Podaj numer ewidencyjny pracownika: ");
            string numerEwidencyjny = Console.ReadLine();
            Osoba pracownik = ListaPracownikow.FirstOrDefault(p => p.NumerEwidencyjny == numerEwidencyjny);

            if (pracownik != null)
            {
                Console.Write("Podaj nowy typ umowy: ");
                pracownik.Umowa.TypUmowy = Console.ReadLine();
                Console.Write("Podaj nową datę zawarcia umowy (dd/MM/yyyy): ");
                pracownik.Umowa.DataZawarcia = DateTime.Parse(Console.ReadLine());
                Console.Write("Podaj nowy czas umowy: ");
                pracownik.Umowa.CzasUmowy = Console.ReadLine();
                Console.WriteLine("Umowa została zmieniona.");
            }
            else
            {
                Console.WriteLine("Pracownik nie został znaleziony.");
            }
        }

        public void UsunPracownika()
        {
            Console.Write("Podaj numer ewidencyjny pracownika: ");
            string numerEwidencyjny = Console.ReadLine();
            Osoba pracownik = ListaPracownikow.FirstOrDefault(p => p.NumerEwidencyjny == numerEwidencyjny);

            if (pracownik != null)
            {
                ListaPracownikow.Remove(pracownik);
                Console.WriteLine("Pracownik został usunięty.");
            }
            else
            {
                Console.WriteLine("Pracownik nie został znaleziony.");
            }
        }
    }
}
