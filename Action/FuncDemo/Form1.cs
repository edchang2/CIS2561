using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncDemo
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
            

            Func<int, int, int, int, double> f=null;

            if(comboBox1.SelectedIndex ==0)
            {
                f = Distance;
            } else if (comboBox1.SelectedIndex == 1)
            {
                f = Sum;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                f = Product;
            }

            Calculate(f);

        }

        double Distance(int x1, int y1, int x2, int y2)
        {

            return Math.Sqrt( (x2-x1) * (x2 - x1) + (y2-y1) * (y2-y1));
        }

        double Product(int x1, int y1, int x2, int y2)
        {
            return x1 * x2 * y1 * y2;
        }

        double Sum(int x1, int y1, int x2, int y2)
        {
            return x1 + y1 + x2 + y2;
        }

        void Calculate ( Func<int,int,int,int,double> f)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int n3 = Convert.ToInt32(textBox3.Text);
            int n4 = Convert.ToInt32(textBox4.Text);

            textBox5.Text = f(n1, n2, n3, n4).ToString();


        }



    }
}
