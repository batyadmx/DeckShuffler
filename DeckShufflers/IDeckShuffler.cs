using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckShufflers
{
    public interface IDeckShuffler
    {
        void CreateDeck(string name, DeckType deckType);
        Deck GetDeck(string name);
        string[] GetAllNames();
        Deck ShuffleDeck(string name, ShuffleMethodsEnum method);
        void DeleteDeck(string name);
    }
}
