using System;
class WhatDay1 {
    static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    enum MonthName {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    static void Main() {
        Console.Write("Please enter a day number between 1 and 365: ");
        string line = Console.ReadLine();
        int dayNum = int.Parse(line);

        int monthNum = 0;

        foreach(int daysInMonth in DaysInMonths) {
            if(dayNum <= daysInMonth) {
                break;
            } else {
                dayNum -= daysInMonth;
                monthNum++;
            }
        }
        MonthName temp = (MonthName)monthNum;
        string monthName = temp.ToString();

        Console.WriteLine("{0} {1}", dayNum, monthName);
        Console.ReadKey();
    }
}
