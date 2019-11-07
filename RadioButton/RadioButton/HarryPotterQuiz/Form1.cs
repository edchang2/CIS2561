using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryPotterQuiz
{
    public partial class Form1 : Form   
    {
        List<Question> questions = new List<Question>();
        bool showAnswer = true;
        Random r = new Random();
        Question curQuestion;

        public Form1()
        {
            InitializeComponent();

            string questionsTxt = Properties.Resources.questions;
            string[] lines = questionsTxt.Split('\n');

            for (int i = 0; i < lines.Length; i += 3)
            {
                Question q = new Question()
                {
                    //constructor is blank but you can construct fields within it (C++)
                    Category = lines[i].Trim(),
                    QuestionText = lines[i+1].Trim(),
                    Answer = lines[i+2].Trim()
                };

                questions.Add(q);
            }

            //now pick a question
            Random r = new Random();
            int index = r.Next(questions.Count);
            curQuestion = questions.ElementAt(index);

            textBox1.Text = curQuestion.Category;
            textBox2.Text = curQuestion.QuestionText;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (showAnswer == false)
            {
                //picks a new question
                Random r = new Random();
                int index = r.Next(questions.Count);
                curQuestion = questions.ElementAt(index);

                textBox1.Text = curQuestion.Category;
                textBox2.Text = curQuestion.QuestionText;
                textBox3.Text = "";

            }
            else
            {
                //show answer to current question
                textBox3.Text = curQuestion.Answer;

            }

            showAnswer = !showAnswer;
        }
    }
}
