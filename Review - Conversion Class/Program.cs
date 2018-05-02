using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Conversion conversion = new Conversion();


            while(true)
            {
                Console.WriteLine("This program has multiple functionalities");
                Console.WriteLine("A to convert miles to KM, B to convert inches to CM, C to convert lbs to kg");
                Console.WriteLine("D to convert KM to miles, E to convert CM to inches, F to convert kg to lbs");
                Console.Write("Enter choice: ");
                choice = Console.ReadLine();

                switch (choice.ToUpper())
                {

                    case "A":
                        Console.Write("Please enter the Miles to convert: ");
                        conversion.ConvertMilesToKm();
                        break;
                    case "B":
                        Console.Write("Please enter the inches to convert: ");
                        conversion.ConvertInchesToCm();
                        break;
                    case "C":
                        Console.Write("Please enter lbs to convert: ");
                        conversion.ConvertLbsToKg();
                        break;
                    case "D":
                        Console.Write("Please enter the Km to convert: ");
                        conversion.ConvertKmToMiles();
                        break;
                    case "E":
                        Console.Write("Please enter the Cm to convert: ");
                        conversion.ConvertCmToInches();
                        break;
                    case "F":
                        Console.Write("Please enter the Kg to convert: ");
                        conversion.ConvertKgToLbs();
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
