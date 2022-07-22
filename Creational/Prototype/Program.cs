using System.Collections;

namespace Prototype
{
    public interface IShape
    {
        public IShape Clone();
        public double GetArea();
    }

    public class Square : IShape
    {
        public int W { get; init; }
        public int H { get; init; }

        public Square() { }

        public Square(Square square)
        {
            W = square.W;
            H = square.H;
        }

        public IShape Clone() => new Square(this);

        public double GetArea() => W * H;
    }

    public class Circle : IShape
    {
        public int Radius { get; init; }

        public Circle() { }

        public Circle(Circle circle)
        {
            Radius = circle.Radius;
        }

        public IShape Clone() => new Circle(this);

        public double GetArea() => 3.14 * Radius * Radius;
    }

    public class PrototypeRegistry : IEnumerable<IShape>
    {
        private readonly Dictionary<string, IShape> prototypes = new();

        public void Add(string protoId, IShape proto) => prototypes.Add(protoId, proto);

        public IEnumerator<IShape> GetEnumerator()
        {
            foreach (var item in prototypes)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var protoRegistry = new PrototypeRegistry();

            var c1 = new Circle() { Radius = 5 };
            Console.WriteLine(c1.GetArea());
            protoRegistry.Add("c1", c1);

            var s1 = new Square() { H = 10, W = 5 };
            Console.WriteLine(s1.GetArea());
            protoRegistry.Add("s1", s1);

            foreach (var item in protoRegistry)
            {
                var cloned = item.Clone();
                Console.WriteLine(cloned.GetArea());
            }
        }
    }
}
