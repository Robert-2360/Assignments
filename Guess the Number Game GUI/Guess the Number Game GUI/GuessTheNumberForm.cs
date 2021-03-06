﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guess_the_Number_Game_GUI
{
   public partial class GuessTheNumberForm : Form
   {
      GuessTheNumber game = new GuessTheNumber(1, 1000);
      int previousGuess = Int32.MaxValue;
      string openningMessage = string.Format("{0}\n{1}",
         "I have a number between 1 and 1000--can you guess my number?",
         "Please enter your first guess in the box below. Then press Enter.");
      string againMessage = string.Format("{0}\n{1}",
         "Press the Play Again button",
         "or Close to quit");

      public GuessTheNumberForm()
      {
         InitializeComponent();
         statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         statusLabel.Text = openningMessage;
      }

      private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            int currentGuess = Convert.ToInt32(inputTextBox.Text);

            if (game.isCorrect(currentGuess))
            {
               this.BackColor = Color.LightGreen;
               playAgainButton.Visible = true;
               inputTextBox.Enabled = false;
               statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               statusLabel.Text = againMessage;
               MessageBox.Show(string.Format("Correct!\nIt took you {0} guess(es).", game.Counter));
            }

            else if (game.isLow(currentGuess))
            {
               statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               statusLabel.Text = string.Format("{0} is too LOW.", currentGuess);
            }

            else if (game.isHigh(currentGuess))
            {
               statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               statusLabel.Text = string.Format("{0} is too HIGH.", currentGuess);
            }

            inputTextBox.Text = "";

            if (game.isGettingCloser(currentGuess, previousGuess))
            {
               this.BackColor = Color.LightPink;
            }
            else
            {
               this.BackColor = Color.LightBlue;
            }

            previousGuess = currentGuess;
            game.Counter++;
         }
      }

      private void playAgainButton_Click(object sender, EventArgs e)
      {
         game.setSecretNumber();
         previousGuess = Int32.MaxValue;
         this.BackColor = Color.LightBlue;
         playAgainButton.Visible = false;
         inputTextBox.Enabled = true;
         inputTextBox.Focus();
         statusLabel.Text = openningMessage;
      }
   }
}
