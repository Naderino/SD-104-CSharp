using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Deck
    {
        public List<Card> theCards;

        //creates a deck of 52 unique cards
        public Deck()
        {
            theCards = new List<Card>();
            for(Suit suit = Suit.Hearts; suit <= Suit.Spades; suit++)
            {
                for (Rank rank = Rank.Ace; rank <= Rank.King; rank++)
                {
                    Card card = new Card(rank, suit);
                    theCards.Add(card);
                }
            }
        }

        // shuffles the deck randomly
        public void Shuffle()
        {
            for (int n = 0; n < theCards.Count; n++)
            {
                Random random = new Random();
                int randomPosition = random.Next(theCards.Count - 1);
                Card tempCard = theCards[n];
                theCards[n] = theCards[randomPosition];
                theCards[randomPosition] = tempCard;
            }
        }

        // Draws a card and reduces the size of the deck
        public Card Draw()
        {
            Card card = theCards[theCards.Count - 1];
            theCards.RemoveAt(theCards.Count - 1);
            return card;
        }
    }
}
