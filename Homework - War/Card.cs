using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Card
    {
        int rank;
        int suit;

        public Card()
        {
            rank = 1;
            suit = 4;
        }

        public Card(int rank, int suit)
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
                case 1: text = "Ace";                        
                        break;
                case 2:
                    text = "Two";
                    break;
                case 3:
                    text = "Three";
                    break;
                case 4:
                    text = "Four";
                    break;
                case 5:
                    text = "Five";
                    break;
                case 6:
                    text = "Six";
                    break;
                case 7:
                    text = "Seven";
                    break;
                case 8:
                    text = "Eight";
                    break;
                case 9:
                    text = "Nine";
                    break;
                case 10:
                    text = "Ten";
                    break;
                case 11:
                    text = "Jack";
                    break;
                case 12:
                    text = "Queen";
                    break;
                case 13:
                    text = "King";
                    break;
                default: break;
            }

            switch (this.suit)
            {
                case 1: text += " of Hearts";
                        break;
                case 2:
                    text += " of Diamonds";
                    break;
                case 3:
                    text += " of Clubs";
                    break;
                case 4:
                    text += " of Spades";
                    break;
            }

            return text;
        }

    }
}
