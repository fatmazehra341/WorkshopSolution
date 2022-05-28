using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopProblemStatement
{
    public class LeapYears
    {
        public void leapYears()
        {
            Console.WriteLine("Enter a year for checking a leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 || year % 100! == 0) || year % 400 == 0)
            {
                Console.WriteLine("Given year is a leap year ");
            }
            else
            {
                Console.WriteLine("Given year is not a leap year");
            }
        }
    }
}
