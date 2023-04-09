using ShufflerSolution.DeckFactories;
using ShufflerSolution.DeckRepos;
using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckShufflers
{
    public class DeckShuffler : IDeckShuffler
    {
        private IDeckFactory deckFactory;
        private IDeckRepository deckRepository;

        public DeckShuffler(IDeckFactory deckFactory, IDeckRepository deckRepository)
        {
            this.deckFactory = deckFactory;
            this.deckRepository = deckRepository;
        }

        public void CreateDeck(string name, DeckType deckType)
        {
            var deck = deckFactory.CreateDeck(name, deckType);
            deckRepository.Add(deck);
        }

        public void DeleteDeck(string name)
        {
            deckRepository.Delete(name);
        }

        public string[] GetAllNames()
        {
            return deckRepository.GetAllNames();
        }

        public Deck GetDeck(string name)
        {
            return deckRepository.Get(name);
        }

        public Deck ShuffleDeck(string name, ShuffleMethodsEnum method)
        {
            var deck = deckRepository.Get(name);
            ShuffleMethods.Shuffle(deck, method);
            deckRepository.Update(deck);
            return deck;
        }
    }
}
