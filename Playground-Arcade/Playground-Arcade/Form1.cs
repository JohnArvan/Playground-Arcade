namespace Playground_Arcade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WordleButton_Click(object sender, EventArgs e)
        {
            WordleForm wordleForm = new WordleForm();
            wordleForm.Show();
        }

        private void CheckersButton_Click(object sender, EventArgs e)
        {
            CheckersForm checkersForm = new CheckersForm();
            checkersForm.Show();
        }

        private void SolitaireButton_Click(object sender, EventArgs e)
        {
            SolitaireForm solitaireForm = new SolitaireForm();
            solitaireForm.Show();
        }

        private void OthelloButton_Click(object sender, EventArgs e)
        {
            OthelloForm othelloForm = new OthelloForm();
            othelloForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}