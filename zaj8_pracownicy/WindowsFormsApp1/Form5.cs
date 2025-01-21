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
    public partial class Form5 : Form
    {
        Kadry kadry = new Kadry();
        public Form5(Kadry K)
        {
            InitializeComponent();
            kadry = K;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NumerEwidencyjny = textBox1.Text;
            Form4 edytuj = new Form4(kadry, NumerEwidencyjny);
            this.Hide();
            edytuj.ShowDialog();
            this.Close();
        }
    }
}
