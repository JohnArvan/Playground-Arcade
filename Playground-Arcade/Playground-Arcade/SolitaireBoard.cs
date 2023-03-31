using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Arcade
{
    public class SolitaireBoard
    {
        //  Create lists for all cards
        //List containing all cards
        private List<SolitaireCard> allCards;
        //Lists containings cards in waste pile and draw pile
        public List<SolitaireCard> wastePile;       //Initially empty
        public List<SolitaireCard> drawPile;
        //Lists containing cards in complete piles (all initially empty)
        public List<SolitaireCard> completePile1;
        public List<SolitaireCard> completePile2;
        public List<SolitaireCard> completePile3;
        public List<SolitaireCard> completePile4;
        //Lists containing cards in each row on the table
        public List<SolitaireCard> tableColumn1;
        public List<SolitaireCard> tableColumn2;
        public List<SolitaireCard> tableColumn3;
        public List<SolitaireCard> tableColumn4;
        public List<SolitaireCard> tableColumn5;
        public List<SolitaireCard> tableColumn6;
        public List<SolitaireCard> tableColumn7;

        public SolitaireBoard()
        {
            //Create arrays containing all possible card ranks and suits
            SolitaireCardRank[] ranks = { SolitaireCardRank.Ace, SolitaireCardRank.Two, SolitaireCardRank.Three, 
                                          SolitaireCardRank.Four, SolitaireCardRank.Five, SolitaireCardRank.Six, 
                                          SolitaireCardRank.Seven, SolitaireCardRank.Eight, SolitaireCardRank.Nine, 
                                          SolitaireCardRank.Ten, SolitaireCardRank.Jack, SolitaireCardRank.Queen, 
                                          SolitaireCardRank.King };
            SolitaireCardSuit[] suits = { SolitaireCardSuit.Diamonds, SolitaireCardSuit.Hearts, SolitaireCardSuit.Spades, SolitaireCardSuit.Clubs };
            //Generate all 52 possible cards and add to allCards 
            allCards = new List<SolitaireCard>();
            tableColumn1 = new List<SolitaireCard>();
            tableColumn2 = new List<SolitaireCard>();
            tableColumn3 = new List<SolitaireCard>();
            tableColumn4 = new List<SolitaireCard>();
            tableColumn5 = new List<SolitaireCard>();
            tableColumn6 = new List<SolitaireCard>();
            tableColumn7 = new List<SolitaireCard>();
            drawPile = new List<SolitaireCard>();
            foreach (SolitaireCardRank rank in ranks)
            {
                foreach (SolitaireCardSuit suit in suits)
                {
                    SolitaireCard card = new(rank, suit);
                    allCards.Add(card);
                }
            }
            //Randomize order of allCards
            allCards = allCards.OrderBy(a => Guid.NewGuid()).ToList();
            //Add 1 card from allCards to tableColumn1
            tableColumn1.Add(allCards[0]);
            //Add 2 cards from allCards to tableColumn2
            tableColumn2.Add(allCards[1]);
            tableColumn2.Add(allCards[2]);
            //Add 3 cards from allCards to tableColumn3
            for (int i = 3; i < 6; i++)
            {
                tableColumn3.Add(allCards[i]);
            }
            //Add 4 cards from allCards to tableColumn4
            for (int i = 6; i < 10; i++)
            {
                tableColumn4.Add(allCards[i]);
            }
            //Add 5 cards from allCards to tableColumn5
            for (int i = 10; i < 15; i++)
            {
                tableColumn5.Add(allCards[i]);
            }
            //Add 6 cards from allCards to tableColumn6
            for (int i = 15; i < 21; i++)
            {
                tableColumn6.Add(allCards[i]);
            }
            //Add 7 cards from allCards to tableColumn7
            for (int i = 21; i < 28; i++)
            {
                tableColumn7.Add(allCards[i]);
            }
            //Add remaining cards from allCards to drawPile
            for (int i = 28; i < allCards.Count; i++)
            {
                drawPile.Add(allCards[i]);
            }
        }
    }
}
