namespace Builder
{
    public interface IBuilder<TBuilder, TProduct>
    {
        public TBuilder AddCellar(Cellar cellar);
        public TBuilder AddFence(Fence fence);
        public TBuilder AddRoof(Roof roof);
        public TBuilder AddWindows(Windows windows);
        public TProduct Build();
    }
}
