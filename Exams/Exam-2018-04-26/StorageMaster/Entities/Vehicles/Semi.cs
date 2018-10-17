namespace StorageMaster.Entities.Vehicles
{
    public class Semi : Vehicle
    {
        private const int defaultCapacity = 2;
        public Semi()
            : base(defaultCapacity)
        {
        }
    }
}