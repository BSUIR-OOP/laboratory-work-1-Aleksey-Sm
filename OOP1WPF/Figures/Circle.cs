using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP1WPF
{
    public class Circle : Figure
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
            => $"Circle: Center({Center.xPos}, {Center.yPos}), Radius = {Radius}";

        public override void Draw(Canvas myCanv)
        {
            System.Windows.Shapes.Ellipse circ = new System.Windows.Shapes.Ellipse();
            circ.Width = Radius * 2;
            circ.Height = Radius * 2;
            Canvas.SetTop(circ, Center.xPos);
            Canvas.SetLeft(circ, Center.yPos);
            circ.Stroke = Brushes.Green;
            myCanv.Children.Add(circ);
        }
    }
}
