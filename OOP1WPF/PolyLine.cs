using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Polyline : Figure
    {
        public Point A { get; set; }
        public Point B { get; set; }

        private Polyline() { }

        public Polyline(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Polyine: A({A.xPos}; {A.yPos}); B({B.xPos}; {B.yPos})";
    }
}
