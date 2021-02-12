using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*project:tic tac toe
 * programmer:Brendan Hawk
 * date:11/23/2020
 * description: tic tac toe game with radio button stating whose turn and menu to click for winner
 */

namespace TicTacToeProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int player1Click = 0, turn1 = 0;
        int winner = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks


            if (turn1 == 0)
            {
                button1.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
                {
                button1.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button2.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button2.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button3.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button3.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button4.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button4.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button5.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button5.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button6.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button6.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button7.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button7.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button8.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button8.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void xRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //display if it is player X turn


        }

        private void oRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //display if it is play O turn
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Display X or O when depending on which user clicks

            if (turn1 == 0)
            {
                button9.Text = "X";
                turn1++;
                xRadioButton.Checked = true;
                oRadioButton.Checked = false;
            }
            else if (turn1 == 1)
            {
                button9.Text = "O";
                turn1--;
                xRadioButton.Checked = false;
                oRadioButton.Checked = true;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //About the programmer

            MessageBox.Show("Tic Tac Toe Project By Brendan Hawk");
        }

        private void clickForWinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Check for a winner
            //check if X is a winner
            while (true)
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                }
                break;
            }



            while (true)
            {
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }



            while (true)
            {
                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X is the winner");
                    winner++;
                }
                break;
            }

            //set the O options for winning

            while (true)
            {
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }



            while (true)
            {
                if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O is the winner");
                    winner--;
                }
                break;
            }


            if (winner == 0)
            {
                MessageBox.Show("Cat game");
            }

        }

        
    }
}
