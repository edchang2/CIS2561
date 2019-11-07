using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        enum CellValue { Empty, X, O };
        CellValue turn = CellValue.X;
        CellValue[,] board = new CellValue[3, 3];

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
            Button b = (Button)sender;
            //or Button b = sender as Button;

            if (b.Text == "")
            {
                string name = b.Name;
                string suffix = b.Name.Last().ToString();
                int ctrlNum = Convert.ToInt32(suffix) - 1;

                int row = ctrlNum % 3;
                int col = ctrlNum / 3;
                board[row, col] = turn;

                if (turn == CellValue.X)
                {
                    b.Text = "X";
                    if (CheckWin() )
                    {
                        MessageBox.Show("X wins!");
                        Reset();
                    }
                    turn = CellValue.O;
                } else
                {//O's turn
                    b.Text = "O";
                    if (CheckWin())
                    {
                        MessageBox.Show("O wins!");
                        Reset();
                    }
                    turn = CellValue.X;
                }
            }

        }

        //resets board
        public void Reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = CellValue.Empty;
                }
            }

            //Form has a collection of its controls
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                }
            }
        }

        //checks if there is a winner
        public bool CheckWin()
        {

            if (
                 //checking horizontals
                 ( board[0,0] != CellValue.Empty && ((board[0, 0]) == board[1, 0]) && (board[1, 0] == board[2, 0])) ||
                 (board[0, 1] != CellValue.Empty && ((board[0, 1]) == board[1, 1]) && (board[1, 1] == board[2, 1])) ||
                  (board[0, 2] != CellValue.Empty && ((board[0, 2]) == board[1, 2]) && (board[1, 2] == board[2, 2])) ||
                  //checking verticals
                  (board[0, 0] != CellValue.Empty && ((board[0, 0]) == board[0, 1]) && (board[0, 1] == board[0, 2])) || 
                  (board[1, 0] != CellValue.Empty && ((board[1, 0]) == board[1, 1]) && (board[1, 1] == board[0, 2])) ||
                  (board[2, 0] != CellValue.Empty && ((board[2, 0]) == board[2, 1]) && (board[2, 1] == board[2, 2])) ||
                  //checking diagonals
                  (board[0, 0] != CellValue.Empty && ((board[0, 0]) == board[1, 1]) && (board[1, 1] == board[2, 2])) ||
                  board[0, 2] != CellValue.Empty && (((board[0, 2]) == board[1, 1]) && (board[0, 1] == board[2, 0])))
                  {
                return true;
            }
            return false;
        }
    }
}
