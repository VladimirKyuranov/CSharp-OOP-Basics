using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badgesCount;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int BadgesCount
        {
            get { return badgesCount; }
            set { badgesCount = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public Trainer()
        {
            badgesCount = 0;
            pokemons = new List<Pokemon>();
        }

        public Trainer(string name, Pokemon pokemon)
            : this()
        {
            this.name = name;
            this.pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            return $"{name} {badgesCount} {pokemons.Count}";
        }
    }
}