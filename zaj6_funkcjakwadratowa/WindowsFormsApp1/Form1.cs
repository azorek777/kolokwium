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
        FunkcjaLiniowa Liniowa = new FunkcjaLiniowa();
        FunkcjaKwadratowa Kwadratowa = new FunkcjaKwadratowa();
        Bitmap Axis;
        public Form1()
        {
            InitializeComponent();
            Axis = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = Axis;
        }
        //funkcja pomocnicza DrawAxis - wyrysowuje dwie prostopadłe linie ze //strzałkami
        private void DrawAxis(PictureBox P)
        {
            //utworzenie obiektu typu Graphics, bazując na obrazie Axis- na nim
            //wykonywane będą wszystkie operacje
            Graphics g = Graphics.FromImage(Axis);
            //ustalenie tła na białe
            g.Clear(Color.White);
            //ustalenie koloru i rozmiaru pióra - obiekt typu Pen
            Pen p = new Pen(Color.Black, 1.0f);
            //rysowanie linii pionowej za pomocą 4 liczb: x1,y1 i x2,y2
            g.DrawLine(p, pictureBox1.Width / 2, 0, pictureBox1.Width / 2,
            pictureBox1.Height);
            //rysowanie linii poziomej
            g.DrawLine(p, 0, pictureBox1.Height / 2, pictureBox1.Width,
            pictureBox1.Height / 2);
            //Rysowanie strzałek osi:
            //3 punkty trójkąta nr 1 - strzałki osi Y
            PointF P1u = new PointF(pictureBox1.Width / 2, 0);
            PointF P2u = new PointF(pictureBox1.Width / 2 - pictureBox1.Width / 30,
            0 + pictureBox1.Height / 15);
            PointF P3u = new PointF(pictureBox1.Width / 2 + pictureBox1.Width / 30, 0 +
            pictureBox1.Height / 15);
            PointF[] UpArrowPoints = { P1u, P2u, P3u };
            //3 punkty trójkąta nr 2 - strzałki osi X
            PointF P1r = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            PointF P2r = new PointF(pictureBox1.Width - pictureBox1.Width / 15,
            pictureBox1.Height / 2 - pictureBox1.Height / 30);
            PointF P3r = new PointF(pictureBox1.Width - pictureBox1.Width / 15,
            pictureBox1.Height / 2 + pictureBox1.Height / 30);
            PointF[] RightArrowPoints = { P1r, P2r, P3r };
            //strzałka będzie wypełniona kolorem czarnym - ustalenie koloru //pędzla
            SolidBrush Brush = new SolidBrush(Color.Black);
            //rysowanie obu strzałek
            g.FillPolygon(Brush, UpArrowPoints);
            g.FillPolygon(Brush, RightArrowPoints);
            //przyporządkowanie zmienionego obrazka Axis do pictureBox
            pictureBox1.Image = Axis;
        }
        //wyrysowanie osi przy załadowaniu formy - event Form1_Load


        private void rysuj_Click(object sender, EventArgs e)
        {
            //odczyt współczynników A i B z textBoxa
            string[] Wspolczynniki = textBox1.Text.Split(',');
            //utworzenie obiektu liniowa zgodnie z odczytanymi współczynnikami
            Liniowa = new FunkcjaLiniowa(double.Parse(Wspolczynniki[0]),double.Parse(Wspolczynniki[1]));
            //wypisanie informacji o funkcji w textBox2
            textBox2.Text = Liniowa.Info();
            Graphics g = Graphics.FromImage(Axis);
            //czyszczenie pictureBox
            g.Clear(Color.White);
            //wyrysowanie osi
            DrawAxis(pictureBox1);
            Pen p2 = new Pen(Color.Red, 2.0f);
            //wyrysowanie wykresu funkcji. UWAGA wysokość "0" pictureBox
            //znajduje się w prawym GÓRNYM rogu!
            g.DrawLine(p2, ScaleX(pictureBox1, -10), pictureBox1.Height -
            ScaleY(pictureBox1, (float)Liniowa.A * (-10) + (float)Liniowa.B),
            ScaleX(pictureBox1, 10), pictureBox1.Height - ScaleY(pictureBox1,
            (float)Liniowa.A * (10) + (float)Liniowa.B));
            pictureBox1.Image = Axis;
        }
        private float ScaleX(PictureBox P, float X)
        {
            float OldMin = -10;
            float OldMax = 10;
            float NewX = (X - OldMin) / (OldMax - OldMin) * P.Width;
            return NewX;
        }
        private float ScaleY(PictureBox P, float Y)
        {
            float OldMin = -10;
            float OldMax = 10;
            float NewY = (Y - OldMin) / (OldMax - OldMin) * P.Height;
            return NewY;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DrawAxis(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e) //kwadratowa
        {
/*            string[] Wspolczynniki = textBox3.Text.Split(',');
            Liniowa = new FunkcjaLiniowa(double.Parse(Wspolczynniki[0]), double.Parse(Wspolczynniki[1]));
            textBox2.Text = Liniowa.Info();*/
            string[] Wspolczynniki = textBox3.Text.Split(',');
            Kwadratowa = new FunkcjaKwadratowa(double.Parse(Wspolczynniki[0]), double.Parse(Wspolczynniki[1]), double.Parse(Wspolczynniki[2]));
            textBox2.Text = "Lorem ipsum";

            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            DrawAxis(pictureBox1);
            Pen p2 = new Pen(Color.Red, 2.0f);
            //Punkty testowe (-2,0) (0,-4) (2,0)

            //wyliczyć krańce (-10,10) i podstawić pod to na dole
            double y1 = Kwadratowa.A * (-10) * (-10) + Kwadratowa.B * (-10) + Kwadratowa.C;
            double y3 = Kwadratowa.A * (10) * (10) + Kwadratowa.B * (10) + Kwadratowa.C;
            Punkt w = Kwadratowa.Wierzcholek();

            PointF P1 = new PointF(ScaleX(pictureBox1, (float)-10), ScaleY(pictureBox1, (float)-y1));
            PointF P2 = new PointF(ScaleX(pictureBox1, (float)w.X), ScaleY(pictureBox1, (float)-w.Y));
            PointF P3 = new PointF(ScaleX(pictureBox1, (float)10), ScaleY(pictureBox1, (float)-y3));
            PointF[] kwadratowa = { P1, P2, P3 }; 
            g.DrawCurve(p2,kwadratowa);
            pictureBox1.Image = Axis;
        }
    }
}
