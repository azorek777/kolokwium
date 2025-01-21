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
    public partial class Form2 : Form
    {
        Kadry kadry = new Kadry();
        public Form2(Kadry K)
        {
            InitializeComponent();
            kadry = K;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(kadry);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adres AdresZatrudnionegoPracownika = new Adres(ulica.Text, nrDomu.Text, kodPocztowy.Text, miasto.Text);
            Umowa ZawartaUmowa = new Umowa(DateTime.Parse(dataZawarciaUmowy.Text), typUmowy.Text, czasTrwania.Text);
            Osoba Pracownik = new Osoba(imie.Text, nazwisko.Text, nrEwidencyjny.Text, AdresZatrudnionegoPracownika, DateTime.Parse(dataUrodzenia.Text), ZawartaUmowa);
            kadry.ZatrudnijPracownika(Pracownik);

            Form1 menu = new Form1(kadry);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
