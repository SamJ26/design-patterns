using Builder.Builders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var castleBuilder = new CastleBuilder();

            var defaultCastle = castleBuilder.Build();

            var customCastle = castleBuilder
                .AddFence(Fence.Wooden)
                .AddRoof(Roof.Roof2)
                .AddWindows(Windows.Big)
                .AddPrison()
                .AddTower()
                .Build();

            var houseBuilder = new HouseBuilder();

            var defaultHouse = houseBuilder.Build();

            var customHouse = houseBuilder
                .AddFence(Fence.Stony)
                .AddCellar(Cellar.Small)
                .AddGarage()
                .AddGarden()
                .Build();
        }
    }
}
