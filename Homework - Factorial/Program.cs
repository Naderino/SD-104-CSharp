
using System;
using System.Collections.Generic;

namespace HW3___Factorial_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Factorial();
                Console.ReadLine();
                Factorial(5);
            }
                   
        }

        public static void Factorial(int number = 0)
        {
            int result = 1;

            if(number == 0)
                result = 0;

            for (int i = number; i > 0; i--)
            {
                if (i != number)
                {
                    Console.Write(" x ");
                }
                Console.Write(i);
                result *= i;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
