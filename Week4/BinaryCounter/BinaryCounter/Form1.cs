using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCounter
{
    public partial class Form1 : Form
    {
        Bit[] bits = new Bit[8];

        public Form1()
        {
            InitializeComponent();

            //assign each picture box to its bit
            for (int i = 1; i <= 8; i++)
            {
                bits[i - 1].LED = (PictureBox)Controls.Find("PictureBox" + i, false).First();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Carry(0);
        }

        void Carry(int index)
        {
            //if user attempts to carry but no bit exists
            if (index == bits.Length)
                return;

            bits[index].Value++;

            if (bits[index].Value == 1)
            {
                //no need to carry, just change the image
                bits[index].LED.Image = Properties.Resources.led_one;
            } else //value is 2
            {
                bits[index].LED.Image = Properties.Resources.led_zero;
                bits[index].Value = 0;
                Carry(++index);
                
            }


        }
            
    }

    struct Bit
    {
        public int Value { get; set; }
        public PictureBox LED { get; set; }
    }

    
}
