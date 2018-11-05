using DungeonsAndCodeWizards.Core;
using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;
using System;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                name = value;
            }
        }


        public double BaseHealth { get; }

        public double Health
        {
            get { return this.health; }
            protected set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else if (value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                }
                else
                {
                    this.health = value;
                }
            }
        }
        
        public double BaseArmor { get; }

        public double Armor
        {
            get { return this.armor; }
            protected set
            {
                if (value < 0)
                {
                    this.armor = 0;
                }
                else if (value > this.BaseArmor)
                {
                    this.armor = this.BaseArmor;
                }
                else
                {
                    this.armor = value;
                }
            }
        }
        public double AbilityPoints { get; }

        public Bag Bag { get; }

        public Faction Faction { get; }

        public bool IsAlive { get; protected set; }

        public virtual double RestHealMultiplier => 0.2;

        public Character(string name, double health, double armor, double abillityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abillityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
        }

        public void TakeDamage(double hitpoints)
        {
            Validate.CharacterAlive(this);

            if (this.Armor >= hitpoints)
            {
                this.Armor -= hitpoints;
            }
            else
            {
                hitpoints -= this.Armor;
                this.Armor = 0;
                this.Health -= hitpoints;
                this.IsAlive = this.Health > 0;
            }
        }

        public void Rest()
        {
            Validate.CharacterAlive(this);
            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            Validate.CharacterAlive(this);
            Validate.CharacterAlive(character);

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            Validate.CharacterAlive(this);
            Validate.CharacterAlive(character);
            character.ReceiveItem(item);
        }
        public void ReceiveItem(Item item)
        {
            Validate.CharacterAlive(this);
            this.Bag.AddItem(item);
        }


        public void UsePoisonPotion()
        {
            this.Health -= 20;
            this.IsAlive = this.Health > 0;
        }

        public void UseArmorRepairKit()
        {
            this.Armor = this.BaseHealth;
        }

        public void ReceiveHealing(double hitpoints)
        {
            this.Health += hitpoints;
        }

        public override string ToString()
        {
            string status = this.IsAlive ? "Alive" : "Dead";
            return $"{this.Name} - HP: {this.Health}/{this.BaseHealth}, AP: {this.Armor}/{this.BaseArmor}, Status: {status}";
        }
    }
}