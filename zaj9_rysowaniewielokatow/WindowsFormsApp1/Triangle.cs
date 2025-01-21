using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
}
