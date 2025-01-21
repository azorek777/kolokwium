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
    public partial class Form1 : Form
    {

        Konto K = new Konto("Jan","Kowalski",1000m,1111);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == K.Wlasciciel.Nazwisko && textBox1.Text == K.Pin.ToString())
            {
                Form2 f2 = new Form2(K);
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy PIN i/lub login");
            }
        }
    }
}
