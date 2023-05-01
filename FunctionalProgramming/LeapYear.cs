using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LeapYear
    {
        public static void LeapYearOrNot()
        {
            Console.WriteLine("Enter the for digit year : ");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year >999 && year <= 9999)         //check year is 4 digit or not
            {
                //Check year is leap year or not
                if((year % 4 == 0 && year % 100 != 0)||year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    Console.WriteLine(year + " is a not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Try again----and Enter 4 digit number");  //if year is not 4 digit display this.
            }
        }
    }
}
