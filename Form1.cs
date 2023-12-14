using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwizz
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }



            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.images__5_;

                    Question.Text = "This is Easy, African Culture, Food and Traditions are located where";

                    button1.Text = "Europe";
                    button2.Text = "Australia";
                    button3.Text = "Asia";
                    button4.Text = "Africa";

                    correctAnswer = 1;
                    correctAnswer = 2;
                    correctAnswer = 3;
                    correctAnswer = 4;

                    break;

                case 2 :
                    pictureBox1.Image = Properties.Resources.images__1_1;

                    Question.Text = "This vibrant mask, often adorned with beads and feathers, is traditionally worn by dancers in which West African culture?";

                    button1.Text = "Yoruba";
                    button2.Text = "Maasai";
                    button3.Text = "Igbo";
                    button4.Text = "Dogon";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.images__2_1;

                    Question.Text = "This traditional dish, made from fermented yams and often served with palm oil and vegetables, is a staple food in which region of Africa?";

                    button1.Text = "North Africa";
                    button2.Text = "East Africa";
                    button3.Text = "West Africa";
                    button4.Text = "Southern Africa";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images__4_1;

                    Question.Text = "This traditional dance, characterized by stomping and rhythmic clapping, is a celebratory expression in which Southern African culture?";

                    button1.Text = "Zulu";
                    button2.Text = "Sotho";
                    button3.Text = "Xhosa";
                    button4.Text = "Shona";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.images__3_1;

                    Question.Text = "This vibrant fabric, often featuring bold geometric patterns, is traditionally worn by women in Kenya.";

                    button1.Text = "Rwanda";
                    button2.Text = "Kenyan";
                    button3.Text = "Tanzani";
                    button4.Text = "Ethiopia";

                    correctAnswer = 2;

                    break;

            }

        }
    }
}
