using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.DomainObjects;

namespace DeckOfCards.BusinessLogic
{
    public static class InputLogic
    {
        public const string shuffleInputValue = "SHUFFLE";
        public const string sortInputValue = "SORT";

        public static bool IsInputValid(string input)
        {
            if (input.ToUpper().Equals(shuffleInputValue) || input.ToUpper().Equals(sortInputValue)) return true;
            else return false;
        }

        public static Deck Execute(string input, Deck deckToProcess)
        {
            if (input.ToUpper().Equals(shuffleInputValue))
                return CardLogic.ShuffleDeck(deckToProcess);
            if (input.ToUpper().Equals(sortInputValue))
                return CardLogic.SortDeck(deckToProcess);
            else
                return new Deck();
        }

        public static Deck RetrieveDeckToProcess(string input)
        {
            if (input.ToUpper().Equals(sortInputValue))
                return CardLogic.ShuffleDeck(CardLogic.GenerateSortedDeck());
            if (input.ToUpper().Equals(shuffleInputValue))
                return CardLogic.GenerateSortedDeck();
            else
                return new Deck();
        }
    }
}
