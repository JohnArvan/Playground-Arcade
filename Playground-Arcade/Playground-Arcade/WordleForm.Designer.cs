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
        }

        #endregion

        private Button GenerateWord;
        private Label labelRandomWord;
    }
}