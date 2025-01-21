using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kadry
    {
        List<Osoba> ListaPracownikow = new List<Osoba>();
        public Kadry() { }
        public void ZatrudnijPracownika()
        {
            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Write("Podaj numer ewidencyjny: ");
            string numerEwidencyjny = Console.ReadLine();
            Console.Write("Podaj datę urodzenia (dd/MM/yyyy): ");
            DateTime dataUrodzenia = DateTime.Parse(Console.ReadLine());
            Console.Write("Podaj ulicę: ");
            string ulica = Console.ReadLine();
            Console.Write("Podaj numer domu: ");
            string numerDomu = Console.ReadLine();
            Console.Write("Podaj kod pocztowy: ");
            string kodPocztowy = Console.ReadLine();
            Console.Write("Podaj miasto: ");
            string miasto = Console.ReadLine();

            Adres adres = new Adres(ulica, numerDomu, kodPocztowy, miasto);

            Console.Write("Podaj typ umowy: ");
            string typUmowy = Console.ReadLine();
            Console.Write("Podaj datę zawarcia umowy (dd/MM/yyyy): ");
            DateTime dataZawarcia = DateTime.Parse(Console.ReadLine());
            Console.Write("Podaj czas umowy: ");
            string czasUmowy = Console.ReadLine();

            Umowa umowa = new Umowa(dataZawarcia, typUmowy, czasUmowy);

            Osoba pracownik = new Osoba(imie, nazwisko, numerEwidencyjny, adres, dataUrodzenia, umowa);
            ListaPracownikow.Add(pracownik);
            Console.WriteLine("Pracownik został zatrudniony.");
        }
        public List<Osoba> WyszukajPracownika()
        {
            Console.WriteLine("Podaj numer Ewidencyjny szukanego pracownika:");
            string numerEwidencyjny = Console.ReadLine();
            Osoba znaleziony_pracownik = ListaPracownikow.FirstOrDefault(o => o.NumerEwidencyjny == numerEwidencyjny);
            List<Osoba> Wyszukany = new List<Osoba>();
            Wyszukany.Add(znaleziony_pracownik);
            return Wyszukany;
        }
        public List<Osoba> WyszukajPracownikow()
        {
            List<Osoba> Wyszukany = new List<Osoba>();
            return Wyszukany;
        }




        public void WyswietlPracownikow(List<Osoba> lista = null)
        {
            var pracownicy = lista ?? ListaPracownikow;

            if (pracownicy.Count == 0)
                Console.WriteLine("Brak pracowników.");
            else
                pracownicy.ForEach(Console.WriteLine);
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
