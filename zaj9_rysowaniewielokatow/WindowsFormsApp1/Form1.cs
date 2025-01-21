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
        Bitmap Axis;
        Polygon P;

        public Form1()
        {
            InitializeComponent();
            Axis = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            pictureBox1.Image = Axis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczbaBokow = int.Parse(textBox1.Text);
            int X = (int)pictureBox1.Size.Width / 2;
            int Y = (int)pictureBox1.Size.Height / 2;

            if (liczbaBokow == 3)
            {
                Triangle triangle = new Triangle(X, Y, int.Parse(textBox2.Text));
                textBox3.Text = triangle.Data();
                PointF[] PointList = new PointF[liczbaBokow];
                for (int i = 0; i < liczbaBokow; i++)
                {

                    float xi = (float)(triangle.Centre.X + triangle.R * Math.Cos(i * triangle.Angle));
                    float yi = (float)(triangle.Centre.Y + triangle.R * Math.Sin(i * triangle.Angle));
                    PointList[i] = new PointF(xi, yi);
                }
                Graphics g = Graphics.FromImage(Axis);
                g.Clear(Color.White);
                g.DrawPolygon(Pens.Red, PointList);
                pictureBox1.Image = Axis;
            }
            else if(liczbaBokow == 4)
            {
                Rectangle rectangle = new Rectangle(X, Y, int.Parse(textBox2.Text));
                textBox3.Text = rectangle.Data();
                PointF[] PointList = new PointF[liczbaBokow];
                for (int i = 0; i < liczbaBokow; i++)
                {

                    float xi = (float)(rectangle.Centre.X + rectangle.R * Math.Cos(i * rectangle.Angle));
                    float yi = (float)(rectangle.Centre.Y + rectangle.R * Math.Sin(i * rectangle.Angle));
                    PointList[i] = new PointF(xi, yi);
                }
                Graphics g = Graphics.FromImage(Axis);
                g.Clear(Color.White);
                g.DrawPolygon(Pens.Red, PointList);
                pictureBox1.Image = Axis;
            }
            else
            {
                Polygon polygon = new Polygon(liczbaBokow, int.Parse(textBox2.Text), X, Y);
                textBox3.Text = polygon.Data();
                PointF[] PointList = new PointF[liczbaBokow];
                for (int i = 0; i < liczbaBokow; i++)
                {

                    float xi = (float)(polygon.Centre.X + polygon.R * Math.Cos(i * polygon.Angle));
                    float yi = (float)(polygon.Centre.Y + polygon.R * Math.Sin(i * polygon.Angle));
                    PointList[i] = new PointF(xi, yi);
                }
                Graphics g = Graphics.FromImage(Axis);
                g.Clear(Color.White);
                g.DrawPolygon(Pens.Red, PointList);
                pictureBox1.Image = Axis;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Axis = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            pictureBox1.Image = Axis;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
