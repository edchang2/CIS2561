using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionDemo
{

    public partial class Form1 : Form
    {

        Action a;

        public Form1()
        {
            InitializeComponent();

            //assign the functions to a
            a += () => {
                textBox2.Text = textBox1.Text.ToLower();
            };

            a += () =>
            {
                textBox3.Text = textBox1.Text.ToUpper();
            };

            a += () =>
            {
                textBox4.Text = new String(textBox1.Text.ToCharArray().Reverse().ToArray());
            };


            a += () =>
            {
                string s = "";

                foreach (char ch in textBox1.Text)
                {
                    s += "*";
                }

                textBox5.Text = s;
            };

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
