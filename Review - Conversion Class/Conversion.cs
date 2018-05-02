using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Conversion
    {
        double number;

        public Conversion ()
        {
            number = 0;
        }

        public void getUserInput()
        {
            number = Int32.Parse(Console.ReadLine());
        }

        public void ConvertMilesToKm ()
        {
            getUserInput();
            Console.WriteLine(number + " miles to KM =  " + (1.6 * number) + " KM");
        }

        public void ConvertKmToMiles()
        {
            getUserInput();
            Console.WriteLine(number + " KM to Miles =  " + (0.62137119 * number) + " miles");
        }

        public void ConvertInchesToCm()
        {
            getUserInput();
            Console.WriteLine(number + " inches to cm =  " + (2.54 * number) + " cm");
        }

        public void ConvertCmToInches()
        {
            getUserInput();
            Console.WriteLine(number + " cm to inches  =  " + (0.39 * number) + " inches");
        }

        public void ConvertKgToLbs()
        {
            getUserInput();
            Console.WriteLine(number + " Kg to Lbs =  " + (0.45359237 * number) + " Lbs");
        }

        public void ConvertLbsToKg()
        {
            getUserInput();
            Console.WriteLine(number + " Lbs to Kg =  " + (2.2 * number) + " Kg");
        }
    }
}
