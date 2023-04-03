using Playground_Arcade.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  TODO
//comments/code cleanup
//maybe hint system

namespace Playground_Arcade
{
    public partial class SolitaireForm : Form
    {
        SolitaireBoard board;
        //Cards in each column
        List<PictureBox> tableColumn1;
        List<PictureBox> tableColumn2;
        List<PictureBox> tableColumn3;
        List<PictureBox> tableColumn4;
        List<PictureBox> tableColumn5;
        List<PictureBox> tableColumn6;
        List<PictureBox> tableColumn7;
        //Cards in waste pile
        List<PictureBox> wastePile;
        //Card(s) selected by user to move
        List<SolitaireCard> selectedCards;
        //Original column of selected cards to move
        List<PictureBox> columnOfCardsToBeMoved;
        //New location of moved cards
        List<SolitaireCard> newColumnOfMovedCards;
        //Number of moves taken (draw card or move card(s))
        int numOfMoves;
        //Number of cards drawn from draw pile each click
        int numOfDraws;

        public SolitaireForm()
        {
            InitializeComponent();
            board = new();
            tableColumn1 = new();
            tableColumn2 = new();
            tableColumn3 = new();
            tableColumn4 = new();
            tableColumn5 = new();
            tableColumn6 = new();
            tableColumn7 = new();
            wastePile = new();
            selectedCards = new();
            columnOfCardsToBeMoved = new();
            newColumnOfMovedCards = new();
        }

        private void StartGame()
        {
            TitleLabel.Visible = false;
            PlayDraw1Button.Visible = false;
            PlayDraw3Button.Visible = false;
            HowToPlayLabel.Visible = false;
            TitlePB1.Visible = false;
            TitlePB2.Visible = false;
            TitlePB3.Visible = false;
            TitlePB4.Visible = false;
            board = new();
            columnOfCardsToBeMoved = new();
            selectedCards = new();
            SetupAllCardPictures();
            UpdateAllCardPictures();
            numOfMoves = 0;
            NumberOfMovesLabel.Text = "Moves: " + numOfMoves;
            UpdateColumnPictures(board.tableColumn1, tableColumn1);
            UpdateColumnPictures(board.tableColumn2, tableColumn2);
            UpdateColumnPictures(board.tableColumn3, tableColumn3);
            UpdateColumnPictures(board.tableColumn4, tableColumn4);
            UpdateColumnPictures(board.tableColumn5, tableColumn5);
            UpdateColumnPictures(board.tableColumn6, tableColumn6);
            UpdateColumnPictures(board.tableColumn7, tableColumn7);
            RestartButton.Visible = true;
            RestartButton.Enabled = true;
            NumberOfMovesLabel.Visible = true;
        }

        private void UpdateNumberOfMoves()
        {
            numOfMoves++;
            NumberOfMovesLabel.Text = "Moves: " + numOfMoves;
        }

        private void GameWonCheck()
        {
            if (board.completePile1.Count == 13 && board.completePile2.Count == 13 && board.completePile3.Count == 13 && board.completePile4.Count == 13)
            {
                YouWinLabel.Visible = true;
            }
        }

