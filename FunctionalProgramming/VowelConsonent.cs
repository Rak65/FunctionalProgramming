using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class VowelConsonent
    {
        public static void CheckAlphabet()
        {
            Console.WriteLine("Enter the character : ");  //take input from the user
            char ch = Convert.ToChar(Console.ReadLine());

            //Condition to check character is vowel or consonent 
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch+" is a vowel.");
            }
            else if((ch >= 'A' && ch <= 'Z')||(ch>='a'&& ch<='z'))
            { 
                Console.WriteLine(ch+" is Consonent."); 
            }
            else
            {
                Console.WriteLine("Enter a valid alphabet ");
            }
        }
    }
}
