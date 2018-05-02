using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates a baseball player's batting average");
            Console.Write("Enter Player Name: ");

            string strPlayerName = Console.ReadLine();

            Console.Write("Enter Player 2: ");

            string player2 = Console.ReadLine();

            if ((strPlayerName == "Vernon" || player2 == "Vernon") || 
                (strPlayerName == "Matt" || player2 == "Matt"))
            {
                Console.WriteLine("Nah bro, give someone else");
                strPlayerName = Console.ReadLine();
            }
            else if (strPlayerName == "Nader")
            {
                Console.WriteLine("Yeah he's a cool guy");
            }
            else
                Console.WriteLine("Thanks for not giving me Vern");

            Console.Write("Enter of Hits: ");
            double nHits = Int32.Parse(Console.ReadLine());
                     
            Console.Write("Enter Number of Bats: ");
            double nAtBats =  Int32.Parse(Console.ReadLine());

            double dblBattingAverage = nHits / nAtBats;

            Console.WriteLine();
            Console.WriteLine(strPlayerName);
            Console.WriteLine(nHits + " hits, " + nAtBats + " bats" );
            Console.WriteLine("Batting Average: " + dblBattingAverage);
            Console.Read();
        }
    }
}
