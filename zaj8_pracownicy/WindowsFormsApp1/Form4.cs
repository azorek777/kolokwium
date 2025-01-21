using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Kadry kadry = new Kadry();
        string NumerEwidencyjny;
        public Form4(Kadry K, string numerEwidencyjny)
        {
            InitializeComponent();
            kadry = K;
            NumerEwidencyjny = numerEwidencyjny;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba pracownik = kadry.WyszukajPracownika(NumerEwidencyjny);
            kadry.ZmienDaneOsobowe();
        }
    }
}
