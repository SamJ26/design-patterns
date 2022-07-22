namespace Builder.Products
{
    public abstract class ProductBase
    {
        public Roof Roof { get; set; }
        public Windows Windows { get; set; }
        public Fence Fence { get; set; }
        public Cellar Cellar { get; set; }
    }
}
