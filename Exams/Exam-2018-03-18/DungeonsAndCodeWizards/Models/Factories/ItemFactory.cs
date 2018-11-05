using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Linq;
using System.Reflection;

namespace DungeonsAndCodeWizards.Models.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string type)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type model = assembly.GetTypes().FirstOrDefault(v => v.Name == type);

            if (model == null ||
                model.IsAbstract ||
                !typeof(Item).IsAssignableFrom(model))
            {
                throw new ArgumentException($"Invalid item \"{type}\"!");
            }

            Item item = (Item)Activator.CreateInstance(model);
            return item;
        }
    }
}
