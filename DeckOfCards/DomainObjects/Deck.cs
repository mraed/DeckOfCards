using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.DomainObjects
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
        }

        public List<Card> Cards { get; set; }

        public void AddCard(Card cardToAdd)
        {
            Cards.Add(cardToAdd);
        }

        //Not super robust but fine for our testing purposes for now
        public override bool Equals(object obj)
        {
            var deck = (Deck)obj;
            return (deck.Cards.SequenceEqual(Cards));
        }
    }

}
