using System;

namespace Lab___Largest_and_Smallest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestNumber;
            int smallestNumber;
            int currentNumber;

            Console.Write("Please enter a number (0 to quit) : ");
            currentNumber = Int32.Parse(Console.ReadLine());

            smallestNumber = currentNumber;
            largestNumber = currentNumber;

            while ( currentNumber != 0 )
            {
                if (currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                }


                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
                Console.Write("Please enter another number(0 to quit): ");
                currentNumber = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your smallest number is: " + smallestNumber);
            Console.WriteLine("Your largest number is: " + largestNumber);
            Console.ReadLine();
        }
    }
}
