namespace Composite
{
    public interface IGraphic
    {
        public void Move(int x, int y);
        public void Draw();
        public bool IsContainer();
    }
}
