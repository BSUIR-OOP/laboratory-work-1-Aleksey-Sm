using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP1WPF
{
    public class Polyline : Figure
    {
        public Point A { get; set; }
        public Point B { get; set; }

        public Polyline(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Polyine: A({A.xPos}; {A.yPos}); B({B.xPos}; {B.yPos})";

        public override void Draw(Canvas myCanv)
        {
            System.Windows.Shapes.Line line = new System.Windows.Shapes.Line();
            line.X1 = A.xPos;
            line.Y1 = A.yPos;
            line.X2 = B.xPos;
            line.Y2 = B.yPos;
            line.Stroke = Brushes.Red;
            myCanv.Children.Add(line);
        }
    }
}
