using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Library_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteka biblioteka = new Biblioteka();

            // Dodawanie książek
            biblioteka.DodajKsiazke(new Ksiazka("Hobbit", "J.R.R. Tolkien", "Fantasy"));
            biblioteka.DodajKsiazke(new Ksiazka("Duma i Uprzedzenie", "Jane Austen", "Romans"));
            biblioteka.DodajKsiazke(new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", "Epopeja"));

            Console.WriteLine();
            // Wyświetlanie książek
            biblioteka.WyswietlKsiazki();

            Console.WriteLine();
            // Wypożyczanie książki
            biblioteka.WypozyczKsiazke("Hobbit");
            biblioteka.WyswietlKsiazki();

            Console.WriteLine();
            // Zwracanie książki
            biblioteka.ZwrocKsiazke("Hobbit");
            biblioteka.WyswietlKsiazki();

            Console.WriteLine();
            // Wyszukiwanie książek
            biblioteka.WyszukajKsiazki("Jane");
            biblioteka.WyszukajKsiazki("Fantasy");
        }
    }
}

