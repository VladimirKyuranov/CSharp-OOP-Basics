public interface IVehicle : IDriveable, IRefuelable
{
	double FuelQuantity { get; }
	double FuelConsumption { get; }
	double DistanceTravelled { get; }
}