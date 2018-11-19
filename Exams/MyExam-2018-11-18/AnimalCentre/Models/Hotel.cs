using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;

namespace AnimalCentre.Models
{
    public class Hotel : IHotel
    {
        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
        }

        private const int capacity = 10;

        private Dictionary<string, IAnimal> animals;

        public IReadOnlyDictionary<string, IAnimal> Animals => this.animals;



        public void Accommodate(IAnimal animal)
        {
            if (this.Animals.Count == capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (this.Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.Animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            this.Animals[animalName].Owner = owner;
            this.Animals[animalName].IsAdopt = true;
            this.animals.Remove(animalName);

        }
    }
}
