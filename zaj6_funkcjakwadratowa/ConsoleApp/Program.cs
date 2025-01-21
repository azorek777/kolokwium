﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Punkt
    {
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
        public Punkt(double x, double y)
        {
            X= x;
            Y = y;
        }
    }
    public class FunkcjaKwadratowa
    {
        public double A
        {
            set; get;
        }
        public double B
        {
            set; get;
        }
        public double C
        {
            set; get;
        }
        public FunkcjaKwadratowa(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public FunkcjaKwadratowa()
        {
            A = 1;
            B = 0;
            C = 0;
        }
        public Punkt Wierzcholek()
        {
            double p = -(B/(2*A));
            double q = -((B*B-4*A*C)/(4*A));
            Punkt w = new Punkt(p,q);
            return w;
        }
        public void MiejscaZerowe()
        {
            double delta = (B * B - 4 * A * C);
            if (delta >= 0)
            {
                double x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine("Funkcja posiada miejsca zerowe w punkcie {0} i {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Funkcja nie posiada miejsc zerowych");
            }
        }
        public void Info()
        {
            Punkt w = this.Wierzcholek();
            Console.WriteLine("Funkcja kwadratowa o wspołczynnikach a={0} b={1} c={2}, posiada wierzchołek w punkcie ({3},{4})",A,B,C,w.X,w.Y);
            this.MiejscaZerowe();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FunkcjaKwadratowa f1 = new FunkcjaKwadratowa(1,-4,-5);
            f1.Info();
            FunkcjaKwadratowa f2 = new FunkcjaKwadratowa(1, 0, 2);
            f2.Info();
            FunkcjaKwadratowa f3 = new FunkcjaKwadratowa(1, 0, -2);
            f3.Info();
            Console.ReadKey();
        }
    }
}