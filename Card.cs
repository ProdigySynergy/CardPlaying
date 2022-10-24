using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffle
{
    public enum Suite
    {
        Club        = 1,
        Diamond     = 2,
        Heart       = 3,
        Spades      = 4,
    }

    public enum Face
    {
        Ace     = 1,
        Two     = 2,
        Three   = 3,
        Four    = 4,
        Five    = 5,
        Six     = 6,
        Seven   = 7,
        Eight   = 8,
        Nine    = 9,
        Ten     = 10,
        Jack    = 11,
        Queen   = 12,
        King    = 13,
    }

    class Card
    {
        public Suite Suite { get; set; }
        public Face Face { get; set; }
    }
}
