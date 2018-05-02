using System;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int player1Points = 0;
            int player2Points = 0;
            bool gameOver = false;
            //Console.WriteLine("Card at position 0: " + deck.theCards[0].ToString());
            deck.Shuffle();
            //Console.WriteLine("Deck has been shuffled. Card at position 0: " + deck.theCards[0].ToString());




            while (!gameOver)
            {
                int warPoints = 0;

                Card player1card = deck.Draw();
                Console.WriteLine("Player 1: " + player1card.ToString());
                Card player2card = deck.Draw();
                Console.WriteLine("Player 2: " + player2card.ToString());

                Console.ReadLine();

                while (player1card == player2card)
                {
                    Console.WriteLine("War!");

                    if (deck.theCards.Count != 0)
                    {
                        warPoints += 2;
                        player1card = deck.Draw();
                        Console.WriteLine("Player 1: " + player1card.ToString());
                        player2card = deck.Draw();
                        Console.WriteLine("Player 2: " + player2card.ToString());
                    }
                    else
                    {
                        gameOver = true;
                        break;
                    }
                }

                if (player1card > player2card)
                {
                    warPoints += 2;
                    player1Points += warPoints;
                    Console.WriteLine("Player 1 wins the round");
                    Console.WriteLine("Player 1 Points: " + player1Points);
                }
                else if (player2card > player1card)
                {
                    warPoints += 2;
                    player2Points += warPoints;
                    Console.WriteLine("Player 2 wins the round");
                    Console.WriteLine("Player 2 Points: " + player2Points);
                }

                Console.ReadLine();

                if (deck.theCards.Count == 0)
                {
                    gameOver = true;
                }
            }

            Console.WriteLine ("Player 1 Points: " + player1Points);
            Console.WriteLine("Player 2 Points: " + player2Points);

            if (player1Points == player2Points)
            {
                Console.WriteLine("The game is a tie!");
            }
            else if (player1Points > player2Points)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else
            {
                Console.WriteLine("Player 2 Wins!");
            }

            Console.ReadLine();

        }
    }
}
