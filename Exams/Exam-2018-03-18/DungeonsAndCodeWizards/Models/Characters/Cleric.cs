using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Core;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) 
            : base(name, 50, 25, 40, new Backpack(), faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            Validate.CharacterAlive(this);
            Validate.CharacterAlive(character);
            Validate.HealEnemy(this.Faction, character.Faction);
            character.ReceiveHealing(this.AbilityPoints);
        }
    }
}
