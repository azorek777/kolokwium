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
    public partial class Form3 : Form
    {
        Kadry kadry = new Kadry();
        public Form3(Kadry K)
        {
            InitializeComponent();
            kadry = K;

            List<Osoba> pracownicy = new List<Osoba>();
            pracownicy = kadry.WyswietlPracownikow();

            foreach (Osoba O in pracownicy)
            {
                textBox1.Text += O.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(kadry);
            this.Hide();
            menu.ShowDialog();
            this.Close();   
        }
    }
}
