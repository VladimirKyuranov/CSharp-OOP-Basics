using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storages
{
    public abstract class Storage
    {
        private List<Vehicle> garage;
        private List<Product> products;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new List<Vehicle>(garageSlots);
            this.garage.AddRange(vehicles);
            this.products = new List<Product>();
        }

        public string Name { get; }

        public int Capacity { get; }

        public int GarageSlots { get; }

        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => this.garage.AsReadOnly();

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Error: Invalid garage slot!");
            }

            if (this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("Error: No vehicle in this garage slot!");
            }

            return this.garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            int destinationSlot = deliveryLocation.garage.IndexOf(null);

            if (destinationSlot == -1)
            {
                throw new InvalidOperationException("Error: No room in garage!");
            }

            this.garage[garageSlot] = null;
            deliveryLocation.garage[destinationSlot] = vehicle;

            return destinationSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Error: Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);
            int unloadedProducts = 0;

            while (!vehicle.IsEmpty && !this.IsFull)
            {
                this.products.Add(vehicle.Unload());
                unloadedProducts++;
            }

            return unloadedProducts;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var sortedProducts = this.products
                .GroupBy(p => p.GetType().Name)
                .OrderByDescending(p => p.Count())
                .ThenBy(p => p.Key);
            var sortedVehicles = this.Garage
                .Select(v => v == null ? "empty" : v.GetType().Name);

            sb.AppendLine($"Stock ({this.products.Sum(p => p.Weight)}/{this.Capacity}): [{string.Join(", ", sortedProducts.Select(p => $"{p.Key} ({p.Count()})"))}]");
            sb.AppendLine($"Garage: [{string.Join("|", sortedVehicles)}]");
            return sb.ToString().TrimEnd();
        }
    }
}
