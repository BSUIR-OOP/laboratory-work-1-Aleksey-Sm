using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP1WPF
{
    public class Rectangle : Figure
    {
        public Point A { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public Rectangle(Point a, int height, int width)
        {
            A = a;
            Height = height;
            Width = width;
        }

        public override string ToString()
            => $"Rectangle: A({A.xPos}, {A.yPos}), B({A.xPos + Width}; {A.yPos}), C({A.xPos + Width}, {A.xPos + Height}), D({A.xPos}, {A.yPos + Height})";

        public override void Draw(Canvas myCanv)
        {
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            rect.Width = Width;
            rect.Height = Height;
            Canvas.SetTop(rect, A.xPos);
            Canvas.SetLeft(rect, A.yPos);
            rect.Stroke = Brushes.Orange;
            myCanv.Children.Add(rect);
        }
    }
}
