using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_Arcade
{
    public partial class WordleForm : Form
    {
        public WordleForm()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private string[] words = { "apple", "grape", "water", "straw" };
        int textBoxIndex = 0;
        public void letterClick(string letter)
        {
            switch (textBoxIndex)
            {
                case 0:
                    if (Guess1.Text.Length < 5)
                    {
                        Guess1.AppendText(letter);
                    }
                    break;
                case 1:
                    if (Guess2.Text.Length < 5)
                    {
                        Guess2.AppendText(letter);
                    }
                    break;
                case 2:
                    if (Guess3.Text.Length < 5)
                    {
                        Guess3.AppendText(letter);
                    }
                    break;
                case 3:
                    if (Guess4.Text.Length < 5)
                    {
                        Guess4.AppendText(letter);
                    }
                    break;
                case 4:
                    if (Guess5.Text.Length < 5)
                    {
                        Guess5.AppendText(letter);
                    }
                    break;
                case 5:
                    if (GuessFinal.Text.Length < 5)
                    {
                        GuessFinal.AppendText(letter);
                    }
                    break;
                default:
                    break;
            }
        }

        private string WordToGuess()
        {
            int index = random.Next(words.Length);
            return words[index];
        }

        private void Q_Click(object sender, EventArgs e)
        {
            string letter = "Q";
            letterClick(letter);
        }

        private void W_Click(object sender, EventArgs e)
        {
            string letter = "W";
            letterClick(letter);
        }

        private void E_Click(object sender, EventArgs e)
        {
            string letter = "E";
            letterClick(letter);
        }

        private void R_Click(object sender, EventArgs e)
        {
            string letter = "R";
            letterClick(letter);
        }

        private void T_Click(object sender, EventArgs e)
        {
            string letter = "T";
            letterClick(letter);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            string letter = "Y";
            letterClick(letter);
        }

        private void U_Click(object sender, EventArgs e)
        {
            string letter = "U";
            letterClick(letter);
        }

        private void I_Click(object sender, EventArgs e)
        {
            string letter = "I";
            letterClick(letter);
        }

        private void O_Click(object sender, EventArgs e)
        {
            string letter = "O";
            letterClick(letter);
        }

        private void P_Click(object sender, EventArgs e)
        {
            string letter = "P";
            letterClick(letter);
        }

        private void A_Click(object sender, EventArgs e)
        {
            string letter = "A";
            letterClick(letter);
        }

        private void S_Click(object sender, EventArgs e)
        {
            string letter = "S";
            letterClick(letter);
        }

        private void D_Click(object sender, EventArgs e)
        {
            string letter = "D";
            letterClick(letter);
        }

        private void F_Click(object sender, EventArgs e)
        {
            string letter = "F";
            letterClick(letter);
        }

        private void G_Click(object sender, EventArgs e)
        {
            string letter = "G";
            letterClick(letter);
        }

        private void H_Click(object sender, EventArgs e)
        {
            string letter = "H";
            letterClick(letter);
        }

        private void J_Click(object sender, EventArgs e)
        {
            string letter = "J";
            letterClick(letter);
        }

        private void K_Click(object sender, EventArgs e)
        {
            string letter = "K";
            letterClick(letter);
        }

        private void L_Click(object sender, EventArgs e)
        {
            string letter = "L";
            letterClick(letter);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            string letter = "Z";
            letterClick(letter);
        }

        private void X_Click(object sender, EventArgs e)
        {
            string letter = "X";
            letterClick(letter);
        }

        private void C_Click(object sender, EventArgs e)
        {
            string letter = "C";
            letterClick(letter);
        }

        private void V_Click(object sender, EventArgs e)
        {
            string letter = "V";
            letterClick(letter);
        }

        private void B_Click(object sender, EventArgs e)
        {
            string letter = "B";
            letterClick(letter);
        }

        private void N_Click(object sender, EventArgs e)
        {
            string letter = "N";
            letterClick(letter);
        }

        private void M_Click(object sender, EventArgs e)
        {
            string letter = "M";
            letterClick(letter);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            switch (textBoxIndex)
            {
                case 0:
                    if (Guess1.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                case 1:
                    if (Guess2.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                case 2:
                    if (Guess3.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                case 3:
                    if (Guess4.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                case 4:
                    if (Guess5.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                case 5:
                    if (GuessFinal.Text.Length == 5)
                    {
                        textBoxIndex++;
                        InvalidWordMessage.Visible = false;
                    }
                    else { InvalidWordMessage.Visible = true; }
                    break;
                default:
                    break;
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            switch (textBoxIndex)
            {
                case 0:
                    if (Guess1.Text.Length > 0) // check if the text box is not empty
                    {
                        Guess1.Text = Guess1.Text.Substring(0, Guess1.Text.Length - 1); // remove the last character
                    }
                    break;
                case 1:
                    if (Guess2.Text.Length > 0) // check if the text box is not empty
                    {
                        Guess2.Text = Guess2.Text.Substring(0, Guess2.Text.Length - 1); // remove the last character
                    }
                    break;
                case 2:
                    if (Guess3.Text.Length > 0) // check if the text box is not empty
                    {
                        Guess3.Text = Guess3.Text.Substring(0, Guess3.Text.Length - 1); // remove the last character
                    }
                    break;
                case 3:
                    if (Guess4.Text.Length > 0) // check if the text box is not empty
                    {
                        Guess4.Text = Guess4.Text.Substring(0, Guess4.Text.Length - 1); // remove the last character
                    }
                    break;
                case 4:
                    if (Guess5.Text.Length > 0) // check if the text box is not empty
                    {
                        Guess5.Text = Guess5.Text.Substring(0, Guess5.Text.Length - 1); // remove the last character
                    }
                    break;
                case 5:
                    if (GuessFinal.Text.Length > 0) // check if the text box is not empty
                    {
                        GuessFinal.Text = GuessFinal.Text.Substring(0, GuessFinal.Text.Length - 1); // remove the last character
                    }
                    break;
                default:
                    break;
            }
        }
        private void Guess1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guess5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuessFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvalidWordMessage_Click(object sender, EventArgs e)
        {

        }

        private void WordleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
