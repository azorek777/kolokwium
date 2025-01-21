using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Kadry kadry = new Kadry();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Kadry K)
        {
            InitializeComponent();
            kadry = K;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 zatrudnij = new Form2(kadry);
            this.Hide();
            zatrudnij.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 wyswietl = new Form3(kadry);
            this.Hide();
            wyswietl.ShowDialog();
            this.Close();
        }


        /*        private void button1_Click(object sender, EventArgs e)
                {
                    if (textBox2.Text == K.Wlasciciel.Nazwisko && textBox1.Text ==
                    K.Pin.ToString())
                    {
                        Form2 f2 = new Form2(K); //przeniesienie informacji o K do drugiej fromy
                        this.Hide(); //ukrycie formy 1
                        f2.ShowDialog(); //wywołanie formy 2
                        this.Close(); //zamknięcie formy 1
                    }
                    else
                        MessageBox.Show("Nieprawidłowy PIN i/lub login");
                }*/
    }
}
