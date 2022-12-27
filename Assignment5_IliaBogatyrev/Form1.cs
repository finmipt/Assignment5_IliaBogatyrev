using System;

namespace Assignment5_IliaBogatyrev
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int randomNumber = 0;
        int numGuesses = 0;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the user's guess
            int guess = Convert.ToInt32(textBox1.Text);

            // Compare the guess to the random number
            if (guess > randomNumber)
            {
                label2.Text = "Too high, try again.";
            }
            else if (guess < randomNumber)
            {
                label2.Text = "Too low, try again.";
            }
            else
            {
                label2.Text = "Congratulations! \n You guessed the correct number in " + numGuesses + " guesses.";

                // Generate a new random number
                randomNumber = rnd.Next(1, 101);

                // Reset the number of guesses
                numGuesses = 0;
            }

            // Increment the number of guesses
            numGuesses++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int numGuesses = 0;
            button1.Visible = true;
            label2.Text = "New game has come)";

        }
    }
}