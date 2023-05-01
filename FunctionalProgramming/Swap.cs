using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Swap
    {
        public static void SwapingTwoNo()
        {
            Console.WriteLine("Enter first number : ");
            int firstNum=Convert.ToInt32(Console.ReadLine());    //take first input from user
            Console.WriteLine("Enter Second number : ");
            int secondNum=Convert.ToInt32(Console.ReadLine());   //take second input from user

            //Swapping both number
            firstNum = firstNum * secondNum;
            secondNum = firstNum/secondNum;
            firstNum= firstNum/secondNum;

            Console.WriteLine("After Swapping, First Number is " + firstNum);    
            Console.WriteLine("After Swapping, Second Number is " + secondNum );
        }
    }
}
