using System.Windows.Controls;

namespace OOP1WPF
{
    public abstract class Figure
    {
        public abstract override string ToString();

        public abstract void Draw(Canvas myCanv);
    }
}
