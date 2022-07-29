namespace Composite.Shapes
{
    public class Circle : GraphicItem
    {
        public Circle(int x, int y) : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawaing Circle with the middle point ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine($"Moving Circle from ({X}, {Y}) to ({x}, {y})");
        }
    }
}
