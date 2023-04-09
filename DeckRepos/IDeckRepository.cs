using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckRepos
{
    public interface IDeckRepository
    {
        Deck Get(string name);
        void Add(Deck deck);
        void Delete(string name);
        void Update(Deck deck);
        string[] GetAllNames();
    }
}
