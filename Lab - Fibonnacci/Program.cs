using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.Write("Please enter which index of the fibonacci sequence you want the value for: ");
                int index = Int32.Parse(Console.ReadLine());

                int num1 = 0;
                int num2 = 0;
                int total = 0;

                for (int i = 0; i < index; i++)
                {
                    if (i == 0)
                    {
                        num1 = 0;
                        num2 = 1;
                    }
                    
                    if (i == 1)
                    {
                        num1 = 0;
                        num2 = 1;
                    }

                    total = num1 + num2;
                        num1 = num2;
                        num2 = total;
                }


                Console.WriteLine("The fibonacci at index " + index + " is: " + total);
                Console.ReadLine();

            }

        }
    }
}
