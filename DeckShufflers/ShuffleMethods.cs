using ShufflerSolution.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution.DeckShufflers
{
    public enum ShuffleMethodsEnum        
    {
        SimpleShuffle
    }

    public static class ShuffleMethods
    {

        public static void Shuffle(Deck deck, ShuffleMethodsEnum method)
        {
            switch (method)
            {
                case ShuffleMethodsEnum.SimpleShuffle:
                    SimpleShuffle(deck);
                    break;
            }
        }

        public static void SimpleShuffle(Deck deck)
        {
            var cards = deck.Cards;
            var rnd = new Random();
            for (var j = 0; j < 5; j++)
            {
                for (var i = 0; i < cards.Length; i++)
                {
                    var pos = rnd.Next(0, cards.Length);
                    var tmp = cards[pos];
                    cards[pos] = cards[i];
                    cards[i] = tmp;
                }
            }
        }
    }
}
