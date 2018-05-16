using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    enum Rank { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
    enum Suit { Hearts = 1, Diamonds, Clubs, Spades };

    class Card
    {
        Rank rank;
        Suit suit;

        public Card()
        {
            rank = Rank.Ace;
            suit = Suit.Spades;
        }

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }


        public static bool operator <(Card theCard1, Card theCard2)
        {
            if (theCard1.rank < theCard2.rank)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >(Card theCard1, Card theCard2)
        {
            if (theCard1.rank > theCard2.rank)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(Card theCard1, Card theCard2)
        {
            if (theCard1.rank == theCard2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Card theCard1, Card theCard2)
        {
            if (theCard1.rank != theCard2.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GreaterThan (Card card)
        {
            if (this.rank > card.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEqual(Card card)
        {
            if (this.rank == card.rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string text = "";

            switch(this.rank)
            {
                case Rank.Ace: text = "Ace";                        
                        break;
                case Rank.Two:
                    text = "Two";
                    break;
                case Rank.Three:
                    text = "Three";
                    break;
                case Rank.Four:
                    text = "Four";
                    break;
                case Rank.Five:
                    text = "Five";
                    break;
                case Rank.Six:
                    text = "Six";
                    break;
                case Rank.Seven:
                    text = "Seven";
                    break;
                case Rank.Eight:
                    text = "Eight";
                    break;
                case Rank.Nine:
                    text = "Nine";
                    break;
                case Rank.Ten:
                    text = "Ten";
                    break;
                case Rank.Jack:
                    text = "Jack";
                    break;
                case Rank.Queen:
                    text = "Queen";
                    break;
                case Rank.King:
                    text = "King";
                    break;
                default: break;
            }

            switch (this.suit)
            {
                case Suit.Hearts: text += " of Hearts";
                        break;
                case Suit.Diamonds:
                    text += " of Diamonds";
                    break;
                case Suit.Clubs:
                    text += " of Clubs";
                    break;
                case Suit.Spades:
                    text += " of Spades";
                    break;
            }

            return text;
        }

    }
}
