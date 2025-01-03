using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02
{
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31) 
                Console.WriteLine("Day must be between 1 and 31.");
            if (month < 1 || month > 12)
                Console.WriteLine("Month must be between 1 and 12.");
            if (year < 1900 || year > DateTime.Now.Year)
                Console.WriteLine("Year must be reasonable.");

            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return string.Format("{0:D2}/{1:D2}/{2}", Day, Month, Year);
        }
    }
}
