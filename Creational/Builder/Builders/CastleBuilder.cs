using Builder.Products;

namespace Builder.Builders
{
    public class CastleBuilder : IBuilder<CastleBuilder, Castle>
    {
        private Castle castle = new();

        public Castle Build()
        {
            var result = castle;
            castle = new Castle();
            return result;
        }

        public CastleBuilder AddCellar(Cellar cellar)
        {
            castle.Cellar = cellar;
            return this;
        }

        public CastleBuilder AddFence(Fence fence)
        {
            castle.Fence = fence;
            return this;
        }

        public CastleBuilder AddRoof(Roof roof)
        {
            castle.Roof = roof;
            return this;
        }

        public CastleBuilder AddWindows(Windows windows)
        {
            castle.Windows = windows;
            return this;
        }

        public CastleBuilder AddPrison()
        {
            castle.Prison = true;
            return this;
        }

        public CastleBuilder AddTower()
        {
            castle.Tower = true;
            return this;
        }
    }
}
