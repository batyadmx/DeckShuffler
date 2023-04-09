using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShufflerSolution.Cards;
using ShufflerSolution.Decks;

namespace ShufflerSolution.DeckFactories
{
    public class DeckFactory : IDeckFactory
    {
        private readonly List<Card> allCards;

        public DeckFactory()
        {
            var allCards = new List<Card>();
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 13; j++)
                {
                    allCards.Add(new Card((CardType)j, (Suits)i));
                }
            }
            this.allCards = allCards;
        }

        public Deck CreateDeck(string name, DeckType deckType)
        {
            Card[] cards = null;
            switch (deckType)
            {
                case DeckType.Deck52:
                    cards = allCards.ToArray();
                    break;
                case DeckType.Deck36:
                    cards = allCards.Where(c => c.CardType == 0 || (int)c.CardType >= 5).ToArray();
                    break;
                case DeckType.Deck32:
                    cards = allCards.Where(c => c.CardType == 0 || (int)c.CardType >= 6).ToArray();
                    break;
                case DeckType.Deck24:
                    cards = allCards.Where(c => c.CardType == 0 || (int)c.CardType >= 8).ToArray();
                    break;
                default:
                    throw new ArgumentException("Invalid deck type");
            }
            return new Deck(cards, deckType, name);
        }
    }
}
