using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the number : ");
            int num=Convert.ToInt32(Console.ReadLine());    //take input from user

            //check the condition for Enven or Odd
            if (num %2 == 0)         
            {
                Console.WriteLine(num + " is Even number.");
            }
            else
            {
                Console.WriteLine(num + " is Odd number.");
            }
        }
    }
}
