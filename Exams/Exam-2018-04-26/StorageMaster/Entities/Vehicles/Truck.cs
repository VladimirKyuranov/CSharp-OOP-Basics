namespace StorageMaster.Entities.Vehicles
{
    public class Truck : Vehicle
    {
        private const int defaultCapacity = 5;
        public Truck()
            : base(defaultCapacity)
        {
        }
    }
}