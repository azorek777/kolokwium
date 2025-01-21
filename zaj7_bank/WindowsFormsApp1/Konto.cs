using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Konto
    {
        public Osoba Wlasciciel { get; set; }
        private decimal saldo;
        private int pin;

        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public int Pin
        {
            get { return pin; }
            set
            {
                pin = value;
            }
        }

        public Konto()
        {
            Wlasciciel = new Osoba("Null", "Null");
            saldo = 0;
            pin = 0000;
        }

        public Konto(Osoba wlasciciel, decimal saldo, int pin)
        {
            Wlasciciel = wlasciciel;
            this.saldo = saldo;
            this.pin = pin;
        }
        public Konto(string imie, string nazwisko, decimal saldo, int pin)
        {
            Osoba wlasciciel = new Osoba(imie,nazwisko);

            Wlasciciel = wlasciciel;
            this.saldo = saldo;
            this.pin = pin;
        }

        private bool sprawdzPin(int podanyPin)
        {
            return podanyPin == pin;
        }

        public string Wplata(decimal kwota, int podanyPin)
        {
            if (sprawdzPin(podanyPin))
            {
                if (kwota > 0)
                {
                    saldo += kwota;
                    return $"Wpłacono: {kwota:C}. Nowe saldo: {saldo:C}";
                }
                else
                {
                    throw new Exception("Kwota wpłaty musi być większa niż 0.");
                }
            }
            return "Operacja anulowana: nieprawidłowy PIN.";
        }

        public string Wyplata(decimal kwota, int podanyPin)
        {
            if (sprawdzPin(podanyPin))
            {
                if (kwota > 0 && kwota <= saldo)
                {
                    saldo -= kwota;
                    return $"Operacja wykonana poprawnie. Wypłacono: {kwota:C}";
                }
                else
                {
                    throw new Exception("Nie można wypłacić: niewystarczające środki lub nieprawidłowa kwota.");
                }
            }
            return "Operacja anulowana: nieprawidłowy PIN.";
        }

        public bool ZmienPin(int obecnyPin, int nowyPin)
        {
            if (sprawdzPin(obecnyPin))
            {
                pin = nowyPin;
                return true;
            }
            else
            {
                throw new Exception("Operacja anulowana: nieprawidłowy PIN.");
            }
        }

        public string InformacjeOKoncie(int podanyPin)
        {
            if (sprawdzPin(podanyPin))
            {
                return $"Właściciel: {Wlasciciel.Imie} {Wlasciciel.Nazwisko}, Saldo: {saldo:C}";
            }
            return "Nieprawidłowy PIN.";
        }
    }
}
