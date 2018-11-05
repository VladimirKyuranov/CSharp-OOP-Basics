using DungeonsAndCodeWizards.Core;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Models.Items
{
    public abstract class Item
    {
        public int Weight { get; protected set; }

        public Item(int weight)
        {
            this.Weight = weight;
        }

        public virtual void AffectCharacter(Character character)
        {
            Validate.CharacterAlive(character);
        }
    }
}