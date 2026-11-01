using System;
using System.Windows.Forms;

namespace Hw3_3
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int timeLeft;
        private Random randomGenerator = new Random();

        public Form1()
        {
            InitializeComponent();

            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(gameTimer_Tick);

            btnStart.Click += new EventHandler(btnStart_Click);
            txtGuess.Click += new EventHandler(btnGuess_Click);

            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            targetNumber = randomGenerator.Next(1, 11);
            timeLeft = 10;
            lblTimer.Text = $"... {timeLeft} seconds left";

            btnStart.Enabled = false;
            txtGuess.Enabled = true;
            txtGuess.Text = "";

            gameTimer.Start();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int userGuess))
            {
                if (userGuess == targetNumber)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Correct! That is the right answer. Play again?");
                    ResetGame();
                }
                else
                {
                    gameTimer.Stop();
                    MessageBox.Show("Wrong number! Let's start again.");
                    ResetGame();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"... {timeLeft} seconds left";

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time is up! You can try again.");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            btnStart.Enabled = true;
            txtGuess.Enabled = false;
            txtGuess.Text = "";
            lblTimer.Text = "... waiting to start";
        }
    }
}