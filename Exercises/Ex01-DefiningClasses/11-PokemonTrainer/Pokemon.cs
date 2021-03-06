﻿namespace DefiningClasses
{
    public class Pokemon
    {
        public string Name { get; }
        
        public string Element { get; }
        
        public int Health { get; private set; }

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public void ReduceHealth()
        {
            this.Health -= 10;
        }
    }
}