using StorageMaster.Entities.Factories;
using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storages;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private static List<Product> productPool = new List<Product>();
        private static List<Storage> storageRegistry = new List<Storage>();
        private static Vehicle currentVehicle = null;
        private static ProductFactory productFactory = new ProductFactory();
        private static StorageFactory storageFactory = new StorageFactory();

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);
            productPool.Add(product);

            return $"Added {type} to pool";
            
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = storageFactory.CreateStorage(type, name);
            storageRegistry.Add(storage);

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);
            currentVehicle = storage.GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;

            foreach (var productName in productNames)
            {
                if (!currentVehicle.IsFull)
                {
                    Product product = productPool.LastOrDefault(p => p.GetType().Name == productName);

                    if (product == null)
                    {
                        throw new InvalidOperationException($"{productName} is out of stock!");
                    }

                    int index = productPool.LastIndexOf(product);
                    productPool.RemoveAt(index);
                    currentVehicle.LoadProduct(product);
                    loadedProductsCount++;
                }
            }

            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage source = storageRegistry.FirstOrDefault(s => s.Name == sourceName);
            Storage destination = storageRegistry.FirstOrDefault(s => s.Name == destinationName);

            if (source == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (destination == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            string vehicleType = source.GetVehicle(sourceGarageSlot).GetType().Name;
            int destinationGarageSlot = source.SendVehicleTo(sourceGarageSlot, destination);
            return $"Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);
            int productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);
            return storage.ToString();
        }

        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            var sortedStorages = storageRegistry
                .OrderByDescending(s => s.Products.Sum(p => p.Price));

            foreach (var storage in sortedStorages)
            {
                sb.AppendLine($"{storage.Name}");
                sb.AppendLine($"Storage worth: ${storage.Products.Sum(p => p.Price):F2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
