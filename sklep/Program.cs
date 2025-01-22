using sklep;

class Program
{
    static void Main(string[] args)
    {
        Sklep sklep = new Sklep();

        // Dodanie produktów
        sklep.DodajProdukt(new Produkt("Mleko", 3.50m, 10));
        sklep.DodajProdukt(new Produkt("Chleb", 2.80m, 15));
        sklep.DodajProdukt(new Produkt("Maslo", 7.20m, 8));
        sklep.DodajProdukt(new Produkt("Ser", 15.00m, 5));
        sklep.DodajProdukt(new Produkt("Jajka", 12.00m, 30));

        // Wyświetlenie produktów
        sklep.WyswietlProdukty();
        Console.WriteLine();

        // Zmiana ceny
        sklep.ZmienCene("Chleb", 3.00m);

        // Wyświetlenie produktów po zmianie ceny
        sklep.WyswietlProdukty();
        Console.WriteLine();

        // Kupno produktu
        sklep.KupProdukt("Jajka", 12);

        // Wyświetlenie produktów po zakupie
        sklep.WyswietlProdukty();
    }
}
