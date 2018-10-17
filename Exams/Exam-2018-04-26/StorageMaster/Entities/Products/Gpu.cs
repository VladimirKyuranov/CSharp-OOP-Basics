namespace StorageMaster.Entities.Products
{
    public class Gpu : Product
    {
        private const double defaultWeight = 0.7;

        public Gpu(double price) 
            : base(price, defaultWeight)
        {
        }
    }
}
