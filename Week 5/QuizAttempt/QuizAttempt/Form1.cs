using System;
using System.Windows.Forms;

namespace QuizAttempt
{
    public partial class Form1 : Form
    {
        //quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended" + Environment.NewLine +
                    "You have answered " + score + " questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + " % " 
                    );
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.background;

                    lblQuestion.Text = "What is the colour of the sky";

                    button1.Text = "blue";
                    button2.Text = "yellow";
                    button3.Text = "orange";
                    button4.Text = "red";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Tony;

                    lblQuestion.Text = "What is Iron man's name";

                    button1.Text = "rody";
                    button2.Text = "Tony stark";
                    button3.Text = "peter quil";
                    button4.Text = "peter Parker";

                    correctAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.EastCoast;

                    lblQuestion.Text = "Who is Singapore's prime Minister";

                    button1.Text = "LKY";
                    button2.Text = "LHL";
                    button3.Text = "GCK";
                    button4.Text = "HSK / East coast plan";

                    correctAnswer = 2;

                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.merdeka;

                    lblQuestion.Text = "What year did Singapore declare its independence from Malaysia ";

                    button1.Text = "1945";
                    button2.Text = "1963";
                    button3.Text = "1965";
                    button4.Text = "1962";

                    correctAnswer = 3;

                    break;


                case 5:
                    pictureBox1.Image = Properties.Resources.background;

                    lblQuestion.Text = "What is 2.0f + 2.0f";

                    button1.Text = "5";
                    button2.Text = "4.0";
                    button3.Text = "4";
                    button4.Text = "4.0f";

                    correctAnswer = 4;

                    break;



                default:
                    break;
            }
        }
    }
}
