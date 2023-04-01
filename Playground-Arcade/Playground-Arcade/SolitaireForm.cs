using Playground_Arcade.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_Arcade
{
    public partial class SolitaireForm : Form
    {
        SolitaireBoard board;
        public List<PictureBox> tableColumn1;
        public List<PictureBox> tableColumn2;
        public List<PictureBox> tableColumn3;
        public List<PictureBox> tableColumn4;
        public List<PictureBox> tableColumn5;
        public List<PictureBox> tableColumn6;
        public List<PictureBox> tableColumn7;

        public SolitaireForm()
        {
            InitializeComponent();

            board = new();

            UpdateCardPicture(board.tableColumn1[0], TableC1R1PB);
        }

        public void SetupAllCards()
        {
            
        }

        public void UpdateCardPicture(SolitaireCard card, PictureBox pictureBox)
        {
            if (card.CardRank == SolitaireCardRank.Ace)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.AceOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.AceOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.AceOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.AceOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Two)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.TwoOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.TwoOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.TwoOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.TwoOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Three)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.ThreeOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.ThreeOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.ThreeOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.ThreeOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Four)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.FourOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.FourOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.FourOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.FourOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Five)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.FiveOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.FiveOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.FiveOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.FiveOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Six)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.SixOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.SixOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.SixOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.SixOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Seven)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.SevenOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.SevenOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.SevenOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.SevenOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Eight)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.EightOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.EightOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.EightOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.EightOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Nine)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.NineOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.NineOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.NineOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.NineOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Ten)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.TenOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.TenOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.TenOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.TenOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Jack)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.JackOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.JackOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.JackOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.JackOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.Queen)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.QueenOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.QueenOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.QueenOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.QueenOfClubs;
                }
            }
            else if (card.CardRank == SolitaireCardRank.King)
            {
                if (card.CardSuit == SolitaireCardSuit.Diamonds)
                {
                    pictureBox.Image = Resources.KingOfDiamonds;
                }
                else if (card.CardSuit == SolitaireCardSuit.Hearts)
                {
                    pictureBox.Image = Resources.KingOfHearts;
                }
                else if (card.CardSuit == SolitaireCardSuit.Spades)
                {
                    pictureBox.Image = Resources.KingOfSpades;
                }
                else if (card.CardSuit == SolitaireCardSuit.Clubs)
                {
                    pictureBox.Image = Resources.KingOfClubs;
                }
            }
        }

        //Draw a card from the drawPile and move it to the wastePile
        //If the drawPile is empty, move all cards in the wastePile back into the drawPile
        private void DrawPilePB_Click(object sender, EventArgs e)
        {
            board.DrawFromDrawPile();
            //Update the wastePile's picture to the newly added card, or blank if empty
            if (board.wastePile.Count == 0)
            {
                WastePilePB.Image = null;
            }
            else
            {
                UpdateCardPicture(board.wastePile[board.wastePile.Count - 1], WastePilePB);
            }
            //Update the drawPile's picture to the card back, or blank if empty
            if (board.drawPile.Count == 0)
            {
                DrawPilePB.Image = null;
            }
            else
            {
                DrawPilePB.Image = Resources.Back;
            }
        }
    }
}
