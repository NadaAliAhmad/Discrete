using System;
using System.Linq;

namespace Discrete1
{
    public static class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter the starting value");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending value");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between{0}:{1} are", start, end);
            for (int i = start; i <= end; i++)
            {
                int m = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        m++;
                        break;
                    }
                }
                if (m == 0 && i != 1)
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
