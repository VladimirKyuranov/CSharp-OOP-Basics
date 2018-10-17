using StorageMaster.Entities.Vehicles;
using System;
using System.Linq;
using System.Reflection;

namespace StorageMaster.Entities.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type model = assembly.GetTypes().FirstOrDefault(v => v.Name == type);

            if (model == null)
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }

            if (!typeof(Vehicle).IsAssignableFrom(model))
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }

            Vehicle vehicle = (Vehicle)Activator.CreateInstance(model);
            return vehicle;
        }
    }
}
