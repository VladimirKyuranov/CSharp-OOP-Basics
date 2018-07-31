using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    public static decimal CalculatePrice(Reservation reservation)
    {
        int seasonMultiplier = (int)Enum.Parse(typeof(SeasonMultiplier), reservation.Season);
        decimal discount = (100m - (int)Enum.Parse(typeof(Discount), reservation.DiscountType)) / 100;
        decimal totalPrice = reservation.PricePerNigth * reservation.NightsCount * seasonMultiplier * discount;

        return totalPrice;
    }
}