using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.DomainObjects;

namespace DeckOfCards.BusinessLogic
{
    public static class CardLogic
    {
        public static Deck ShuffleDeck(Deck deckToShuffle)
        {
            //Using the Knuth-Fisher-Yates Shuffle

            //converting list to array for this, code is easier to read and is more efficient
            var cardsToShuffle = deckToShuffle.Cards.ToArray();

            //Random() isn't the most robust random number generator so if extreme unpredictabilty was required we'd want to use something else
            var randomSource = new Random(DateTime.Now.Millisecond);
            int count = cardsToShuffle.Count();
            while (count > 1)
            {
                int randomDraw = randomSource.Next(count);
                Card shuffledCard = cardsToShuffle[randomDraw];
                cardsToShuffle[randomDraw] = cardsToShuffle[count - 1];
                cardsToShuffle[count - 1] = shuffledCard;

                count--;
            }

            return new Deck { Cards = cardsToShuffle.ToList<Card>() };
        }

        public static Deck SortDeck(Deck deckToSort)
        {
            return new Deck { Cards = deckToSort.Cards.OrderBy(c => c.CardSuit).ThenBy(c => c.CardRank).ToList() };
        }

        public static void DeckPrinter(Deck deckToPrint)
        {
            foreach (var card in deckToPrint.Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public static Deck GenerateSortedDeck()
        {
            var deckToReturn = new Deck();

            //to iterate over an enum you have to project the values into an array
            var ranks = (Rank[])Enum.GetValues(typeof(Rank));
            var suits = (Suit[])Enum.GetValues(typeof(Suit));

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deckToReturn.AddCard(new Card(rank, suit));
                }
            }

            return deckToReturn;
        }
    }
}
