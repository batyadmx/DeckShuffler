using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckFactories
{
    public interface IDeckFactory
    {
        Deck CreateDeck(string name, DeckType deckType);
    }
}
