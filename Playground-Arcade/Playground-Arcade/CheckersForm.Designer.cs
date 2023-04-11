namespace Playground_Arcade
{
    partial class CheckersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            G = new Panel();
            labelp1 = new Label();
            labelp2 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblP1S = new Label();
            lblP2S = new Label();
            lblStatus = new Label();
            btnExit = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // G
            // 
            G.BackColor = Color.Gray;
            G.Location = new Point(12, 12);
            G.Margin = new Padding(4, 3, 4, 3);
            G.Name = "G";
            G.Size = new Size(565, 558);
            G.TabIndex = 0;
            // 
            // labelp1
            // 
            labelp1.AutoSize = true;
            labelp1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelp1.ForeColor = Color.Blue;
            labelp1.Location = new Point(878, 54);
            labelp1.Margin = new Padding(4, 0, 4, 0);
            labelp1.Name = "labelp1";
            labelp1.Size = new Size(35, 37);
            labelp1.TabIndex = 3;
            labelp1.Text = "0";
            // 
            // labelp2
            // 
            labelp2.AutoSize = true;
            labelp2.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelp2.ForeColor = Color.Red;
            labelp2.Location = new Point(878, 485);
            labelp2.Margin = new Padding(4, 0, 4, 0);
            labelp2.Name = "labelp2";
            labelp2.Size = new Size(35, 37);
            labelp2.TabIndex = 4;
            labelp2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(593, 539);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 24);
            label1.TabIndex = 5;
            label1.Text = "Player 2 Total Wins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(593, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 24);
            label2.TabIndex = 6;
            label2.Text = "Player 1 Total Wins";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(664, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 24);
            label3.TabIndex = 7;
            label3.Text = "Blue Collected";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(677, 496);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 24);
            label4.TabIndex = 8;
            label4.Text = "Red Collected";
            // 
            // lblP1S
            // 
            lblP1S.AutoSize = true;
            lblP1S.Font = new Font("Consolas", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblP1S.ForeColor = Color.Red;
            lblP1S.Location = new Point(877, 12);
            lblP1S.Margin = new Padding(4, 0, 4, 0);
            lblP1S.Name = "lblP1S";
            lblP1S.Size = new Size(35, 37);
            lblP1S.TabIndex = 9;
            lblP1S.Text = "0";
            // 
            // lblP2S
            // 
            lblP2S.AutoSize = true;
            lblP2S.Font = new Font("Consolas", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblP2S.ForeColor = Color.Blue;
            lblP2S.Location = new Point(877, 527);
            lblP2S.Margin = new Padding(4, 0, 4, 0);
            lblP2S.Name = "lblP2S";
            lblP2S.Size = new Size(35, 37);
            lblP2S.TabIndex = 10;
            lblP2S.Text = "0";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(620, 209);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 78);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Player 1's Turn";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(625, 307);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(227, 33);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(625, 267);
            btnRestart.Margin = new Padding(4, 3, 4, 3);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(227, 33);
            btnRestart.TabIndex = 13;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // CheckersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 597);
            Controls.Add(btnRestart);
            Controls.Add(btnExit);
            Controls.Add(lblStatus);
            Controls.Add(lblP2S);
            Controls.Add(lblP1S);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelp2);
            Controls.Add(labelp1);
            Controls.Add(G);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CheckersForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkers";
            Load += Checkers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.Label labelp1;
        private System.Windows.Forms.Label labelp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblP1S;
        private System.Windows.Forms.Label lblP2S;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}

