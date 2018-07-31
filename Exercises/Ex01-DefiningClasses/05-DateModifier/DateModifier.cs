using System;
using System.Globalization;

public class DateModifier
{

    public int GetDaysBetweenDates(string dateOne, string dateTwo)
    {
        DateTime firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime secondtDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((firstDate.Date - secondtDate.Date).Days);
    }
}