namespace Composite
{
    public abstract class GraphicItem : IGraphic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GraphicItem(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();

        public abstract void Move(int x, int y);

        public bool IsContainer() => false;
    }
}
