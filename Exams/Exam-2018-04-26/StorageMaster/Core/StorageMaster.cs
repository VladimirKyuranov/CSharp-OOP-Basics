using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private static Dictionary<Product, int> productPool = new Dictionary<Product, int>();
        private static Dictionary<Product, int> storageRegistry = new Dictionary<Product, int>();
        private static Vehicle currentVehicle;

        public string AddProduct(string type, double price)
        {
            throw new NotImplementedException();
        }

        public string RegisterStorage(string type, string name)
        {
            throw new NotImplementedException();
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            throw new NotImplementedException();
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            throw new NotImplementedException();
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }

        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}
