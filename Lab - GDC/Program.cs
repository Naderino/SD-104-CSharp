using System;

namespace GDC_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;


            Console.Write("Please enter an integer to divide: ");
            while(Int32.TryParse(Console.ReadLine(),out number1) == false)
            {
                Console.Write("This is not an integer. Give me an integer: ");
            }
            Console.Write("Please enter a second integer to divide: ");
            while (Int32.TryParse(Console.ReadLine(), out number2) == false)
            {
                Console.Write("This is not an integer. Give me an integer: ");
            }

            if (number1 >= number2)
            {
                while (number1 % number2 != 0)
                {
                    int remainder = number1 % number2;
                    number1 = number2;
                    number2 = remainder;
                }
                Console.WriteLine(number2 + " is the GCD");
            }
            else if (number2 >= number1)
            {
                while ( number2 % number1 != 0)
                {
                    int remainder = number2 % number1;
                    number2 = number1;
                    number1 = remainder;
                }
                Console.WriteLine(number1 + " is the GCD");
            }


            Console.ReadLine();
        }
    }
}
