namespace Composite
{
    public class GraphicContainer : IGraphic
    {
        private readonly List<IGraphic> elements = new();

        public void Add(IGraphic graphic) => elements.Add(graphic);

        public void Remove(IGraphic graphic) => elements.Remove(graphic);

        public void Draw()
        {
            foreach (var elem in elements)
            {
                elem.Draw();
            }
        }

        public void Move(int x, int y)
        {
            foreach (var elem in elements)
            {
                elem.Move(x, y);
            }
        }

        public bool IsContainer() => true;
    }
}
