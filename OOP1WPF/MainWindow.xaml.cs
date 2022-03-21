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

            FigureList myList = new FigureList(new Figure[]
            {
                new Polyline(new Point(20, 30), new Point(70, 30)),
                new Triangle(new Point(50, 40), new Point(40, 80), new Point(90, 100)),
                new Circle(new Point(100, 100), 50),
                new Ellipse(new Point(200, 150), 100, 40),
                new Rectangle(new Point(200, 50), 150, 50),
                new Square(new Point(300, 300), 70)
            });

            foreach (Figure f in myList.figureList)
                f.Draw(myCanvas);

            this.Content = myCanvas;
        }
    }
}
