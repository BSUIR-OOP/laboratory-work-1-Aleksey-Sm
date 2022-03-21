using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP1WPF
{
    public class Ellipse : Figure
    {
        public Point Center { get; set; }
        public int A { get; set; }

        public int B { get; set; }

        public Ellipse(Point center, int a, int b)
        {
            Center = center;
            A = a;
            B = b;
        }

        public override string ToString()
            => $"Ellipse: Center({Center.xPos}, {Center.yPos}), Semi-minor axis = {A}, Semi-major axis = {B}";

        public override void Draw(Canvas myCanv)
        {
            System.Windows.Shapes.Ellipse elips = new System.Windows.Shapes.Ellipse();
            elips.Width = A * 2;
            elips.Height = B * 2;
            Canvas.SetTop(elips, Center.xPos);
            Canvas.SetLeft(elips, Center.yPos);
            elips.Stroke = Brushes.Blue;
            myCanv.Children.Add(elips);
        }
    }
}
