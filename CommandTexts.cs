using ShufflerSolution.Decks;
using ShufflerSolution.DeckShufflers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflerSolution
{
    public static class CommandTexts
    {
        public static string PrintDeckName => "Print deck name: ";
        public static string PrintDeckType { 
            get {
                
                return "Print deck type\n" + BuildStringFromEnum(typeof(DeckType));
            } }
        public static string InvalidCommand => "Invalid command. TryAgain";
        public static string PrintShuffleType { 
            get {
                return "Print shuffle method\n" + BuildStringFromEnum(typeof(ShuffleMethodsEnum)); 
            } }

        private static string BuildStringFromEnum(Type enumType)
        {
            var values = Enum.GetValues(enumType);
            var sbuilder = new StringBuilder();
            foreach (var v in values)
                sbuilder.AppendLine($"  {(int)v} - {v}");
            return sbuilder.ToString();
        } 
    }
}
