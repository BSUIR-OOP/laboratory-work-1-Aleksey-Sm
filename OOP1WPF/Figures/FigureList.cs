using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1WPF
{
    public class FigureList
    {
        public List<Figure> figureList;

        public FigureList(Figure[] figures)
        {
            figureList = new List<Figure>();
            for (int i = 0; i < figures.Length; i++)
                figureList.Add(figures[i]);
        }
    }
}
