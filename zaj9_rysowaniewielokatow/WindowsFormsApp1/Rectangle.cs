using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Rectangle : Polygon
    {
        public Rectangle(int X, int Y, double sideSize) : base(4, sideSize, X, Y)
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
}
