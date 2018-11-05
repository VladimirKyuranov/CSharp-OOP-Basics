using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Factories;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> party;
        private Stack<Item> itemPool;
        private int lastSurvivorRounds;
        private CharacterFactory characterFactory = new CharacterFactory();
        private ItemFactory ItemFactory = new ItemFactory();

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.itemPool = new Stack<Item>();
            this.lastSurvivorRounds = 0;
        }
        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];
            Character character = characterFactory.CreateCharacter(faction, characterType, name);
            this.party.Add(character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];
            Item item = ItemFactory.CreateItem(itemName);
            this.itemPool.Push(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            Character character = Validate.CharacterInParty(characterName, this.party);
            Validate.EmptyPool(this.itemPool);
            Item item = this.itemPool.Pop();
            character.ReceiveItem(item);

            return $"{characterName} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];
            Character character = Validate.CharacterInParty(characterName, this.party);
            Item item = character.Bag.GetItem(itemName);
            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];
            Character giver = Validate.CharacterInParty(giverName, this.party);
            Character receiver = Validate.CharacterInParty(receiverName, this.party);
            Item item = giver.Bag.GetItem(itemName);
            giver.UseItemOn(item, receiver);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];
            Character giver = Validate.CharacterInParty(giverName, this.party);
            Character receiver = Validate.CharacterInParty(receiverName, this.party);
            Item item = giver.Bag.GetItem(itemName);
            giver.GiveCharacterItem(item, receiver);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder stats = new StringBuilder();

            foreach (var character in this.party
                .OrderByDescending(c => c.IsAlive)
                .ThenByDescending(c => c.Health))
            {
                stats.AppendLine(character.ToString());
            }

            return stats.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string defenderName = args[1];
            Character attacker = Validate.CharacterInParty(attackerName, this.party);

            if (attacker is Warrior warrior)
            {
                Character defender = Validate.CharacterInParty(defenderName, this.party);
                StringBuilder result = new StringBuilder();
                warrior.Attack(defender);

                result.AppendLine($"{attackerName} attacks {defenderName} for {attacker.AbilityPoints} hit points! {defenderName} has {defender.Health}/{defender.BaseHealth} HP and {defender.Armor}/{defender.BaseArmor} AP left!");

                if (!defender.IsAlive)
                {
                    result.AppendLine($"{defender.Name} is dead!");
                }

                return result.ToString().TrimEnd();
            }
            else
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }
            
        }

        public string Heal(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string healerName = args[0];
            string healedName = args[1];
            Character healer = Validate.CharacterInParty(healerName, this.party);

            if (healer is Cleric cleric)
            {
                Character healed = Validate.CharacterInParty(healedName, this.party);
                cleric.Heal(healed);

                result.AppendLine($"{healer.Name} heals {healed.Name} for {healer.AbilityPoints}! {healed.Name} has {healed.Health} health now!");

                return result.ToString().TrimEnd();
            }
            else
            {
                throw new ArgumentException($"{healer.Name} cannot heal!");
            }
        }

        public string EndTurn(string[] args)
        {
            StringBuilder result = new StringBuilder();
            List<Character> aliveParty = this.party
                .Where(c => c.IsAlive)
                .ToList();

            foreach (var character in aliveParty)
            {
                double healthBefore = character.Health;
                character.Rest();
                result.AppendLine($"{character.Name} rests ({healthBefore} => {character.Health})");
            }

            if (aliveParty.Count < 2)
            {
                this.lastSurvivorRounds++;
            }

            return result.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            return this.lastSurvivorRounds > 1;
        }

        public string GameOver()
        {
            StringBuilder finalStats = new StringBuilder();

            finalStats.AppendLine("Final stats:")
                .AppendLine(GetStats());

            return finalStats.ToString().TrimEnd();
        }
    }
}