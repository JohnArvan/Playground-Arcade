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
            this.G = new System.Windows.Forms.Panel();
            this.labelp1 = new System.Windows.Forms.Label();
            this.labelp2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblP1S = new System.Windows.Forms.Label();
            this.lblP2S = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(484, 484);
            this.G.TabIndex = 0;
            // 
            // labelp1
            // 
            this.labelp1.AutoSize = true;
            this.labelp1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp1.ForeColor = System.Drawing.Color.Blue;
            this.labelp1.Location = new System.Drawing.Point(753, 47);
            this.labelp1.Name = "labelp1";
            this.labelp1.Size = new System.Drawing.Size(35, 37);
            this.labelp1.TabIndex = 3;
            this.labelp1.Text = "0";
            // 
            // labelp2
            // 
            this.labelp2.AutoSize = true;
            this.labelp2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp2.ForeColor = System.Drawing.Color.Red;
            this.labelp2.Location = new System.Drawing.Point(753, 420);
            this.labelp2.Name = "labelp2";
            this.labelp2.Size = new System.Drawing.Size(35, 37);
            this.labelp2.TabIndex = 4;
            this.labelp2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(508, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 2 Total Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(508, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 1 Total Wins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(569, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue Collected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(580, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Red Collected";
            // 
            // lblP1S
            // 
            this.lblP1S.AutoSize = true;
            this.lblP1S.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1S.ForeColor = System.Drawing.Color.Red;
            this.lblP1S.Location = new System.Drawing.Point(752, 10);
            this.lblP1S.Name = "lblP1S";
            this.lblP1S.Size = new System.Drawing.Size(35, 37);
            this.lblP1S.TabIndex = 9;
            this.lblP1S.Text = "0";
            // 
            // lblP2S
            // 
            this.lblP2S.AutoSize = true;
            this.lblP2S.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2S.ForeColor = System.Drawing.Color.Blue;
            this.lblP2S.Location = new System.Drawing.Point(752, 457);
            this.lblP2S.Name = "lblP2S";
            this.lblP2S.Size = new System.Drawing.Size(35, 37);
            this.lblP2S.TabIndex = 10;
            this.lblP2S.Text = "0";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(531, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 68);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Player 1\'s Turn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(536, 231);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(195, 29);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // CheckersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblP2S);
            this.Controls.Add(this.lblP1S);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelp2);
            this.Controls.Add(this.labelp1);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Checkers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

