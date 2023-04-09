using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.Cards
{
    /*public class Card
    {
        public CardType CardType { get; }
        public Suits Suit { get; }

        public Card(CardType cardType, Suits suit) 
        {
            CardType = cardType;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{CardType} of {Suit}";
        }
    }*/

    public record Card(CardType CardType, Suits Suit);
}
