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
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(230, 47);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(304, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Playground Arcade";
            // 
            // WordleButton
            // 
            this.WordleButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordleButton.Location = new System.Drawing.Point(132, 150);
            this.WordleButton.Name = "WordleButton";
            this.WordleButton.Size = new System.Drawing.Size(171, 55);
            this.WordleButton.TabIndex = 1;
            this.WordleButton.Text = "Wordle";
            this.WordleButton.UseVisualStyleBackColor = true;
            this.WordleButton.Click += new System.EventHandler(this.WordleButton_Click);
            // 
            // CheckersButton
            // 
            this.CheckersButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckersButton.Location = new System.Drawing.Point(459, 150);
            this.CheckersButton.Name = "CheckersButton";
            this.CheckersButton.Size = new System.Drawing.Size(171, 55);
            this.CheckersButton.TabIndex = 2;
            this.CheckersButton.Text = "Checkers";
            this.CheckersButton.UseVisualStyleBackColor = true;
            this.CheckersButton.Click += new System.EventHandler(this.CheckersButton_Click);
            // 
            // SolitaireButton
            // 
            this.SolitaireButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolitaireButton.Location = new System.Drawing.Point(132, 235);
            this.SolitaireButton.Name = "SolitaireButton";
            this.SolitaireButton.Size = new System.Drawing.Size(171, 55);
            this.SolitaireButton.TabIndex = 3;
            this.SolitaireButton.Text = "Solitaire";
            this.SolitaireButton.UseVisualStyleBackColor = true;
            this.SolitaireButton.Click += new System.EventHandler(this.SolitaireButton_Click);
            // 
            // OthelloButton
            // 
            this.OthelloButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OthelloButton.Location = new System.Drawing.Point(459, 235);
            this.OthelloButton.Name = "OthelloButton";
            this.OthelloButton.Size = new System.Drawing.Size(171, 55);
            this.OthelloButton.TabIndex = 4;
            this.OthelloButton.Text = "Othello";
            this.OthelloButton.UseVisualStyleBackColor = true;
            this.OthelloButton.Click += new System.EventHandler(this.OthelloButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OthelloButton);
            this.Controls.Add(this.SolitaireButton);
            this.Controls.Add(this.CheckersButton);
            this.Controls.Add(this.WordleButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Button WordleButton;
        private Button CheckersButton;
        private Button SolitaireButton;
        private Button OthelloButton;
    }
}