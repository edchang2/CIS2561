using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowflake
{
    public partial class Form1 : Form
    {
        List<SnowFlake> flakes = new List<SnowFlake>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                flakes.Add(new SnowFlake());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (SnowFlake flake in flakes)
            {
                flake.Move();
            }

            //invalidate means that the box is being told to refresh ie repaint
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (SnowFlake flake in flakes)
            {
                flake.Draw(e.Graphics);
            }
        }
    }
}
