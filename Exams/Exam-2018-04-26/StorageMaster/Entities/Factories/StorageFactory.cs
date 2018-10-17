using StorageMaster.Entities.Storages;
using System;
using System.Linq;
using System.Reflection;

namespace StorageMaster.Entities.Factories
{
    public class StorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type model = assembly.GetTypes().FirstOrDefault(v => v.Name == type);

            if (model == null)
            {
                throw new InvalidOperationException("Invalid storage type!");
            }

            if (!typeof(Storage).IsAssignableFrom(model))
            {
                throw new InvalidOperationException("Invalid storage type!");
            }

            Storage Storage = (Storage)Activator.CreateInstance(model, name);
            return Storage;
        }
    }
}
