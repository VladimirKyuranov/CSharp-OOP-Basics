﻿using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Play : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            animal.CheckProcedureTime(procedureTime);

            animal.Energy -= 6;
            animal.Happiness += 12;

            animal.ProcedureTime -= procedureTime;

            this.procedureHistory.Add(animal);
        }
    }
}
