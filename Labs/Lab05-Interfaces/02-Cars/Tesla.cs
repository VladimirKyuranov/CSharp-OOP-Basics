using System;
using System.Collections.Generic;
using System.Text;

public class Tesla : Seat, IElectricCar
{
    public int Battery { get; private set; }

    public Tesla(string model, string color, int battery)
        : base(model, color)
    {
        Battery = Battery;
    }
}