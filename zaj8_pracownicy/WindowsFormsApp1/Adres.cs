using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Adres
    {
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public Adres(string ulica, string numerdomu, string kodpocztowy, string miasto)
        {
            Ulica = ulica;
            NumerDomu = numerdomu;
            KodPocztowy = kodpocztowy;
            Miasto = miasto;
        }
        public override string ToString()
        {
            return $"Ulica: {this.Ulica} Nr domu {this.NumerDomu} Kod pocztowy {this.KodPocztowy} Miasto {this.Miasto}";
        }
    }
}
