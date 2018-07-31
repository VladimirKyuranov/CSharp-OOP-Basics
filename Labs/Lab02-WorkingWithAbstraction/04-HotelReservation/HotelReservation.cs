using System;

class HotelReservation
{
    static void Main(string[] args)
    {
        Reservation reservation = new Reservation(Console.ReadLine());
        decimal totalPrice = PriceCalculator.CalculatePrice(reservation);
        Console.WriteLine($"{totalPrice:F2}");
    }
}