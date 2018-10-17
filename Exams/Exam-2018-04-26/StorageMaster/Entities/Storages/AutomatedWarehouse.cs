using StorageMaster.Entities.Factories;
using StorageMaster.Entities.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private static VehicleFactory vehicleFactory = new VehicleFactory();
        private const int defaultCapacity = 1;
        private const int defaultGarageSlots = 2;
        private static IEnumerable<Vehicle> defaultVehicles = new List<Vehicle>
        {
            vehicleFactory.CreateVehicle("Truck")
        };

        public AutomatedWarehouse(string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}