using System;

namespace Find_the_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program is going to take user input - Number of numbers he is going to write
            //Program is going to validate user input and make sure it's a number
            //Program is going to loop and have the user write a number up to the (size / number of numbers)
            //Program is gonna find the max number and the minimum number in the array.
            //Program will output this to the user.

            // hint #1
            //int min;
            //int max;

            //hint #2 -- DO NOT DO THIS IN THE LOOP
            // min and your max is going to start as the first value in your array. So array[0]

            //hint#3
            //min means array[position] < min
            //max means array[position] > max

            Console.Write("Please enter how many numbers you want in your array: ");
            int input;

            // Validating the size of the array
            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number. Please enter a number: ");
            }

            // Setting the size of the array through the number the user input
            int[] userArray = new int[input];

            // Creating the array through user input
            for (int count = 0; count < userArray.Length; count++)
            {
                Console.Write("Please enter the value for number " + (count + 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.Write("Not a number. Please enter a number: ");
                }
                userArray[count] = input;
            }

            int min = userArray[0];
            int max = userArray[0];


            for (int count = 0; count < userArray.Length; count++)
            {
                if (userArray[count] < min)
                    min = userArray[count];

                if (userArray[count] > max)
                    max = userArray[count];
            }

            Console.WriteLine("Your minimum number is: " + min);
            Console.WriteLine("Your maximum number is: " + max);

            Console.Read();

        }
    }
}