        //Draw a card from the drawPile and move it to the wastePile
        //If the drawPile is empty, move all cards in the wastePile back into the drawPile
        private void DrawPilePB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numOfDraws; i++)
            {
                board.DrawFromDrawPile();
                //Update the wastePile's picture to the newly added card, or blank if empty
                if (board.wastePile.Count == 0)
                {
                    WastePilePB.Image = null;
                }
                else
                {
                    board.wastePile[^1].FlipCard();
                    UpdateCardPicture(board.wastePile[^1], WastePilePB);
                    selectedCards.Clear();
                    if (i == 0)
                    {
                        UpdateNumberOfMoves();
                    }
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
            tableColumn1[0].Enabled = true;
            tableColumn1[0].Visible = true;
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
            for (int i = 0; i < 2; i++)
            {
                tableColumn2[i].Enabled = true;
                tableColumn2[i].Visible = true;
            }
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
            for (int i = 0; i < 3; i++)
            {
                tableColumn3[i].Enabled = true;
                tableColumn3[i].Visible = true;
            }
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
            for (int i = 0; i < 4; i++)
            {
                tableColumn4[i].Enabled = true;
                tableColumn4[i].Visible = true;
            }
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
            for (int i = 0; i < 5; i++)
            {
                tableColumn5[i].Enabled = true;
                tableColumn5[i].Visible = true;
            }
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
            for (int i = 0; i < 6; i++)
            {
                tableColumn6[i].Enabled = true;
                tableColumn6[i].Visible = true;
            }
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
            for (int i = 0; i < 7; i++)
            {
                tableColumn7[i].Enabled = true;
                tableColumn7[i].Visible = true;
            }
            board.tableColumn7[6].FlipCard();
            wastePile = new List<PictureBox> { WastePilePB };
            CompletePile1PB.Enabled = true;
            CompletePile1PB.Visible = true;
            CompletePile2PB.Enabled = true;
            CompletePile2PB.Visible = true;
            CompletePile3PB.Enabled = true;
            CompletePile3PB.Visible = true;
            CompletePile4PB.Enabled = true;
            CompletePile4PB.Visible = true;
            WastePilePB.Enabled = true;
            WastePilePB.Visible = true;
            DrawPilePB.Enabled = true;
            DrawPilePB.Visible = true;
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

        public void UpdateColumnPictures(List<SolitaireCard> cardColumn, List<PictureBox> pictureColumn)
        {
            if (cardColumn != board.wastePile && cardColumn != null)
            {
                for (int i = 0; i < cardColumn.Count; i++)
                {
                    UpdateCardPicture(cardColumn[i], pictureColumn[i]);
                }
                foreach (PictureBox picture in pictureColumn)
                {
                    picture.BringToFront();
                }
            }
        }

        public static void UpdateCardPicture(SolitaireCard card, PictureBox pictureBox)
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
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void MoveToCompletePile(List<SolitaireCard> clickedPile, PictureBox clickedPictureBox)
        {
            if (selectedCards.Count == 1)
            {
                if (clickedPile.Count == 0)
                {
                    if (selectedCards[0].CardRank == SolitaireCardRank.Ace)
                    {
                        clickedPile.Add(selectedCards[0]);
                        DetermineColumnToRemoveFrom(columnOfCardsToBeMoved);
                        UpdateCardPicture(selectedCards[0], clickedPictureBox);
                        selectedCards.Clear();
                        UpdateColumnPictures(newColumnOfMovedCards, columnOfCardsToBeMoved);
                        UpdateNumberOfMoves();
                        GameWonCheck();
                    }
                }
                else if (selectedCards[0].CardRank == clickedPile[^1].CardRank + 1 && selectedCards[0].CardSuit == clickedPile[^1].CardSuit)
                {
                    clickedPile.Add(selectedCards[0]);
                    DetermineColumnToRemoveFrom(columnOfCardsToBeMoved);
                    UpdateCardPicture(selectedCards[0], clickedPictureBox);
                    selectedCards.Clear();
                    UpdateColumnPictures(newColumnOfMovedCards, columnOfCardsToBeMoved);
                    UpdateNumberOfMoves();
                    GameWonCheck();
                }
            }
        }

        private void MoveCard(List<SolitaireCard> clickedColumn, List<PictureBox> clickedPictureBox, int clickedCardIndex)
        {
            //If the clicked column is empty and the first selected card is a king, move the selected cards to the new column
            if (clickedColumn.Count == 0 && selectedCards.Count > 0)
            {   
                if (selectedCards[0].CardRank == SolitaireCardRank.King)
                {
                    //Move all selected cards to the new column
                    for (int i = 0; i < selectedCards.Count; i++)
                    {
                        clickedColumn.Add(selectedCards[i]);
                        clickedPictureBox[clickedCardIndex + i].Enabled = true;
                        clickedPictureBox[clickedCardIndex + i].Visible = true;
                    }
                    //Remove selected cards from old column
                    DetermineColumnToRemoveFrom(columnOfCardsToBeMoved);
                    selectedCards.Clear();
                    UpdateColumnPictures(clickedColumn, clickedPictureBox);
                    UpdateColumnPictures(newColumnOfMovedCards, columnOfCardsToBeMoved);
                    UpdateNumberOfMoves();
                }
            }
            //Check if clicked card is face up
            else if (clickedColumn.Count > 0 && clickedColumn[clickedCardIndex].IsFaceUp)
            {
                //If no card is currently selected, select clicked card
                if (selectedCards.Count == 0)
                {
                    for (int i = clickedCardIndex; i < clickedColumn.Count; i++)
                    {
                        selectedCards.Add(clickedColumn[i]);
                        columnOfCardsToBeMoved = clickedPictureBox;
                        newColumnOfMovedCards = clickedColumn;
                    }
                    clickedPictureBox[clickedCardIndex].BorderStyle = BorderStyle.Fixed3D;
                }
                //If a card is currently selected, move it to the clicked location if possible
                else
                {
                    //If the selected card is clicked again, unselect it
                    if (clickedColumn[clickedCardIndex] == selectedCards[0])
                    {
                        clickedPictureBox[clickedCardIndex].BorderStyle = BorderStyle.FixedSingle;
                        selectedCards.Clear();
                    }
                    //If currently selected card is opposite color of this card, and this card has no card below it
                    else if (clickedColumn[clickedCardIndex].isRed != selectedCards[0].isRed && clickedColumn.Count == (clickedCardIndex + 1) && selectedCards[0].CardRank == clickedColumn[clickedCardIndex].CardRank - 1)
                    {
                        //Move all selected cards to the new column
                        for (int i = 0; i < selectedCards.Count; i++)
                        {
                            clickedColumn.Add(selectedCards[i]);
                            clickedPictureBox[clickedCardIndex + i + 1].Enabled = true;
                            clickedPictureBox[clickedCardIndex + i + 1].Visible = true;
                        }
                        //Remove selected cards from old column
                        DetermineColumnToRemoveFrom(columnOfCardsToBeMoved);
                        selectedCards.Clear();
                        UpdateColumnPictures(clickedColumn, clickedPictureBox);
                        UpdateColumnPictures(newColumnOfMovedCards, columnOfCardsToBeMoved);
                        UpdateNumberOfMoves();
                    }
                }
            }
        }

        private void DetermineColumnToRemoveFrom(List<PictureBox> column)
        {
            if (tableColumn1 == column)
            {
                RemoveMovedCard(tableColumn1, board.tableColumn1, TableC1R1PB);
            }
            else if (tableColumn2 == column)
            {
                RemoveMovedCard(tableColumn2, board.tableColumn2, TableC2R1PB);
            }
            else if (tableColumn3 == column)
            {
                RemoveMovedCard(tableColumn3, board.tableColumn3, TableC3R1PB);
            }
            else if (tableColumn4 == column)
            {
                RemoveMovedCard(tableColumn4, board.tableColumn4, TableC4R1PB);
            }
            else if (tableColumn5 == column)
            {
                RemoveMovedCard(tableColumn5, board.tableColumn5, TableC5R1PB);
            }
            else if (tableColumn6 == column)
            {
                RemoveMovedCard(tableColumn6, board.tableColumn6, TableC6R1PB);
            }
            else if (tableColumn7 == column)
            {
                RemoveMovedCard(tableColumn7, board.tableColumn7, TableC7R1PB);
            }
            else if (wastePile == column)
            {
                RemoveMovedCard(wastePile, board.wastePile, WastePilePB);
            }
        }

        private void RemoveMovedCard(List<PictureBox> tableColumnPictures, List<SolitaireCard> boardCards, PictureBox cardPicture)
        {
            //Remove top card of waste pile and update picture
            if (columnOfCardsToBeMoved == wastePile)
            {
                board.wastePile.RemoveAt(board.wastePile.Count - 1);
                WastePilePB.BorderStyle = BorderStyle.FixedSingle;
                if (board.wastePile.Count > 0)
                {
                    UpdateCardPicture(board.wastePile[^1], WastePilePB);
                }
                else
                {
                    WastePilePB.Image = null;
                }
            }
            //Remove selected card(s) from old pile and update picture boxes
            for (int i = 0; i < boardCards.Count; i++)
            {
                if (boardCards[i] == selectedCards[0])
                {
                    for (int e = i; e < (i + selectedCards.Count); e++)
                    {
                        if (e != 0)
                        {
                            tableColumnPictures[e].Enabled = false;
                            tableColumnPictures[e].Visible = false;
                        }
                        else
                        {
                            cardPicture.Image = null;
                            cardPicture.BorderStyle = BorderStyle.FixedSingle;
                        }
                        boardCards.RemoveAt(i);
                    }
                    if (boardCards.Count > 0)
                    {
                        boardCards[i - 1].FlipCard();
                    }
                    return;
                }
            }
        }

        //Click on card pictures to select corresponding card or move it to the selected location
        //Column 1
        private void TableC1R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 0);
        }
        private void TableC1R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 1);
        }
        private void TableC1R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 2);
        }
        private void TableC1R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 3);
        }
        private void TableC1R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 4);
        }
        private void TableC1R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 5);
        }
        private void TableC1R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 6);
        }
        private void TableC1R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 7);
        }
        private void TableC1R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 8);
        }
        private void TableC1R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 9);
        }
        private void TableC1R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 10);
        }
        private void TableC1R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 11);
        }
        private void TableC1R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn1, tableColumn1, 12);
        }
        //Column 2
        private void TableC2R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 0);
        }
        private void TableC2R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 1);
        }
        private void TableC2R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 2);
        }
        private void TableC2R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 3);
        }
        private void TableC2R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 4);
        }
        private void TableC2R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 5);
        }
        private void TableC2R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 6);
        }
        private void TableC2R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 7);
        }
        private void TableC2R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 8);
        }
        private void TableC2R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 9);
        }
        private void TableC2R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 10);
        }
        private void TableC2R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 11);
        }
        private void TableC2R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 12);
        }
        private void TableC2R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn2, tableColumn2, 13);
        }
        //Column3
        private void TableC3R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 0);
        }
        private void TableC3R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 1);
        }
        private void TableC3R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 2);
        }
        private void TableC3R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 3);
        }
        private void TableC3R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 4);
        }
        private void TableC3R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 5);
        }
        private void TableC3R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 6);
        }
        private void TableC3R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 7);
        }
        private void TableC3R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 8);
        }
        private void TableC3R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 9);
        }
        private void TableC3R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 10);
        }
        private void TableC3R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 11);
        }
        private void TableC3R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 12);
        }
        private void TableC3R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 13);
        }
        private void TableC3R15PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn3, tableColumn3, 14);
        }
        //Column 4
        private void TableC4R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 0);
        }
        private void TableC4R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 1);
        }
        private void TableC4R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 2);
        }
        private void TableC4R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 3);
        }
        private void TableC4R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 4);
        }
        private void TableC4R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 5);
        }
        private void TableC4R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 6);
        }
        private void TableC4R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 7);
        }
        private void TableC4R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 8);
        }
        private void TableC4R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 9);
        }
        private void TableC4R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 10);
        }
        private void TableC4R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 11);
        }
        private void TableC4R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 12);
        }
        private void TableC4R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 13);
        }
        private void TableC4R15PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 14);
        }
        private void TableC4R16PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn4, tableColumn4, 15);
        }
        //Column 5
        private void TableC5R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 0);
        }
        private void TableC5R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 1);
        }
        private void TableC5R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 2);
        }
        private void TableC5R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 3);
        }
        private void TableC5R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 4);
        }
        private void TableC5R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 5);
        }
        private void TableC5R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 6);
        }
        private void TableC5R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 7);
        }
        private void TableC5R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 8);
        }
        private void TableC5R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 9);
        }
        private void TableC5R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 10);
        }
        private void TableC5R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 11);
        }
        private void TableC5R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 12);
        }
        private void TableC5R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 13);
        }
        private void TableC5R15PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 14);
        }
        private void TableC5R16PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 15);
        }
        private void TableC5R17PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn5, tableColumn5, 16);
        }
        //Column 6
        private void TableC6R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 0);
        }
        private void TableC6R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 1);
        }
        private void TableC6R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 2);
        }
        private void TableC6R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 3);
        }
        private void TableC6R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 4);
        }
        private void TableC6R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 5);
        }
        private void TableC6R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 6);
        }
        private void TableC6R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 7);
        }
        private void TableC6R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 8);
        }
        private void TableC6R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 9);
        }
        private void TableC6R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 10);
        }
        private void TableC6R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 11);
        }
        private void TableC6R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 12);
        }
        private void TableC6R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 13);
        }
        private void TableC6R15PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 14);
        }
        private void TableC6R16PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 15);
        }
        private void TableC6R17PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 16);
        }
        private void TableC6R18PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn6, tableColumn6, 17);
        }
        //Column 7
        private void TableC7R1PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 0);
        }
        private void TableC7R2PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 1);
        }
        private void TableC7R3PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 2);
        }
        private void TableC7R4PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 3);
        }
        private void TableC7R5PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 4);
        }
        private void TableC7R6PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 5);
        }
        private void TableC7R7PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 6);
        }
        private void TableC7R8PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 7);
        }
        private void TableC7R9PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 8);
        }
        private void TableC7R10PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 9);
        }
        private void TableC7R11PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 10);
        }
        private void TableC7R12PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 11);
        }
        private void TableC7R13PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 12);
        }
        private void TableC7R14PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 13);
        }
        private void TableC7R15PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 14);
        }
        private void TableC7R16PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 15);
        }
        private void TableC7R17PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 16);
        }
        private void TableC7R18PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 17);
        }
        private void TableC7R19PB_Click(object sender, EventArgs e)
        {
            MoveCard(board.tableColumn7, tableColumn7, 18);
        }
        //Waste pile
        private void WastePilePB_Click(object sender, EventArgs e)
        {
            if (board.wastePile.Count > 0)
            {
                if (selectedCards.Count > 0)
                {
                    if (selectedCards[0] == board.wastePile[^1])
                    {
                        WastePilePB.BorderStyle = BorderStyle.FixedSingle;
                        selectedCards.Clear();
                    }
                }
                else
                {
                    selectedCards.Add(board.wastePile[^1]);
                    WastePilePB.BorderStyle = BorderStyle.Fixed3D;
                    columnOfCardsToBeMoved = wastePile;
                    newColumnOfMovedCards = board.wastePile;
                }
            }
        }
        //Complete piles
        private void CompletePile1PB_Click(object sender, EventArgs e)
        {
            MoveToCompletePile(board.completePile1, CompletePile1PB);
        }
        private void CompletePile2PB_Click(object sender, EventArgs e)
        {
            MoveToCompletePile(board.completePile2, CompletePile2PB);
        }
        private void CompletePile3PB_Click(object sender, EventArgs e)
        {
            MoveToCompletePile(board.completePile3, CompletePile3PB);
        }
        private void CompletePile4PB_Click(object sender, EventArgs e)
        {
            MoveToCompletePile(board.completePile4, CompletePile4PB);
        }
        //Start game buttons
        private void PlayDraw1Button_Click(object sender, EventArgs e)
        {
            numOfDraws = 1;
            StartGame();
        }
        private void PlayDraw3Button_Click(object sender, EventArgs e)
        {
            numOfDraws = 3;
            StartGame();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}