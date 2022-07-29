namespace Composite.Shapes
{
    public class Square : GraphicItem
    {
        public Square(int x, int y) : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawaing Square with the middle point ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine($"Moving Square from ({X}, {Y}) to ({x}, {y})");
        }
    }
}
