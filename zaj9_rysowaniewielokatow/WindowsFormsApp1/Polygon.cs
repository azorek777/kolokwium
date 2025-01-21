using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
            R = this.SideSize / (2 * Math.Sin(Math.PI / this.NumberOfSides));
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
}
