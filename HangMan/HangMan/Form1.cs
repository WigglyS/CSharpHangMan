using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangManMainWindow : Form
    {
        HangManGame game;

        List<Label> lettersInWord =  new List<Label>();
        List<Label> lettersToRemove = new List<Label>();
        List<Label> GuessedLettersLabels = new List<Label>();
        List<Label> UnderScoreLables = new List<Label>();

        public HangManMainWindow()
        {
            InitializeComponent();
            game = new HangManGame();
        }

        private void StartGame(object sender, EventArgs e)
        {

            pnlUsedLetters.Visible = true;
            pnlWord.Visible = true;
            pnlLives.Visible = true;
            btnStart.Visible = false;

            lblInstructions.Text = "Guess a letter";
            SetUpWord();
            UpdateLivesText();
        }

        private void SetUpWord()
        {
            
            for (int i = 0; i <game.CurrentWord.Length ; i++)
            {
                Label letter = new Label();
                letter.Size = new Size(20, 20);
                letter.Font = new Font("Serif", 12, FontStyle.Regular);

                letter.Text = " ";
                lettersInWord.Add(letter);
                flowLayLetters.Controls.Add(letter);

                Label underScore = new Label();
                underScore.Size = new Size(20, 20);
                underScore.Font = new Font("Serif", 12, FontStyle.Regular);
                underScore.Text = "--";
                UnderScoreLables.Add(underScore);
                flowLayUnderLines.Controls.Add(underScore);
                //tableLayLettersAndSpaces.Controls.Add(letter);
            }
            
        }

        /// <summary>
        /// chechs the users input and gives them feed back if they were right or wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckInput(object sender, EventArgs e)
        {
            string message = "";

            if (txbUserInput.Text.Length > 0)
            {
                char guessedChar = txbUserInput.Text[0];

               
                List<int> indexs = game.CheckLetter( guessedChar, out message);

                if(indexs.Count > 0)
                {
                    foreach (var index in indexs)
                    {
                        lettersInWord[index].Text = guessedChar.ToString().ToUpper();
                    }
                }
               
            }

            UpdateLivesText();

            if (game.CheckWord(ConvertLablestoString()))
            {
                DoWin();
            }
            if (game.Lives <= 0)
            {
                DoGameOver();
            }

            lblInstructions.Text = message;
            UpdateUsedLetter();

            txbUserInput.Clear();
        }

        /// <summary>
        /// refreshes the letters in the Guessed letters display
        /// </summary>
        private void UpdateUsedLetter()
        {
            foreach (var label in GuessedLettersLabels)
            {
                label.Dispose();
            }

            foreach (var c in game.GuessedCharacters)
            {
                Label letter = new Label();
                letter.Size = new Size(20, 20);
                letter.Font = new Font("Serif", 12, FontStyle.Regular);

                letter.Text = c.ToString().ToUpper();
                GuessedLettersLabels.Add(letter);
                flowLayUsedLetters.Controls.Add(letter);
            }
        }


        /// <summary>
        /// handles game over
        /// 
        /// </summary>
        private void DoGameOver()
        {
            string message = "You lost would you like to try again?";
            string title = "Try Again?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }
        private void DoWin()
        {
            string message = "You won would you like to play again?";
            string title = "PlayAgain?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }

        private void ResetGame(object sender, EventArgs e)
        {
            ResetGame();
        }
        /// <summary>
        /// starts the game over with a new word
        /// </summary>
        private void ResetGame()
        {

            lblInstructions.Text = "Guess a letter";

            foreach (var label in GuessedLettersLabels)
            {
                label.Dispose();
            }
            foreach (var label in lettersInWord)
            {
               
                lettersToRemove.Add(label);
            }
            foreach (var label in UnderScoreLables)
            {
                label.Dispose();
            }

            destroyLables();
            game.Reset();
            UpdateLivesText();
            
            SetUpWord();

            
            
        }
        void destroyLables()
        {
            foreach (var lable in lettersToRemove)
            {
                lettersInWord.Remove(lable);
                lable.Dispose();
            }

        }

        /// <summary>
        /// converts the text on the labes to one long string to check the word
        /// </summary>
        /// <returns></returns>
        string ConvertLablestoString()
        {
            string word = "";
            foreach (var label in lettersInWord)
            {
               word += label.Text;
            }

            return word;
        }


        void UpdateLivesText()
        {
            lblLives.Text = "Lives : " + game.Lives;
        }
    }

}
