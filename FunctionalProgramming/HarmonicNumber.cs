using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class HarmonicNumber
    {
        public static double Harmonic(int n)
        {
            double  sum = 0D;
            for(int i = 1; i <= n; i++) 
            {
                sum=sum+1D/i;
            }
            return sum;
        }
    }
}
