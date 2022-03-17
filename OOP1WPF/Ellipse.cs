using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Ellipse : Figure
    {
        public Point Center { get; set; }
        public int A { get; set; }

        public int B { get; set; }

        private Ellipse() { }

        public Ellipse(Point center, int a, int b)
        {
            Center = center;
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Ellipse: Center({Center.xPos}, {Center.yPos}), Semi-minor axis = {A}, Semi-major axis = {B}";
    }
}
