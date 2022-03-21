using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class Point
    {
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
    }
}
