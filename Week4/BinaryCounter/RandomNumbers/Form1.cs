using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {
        Bit[] bits = new Bit[9];
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 9; i++)
            {
                bits[i - 1].LED = (PictureBox)Controls.Find("PictureBox" + i, false).First();
                bits[i - 1].LED.Image = Properties.Resources.led_one;
                bits[i - 1].Value = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tap1 = bits[2].Value;
            int tap2 = bits[0].Value;

            int newBit = 0;

            if (tap1 + tap2 == 1)
            {//new bit is 1
                newBit = 1;
            }
            textBox1.Text = tap1.ToString();
            textBox2.Text = tap2.ToString();
            textBox3.Text = newBit.ToString();

            //shift
            for (int i = 0; i < bits.Length - 1; i++)
            {
                bits[i] = bits[i + 1];
            }
            //tack new bit into last index
            bits[bits.Length - 1].Value = newBit;
            if (newBit == 0)
            {
                bits[bits.Length - 1].LED.Image = Properties.Resources.led_zero;
            } else
            {
                bits[bits.Length - 1].LED.Image = Properties.Resources.led_one;
            }


        }
    }

    struct Bit
    {
        public int Value { get; set; }
        public PictureBox LED { get; set; }

    }
}
