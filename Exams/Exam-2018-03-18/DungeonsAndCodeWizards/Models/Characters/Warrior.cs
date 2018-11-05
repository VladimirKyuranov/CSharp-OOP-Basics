using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Core;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction) 
            : base(name, 100, 50, 40, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            Validate.CharacterAlive(this);
            Validate.CharacterAlive(character);
            Validate.AttackSelf(this.Name, character.Name);
            Validate.AttackSameFaction(this.Faction, character.Faction);
            character.TakeDamage(this.AbilityPoints);
        }
    }
}
