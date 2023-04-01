namespace Playground_Arcade
{
    partial class WordleForm
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
<<<<<<< Updated upstream
            GenerateWord = new Button();
            labelRandomWord = new Label();
            SuspendLayout();
            // 
            // GenerateWord
            // 
            GenerateWord.Location = new Point(393, 177);
            GenerateWord.Name = "GenerateWord";
            GenerateWord.Size = new Size(71, 28);
            GenerateWord.TabIndex = 0;
            GenerateWord.Text = "Generate word";
            GenerateWord.UseVisualStyleBackColor = true;
            GenerateWord.Click += GenerateWord_Click;
            // 
            // labelRandomWord
            // 
            labelRandomWord.AutoSize = true;
            labelRandomWord.Location = new Point(372, 231);
            labelRandomWord.Name = "labelRandomWord";
            labelRandomWord.Size = new Size(123, 15);
            labelRandomWord.TabIndex = 1;
            labelRandomWord.Text = "Word to be Generated";
            labelRandomWord.Visible = false;
            // 
            // WordleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRandomWord);
            Controls.Add(GenerateWord);
            Name = "WordleForm";
            Text = "WordleForm";
            Load += WordleForm_Load;
            ResumeLayout(false);
            PerformLayout();
=======
            this.Guess1 = new System.Windows.Forms.RichTextBox();
            this.Q = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guess1
            // 
            this.Guess1.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guess1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Guess1.Location = new System.Drawing.Point(222, 12);
            this.Guess1.MaxLength = 5;
            this.Guess1.Name = "Guess1";
            this.Guess1.Size = new System.Drawing.Size(170, 55);
            this.Guess1.TabIndex = 0;
            this.Guess1.Text = "APPLE";
            this.Guess1.TextChanged += new System.EventHandler(this.Guess1_TextChanged);
            // 
            // Q
            // 
            this.Q.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Q.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(100, 230);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(29, 32);
            this.Q.TabIndex = 1;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = false;
            this.Q.Click += new System.EventHandler(this.Q_Click);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.W.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.Location = new System.Drawing.Point(135, 230);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(29, 32);
            this.W.TabIndex = 2;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = false;
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(170, 230);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(29, 32);
            this.E.TabIndex = 3;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = false;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.R.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(205, 230);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(29, 32);
            this.R.TabIndex = 4;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = false;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // T
            // 
            this.T.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.T.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(240, 230);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(29, 32);
            this.T.TabIndex = 5;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = false;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Y.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.Location = new System.Drawing.Point(275, 230);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(29, 32);
            this.Y.TabIndex = 6;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = false;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // U
            // 
            this.U.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.U.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U.Location = new System.Drawing.Point(310, 230);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(29, 32);
            this.U.TabIndex = 7;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = false;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // I
            // 
            this.I.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.I.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(345, 230);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(29, 32);
            this.I.TabIndex = 8;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = false;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // O
            // 
            this.O.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.O.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(380, 230);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(29, 32);
            this.O.TabIndex = 9;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = false;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(415, 230);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(29, 32);
            this.P.TabIndex = 10;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = false;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(118, 262);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(29, 32);
            this.A.TabIndex = 11;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(153, 262);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(29, 32);
            this.S.TabIndex = 12;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = false;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.D.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(188, 262);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(29, 32);
            this.D.TabIndex = 13;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.F.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(223, 262);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(29, 32);
            this.F.TabIndex = 14;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = false;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.G.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(258, 262);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(29, 32);
            this.G.TabIndex = 15;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = false;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.H.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(293, 262);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(29, 32);
            this.H.TabIndex = 16;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = false;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // J
            // 
            this.J.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.J.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J.Location = new System.Drawing.Point(328, 262);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(29, 32);
            this.J.TabIndex = 17;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = false;
            this.J.Click += new System.EventHandler(this.J_Click);
            // 
            // K
            // 
            this.K.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K.Location = new System.Drawing.Point(363, 262);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(29, 32);
            this.K.TabIndex = 18;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = false;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.Location = new System.Drawing.Point(398, 262);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(29, 32);
            this.L.TabIndex = 19;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = false;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // Z
            // 
            this.Z.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Z.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z.Location = new System.Drawing.Point(135, 294);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(29, 32);
            this.Z.TabIndex = 20;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = false;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(170, 294);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(29, 32);
            this.X.TabIndex = 21;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(205, 294);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(29, 32);
            this.C.TabIndex = 22;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.V.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(240, 294);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(29, 32);
            this.V.TabIndex = 23;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = false;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(275, 294);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 32);
            this.B.TabIndex = 24;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.N.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(310, 294);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(29, 32);
            this.N.TabIndex = 25;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = false;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.M.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(345, 294);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(29, 32);
            this.M.TabIndex = 26;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = false;
            this.M.Click += new System.EventHandler(this.M_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(380, 294);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 32);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(85, 294);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(44, 32);
            this.Enter.TabIndex = 28;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.M);
            this.Controls.Add(this.N);
            this.Controls.Add(this.B);
            this.Controls.Add(this.V);
            this.Controls.Add(this.C);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.I);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.T);
            this.Controls.Add(this.R);
            this.Controls.Add(this.E);
            this.Controls.Add(this.W);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.Guess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

>>>>>>> Stashed changes
        }

        #endregion

<<<<<<< Updated upstream
        private Button GenerateWord;
        private Label labelRandomWord;
=======
        private System.Windows.Forms.RichTextBox Guess1;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Enter;
>>>>>>> Stashed changes
    }
}

