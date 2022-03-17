using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Circle : Figure
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        private Circle() { }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
            => $"Circle: Center({Center.xPos}, {Center.yPos}), Radius = {Radius}";
    }
}
