using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class Fibanocci
    {
        public static void fibanocci()
        {
            int number, n1 = 0, n2 = 1;
            Console.WriteLine("Enter a number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 +" "+ n2);
            for(int i = 2; i < number; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
        }
    }
}
