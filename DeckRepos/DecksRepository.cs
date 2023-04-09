using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckRepos
{
    public class DecksRepository : IDeckRepository
    {
        private Dictionary<string, Deck> decks;

        public DecksRepository()
        {
            decks = new Dictionary<string, Deck>();
        }

        public void Add(Deck deck)
        {
            if (decks.ContainsKey(deck.Name))
                throw new Exception($"The deck named {deck.Name} already exists");
            decks.Add(deck.Name, deck);
        }

        public void Delete(string name)
        {
            if (!decks.ContainsKey(name))
                throw new Exception($"The deck named {name} is not found");
            decks.Remove(name);
        }

        public string[] GetAllNames()
        {
            return decks.Select(kv => kv.Key).ToArray();
        }

        public Deck Get(string name)
        {
            if (!decks.ContainsKey(name))
                throw new Exception($"The deck named {name} is not found");
            return decks[name].Clone();
        }

        public void Update(Deck deck)
        {
            if (!decks.ContainsKey(deck.Name))
                throw new Exception($"The deck named {deck.Name} is not found");
            decks[deck.Name] = deck;
        }
    }
}
