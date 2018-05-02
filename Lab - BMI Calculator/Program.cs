using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            Console.Write("Please enter your weight your in pounds: ");
            weight = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter your height in inches: ");
            height = Int32.Parse(Console.ReadLine());

            double BMI = (weight * 703) / ((height * height));

            //write your if statements here

            if (BMI < 18.5)
            {
                //BMI < 18.5   - Underweight
                Console.WriteLine("Dang son. You skinny. Your BMI is: " + BMI);
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You fine dawg. Your BMI is: " + BMI);
            }
            else if ((BMI >= 25) && (BMI < 30))
            {
                Console.WriteLine("You're a little overweight. Your BMI is: " + BMI);
            }
            else if (BMI >= 30)
            {
                Console.WriteLine("Dude... Lose some weight. Your BMI is: " + BMI);
            }

            Console.Read();
        }
    }
}
