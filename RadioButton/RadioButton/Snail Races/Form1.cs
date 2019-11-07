using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snail_Races
{
    public partial class Form1 : Form
    {
        Snail[] snails = new Snail[3];
        public Form1()
        {
            InitializeComponent();
            snails[0] = new Snail()
            {
                Name = "Rocky",
                X = 50,
                Y = 50,
                Image = Properties.Resources.rocky
            };

            snails[1] = new Snail()
            {
                Name = "Gary",
                X = 50,
                Y = 100,
                Image = Properties.Resources.snail3
            };

            snails[2] = new Snail()
            {
                Name = "Princess",
                X = 50,
                Y = 150,
                Image = Properties.Resources.snail6
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Snail s in snails)
            {
                s.Move();
                if (s.X > pictureBox1.Width - 50)
                {
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;

                    MessageBox.Show("Congrats, " + s.Name + " is the winner!");
                }

            }

            //TODO display who wins




            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Snail s in snails)
            {
                s.Draw(e.Graphics);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Snail s in snails)
            {
                s.X = 50;
                
            }
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Invalidate();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cheer gary on
            snails[1].X += 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cheer princess on
            snails[2].X += 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cheer rocky on
            snails[0].X += 10;
        }
    }
}
