using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PrimeFactors
    {
        public static void Factors()
        {
            Console.WriteLine("Enter the number : ");
            int num =Convert.ToInt32(Console.ReadLine());  //take input from the user

            //Find the prime factor
            for (int i = 2; i*i <= num; i++) 
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if(num > 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
