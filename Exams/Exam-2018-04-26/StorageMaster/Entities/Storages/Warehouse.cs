using StorageMaster.Entities.Factories;
using StorageMaster.Entities.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Entities.Storages
{
    public class Warehouse : Storage
    {
        private static VehicleFactory vehicleFactory = new VehicleFactory();

        private const int defaultCapacity = 10;
        private const int defaultGarageSlots = 10;
        private static IEnumerable<Vehicle> defaultVehicles = new List<Vehicle>
        {
            vehicleFactory.CreateVehicle("Semi"),
            vehicleFactory.CreateVehicle("Semi"),
            vehicleFactory.CreateVehicle("Semi"),
            null,
            null,
            null,
            null,
            null,
            null,
            null
        };

        public Warehouse(string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}