using StorageMaster.Entities.Factories;
using StorageMaster.Entities.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Entities.Storages
{
    public class DistributionCenter : Storage
    {
        private static VehicleFactory vehicleFactory = new VehicleFactory();
        private const int defaultCapacity = 2;
        private const int defaultGarageSlots = 5;
        private static IEnumerable<Vehicle> defaultVehicles = new List<Vehicle>
        {
            vehicleFactory.CreateVehicle("Van"),
            vehicleFactory.CreateVehicle("Van"),
            vehicleFactory.CreateVehicle("Van"),
            null,
            null
        };

        public DistributionCenter(string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}