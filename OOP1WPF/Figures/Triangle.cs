using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOP1WPF
{
    public class Triangle : Figure
    {
        public Point A { get; set; }

        public Point B { get; set; }

        public Point C { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
            => $"Triangle: A({A.xPos}; {A.yPos}); B({B.xPos}; {B.yPos}); C({C.xPos}; {C.yPos})";

        public override void Draw(Canvas myCanv)
        {
            Polygon triang = new Polygon();
            triang.Stroke = Brushes.Black;
            System.Windows.Point Point1 = new System.Windows.Point(A.xPos, A.yPos);
            System.Windows.Point Point2 = new System.Windows.Point(B.xPos, B.yPos);
            System.Windows.Point Point3 = new System.Windows.Point(C.xPos, C.yPos);
            PointCollection points = new PointCollection();
            points.Add(Point1);
            points.Add(Point2);
            points.Add(Point3);
            triang.Points = points;
            myCanv.Children.Add(triang);
        }
    }
}
