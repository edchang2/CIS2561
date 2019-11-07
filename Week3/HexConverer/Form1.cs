using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexConverer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //convert hex to decimal
            
            string input = textBox1.Text;
            input = new string(input.Reverse().ToArray());

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int digit = toDecimal(input[i]); //convert char to dec

                sum += digit * (int) Math.Pow(16, i);
            }

            textBox1.Text = "";
            textBox2.Text = sum.ToString();

        }

        /// <summary>
        /// Converts a char to its decmial equivalent
        /// 
        /// </summary>
        /// <param name="ch"></param>
        /// <returns>ch</returns>
        int toDecimal(char ch)
        {

            if (ch >= '0' && ch <= '9')
            {
                ch -= '0';
            }
            else if (ch >= 'a' && ch <= 'f')
            {
                ch -= 'a';
                ch += (char) 10;
            }
            else if (ch >= 'A' && ch <= 'F')
            {
                ch -= 'a';
                ch += (char)10;
            }
            else
            {
                throw new Exception("Invalid character: " + ch);
            }

            return ch;
        }
    }
}
