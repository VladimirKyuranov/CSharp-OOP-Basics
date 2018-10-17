namespace StorageMaster.Entities.Vehicles
{
    public class Van : Vehicle
    {
        private const int defaultCapacity = 2;
        public Van()
            : base(defaultCapacity)
        {
        }
    }
}