using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DeckOfCards.DomainObjects;
using DeckOfCards.BusinessLogic;

namespace DeckOfCards
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void GenerateSortedDeckTest()
        {
            Assert.AreEqual(sortedDeckExample, CardLogic.GenerateSortedDeck());
        }

        //Not a robust test; the proper way to test randomness is running many iterations and using probability to see the distribution. But that's pretty involved for this code sample.
        [Test]
        public void ShuffledDeckTest()
        {
            Assert.AreNotEqual(sortedDeckExample, CardLogic.ShuffleDeck(shuffledDeckExample));
        }

        [Test]
        public void SortAShuffledDeckTest()
        {
            Assert.AreEqual(sortedDeckExample, CardLogic.SortDeck(shuffledDeckExample));
        }

        [Test]
        public void IsInputValidShuffleTrueTest()
        {
            Assert.IsTrue(InputLogic.IsInputValid("shuFfle"));
        }

        [Test]
        public void IsInputValidSortTrueTest()
        {
            Assert.IsTrue(InputLogic.IsInputValid("sOrT"));
        }

        [Test]
        public void IsInputValidFalseTest()
        {
            Assert.IsFalse(InputLogic.IsInputValid("lksfEsdl"));
        }

        [Test]
        public void RetrieveDeckForShufflingTest()
        {
            var returnValue = InputLogic.RetrieveDeckToProcess("shuffle");
            Assert.AreEqual(sortedDeckExample, returnValue);
        }

        [Test]
        public void RetrieveDeckForSortingTest()
        {
            var returnValue = InputLogic.RetrieveDeckToProcess("sort");
            Assert.AreNotEqual(sortedDeckExample, returnValue);
        }

        [Test]
        public void ExecuteSortTest()
        {
            var returnDeck = InputLogic.Execute("sort", shuffledDeckExample);

            Assert.AreNotEqual(shuffledDeckExample, returnDeck);
            Assert.AreEqual(returnDeck, sortedDeckExample);
        }

        [Test]
        public void ExecuteShuffleTest()
        {
            var deck = sortedDeckExample;
            Assert.AreNotEqual(deck, InputLogic.Execute("shuffle", deck));
        }
       
        Deck sortedDeckExample = new Deck { Cards = new List<Card> {
            new Card(Rank.Ace, Suit.Clubs),
            new Card(Rank.Two, Suit.Clubs),
            new Card(Rank.Three, Suit.Clubs),
            new Card(Rank.Four, Suit.Clubs),
            new Card(Rank.Five, Suit.Clubs),
            new Card(Rank.Six, Suit.Clubs),
            new Card(Rank.Seven, Suit.Clubs),
            new Card(Rank.Eight, Suit.Clubs),
            new Card(Rank.Nine, Suit.Clubs),
            new Card(Rank.Ten, Suit.Clubs),
            new Card(Rank.Jack, Suit.Clubs),
            new Card(Rank.Queen, Suit.Clubs),
            new Card(Rank.King, Suit.Clubs),

            new Card(Rank.Ace, Suit.Diamonds),
            new Card(Rank.Two, Suit.Diamonds),
            new Card(Rank.Three, Suit.Diamonds),
            new Card(Rank.Four, Suit.Diamonds),
            new Card(Rank.Five, Suit.Diamonds),
            new Card(Rank.Six, Suit.Diamonds),
            new Card(Rank.Seven, Suit.Diamonds),
            new Card(Rank.Eight, Suit.Diamonds),
            new Card(Rank.Nine, Suit.Diamonds),
            new Card(Rank.Ten, Suit.Diamonds),
            new Card(Rank.Jack, Suit.Diamonds),
            new Card(Rank.Queen, Suit.Diamonds),
            new Card(Rank.King, Suit.Diamonds),

            new Card(Rank.Ace, Suit.Hearts),
            new Card(Rank.Two, Suit.Hearts),
            new Card(Rank.Three, Suit.Hearts),
            new Card(Rank.Four, Suit.Hearts),
            new Card(Rank.Five, Suit.Hearts),
            new Card(Rank.Six, Suit.Hearts),
            new Card(Rank.Seven, Suit.Hearts),
            new Card(Rank.Eight, Suit.Hearts),
            new Card(Rank.Nine, Suit.Hearts),
            new Card(Rank.Ten, Suit.Hearts),
            new Card(Rank.Jack, Suit.Hearts),
            new Card(Rank.Queen, Suit.Hearts),
            new Card(Rank.King, Suit.Hearts),

            new Card(Rank.Ace, Suit.Spades),
            new Card(Rank.Two, Suit.Spades),
            new Card(Rank.Three, Suit.Spades),
            new Card(Rank.Four, Suit.Spades),
            new Card(Rank.Five, Suit.Spades),
            new Card(Rank.Six, Suit.Spades),
            new Card(Rank.Seven, Suit.Spades),
            new Card(Rank.Eight, Suit.Spades),
            new Card(Rank.Nine, Suit.Spades),
            new Card(Rank.Ten, Suit.Spades),
            new Card(Rank.Jack, Suit.Spades),
            new Card(Rank.Queen, Suit.Spades),
            new Card(Rank.King, Suit.Spades)}};


            // I just shuffled this myself
            Deck shuffledDeckExample = new Deck { Cards = new List<Card> {
            new Card(Rank.Five, Suit.Spades),
            new Card(Rank.Three, Suit.Spades),
            new Card(Rank.Three, Suit.Clubs),
            new Card(Rank.Eight, Suit.Spades),
            new Card(Rank.Six, Suit.Clubs),
            new Card(Rank.Eight, Suit.Clubs),
            new Card(Rank.Ten, Suit.Clubs),
            new Card(Rank.Queen, Suit.Clubs),
            new Card(Rank.Jack, Suit.Hearts),
            new Card(Rank.King, Suit.Clubs),
            new Card(Rank.Two, Suit.Diamonds),
            new Card(Rank.Three, Suit.Diamonds),
            new Card(Rank.Four, Suit.Clubs),
            new Card(Rank.Four, Suit.Diamonds),
            new Card(Rank.King, Suit.Spades),
            new Card(Rank.Jack, Suit.Clubs),
            new Card(Rank.Seven, Suit.Hearts),
            new Card(Rank.Five, Suit.Diamonds),
            new Card(Rank.Ace, Suit.Clubs),
            new Card(Rank.Ten, Suit.Spades),
            new Card(Rank.King, Suit.Diamonds),
            new Card(Rank.Ace, Suit.Diamonds),
            new Card(Rank.Two, Suit.Clubs),
            new Card(Rank.Six, Suit.Diamonds),
            new Card(Rank.Seven, Suit.Diamonds),
            new Card(Rank.Four, Suit.Spades),
            new Card(Rank.Nine, Suit.Diamonds),
            new Card(Rank.Seven, Suit.Clubs),
            new Card(Rank.King, Suit.Hearts),
            new Card(Rank.Five, Suit.Hearts),
            new Card(Rank.Ten, Suit.Diamonds),
            new Card(Rank.Jack, Suit.Diamonds),
            new Card(Rank.Nine, Suit.Clubs),
            new Card(Rank.Seven, Suit.Spades),
            new Card(Rank.Queen, Suit.Spades),
            new Card(Rank.Queen, Suit.Diamonds),
            new Card(Rank.Ace, Suit.Hearts),
            new Card(Rank.Two, Suit.Spades),
            new Card(Rank.Five, Suit.Clubs),
            new Card(Rank.Two, Suit.Hearts),
            new Card(Rank.Three, Suit.Hearts),
            new Card(Rank.Queen, Suit.Hearts),
            new Card(Rank.Four, Suit.Hearts),
            new Card(Rank.Eight, Suit.Diamonds),
            new Card(Rank.Six, Suit.Hearts),
            new Card(Rank.Eight, Suit.Hearts),
            new Card(Rank.Jack, Suit.Spades),
            new Card(Rank.Nine, Suit.Spades),
            new Card(Rank.Nine, Suit.Hearts),
            new Card(Rank.Six, Suit.Spades),
            new Card(Rank.Ten, Suit.Hearts),
            new Card(Rank.Ace, Suit.Spades),
            }};
    }
}
