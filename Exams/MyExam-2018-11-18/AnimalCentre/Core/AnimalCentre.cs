using AnimalCentre.Models;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Factories;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;

namespace AnimalCentre.Core
{
    public class AnimalCentre
    {
        private Hotel hotel;
        private Procedure chip;
        private Procedure dentalCare;
        private Procedure fitness;
        private Procedure nailTrim;
        private Procedure play;
        private Procedure vaccinate;

        public Dictionary<string, List<IAnimal>> AddoptedPets { get; }


        public AnimalCentre()
        {
            this.hotel = new Hotel();
            this.chip = new Chip();
            this.dentalCare = new DentalCare();
            this.fitness = new Fitness();
            this.nailTrim = new NailTrim();
            this.play = new Play();
            this.vaccinate = new Vaccinate();
            this.AddoptedPets = new Dictionary<string, List<IAnimal>>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(type, name, energy, happiness, procedureTime);
            hotel.Accommodate(animal);

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.chip.DoService(animal, procedureTime);
            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.vaccinate.DoService(animal, procedureTime);
            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.fitness.DoService(animal, procedureTime);
            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.play.DoService(animal, procedureTime);
            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.dentalCare.DoService(animal, procedureTime);
            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            IAnimal animal = this.GetAnimal(name);
            this.nailTrim.DoService(animal, procedureTime);
            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            IAnimal animal = this.GetAnimal(animalName);

            this.hotel.Adopt(animalName, owner);

            if (!this.AddoptedPets.ContainsKey(owner))
            {
                this.AddoptedPets.Add(owner, new List<IAnimal>());
            }

            this.AddoptedPets[owner].Add(animal);

            if (animal.IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }
            else
            {
                return $"{owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            switch (type)
            {
                case "Chip":
                    return chip.History();
                case "DentalCare":
                    return dentalCare.History();
                case "Fitness":
                    return fitness.History();
                case "NailTrim":
                    return nailTrim.History();
                case "Play":
                    return play.History();
                case "Vaccinate":
                    return vaccinate.History();
                default:
                    throw new ArgumentException("Invalid Procedure Type");
            }
        }

        public IAnimal GetAnimal(string animalName)
        {
            if (!this.hotel.Animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            return this.hotel.Animals[animalName];
        }

    }
}
