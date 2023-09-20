using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class PalindromeNumber
    {
        public static void palindrome()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }

            if (originalNum == reversedNum)
                Console.WriteLine(originalNum + " is a palindrome number.");
            else
                Console.WriteLine(originalNum + " is not a palindrome number.");
        }
    }
}
