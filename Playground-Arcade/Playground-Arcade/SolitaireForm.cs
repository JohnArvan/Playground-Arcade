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
        List<PictureBox> tableColumn1;
        List<PictureBox> tableColumn2;
        List<PictureBox> tableColumn3;
        List<PictureBox> tableColumn4;
        List<PictureBox> tableColumn5;
        List<PictureBox> tableColumn6;
        List<PictureBox> tableColumn7;

        public SolitaireForm()
        {
            InitializeComponent();

            board = new();

            //UpdateCardPicture(board.tableColumn1[0], TableC1R1PB);
            SetupAllCardPictures();
            UpdateAllCardPictures();
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
                board.wastePile[board.wastePile.Count - 1].FlipCard();
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

        //Add table picture boxes to corrseponding card lists from SolitaireBoard, and flip bottom card of each column
        public void SetupAllCardPictures()
        {
            //All picture boxes in column 1
            tableColumn1 = new List<PictureBox>()
            {
                TableC1R1PB,
                TableC1R2PB,
                TableC1R3PB,
                TableC1R4PB,
                TableC1R5PB,
                TableC1R6PB,
                TableC1R7PB,
                TableC1R8PB,
                TableC1R9PB,
                TableC1R10PB,
                TableC1R11PB,
                TableC1R12PB,
                TableC1R13PB
            };
            board.tableColumn1[0].FlipCard();
            //All picture boxes in column 2
            tableColumn2 = new List<PictureBox>()
            {
                TableC2R1PB,
                TableC2R2PB,
                TableC2R3PB,
                TableC2R4PB,
                TableC2R5PB,
                TableC2R6PB,
                TableC2R7PB,
                TableC2R8PB,
                TableC2R9PB,
                TableC2R10PB,
                TableC2R11PB,
                TableC2R12PB,
                TableC2R13PB,
                TableC2R14PB
            };
            board.tableColumn2[1].FlipCard();
            //All picture boxes in column 3
            tableColumn3 = new List<PictureBox>()
            {
                TableC3R1PB,
                TableC3R2PB,
                TableC3R3PB,
                TableC3R4PB,
                TableC3R5PB,
                TableC3R6PB,
                TableC3R7PB,
                TableC3R8PB,
                TableC3R9PB,
                TableC3R10PB,
                TableC3R11PB,
                TableC3R12PB,
                TableC3R13PB,
                TableC3R14PB,
                TableC3R15PB
            };
            board.tableColumn3[2].FlipCard();
            //All picture boxes in column 4
            tableColumn4 = new List<PictureBox>()
            {
                TableC4R1PB,
                TableC4R2PB,
                TableC4R3PB,
                TableC4R4PB,
                TableC4R5PB,
                TableC4R6PB,
                TableC4R7PB,
                TableC4R8PB,
                TableC4R9PB,
                TableC4R10PB,
                TableC4R11PB,
                TableC4R12PB,
                TableC4R13PB,
                TableC4R14PB,
                TableC4R15PB,
                TableC4R16PB
            };
            board.tableColumn4[3].FlipCard();
            //All picture boxes in column 5
            tableColumn5 = new List<PictureBox>()
            {
                TableC5R1PB,
                TableC5R2PB,
                TableC5R3PB,
                TableC5R4PB,
                TableC5R5PB,
                TableC5R6PB,
                TableC5R7PB,
                TableC5R8PB,
                TableC5R9PB,
                TableC5R10PB,
                TableC5R11PB,
                TableC5R12PB,
                TableC5R13PB,
                TableC5R14PB,
                TableC5R15PB,
                TableC5R16PB,
                TableC5R17PB
            };
            board.tableColumn5[4].FlipCard();
            //All picture boxes in column 6
            tableColumn6 = new List<PictureBox>()
            {
                TableC6R1PB,
                TableC6R2PB,
                TableC6R3PB,
                TableC6R4PB,
                TableC6R5PB,
                TableC6R6PB,
                TableC6R7PB,
                TableC6R8PB,
                TableC6R9PB,
                TableC6R10PB,
                TableC6R11PB,
                TableC6R12PB,
                TableC6R13PB,
                TableC6R14PB,
                TableC6R15PB,
                TableC6R16PB,
                TableC6R17PB,
                TableC6R18PB
            };
            board.tableColumn6[5].FlipCard();
            //All picture boxes in column 7
            tableColumn7 = new List<PictureBox>()
            {
                TableC7R1PB,
                TableC7R2PB,
                TableC7R3PB,
                TableC7R4PB,
                TableC7R5PB,
                TableC7R6PB,
                TableC7R7PB,
                TableC7R8PB,
                TableC7R9PB,
                TableC7R10PB,
                TableC7R11PB,
                TableC7R12PB,
                TableC7R13PB,
                TableC7R14PB,
                TableC7R15PB,
                TableC7R16PB,
                TableC7R17PB,
                TableC7R18PB,
                TableC7R19PB
            };
            board.tableColumn7[6].FlipCard();
        }

        //Update each table picture box's picture to the corresponding card
        public void UpdateAllCardPictures()
        {
            //Update TableColumn1
            for (int i = 0; i < board.tableColumn1.Count; i++)
            {
                UpdateCardPicture(board.tableColumn1[i], tableColumn1[i]);
            }
            //Update TableColumn2
            for (int i = 0; i < board.tableColumn2.Count; i++)
            {
                UpdateCardPicture(board.tableColumn2[i], tableColumn2[i]);
            }
            //Update TableColumn3
            for (int i = 0; i < board.tableColumn3.Count; i++)
            {
                UpdateCardPicture(board.tableColumn3[i], tableColumn3[i]);
            }
            //Update TableColumn4
            for (int i = 0; i < board.tableColumn4.Count; i++)
            {
                UpdateCardPicture(board.tableColumn4[i], tableColumn4[i]);
            }
            //Update TableColumn5
            for (int i = 0; i < board.tableColumn5.Count; i++)
            {
                UpdateCardPicture(board.tableColumn5[i], tableColumn5[i]);
            }
            //Update TableColumn6
            for (int i = 0; i < board.tableColumn6.Count; i++)
            {
                UpdateCardPicture(board.tableColumn6[i], tableColumn6[i]);
            }
            //Update TableColumn7
            for (int i = 0; i < board.tableColumn7.Count; i++)
            {
                UpdateCardPicture(board.tableColumn7[i], tableColumn7[i]);
            }
        }

        public void UpdateCardPicture(SolitaireCard card, PictureBox pictureBox)
        {
            if (!card.IsFaceUp)
            {
                pictureBox.Image = Resources.Back;
            }
            else if (card.CardRank == SolitaireCardRank.Ace)
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
    }
}
