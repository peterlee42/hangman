namespace Hangman
{
    partial class hangman
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGuess = new System.Windows.Forms.ComboBox();
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGuessLetter = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.txtWrongLetters = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuessWord = new System.Windows.Forms.Button();
            this.txtGuessWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letter";
            // 
            // cbxGuess
            // 
            this.cbxGuess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGuess.FormattingEnabled = true;
            this.cbxGuess.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.cbxGuess.Location = new System.Drawing.Point(50, 74);
            this.cbxGuess.Name = "cbxGuess";
            this.cbxGuess.Size = new System.Drawing.Size(48, 21);
            this.cbxGuess.TabIndex = 1;
            // 
            // pbHangman
            // 
            this.pbHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHangman.Location = new System.Drawing.Point(152, 12);
            this.pbHangman.Name = "pbHangman";
            this.pbHangman.Size = new System.Drawing.Size(202, 282);
            this.pbHangman.TabIndex = 3;
            this.pbHangman.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(129, 48);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGuessLetter
            // 
            this.btnGuessLetter.Location = new System.Drawing.Point(12, 101);
            this.btnGuessLetter.Name = "btnGuessLetter";
            this.btnGuessLetter.Size = new System.Drawing.Size(129, 48);
            this.btnGuessLetter.TabIndex = 2;
            this.btnGuessLetter.Text = "Guess Letter";
            this.btnGuessLetter.UseVisualStyleBackColor = true;
            this.btnGuessLetter.Click += new System.EventHandler(this.btnGuessLetter_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(12, 261);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(129, 33);
            this.btnGiveUp.TabIndex = 5;
            this.btnGiveUp.Text = "GIVE UP.";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // txtWrongLetters
            // 
            this.txtWrongLetters.Location = new System.Drawing.Point(12, 300);
            this.txtWrongLetters.Multiline = true;
            this.txtWrongLetters.Name = "txtWrongLetters";
            this.txtWrongLetters.ReadOnly = true;
            this.txtWrongLetters.Size = new System.Drawing.Size(129, 40);
            this.txtWrongLetters.TabIndex = 6;
            this.txtWrongLetters.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(152, 300);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(202, 40);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word";
            // 
            // btnGuessWord
            // 
            this.btnGuessWord.Location = new System.Drawing.Point(12, 207);
            this.btnGuessWord.Name = "btnGuessWord";
            this.btnGuessWord.Size = new System.Drawing.Size(129, 48);
            this.btnGuessWord.TabIndex = 4;
            this.btnGuessWord.Text = "Guess Word";
            this.btnGuessWord.UseVisualStyleBackColor = true;
            this.btnGuessWord.Click += new System.EventHandler(this.btnGuessWord_Click);
            // 
            // txtGuessWord
            // 
            this.txtGuessWord.Location = new System.Drawing.Point(12, 181);
            this.txtGuessWord.Name = "txtGuessWord";
            this.txtGuessWord.Size = new System.Drawing.Size(129, 20);
            this.txtGuessWord.TabIndex = 3;
            // 
            // hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.unknown;
            this.ClientSize = new System.Drawing.Size(369, 348);
            this.Controls.Add(this.txtGuessWord);
            this.Controls.Add(this.btnGuessWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtWrongLetters);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnGuessLetter);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbHangman);
            this.Controls.Add(this.cbxGuess);
            this.Controls.Add(this.label1);
            this.Name = "hangman";
            this.Text = "Hangman Video Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGuess;
        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGuessLetter;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.TextBox txtWrongLetters;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuessWord;
        private System.Windows.Forms.TextBox txtGuessWord;
    }
}

