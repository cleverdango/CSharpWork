using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class Deck264
    {

        private enum Suits264
        {
            Spade,
            Heart,
            Diamond,
            Club
        }

        private enum Values264
        {
            cA ,
            c2,
            c3,
            c4,
            c5,
            c6,
            c7,
            c8,
            c9,
            c10,
            cJ,
            cQ,
            cK
        }

        private struct Card264
        {
            Suits264 Suit;
            Values264 Value;
            public Card264(Suits264 suit, Values264 value)
            {
                this.Suit = suit;
                this.Value = value;
            }

            public override string ToString()
            {
                string sSuit;
                string sValue;
                switch (this.Suit)
                {
                    case Suits264.Spade: sSuit = "♠"; break;
                    case Suits264.Heart: sSuit = "♥"; break;
                    case Suits264.Diamond: sSuit = "♦"; break;
                    case Suits264.Club: sSuit = "♣"; break;
                    default:
                        throw new InvalidOperationException();
                }
                //switch (this.Value)
                //{
                //    case Values264.cA:
                //        sValue = "A";
                //        break;
                //    case Values264.c2:
                //    case Values264.c3:
                //    case Values264.c4:
                //    case Values264.c5:
                //    case Values264.c6:
                //    case Values264.c7:
                //    case Values264.c8:
                //    case Values264.c9:
                //    case Values264.c10:
                //        sValue = (this.Value - Values264.cA + 1).ToString();
                //        break;
                //    case Values264.cJ: sValue = "J"; break;
                //    case Values264.cQ: sValue = "Q"; break;
                //    case Values264.cK: sValue = "K"; break;
                //    default:
                //        throw new InvalidOperationException();
                //}
                //sValue=Enum.GetValues(Suit.GetType()).ToString();
                sValue = this.Value.ToString().Substring(1);
                return sSuit + sValue;
            }
        }

        private Random r = new Random();

        private List<Card264> cards;

        private Card264 randomCard()
        {
            return new Card264((Suits264)r.Next(4), (Values264)r.Next(0, 13));
        }

        public void ShuffleDeck()
        {
            cards = new List<Card264>();
            while (cards.Count < 52)
            {
                Card264 card = randomCard();
                if (!cards.Contains(card))
                {
                    cards.Add(card);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (var card in cards)
            {
                sb.Append(card.ToString());
                sb.Append("、");
                count++;
                if (count % 13 == 0)
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}
