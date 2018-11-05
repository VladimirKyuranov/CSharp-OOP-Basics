using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Core
{
    public static class Validate
    {
        public static void AddItem(int load, int capacity, int weight)
        {
            if (load + weight > capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
        }

        public static Item GetItem(List<Item> items, string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            Item item = items.FirstOrDefault(i => i.GetType().Name == name);

            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            return item;
        }

        public static void CharacterAlive(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public static void AttackSelf(string attackerName, string defenderName)
        {
            if (attackerName == defenderName)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
        } 

        public static void AttackSameFaction(Faction attackerFaction, Faction defenderFaction)
        {
            if (attackerFaction == defenderFaction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {attackerFaction} faction!");
            }
        }

        public static void HealEnemy(Faction attackerFaction, Faction defenderFaction)
        {
            if (attackerFaction != defenderFaction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }
        }

        public static Character CharacterInParty(string characterName, List<Character> party)
        {
            Character character = party.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            return character;
        }

        public static void EmptyPool(Stack<Item> pool)
        {
            if (pool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
        }
    }
}
