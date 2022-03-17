using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Square : Figure
    {
        public Point A { get; set; }

        public int Length { get; set; }

        private Square() { }

        public Square(Point a, int length)
        {
            A = a;
            Length = length;
        }

        public override string ToString()
            => $"Square: A({A.xPos}, {A.yPos}), B({A.xPos + Length}, {A.yPos}), C({A.xPos + Length}, {A.yPos + Length}), D({A.xPos}, {A.yPos + Length})";
    }
}
