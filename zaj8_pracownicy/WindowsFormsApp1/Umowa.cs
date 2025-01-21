using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Umowa
    {
        public DateTime DataZawarcia { set; get; }
        public string TypUmowy { set; get; }
        public string CzasUmowy { set; get; }

        public Umowa(DateTime dataZawarcia, string typUmowy, string czasUmowy)
        {
            DataZawarcia = dataZawarcia;
            TypUmowy = typUmowy;
            CzasUmowy = czasUmowy;
        }
        public override string ToString()
        {
            return $"Data zawarcia: {this.DataZawarcia.ToString("dd/MM/yyyy")} typ umowy {this.TypUmowy} czas umowy {this.CzasUmowy}";
        }
    }
}
