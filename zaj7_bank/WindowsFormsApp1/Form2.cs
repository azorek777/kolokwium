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
        Konto K = new Konto();
        public Form2(Konto A)
        {
            InitializeComponent();
            K = A;
            textBox1.Text = K.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.Wplata(int.Parse(textBox3.Text), K.Pin));
                textBox1.Text = K.Saldo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.Wyplata(int.Parse(textBox4.Text), K.Pin));
                textBox1.Text = K.Saldo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = K.Saldo.ToString();
            textBox2.Text = K.InformacjeOKoncie(K.Pin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (K.ZmienPin(K.Pin, int.Parse(textBox5.Text)))
                {
                    MessageBox.Show("Prawidłowa zmiana PIN-u");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
