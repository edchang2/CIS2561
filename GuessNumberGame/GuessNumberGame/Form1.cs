using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        static int number = r.Next(0, 1000);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String text = textBox2.Text;
            int guess = 0;

            textBox2.Text = "";

            if( Int32.TryParse(text, out guess))
            {
                guess = Int32.Parse(text);
            } else
            {
                textBox1.Text += "Input is in an incorrect format\r\n";
                return;
            }

            if (guess > number)
            {
                textBox1.Text += guess + " is too high\r\n";
            } else if (guess < number)
            {
                textBox1.Text += guess + " is too low\r\n";
            } else if (guess == number)
            {
                textBox1.Text += guess + " is correct\r\n";
            }



        }
    }
}
