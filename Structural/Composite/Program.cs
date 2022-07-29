using Composite.Shapes;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var screen = new GraphicContainer();

            screen.Add(new Circle(5, 5));
            screen.Add(new Square(10, 10));
            var container = new GraphicContainer();
            container.Add(new Square(20, 20));
            container.Add(new Square(0, 20));
            screen.Add(container);

            screen.Draw();
        }
    }
}
