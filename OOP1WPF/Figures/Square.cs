using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP1WPF
{
    public class Square : Figure
    {
        public Point A { get; set; }

        public int Length { get; set; }

        public Square(Point a, int length)
        {
            A = a;
            Length = length;
        }

        public override string ToString()
            => $"Square: A({A.xPos}, {A.yPos}), B({A.xPos + Length}, {A.yPos}), C({A.xPos + Length}, {A.yPos + Length}), D({A.xPos}, {A.yPos + Length})";

        public override void Draw(Canvas myCanv)
        {
            System.Windows.Shapes.Rectangle squa = new System.Windows.Shapes.Rectangle();
            squa.Width = Length;
            squa.Height = Length;
            Canvas.SetLeft(squa, A.xPos);
            Canvas.SetTop(squa, A.yPos);
            squa.Stroke = Brushes.Purple;
            myCanv.Children.Add(squa);
        }
    }
}
