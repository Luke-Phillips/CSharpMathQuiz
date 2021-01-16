using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // These integer variable keep track of time.
        int startTime = 30; // adjusted for smarties
        int timeLeft;

        /// <summary>
        /// Start the quiz by filling in all of the problem 
        /// values and starting the timer. 
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftOp.Text = addend1.ToString();
            plusRightOp.Text = addend2.ToString();

            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(2, 100);
            subtrahend = randomizer.Next(1, minuend);

            minusLeftOp.Text = minuend.ToString();
            minusRightOp.Text = subtrahend.ToString();

            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            multLeftOp.Text = multiplicand.ToString();
            multRightOp.Text = multiplier.ToString();

            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 10);
            dividend = divisor * temporaryQuotient;

            divLeftOp.Text = dividend.ToString();
            divRightOp.Text = divisor.ToString();
            
            quotient.Value = 0;

            // Start the timer.
            timeLeft = startTime;
            timeLeftLabel.Text = timeLeft + " seconds";
            timeLeftLabel.BackColor = Color.White;
            timeLeftLabel.ForeColor = Color.Black;
            timer1.Start();
        }
 
        private bool CheckSumAnswer()
        {
            return addend1 + addend2 == sum.Value;
        }
        private bool CheckDifferenceAnswer()
        {
            return minuend - subtrahend == difference.Value;
        }
        private bool CheckProductAnswer()
        {
            return multiplicand * multiplier == product.Value;
        }
        private bool CheckQuotientAnswer()
        {
            return dividend / divisor == quotient.Value;
        }
        private bool CheckAnswer()
        {
            return CheckSumAnswer()
                && CheckDifferenceAnswer()
                && CheckProductAnswer()
                && CheckQuotientAnswer();
        }

        private void playSound(in string path)
        {
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer, show a  
                // MessageBox, play a victory sound, and adjust
                // startTime.
                timer1.Stop();
                string soundPath = @"c:\Windows\Media\tada.wav";
                playSound(soundPath);
                MessageBox.Show("You got all the answers right!", "Congratulations");
                startTime -= (timeLeft / 2);
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                timeLeft -= 1;
                timeLeftLabel.Text = timeLeft + " seconds";

                if (timeLeft <= 5)
                {
                    // Time's running low,
                    // give an audible and visual alert.
                    timeLeftLabel.BackColor = Color.Red;
                    timeLeftLabel.ForeColor = Color.White;
                    string soundPath = @"c:\Windows\Media\Windows Startup.wav";
                    playSound(soundPath);
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, play a sound, adjust startTime, and
                // fill in the answers.
                timer1.Stop();
                timeLeftLabel.Text = "Time's up!";
                string soundPath = @"c:\Windows\Media\Speech Misrecognition.wav";
                playSound(soundPath);
                MessageBox.Show("You didn't finish in time.", "Sorry");
                startTime += 5;
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void answer_Change(object sender, EventArgs e)
        {
            NumericUpDown answer = sender as NumericUpDown;
            string soundPath = @"c:\Windows\Media\Speech On.wav";
            switch (answer.Name)
            {
                case "sum":
                    if (CheckSumAnswer() && timeLeft > 0)
                    {
                        playSound(soundPath);
                    }
                    break;
                case "difference":
                    if (CheckDifferenceAnswer() && timeLeft > 0)
                    {
                        playSound(soundPath);
                    }
                    break;
                case "product":
                    if (CheckProductAnswer() && timeLeft > 0)
                    {
                        playSound(soundPath);
                    }
                    break;
                case "quotient":
                    if (CheckQuotientAnswer() && timeLeft > 0)
                    {
                        playSound(soundPath);
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Update today's date
            dateLabel.Text = DateTime.Now.ToString("dd MMMMM yyyy");
            //this.Icon = new Icon("au-cyan-dum-low.ico");
        }
    }
}