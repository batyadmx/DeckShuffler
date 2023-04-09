using System;
using System.Text;
using ShufflerSolution.Cards;
using ShufflerSolution.DeckFactories;
using ShufflerSolution.DeckRepos;
using ShufflerSolution.Decks;
using ShufflerSolution.DeckShufflers;

namespace ShufflerSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckShuffler shuffler = new DeckShuffler(new DeckFactory(), new DecksRepository());
            while (true)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "getAll":
                        var names = shuffler.GetAllNames();
                        var builder = new StringBuilder();
                        foreach (var el in names)
                            builder.Append($"{el} \n");
                        Console.WriteLine(builder.ToString());
                        break;
                    case "get":
                        Console.Write(CommandTexts.PrintDeckName);
                        Console.WriteLine(shuffler.GetDeck(Console.ReadLine()));
                        break;
                    case "create":
                        Console.Write(CommandTexts.PrintDeckName);
                        var name = Console.ReadLine();
                        Console.Write(CommandTexts.PrintDeckType);
                        var type = (DeckType)int.Parse(Console.ReadLine());
                        shuffler.CreateDeck(name, type);
                        break;
                    case "shuffle":
                        Console.Write(CommandTexts.PrintDeckName);
                        name = Console.ReadLine();
                        Console.Write(CommandTexts.PrintShuffleType);
                        shuffler.ShuffleDeck(name, (ShuffleMethodsEnum)int.Parse(Console.ReadLine()));
                        break;
                    case "delete":
                        Console.Write(CommandTexts.PrintDeckName);
                        shuffler.DeleteDeck(Console.ReadLine());
                        break;
                    case "stop":
                        return;                  
                    default:
                        Console.WriteLine(CommandTexts.InvalidCommand);
                        break;
                }
            }
        }
    }
}
