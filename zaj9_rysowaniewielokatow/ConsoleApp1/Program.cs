using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x; Y = y; 
            }
        }
        public class Polygon
        {
            public int NumberOfSides { get; set; }
            public double SideSize { get; set; }
            public List<double> Sides { get; set; }
            public Point Centre { get; set; }
            public double Angle { get; set; }
            public double R { get; set; }
            public Polygon()
            {
                this.NumberOfSides = 0;
                this.SideSize = 0;
                this.Sides = new List<double>();
                this.Centre = new Point(0, 0);
                this.Angle = 0;
                this.R = 0;
            }
            public Polygon(int X, int Y, double sideSize)
            {
                SideSize = sideSize;
                Centre = new Point(X, Y);
            }
            public Polygon(int numberOfSides, double sideSize, int X, int Y)
            {
                NumberOfSides = numberOfSides;
                SideSize = sideSize;
                Centre = new Point(X, Y);
                this.Sides = new List<double>();
                for (int i = 0; i < numberOfSides; i++)
                {
                    this.Sides.Add(SideSize);
                }
                Angle = 2 * Math.PI / this.NumberOfSides;
                R = this.SideSize/(2*Math.Sin(Math.PI/this.NumberOfSides));
            }
            public double Perimeter()
            {
                return this.SideSize * this.NumberOfSides;
            }
            public virtual string Data()
            {
                return $"To jest NumberOfSides - {this.NumberOfSides}, kąt {this.Angle}, jego obwód wynosi {Perimeter()}.";
            }
        }
        public class Rectangle : Polygon
        {
            public Rectangle(int X, int Y, double sideSize) : base(4, sideSize,X, Y)
            {
                Angle = Math.PI / 2;
                R = SideSize / (2 * Math.Sin(Math.PI / this.NumberOfSides));
            }
            public double Area()
            {
                return SideSize * SideSize;
            }
            public override string Data()
            {
                return $"Figura to kwadrat o polu {Area():F2} i obwodzie \r\n{Perimeter():F2}.";
            }
        }
        public class Triangle : Polygon
        {
            public double Height { get; set; }
            public Triangle(int X, int Y, double sideSize) : base(3, sideSize, X, Y)
            {
                Angle = 2 * Math.PI / 3;
                R = SideSize / (2 * Math.Sin(Math.PI / 3));
                Height = SideSize * Math.Sqrt(3) / 2;
            }
            public double Area()
            {
                return 0.5 * SideSize * Height;
            }
            public override string Data()
            {
                return $"Figura to trójkąt o polu {Area():F2} i obwodzie \r\n{Perimeter():F2}.";
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 2, 8);
            Console.WriteLine(rectangle.Data());
            Console.ReadLine();
        }
    }
}
