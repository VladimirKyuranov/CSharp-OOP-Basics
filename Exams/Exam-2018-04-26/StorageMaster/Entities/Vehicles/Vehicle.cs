using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private List<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }

        public int Capacity { get; }
        
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => this.Trunk.Count == 0;

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product product = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }
    }
}