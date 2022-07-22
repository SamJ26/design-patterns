using Builder.Products;

namespace Builder.Builders
{
    public class HouseBuilder : IBuilder<HouseBuilder, House>
    {
        private House house = new();

        public House Build()
        {
            var result = house;
            house = new House();
            return result;
        }

        public HouseBuilder AddCellar(Cellar cellar)
        {
            house.Cellar = cellar;
            return this;
        }

        public HouseBuilder AddFence(Fence fence)
        {
            house.Fence = fence;
            return this;
        }

        public HouseBuilder AddRoof(Roof roof)
        {
            house.Roof = roof;
            return this;
        }

        public HouseBuilder AddWindows(Windows windows)
        {
            house.Windows = windows;
            return this;
        }

        public HouseBuilder AddGarden()
        {
            house.Garden = true;
            return this;
        }

        public HouseBuilder AddGarage()
        {
            house.Garage = true;
            return this;
        }
    }
}
