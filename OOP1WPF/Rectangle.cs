using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Rectangle : Figure
    {
        public Point A { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        private Rectangle() { }

        public Rectangle(Point a, int height, int width)
        {
            A = a;
            Height = height;
            Width = width;
        }

        public override string ToString()
            => $"Rectangle: A({A.xPos}, {A.yPos}), B({A.xPos + Width}; {A.yPos}), C({A.xPos + Width}, {A.xPos + Height}), D({A.xPos}, {A.yPos + Height})";
    }
}
