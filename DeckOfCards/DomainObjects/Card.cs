using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.DomainObjects
{
    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }

        public Rank CardRank { get; set; }
        public Suit CardSuit { get; set; }

        public override string ToString()
        {
            string rankString;
            var rankValue = (int)CardRank;
            switch (rankValue)
            {
                case 1:
                case 11:
                case 12:
                case 13:
                    rankString = CardRank.ToString();
                    break;
                default:
                    rankString = rankValue.ToString();
                    break;
            }

            return string.Format("{0} {1}", CardSuit.ToString()[0], rankString);
        }

        //Not that robust but it's good enough for us to do testing with
        public override bool Equals(object obj)
        {
            var card = (Card)obj;
            return (card.CardRank == CardRank && card.CardSuit == CardSuit);
        }
    }
}
