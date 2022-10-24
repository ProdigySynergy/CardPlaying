using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffle
{
    class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Init();
        }

        public void Init()
        {
            this.Cards = new List<Card>();
            for (int i = 1; i <= Enum.GetValues(typeof(Suite)).Length; i++)
            {
                for (int j = 1; j <= Enum.GetValues(typeof(Face)).Length; j++)
                {
                    // For each suites create faces
                    Enum.TryParse(i.ToString(), out Suite aSuite);
                    Enum.TryParse(j.ToString(), out Face aFace);

                    this.Cards.Add(
                        new Card()
                        {
                            Suite = aSuite,
                            Face = aFace
                        }
                    );
                }
            }

            Console.WriteLine("----------- Init Deck ---------");
            this.Cards.ForEach(o => Console.WriteLine(o.Face));
        }

        public void Shuffle()
        {
            int cardCount = this.Cards.Count;

            for (int i = 0; i < cardCount; i++)
            {
                int last = cardCount - i;
                int rand = Rand(0, last - 1);

                // Using Fisher-Yates
                // swap the items
                Card temp = this.Cards[last - 1];
                this.Cards[last - 1] = this.Cards[rand];
                this.Cards[rand] = temp;
            }

            Console.WriteLine("----------- Deck is Shuffled ---------");
            this.Cards.ForEach(o => Console.WriteLine(o.Face));
        }

        private int Rand(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public Card DealCard(int i = 0)
        {
            Card picked = this.Cards[i];
            this.Cards.Remove(picked);

            return picked;
        }

        public IEnumerable<Card> DealXCards(int x)
        {
            List<Card> xCards = new List<Card>();

            for (int i = 0; i < x; i++)
            {
                xCards.Add(this.DealCard());
            }

            return xCards;
        }
    }
}
