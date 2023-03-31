using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Arcade
{
    public class SolitaireCard
    {
        public SolitaireCardRank CardRank { get; private set; }
        public SolitaireCardSuit CardSuit { get; private set; }

        public SolitaireCard(SolitaireCardRank rank, SolitaireCardSuit suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }

        public override string ToString()
        {
            return CardRank + " of " + CardSuit;
        }
    }

    public enum SolitaireCardRank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    public enum SolitaireCardSuit { Diamonds, Hearts, Spades, Clubs }
}
