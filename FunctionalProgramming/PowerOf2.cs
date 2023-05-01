using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PowerOf2
    {
        public static void Pow() 
        {
            Console.WriteLine("Enter the Power : ");
            int power=Convert.ToInt32(Console.ReadLine()); //take input from the user
            if (power < 0 || power > 31)
            {
                Console.WriteLine("Invalid, Enter again---Power should be between 0 and 31");
            }
            else
            {
                Console .WriteLine ( Math.Pow (2, power));
            }
        }
    }
}
