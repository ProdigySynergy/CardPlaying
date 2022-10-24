using System;

namespace CardShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            // print Deck
            // shuffle Deck
            deck.Shuffle();
            // Deal a Card
            Console.WriteLine("----------- Deal A Card ---------");
            Console.WriteLine(deck.DealCard().Face);
            // Deal X Cards
            Console.WriteLine("----------- Deal X Cards ---------");
            var xCards = deck.DealXCards(2);
            foreach(var aCard in xCards)
            {
                Console.WriteLine(aCard.Face);
            }
        }
    }
}
