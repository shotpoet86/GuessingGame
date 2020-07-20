//Programmer: Austin Parker
//Date: May 20,2020
//Purpose: Creates a guessing game where users can input any number
//of guesses and colors change based on user input.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {

        //Global variables for guess count and guess number
        private static int guessCount = 0;
        private static int guessNumber = 0;
        public GuessingGame()
        {
            InitializeComponent();

            //This will show the hint when opening the application
            if (guessCount <= 0)
            {
                MessageBox.Show("Hint: The guess number is between 0 and 101");

                Random randNum = new Random();
                //Random number between 1 to 100
                guessNumber = randNum.Next(0, 101);
            }
        }

        //Guess button click event
        private void btnGuess_Click(object sender, EventArgs e)
        {
            //calls guess number method
            GuessNumber();
        }

        //Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets all the inputs of the application
            txtGuessNumber.Text = string.Empty;
            lblGuessCount.Text = "0";
            this.BackColor = Color.Empty;
            guessCount = 0;
            guessNumber = 0;
        }

        //The method for guessing the number
        private void GuessNumber()
        {
            int numberGuess;

            //This will only proocess if user enters a valid number
            if (int.TryParse(txtGuessNumber.Text, out numberGuess))
            {
                guessCount++;

                //If number is higher than the random number, shows light blue background
                if (numberGuess > guessNumber)
                {
                    this.BackColor = Color.LightBlue;
                }
                //If number is lower than the random number, shows light red background
                else if (numberGuess < guessNumber)
                {
                    this.BackColor = Color.PaleVioletRed;
                }
                //Displays green when user enters correct number
                else if (numberGuess == guessNumber)
                {
                    this.BackColor = Color.LightGreen;
                    MessageBox.Show("You guessed the correct number! " + guessNumber);
                }

                //Display total number of guesses
                lblGuessCount.Text = guessCount.ToString();
            }
            //Alert for non valid number 
            else
            {
                MessageBox.Show("Enter a valid number!");
            }
        }
    }
}
