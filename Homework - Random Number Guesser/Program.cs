using System;

namespace Modulo_Function
{
    class Program
    {
        static void Main ()
        {
            bool playAgain = true;

            int random = RandomNumber(1, 5);
            int guesses = 0;

            while (playAgain == true)
            {
                int number = InputNumber();
                guesses++;
                if (number > random)
                {
                    Console.WriteLine("Too high");
                }
                else if (number < random)
                {
                    Console.WriteLine("Too low");
                }
                else if (number == random)
                {
                    Console.Write("You win. You made " + guesses + " guess(es). Play again? (Y for yes, N for no): ");
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "Y")
                    {
                        playAgain = true;
                        random = RandomNumber(1, 5);
                        guesses = 0;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
            }
        }

        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private static int InputNumber()
        {
            int input;
            Console.Write("Hey You! Give me a number! ");
            while(Int32.TryParse(Console.ReadLine(),out input) == false)
            {
                Console.WriteLine("Not a number. Give me a number: ");
            }
            return input;
        }

    }
}
