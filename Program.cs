using System;
using System.Globalization;

Console.WriteLine("******************************* Today's Date *******************************");
Console.WriteLine();

DateTime dt = DateTime.Now;

// Formatting Console Output - using the curly-bracket syntax
Console.WriteLine("Today's Date is {0}", dt.ToString("dddd MMMMM dd, yyyy"));
Console.WriteLine("Time zone: {0}", TimeZoneInfo.Local);
Console.WriteLine("Day Number of Year: {0}", dt.DayOfYear);
Console.WriteLine("Week Number of Year: {0}", new CultureInfo("en-US").Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday));
Console.WriteLine("Month Number of Year: {0}", dt.Month);
Console.WriteLine("Leap Year: {0} - Next is {1}", DateTime.IsLeapYear(dt.Year) ? "Yes" : "No", GetNextLeapYear(dt.Year + 1));

Console.ReadLine();

int GetNextLeapYear(int year)
{
    if (!DateTime.IsLeapYear(year))
    {
        return GetNextLeapYear(year + 1);
    }

    return year;
}