using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class Form1 : Form
    {

        const int DISPLAY_CENTER_Y = 100;
        const int DISPLAY_LEFT = 5;
        const int DISPLAY_WIDTH = (323-62);

        int[] values = new int[DISPLAY_WIDTH];
        float amplitude = 50.0f;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (int) (Math.Sin(2* Math.PI * i/(DISPLAY_WIDTH/2) ) * amplitude);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();

            //TODO - Rotate the array
            //save the 1st value to a temp variable
            int temp = values[0];
    
            //shift all the elements down one using a for loop
            for (int i = 0; i < values.Length - 1; i++)
			{
                values[i] = values[i+1];
			}
 
            //copy the temp variable into the last slot
            values[values.Length - 1] = values[0]; 
   
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < values.Length; i++)
            {
                e.Graphics.FillRectangle(Brushes.White, DISPLAY_LEFT + i, DISPLAY_CENTER_Y - values[i], 3, 3);
            }
        }
    }
}
