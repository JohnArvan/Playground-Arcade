using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string WordToGuess()
        {
            int index = random.Next(words.Length);
            return words[index];
        }

        private void Q_Click(object sender, EventArgs e)
        {
            string letter = "Q";
            Guess1.AppendText(letter);
        }

        private void W_Click(object sender, EventArgs e)
        {
            string letter = "W";
            Guess1.AppendText(letter);
        }

        private void E_Click(object sender, EventArgs e)
        {
            string letter = "E";
            Guess1.AppendText(letter);
        }

        private void R_Click(object sender, EventArgs e)
        {
            string letter = "R";
            Guess1.AppendText(letter);
        }

        private void T_Click(object sender, EventArgs e)
        {
            string letter = "T";
            Guess1.AppendText(letter);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            string letter = "Y";
            Guess1.AppendText(letter);
        }

        private void U_Click(object sender, EventArgs e)
        {
            string letter = "U";
            Guess1.AppendText(letter);
        }

        private void I_Click(object sender, EventArgs e)
        {
            string letter = "I";
            Guess1.AppendText(letter);
        }

        private void O_Click(object sender, EventArgs e)
        {
            string letter = "O";
            Guess1.AppendText(letter);
        }

        private void P_Click(object sender, EventArgs e)
        {
            string letter = "P";
            Guess1.AppendText(letter);
        }

        private void A_Click(object sender, EventArgs e)
        {
            string letter = "A";
            Guess1.AppendText(letter);
        }

        private void S_Click(object sender, EventArgs e)
        {
            string letter = "S";
            Guess1.AppendText(letter);
        }

        private void D_Click(object sender, EventArgs e)
        {
            string letter = "D";
            Guess1.AppendText(letter);
        }

        private void F_Click(object sender, EventArgs e)
        {
            string letter = "F";
            Guess1.AppendText(letter);
        }

        private void G_Click(object sender, EventArgs e)
        {
            string letter = "G";
            Guess1.AppendText(letter);
        }

        private void H_Click(object sender, EventArgs e)
        {
            string letter = "H";
            Guess1.AppendText(letter);
        }

        private void J_Click(object sender, EventArgs e)
        {
            string letter = "J";
            Guess1.AppendText(letter);
        }

        private void K_Click(object sender, EventArgs e)
        {
            string letter = "K";
            Guess1.AppendText(letter);
        }

        private void L_Click(object sender, EventArgs e)
        {
            string letter = "L";
            Guess1.AppendText(letter);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            string letter = "Z";
            Guess1.AppendText(letter);
        }

        private void X_Click(object sender, EventArgs e)
        {
            string letter = "X";
            Guess1.AppendText(letter);
        }

        private void C_Click(object sender, EventArgs e)
        {
            string letter = "C";
            Guess1.AppendText(letter);
        }

        private void V_Click(object sender, EventArgs e)
        {
            string letter = "V";
            Guess1.AppendText(letter);
        }

        private void B_Click(object sender, EventArgs e)
        {
            string letter = "B";
            Guess1.AppendText(letter);
        }

        private void N_Click(object sender, EventArgs e)
        {
            if (Guess1.Text.Length < 5)
            {
                string letter = "N";
                Guess1.AppendText(letter);
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            string letter = "M";
            Guess1.AppendText(letter);
        }

        private void Enter_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Guess1.Text.Length > 0) // check if the text box is not empty
            {
                Guess1.Text = Guess1.Text.Substring(0, Guess1.Text.Length - 1); // remove the last character
            }
        }
        private void Guess1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
