using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Canvas myCanvas = new Canvas();

            // Draw Line
            Polyline polyline = new Polyline(new Point(20, 30), new Point(70, 30));
            System.Windows.Shapes.Line line = new System.Windows.Shapes.Line();
            line.X1 = polyline.A.xPos;
            line.Y1 = polyline.A.yPos;
            line.X2 = polyline.B.xPos;
            line.Y2 = polyline.B.yPos;
            line.Stroke = Brushes.Red;
            myCanvas.Children.Add(line);

            // Draw triangle

            Triangle triangle = new Triangle(new Point(50, 40), new Point(40, 80), new Point(90, 100));
            Polygon triang = new Polygon();
            triang.Stroke = Brushes.Black;
            System.Windows.Point Point1 = new System.Windows.Point(triangle.A.xPos, triangle.A.yPos);
            System.Windows.Point Point2 = new System.Windows.Point(triangle.B.xPos, triangle.B.yPos);
            System.Windows.Point Point3 = new System.Windows.Point(triangle.C.xPos, triangle.C.yPos);
            PointCollection points = new PointCollection();
            points.Add(Point1);
            points.Add(Point2);
            points.Add(Point3);
            triang.Points = points;
            myCanvas.Children.Add(triang);

            // Draw circle
            Circle circle = new Circle(new Point(100, 100), 50);
            System.Windows.Shapes.Ellipse circ = new System.Windows.Shapes.Ellipse();
            circ.Width = circle.Radius * 2;
            circ.Height = circle.Radius * 2;
            Canvas.SetTop(circ, circle.Center.xPos);
            Canvas.SetLeft(circ, circle.Center.yPos);
            circ.Stroke = Brushes.Green;
            myCanvas.Children.Add(circ);

            // Draw Ellipse
            Ellipse ellipse = new Ellipse(new Point(200, 150), 100, 40);
            System.Windows.Shapes.Ellipse elips = new System.Windows.Shapes.Ellipse();
            elips.Width = ellipse.A * 2;
            elips.Height = ellipse.B * 2;
            Canvas.SetTop(elips, ellipse.Center.xPos);
            Canvas.SetLeft(elips, ellipse.Center.yPos);
            elips.Stroke = Brushes.Blue;
            myCanvas.Children.Add(elips);

            // Draw Rectangle
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            Rectangle rectangle = new Rectangle(new Point(200, 50), 150, 50);
            rect.Width = rectangle.Width;
            rect.Height = rectangle.Height;
            Canvas.SetTop(rect, rectangle.A.xPos);
            Canvas.SetLeft(rect, rectangle.A.yPos);
            rect.Stroke = Brushes.Orange;
            myCanvas.Children.Add(rect);

            // Draw square 
            System.Windows.Shapes.Rectangle squa = new System.Windows.Shapes.Rectangle();
            Square square = new Square(new Point(300, 300), 70);
            squa.Width = square.Length;
            squa.Height = square.Length;
            Canvas.SetLeft(squa, square.A.xPos);
            Canvas.SetTop(squa, square.A.yPos);
            squa.Stroke = Brushes.Purple;
            myCanvas.Children.Add(squa);

            this.Content = myCanvas;
        }
    }
}
