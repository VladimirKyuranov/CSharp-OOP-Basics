namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        public string FavouriteFood
        {
            get { return favouriteFood; }
            private set { favouriteFood = value; }
        }


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            string result = $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
            return result;
        }
    }
}