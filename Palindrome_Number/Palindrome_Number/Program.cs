using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    public class PalindromeExample
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Number is Palindrome. ");
            }
            
            else
            {
                Console.WriteLine("Number is not Palindrome. ");
            }


        }
    }
}
