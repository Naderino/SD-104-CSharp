using System;

namespace Lab_5
{
    class Program
    {
        static void Main()
        {

            int nTestScore = 0;
            int nTotalScores = 0;
            double dblRunningTotal = 0;
            Console.Write("Test Score "+ (nTotalScores + 1) + ": Enter a test score or anything less than 0 to exit: ");
            if (Int32.TryParse(Console.ReadLine(), out nTestScore) == true)
            {
                while (nTestScore >= 0)
                {
                    nTotalScores++;
                    dblRunningTotal += nTestScore; // dblRunningTotal = nTestScore + dblRunningTotal

                    Console.Write("Test Score " + (nTotalScores + 1) + ": Enter a test score or anything less than 0 to exit: ");
                    if (Int32.TryParse(Console.ReadLine(), out nTestScore) == false)
                    {
                        Console.WriteLine("This is not an integer. Goodbye. ");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("This is not an integer. Goodbye. ");
            }

            if (nTotalScores > 0)
            {
                Console.WriteLine("The score average is: " + dblRunningTotal / nTotalScores + " for " + nTotalScores + " total test scores");
            }

            Console.WriteLine("Now exiting the program.");
            Console.ReadLine();
        }
    }
}
