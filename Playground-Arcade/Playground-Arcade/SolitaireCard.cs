using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//card pictures from: https://www.abc2000.com.au/playing-cards-faces.htm
//card back picture from: https://www.dreamstime.com/back-side-poker-playing-cards-isolated-white-image108098349

namespace Playground_Arcade
{
    public class SolitaireCard
    {
        public SolitaireCardRank CardRank { get; private set; }
        public SolitaireCardSuit CardSuit { get; private set; }
        public bool IsFaceUp { get; set; }
        public bool IsRed { get; private set; }

        public SolitaireCard(SolitaireCardRank rank, SolitaireCardSuit suit)
        {
            CardRank = rank;
            CardSuit = suit;
            if (CardSuit == SolitaireCardSuit.Diamonds || CardSuit == SolitaireCardSuit.Hearts)
            {
                IsRed = true;
            }
            else
            {
                IsRed = false;
            }

        }

        //Flip card so it's face up
        public void FlipCard()
        {
            IsFaceUp = true;
        }

        //Return string of cards rank and suit
        public override string ToString()
        {
            return CardRank + " of " + CardSuit;
        }
    }

    public enum SolitaireCardRank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    public enum SolitaireCardSuit { Diamonds, Hearts, Spades, Clubs }
}
