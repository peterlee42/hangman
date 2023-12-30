using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class hangman : Form
    {
        // Create global string list to store words.
        List<string> WordBank = new List<string>();
        // Declare random number generator.
        Random randomGenerator = new Random();
        // Initialize secret word and hCounter (hang stage counter).
        string SecretWord = "";
        int hCounter = 0;
        // Declare list of used letters.
        List<string> usedLetters = new List<string>();

        public void ClearAll()
        {
            // Clears and resets everything.
            txtOutput.Clear();
            txtWrongLetters.Clear();
            usedLetters.Clear();
            txtGuessWord.Clear();
            cbxGuess.SelectedIndex = 0;
            pbHangman.BackgroundImage = Image.FromFile("0.jpg");
            hCounter = 0;
            SecretWord = "";
        }

        public hangman()
        {
            InitializeComponent();
            // Set picturebox image to 
            pbHangman.BackgroundImage = Image.FromFile("0.jpg");

            // Select first item in letters combobox.
            cbxGuess.SelectedIndex = 0;

            // Read words.txt and add it to a array lines.
            string[] lines = System.IO.File.ReadAllLines("words.txt");

            // For each line in lines, add line to WordBank.
            //foreach (string line in lines)
            //{
            //WordBank.Add(line);
            //}
            WordBank.Add("peterlee");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                // Set background image to 0.jpg.
                pbHangman.BackgroundImage = Image.FromFile("0.jpg");

                // Declare RandomIndex and i. Declare and set underscores variable to empty strings.
                int RandomIndex, i;
                string underscores = "";

                // Set selected index to first item. Set hCounter to 0.
                cbxGuess.SelectedIndex = 0;
                hCounter = 0;

                // Clear usedLetters and txtWrongLetters.
                usedLetters.Clear();
                txtWrongLetters.Clear();

                // Get random index from 0 to the total items in WordBank. Set secret word to the RandomIndex of WordBank.
                RandomIndex = randomGenerator.Next(0, WordBank.Count-1);
                SecretWord = WordBank[RandomIndex];

                // Loop from 0 to the length of secretWord and add "-" to underscores every time.
                for (i = 0; i < SecretWord.Length; i++)
                {
                    underscores += "-";
                }

                // Output underscores to txtOutput.
                txtOutput.Text = underscores;
            }
            catch
            {
                // Clear all and give message
                ClearAll();
                MessageBox.Show("ERROR. PLEASE CONTACT DEVELOPERS!");
            }
        }

        private void btnGuessLetter_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables.
                string LetterGuess;
                int i, j;
                string underscores;
                // Declare boolean value to check if guess is correct.
                bool correctGuess = false;

                // Set variables to corresponding textboxes
                underscores = txtOutput.Text;
                LetterGuess = cbxGuess.Text;

                if (SecretWord == "")//If secret word has not been assigned, give error.
                {
                    MessageBox.Show("Please start a new game.");
                    return;
                }
                for (j = 0; j < usedLetters.Count; j++) // Checks if letters have been used
                {
                    if (LetterGuess == usedLetters[j])
                    {
                        MessageBox.Show("You already used this letter.");
                        return;
                    }
                }

                // Adds LetterGuess to usedLetters
                usedLetters.Add(LetterGuess);

                // Loops through SecretWord
                for (i = 0; i < SecretWord.Length; i++)
                {
                    //Current letter
                    string currentchar = SecretWord.Substring(i, 1);

                    if (currentchar == LetterGuess) //Checks if letter is in the word
                    {
                        correctGuess = true;
                        underscores = underscores.Remove(i, 1).Insert(i, LetterGuess);
                        txtOutput.Text = underscores;
                        if(underscores == SecretWord) //Checks if all letters have been correctly guessed and gives message.
                        {
                            MessageBox.Show("You won!");
                            ClearAll();
                            return;
                        }
                    }
                }
                // If guess is incorrect
                if(correctGuess == false)
                {
                    // Add one to hCounter. If it's equal to 6 (the last stage), end game.
                    hCounter++;
                    if (hCounter == 6)
                    { //GAME LOST
                        
                        pbHangman.BackgroundImage = Image.FromFile(hCounter.ToString() + ".jpg");
                        MessageBox.Show("Game over! The word was " + SecretWord + "!");
                        ClearAll();
                    }
                    // Else, add LetterGuess to wrongLetters textbox and sets picturebox to next stage
                    else
                    {
                        txtWrongLetters.Text += LetterGuess + ", ";
                        pbHangman.BackgroundImage = Image.FromFile(hCounter.ToString() + ".jpg");
                    }
                }
            }
            catch
            {
                // Clear all and give message
                ClearAll();
                MessageBox.Show("ERROR. PLEASE CONTACT DEVELOPERS!");
            }

        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecretWord == "")//if secret word has not been assigned, give error message
                {
                    MessageBox.Show("Please start a new game before quitting.");
                    return;
                }
                // Set picturebox to red image and give message
                pbHangman.BackgroundImage = Image.FromFile("Red_Color.jpg");
                MessageBox.Show("L. The word was " + SecretWord + ".");

                // Force close appication
                System.Windows.Forms.Application.ExitThread();
            }

            catch
            {
                // Clear all and give message
                ClearAll();
                MessageBox.Show("ERROR. PLEASE CONTACT DEVELOPERS!");
            }
        }

        private void btnGuessWord_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares guessword.
                string guessWord = txtGuessWord.Text.Trim();

                // Error if secret word has not been assigned.
                if (SecretWord == "")
                {
                    MessageBox.Show("Please start a new game.");
                    return;
                }
                // Error if guessword has not been assigned.
                else if (guessWord == "")
                {
                    MessageBox.Show("ERROR: Please input a word.");
                    txtGuessWord.Clear();
                    return;
                }
                else if (guessWord.Any(Char.IsDigit))
                {
                    MessageBox.Show("ERROR: Letters only.");
                    return;
                }

                // If GuessWord is equal to SecretWord, output word and give message.
                if (guessWord == SecretWord)
                {
                    txtOutput.Text = guessWord;
                    MessageBox.Show("You won!");
                }
                // Else set picturebox to last stage of hangman and give message.
                else
                {
                    pbHangman.BackgroundImage = Image.FromFile("7.jpg");
                    MessageBox.Show("Game over! The word was " + SecretWord + "!");
                }
                // Clear all
                ClearAll();
            }
            catch
            {
                // Clear all and give message
                ClearAll();
                MessageBox.Show("ERROR. PLEASE CONTACT DEVELOPERS!");
            }
        }
    }
}
