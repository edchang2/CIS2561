using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSort
{
    public partial class Form1 : Form
    {
        int[] values = new int[100]; //the data to sort
        Random r = new Random();
        int top;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            top = 99;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TODO
            //make a for-loop that goes from 0 to top
            //use i as your loop counter
            //if the value of the array at position i
            //is greater than the value of the array
            //at the position top, exchange the values
            //in positions i and top
            for (int i = 0; i <= top; i++)
			{
                if (values[i] > values[top]) {
                    int temp = values[i];
                    values[i] = values[top];
                    values[top] = temp;
                }
                                

			}
             
            
            //TODO - subtract 1 from top
             top -= 1;


            //don't change this stuff
            pictureBox1.Invalidate();

            if (top == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, 500, 100);
            int w = pictureBox1.Width / 100;

            for (int i = 0; i < 100; i++)
            {
                int h = (int)(values[i] / 100.0 * pictureBox1.Height);
                int t = (int)((100 - values[i]) / 100.0 * pictureBox1.Height);
                e.Graphics.FillRectangle(Brushes.Red, i * w, t, w, h);
            }


        }

        void Reset()
        {
            //TODO
            //Populate values with numbers from 1 to 100
            //use a for-loop from 0 to 100 
            //call the loop counter i
            //set the values of the array at position i to i+1.
            for (int i = 0; i < 100; i++)
			{
                values[i] = i + 1;
			}
           

            //TODO - shuffle the values
            //Make a for loop that runs 1000 times.
            //Inside the loop generate two random ints
            //Exchange the values in the array, values, 
            //at those two indexes.  You will need a 
            //temp variable.
            //Remember you have a Random number generator
            //called rand in your class
            for (int i = 0; i < 1000; i++)
			{
                int a = r.Next(100);
                int b = r.Next(100);
                
                int temp = values[a];
                values[a] = values[b];
                values[b] = temp;

			}
            

            //leave this stuff alone
            pictureBox1.Invalidate();
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
