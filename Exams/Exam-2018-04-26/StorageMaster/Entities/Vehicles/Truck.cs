namespace StorageMaster.Entities.Vehicles
{
    public class Truck : Vehicle
    {
        private const int defaultCapacity = 2;
        public Truck()
            : base(defaultCapacity)
        {
        }
    }
}