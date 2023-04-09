using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShufflerSolution.Cards;

namespace ShufflerSolution.Decks
{
    public class Deck
    {
        public Card[] Cards { get; set; }
        public DeckType DeckType { get; }
        public string Name { get; }

        public Deck(Card[] cards, DeckType deckType, string name)
        {
            Cards = cards;
            DeckType = deckType;
            Name = name;
        }

        public Deck Clone()
        {
            return new Deck(Cards.Clone() as Card[], DeckType, Name);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (var i = 0; i < Cards.Length; i++)
                builder.Append($"{i + 1}: {Cards[i].Suit} {Cards[i].CardType} \n");
            return builder.ToString();
        }
    }
}
