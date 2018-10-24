using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        private List<Pokemon> pokemons;

        public string Name { get; }
       
        public int BadgesCount { get; private set; }

        public IReadOnlyCollection<Pokemon> Pokemons => this.pokemons.AsReadOnly();

        public Trainer()
        {
            this.BadgesCount = 0;
            pokemons = new List<Pokemon>();
        }

        public Trainer(string name, Pokemon pokemon)
            : this()
        {
            this.Name = name;
            this.pokemons.Add(pokemon);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddBadge()
        {
            this.BadgesCount++;
        }

        public void TakeDamage()
        {
            this.pokemons.ForEach(p => p.ReduceHealth());
            this.pokemons.RemoveAll(p => p.Health <= 0);
        }

        public override string ToString()
        {
            return $"{Name} {BadgesCount} {pokemons.Count}";
        }
    }
}