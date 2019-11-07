using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseInverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            char ch = 'A';
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.flipCase();
        }
    }

    static class CharExtensions
    {
        static bool isUppercaseLetter(this char ch)
        {
            return Char.IsLetter(ch) && Char.IsUpper(ch);

        }

        static bool isLowerCaseLetter(this char ch)
        {
            return Char.IsLetter(ch) && Char.IsLower(ch);

        }

        public static char FlipCase(this char ch)
        {
            if (ch.isUppercaseLetter())
            {
                return ch.ToString().ToLower()[0];
            } else if (ch.isLowerCaseLetter())
            {
                return ch.ToString().ToUpper()[0];
            }
            return ch;

        }

    }

    static class StringExtensions
    {
        public static string flipCase(this string str)
        {
            string flipped = "";
            foreach (char ch in str)
            {
                flipped += ch.FlipCase();
            }
            return flipped;
        }
    }
}
