using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LargestAmongThreeNo
    {
        public static void largestNumber()
        {
            //take three input from the user
            Console.WriteLine("Enter first number : ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number :");
            int num3=Convert.ToInt32(Console.ReadLine());

            //check condition
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("The first number is greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 2nd number is greatest among three.");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is greatest among three.");
            }
            else
            {
                Console.WriteLine("The 3rd number is greatest among three.");
            }
        }
    }
}
