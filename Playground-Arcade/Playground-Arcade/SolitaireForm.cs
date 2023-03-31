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

            SetupAllCards();
        }

        public void SetupAllCards()
        {
            //testing, will change later
            Debug.WriteLine(board.tableColumn1[0].ToString());
            if (board.tableColumn1[0].CardRank == SolitaireCardRank.Ace)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.AceOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.AceOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.AceOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.AceOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Two)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.TwoOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.TwoOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.TwoOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.TwoOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Three)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.ThreeOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.ThreeOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.ThreeOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.ThreeOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Four)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.FourOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.FourOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.FourOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.FourOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Five)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.FiveOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.FiveOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.FiveOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.FiveOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Six)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.SixOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.SixOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.SixOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.SixOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Seven)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.SevenOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.SevenOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.SevenOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.SevenOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Eight)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.EightOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.EightOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.EightOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.EightOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Nine)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.NineOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.NineOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.NineOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.NineOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Ten)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.TenOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.TenOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.TenOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.TenOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Jack)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.JackOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.JackOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.JackOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.JackOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.Queen)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.QueenOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.QueenOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.QueenOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.QueenOfClubs;
                }
            }
            else if (board.tableColumn1[0].CardRank == SolitaireCardRank.King)
            {
                if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Diamonds)
                {
                    TableC1R1PB.Image = Resources.KingOfDiamonds;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Hearts)
                {
                    TableC1R1PB.Image = Resources.KingOfHearts;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Spades)
                {
                    TableC1R1PB.Image = Resources.KingOfSpades;
                }
                else if (board.tableColumn1[0].CardSuit == SolitaireCardSuit.Clubs)
                {
                    TableC1R1PB.Image = Resources.KingOfClubs;
                }
            }
        }

        public void UpdateCardPicture(SolitaireCard card, PictureBox pictureBox)
        {
            
        }
    }
}
