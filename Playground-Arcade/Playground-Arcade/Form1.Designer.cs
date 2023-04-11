namespace Playground_Arcade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WordleButton = new System.Windows.Forms.Button();
            this.CheckersButton = new System.Windows.Forms.Button();
            this.SolitaireButton = new System.Windows.Forms.Button();
            this.OthelloButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.TitleLabel.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TitleLabel.Location = new System.Drawing.Point(409, 63);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(493, 67);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Playground Arcade";
            // 
            // WordleButton
            // 
            this.WordleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WordleButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.WordleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordleButton.Font = new System.Drawing.Font("HP Simplified", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordleButton.Location = new System.Drawing.Point(357, 180);
            this.WordleButton.Name = "WordleButton";
            this.WordleButton.Size = new System.Drawing.Size(266, 113);
            this.WordleButton.TabIndex = 1;
            this.WordleButton.Text = "Wordle";
            this.WordleButton.UseVisualStyleBackColor = false;
            this.WordleButton.Click += new System.EventHandler(this.WordleButton_Click);
            // 
            // CheckersButton
            // 
            this.CheckersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckersButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CheckersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckersButton.Font = new System.Drawing.Font("HP Simplified", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckersButton.Location = new System.Drawing.Point(697, 180);
            this.CheckersButton.Name = "CheckersButton";
            this.CheckersButton.Size = new System.Drawing.Size(266, 113);
            this.CheckersButton.TabIndex = 2;
            this.CheckersButton.Text = "Checkers";
            this.CheckersButton.UseVisualStyleBackColor = false;
            this.CheckersButton.Click += new System.EventHandler(this.CheckersButton_Click);
            // 
            // SolitaireButton
            // 
            this.SolitaireButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SolitaireButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SolitaireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolitaireButton.Font = new System.Drawing.Font("HP Simplified", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolitaireButton.Location = new System.Drawing.Point(357, 349);
            this.SolitaireButton.Name = "SolitaireButton";
            this.SolitaireButton.Size = new System.Drawing.Size(266, 113);
            this.SolitaireButton.TabIndex = 3;
            this.SolitaireButton.Text = "Solitaire";
            this.SolitaireButton.UseVisualStyleBackColor = false;
            this.SolitaireButton.Click += new System.EventHandler(this.SolitaireButton_Click);
            // 
            // OthelloButton
            // 
            this.OthelloButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OthelloButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.OthelloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OthelloButton.Font = new System.Drawing.Font("HP Simplified", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OthelloButton.Location = new System.Drawing.Point(697, 349);
            this.OthelloButton.Name = "OthelloButton";
            this.OthelloButton.Size = new System.Drawing.Size(266, 113);
            this.OthelloButton.TabIndex = 4;
            this.OthelloButton.Text = "Othello";
            this.OthelloButton.UseVisualStyleBackColor = false;
            this.OthelloButton.Click += new System.EventHandler(this.OthelloButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("HP Simplified", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(572, 514);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 59);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1241, 634);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OthelloButton);
            this.Controls.Add(this.SolitaireButton);
            this.Controls.Add(this.CheckersButton);
            this.Controls.Add(this.WordleButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Button WordleButton;
        private Button CheckersButton;
        private Button SolitaireButton;
        private Button OthelloButton;
        private Button ExitButton;
    }
}