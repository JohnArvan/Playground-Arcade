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

        private void WordleForm_Load(object sender, EventArgs e)
        {

        }

        private void GenerateWord_Click(object sender, EventArgs e)
        {
            // Define an array of words
            string[] words = { "apple", "banana", "cherry", "grape", "orange", "pear", "pineapple", "strawberry", "watermelon" };

            // Generate a random word from the array
            Random rand = new Random();
            string randomWord = words[rand.Next(words.Length)];

            // Display the random word in a Label control
            labelRandomWord.Text = randomWord;
        }
    }
}
