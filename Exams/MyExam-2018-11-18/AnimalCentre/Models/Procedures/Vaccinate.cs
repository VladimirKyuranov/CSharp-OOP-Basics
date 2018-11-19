using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Vaccinate : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            animal.CheckProcedureTime(procedureTime);

            animal.Energy -= 8;
            animal.IsVaccinated = true;

            animal.ProcedureTime -= procedureTime;

            this.procedureHistory.Add(animal);
        }
    }
}
