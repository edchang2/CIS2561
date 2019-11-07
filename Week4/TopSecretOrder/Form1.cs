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

namespace Week4
{
    public partial class Form1 : Form
    {
        string secretMessage = "";
        string printedMessage = "";
        public static string message;

        Brush brush = Brushes.Gray;
        Font font = new Font("Arial", 9);
        int index = 0;
        SoundPlayer click = new SoundPlayer(Properties.Resources.Click3);


        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm mf = new MessageForm();
            mf.ShowDialog();
            secretMessage = mf.message;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(printedMessage, font, brush, 15, 75);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < secretMessage.Length)
            {
                printedMessage += secretMessage[index];
                index++;
                click.Play();
                pictureBox1.Invalidate();
            } else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            index = 0;
            printedMessage = "";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
