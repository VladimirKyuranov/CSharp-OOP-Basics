﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainer>();
            string input, element;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = inputArgs[0];
                string pokemonName = inputArgs[1];
                string pokemonElement = inputArgs[2];
                int pokemonHealth = int.Parse(inputArgs[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName, pokemon);

                if (trainers.ContainsKey(trainer.Name) == false)
                {
                    trainers.Add(trainer.Name, trainer);
                }
                else
                {
                    trainers[trainer.Name].AddPokemon(pokemon);
                }
            }

            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.TakeDamage();
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, 
                trainers.Values
                .OrderByDescending(t => t.BadgesCount)));
        }
    }
}