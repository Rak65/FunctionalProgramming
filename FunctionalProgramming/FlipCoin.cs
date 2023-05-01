using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public static void HeadTail()
        {
            int countHead = 0;
            int countTail = 0;
            Console.WriteLine("How many times you want to flip the coin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)            //check n is positive number or not
            {
                Console.WriteLine("Invalid times---Enter no should be greater than zero");
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Random random = new Random();
                    int ran = random.Next(2);
                    Console.WriteLine(ran);
                    if (ran <0.5)
                    {
                        countTail++;
                    }
                    else
                    {
                        countHead++;
                    }
                }
                float headPerc = (100F / n) * countHead;          //calculate head percentage
                float tailPerc= (100F / n) * countTail;           //calculate tail percentage
                Console.WriteLine("Head Percentage = " + headPerc + " %");  
                Console.WriteLine("Tail Percentage = " + tailPerc + " %");  
                Console.ReadKey();
            }
        }
    }
}
