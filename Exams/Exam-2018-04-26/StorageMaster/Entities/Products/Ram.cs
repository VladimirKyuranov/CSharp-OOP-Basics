namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        private const double defaultWeight = 0.1;

        public Ram(double price)
            : base(price, defaultWeight)
        {
        }
    }
}
