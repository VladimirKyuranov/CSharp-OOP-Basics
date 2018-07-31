using System;
using System.Collections.Generic;
using System.Text;

public class Reservation
{
    public decimal PricePerNigth { get; set; }
    public int NightsCount { get; set; }
    public string Season { get; set; }
    public string DiscountType { get; set; }

    public Reservation(string reservation)
    {
        string[] reservationInfo = reservation.Split();

        PricePerNigth = decimal.Parse(reservationInfo[0]);
        NightsCount = int.Parse(reservationInfo[1]);
        Season = reservationInfo[2];
        DiscountType = "None";

        if (reservationInfo.Length > 3)
        {
            DiscountType = reservationInfo[3];
        }
    }
}
