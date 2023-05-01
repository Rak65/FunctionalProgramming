using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Harmonic value N : ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The "+n+"th Harmonic value = "+HarmonicNumber.Harmonic(n));
            Console .ReadKey();
        }
    }
}
