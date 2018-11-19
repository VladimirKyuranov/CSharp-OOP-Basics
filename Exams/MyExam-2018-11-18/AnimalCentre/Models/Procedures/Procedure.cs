using AnimalCentre.Models.Contracts;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        public Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        protected List<IAnimal> procedureHistory;
        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");

            this.procedureHistory
                .ForEach(a => sb.AppendLine(a.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
