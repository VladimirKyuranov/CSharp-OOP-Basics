﻿using StorageMaster.Entities.Products;
using System;
using System.Linq;
using System.Reflection;

namespace StorageMaster.Entities.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(string type, double price)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type model = assembly.GetTypes().FirstOrDefault(v => v.Name == type);

            if (model == null)
            {
                throw new InvalidOperationException("Invalid product type!");
            }

            if (!typeof(Product).IsAssignableFrom(model))
            {
                throw new InvalidOperationException("Invalid product type!");
            }

            Product Product = (Product)Activator.CreateInstance(model, price);
            return Product;
        }
    }
}