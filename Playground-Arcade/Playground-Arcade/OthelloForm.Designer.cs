namespace Othello
{
    partial class OthelloForm
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
            this.pnl_board = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_humanScore = new System.Windows.Forms.Label();
            this.lbl_cpuScore = new System.Windows.Forms.Label();
            this.lbl_human = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_board
            // 
            this.pnl_board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_board.Location = new System.Drawing.Point(9, 12);
            this.pnl_board.Name = "pnl_board";
            this.pnl_board.Size = new System.Drawing.Size(318, 297);
            this.pnl_board.TabIndex = 0;
            this.pnl_board.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnl_board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(333, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(159, 151);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "RESET BOARD/SCORE";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_humanScore
            // 
            this.lbl_humanScore.AutoSize = true;
            this.lbl_humanScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_humanScore.Location = new System.Drawing.Point(473, 195);
            this.lbl_humanScore.Name = "lbl_humanScore";
            this.lbl_humanScore.Size = new System.Drawing.Size(19, 20);
            this.lbl_humanScore.TabIndex = 2;
            this.lbl_humanScore.Text = "0";
            // 
            // lbl_cpuScore
            // 
            this.lbl_cpuScore.AutoSize = true;
            this.lbl_cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_cpuScore.Location = new System.Drawing.Point(473, 245);
            this.lbl_cpuScore.Name = "lbl_cpuScore";
            this.lbl_cpuScore.Size = new System.Drawing.Size(19, 20);
            this.lbl_cpuScore.TabIndex = 3;
            this.lbl_cpuScore.Text = "0";
            // 
            // lbl_human
            // 
            this.lbl_human.AutoSize = true;
            this.lbl_human.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_human.Location = new System.Drawing.Point(329, 195);
            this.lbl_human.Name = "lbl_human";
            this.lbl_human.Size = new System.Drawing.Size(127, 20);
            this.lbl_human.TabIndex = 4;
            this.lbl_human.Text = "Human (Black)";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_cpu.Location = new System.Drawing.Point(333, 245);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(108, 20);
            this.lbl_cpu.TabIndex = 5;
            this.lbl_cpu.Text = "CPU (White)";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 383);
            this.Controls.Add(this.lbl_cpu);
            this.Controls.Add(this.lbl_human);
            this.Controls.Add(this.lbl_cpuScore);
            this.Controls.Add(this.lbl_humanScore);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pnl_board);
            this.Name = "Form";
            this.Text = "Othello";
            this.Load += new System.EventHandler(this.load_form);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paint_form);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_board;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_humanScore;
        private System.Windows.Forms.Label lbl_cpuScore;
        private System.Windows.Forms.Label lbl_human;
        private System.Windows.Forms.Label lbl_cpu;
    }
}