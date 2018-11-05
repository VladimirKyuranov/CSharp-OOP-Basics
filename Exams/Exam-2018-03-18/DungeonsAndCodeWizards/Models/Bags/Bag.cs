using DungeonsAndCodeWizards.Core;
using DungeonsAndCodeWizards.Models.Items;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        private int capacity;
        private List<Item> items;

        public int Load => this.items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public Bag(int capacity)
        {
            this.capacity = capacity;
            this.items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Validate.AddItem(this.Load, this.capacity, item.Weight);
            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            Item item = Validate.GetItem(this.items, name);
            this.items.Remove(item);
            return item;
        }
    }
}
