using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //The counter determines whos turn it is O is 0 X is 1
        int counter = 0;
        //This keeps track of the number of wins that X has
        int xWinCount = 0;
        //This keeps track of O's wins
        int oWinCount = 0;
        //This keeps count for a tie
        int turnCounter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        //Resets the game board. If there was a winner they will go first.
        //In the case of a draw whoever did not start last time will now start.
        private void newGameButton_Click(object sender, EventArgs e)
        {
            box1.Image = null;
            box1.Enabled = true;
            box1.Tag = "";

            box2.Image = null;
            box2.Enabled = true;
            box2.Tag = "";

            box3.Image = null;
            box3.Enabled = true;
            box3.Tag = "";

            box4.Image = null;
            box4.Enabled = true;
            box4.Tag = "";

            box5.Image = null;
            box5.Enabled = true;
            box5.Tag = "";

            box6.Image = null;
            box6.Enabled = true;
            box6.Tag = "";

            box7.Image = null;
            box7.Enabled = true;
            box7.Tag = "";

            box8.Image = null;
            box8.Enabled = true;
            box8.Tag = "";

            box9.Image = null;
            box9.Enabled = true;
            box9.Tag = "";

            //Clears the win label & resets the tie counter
            winnerLabel.Visible = false;
            turnCounter = 0;
            

        }

        #region Gameboard locations
        //(1,1)
        private void box1_Click(object sender, EventArgs e)
        {
            if(counter == 0)
            {
                box1.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box1.Tag = "O";
            }else
            {
                box1.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box1.Tag = "X";
            }
            //Turn off the button
            box1.Enabled = false;
            CheckWin();
            turnCounter++;

        }

        //(2,1)
        private void box2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box2.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box2.Tag = "O";
            }
            else
            {
                box2.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box2.Tag = "X";
            }
            box2.Enabled = false;
            CheckWin();
            turnCounter++;

        }
        //(3,1)
        private void box3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box3.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box3.Tag = "O";
            }
            else
            {
                box3.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box3.Tag = "X";
            }
            box3.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(1,2)
        private void box4_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box4.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box4.Tag = "O";
            }
            else
            {
                box4.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box4.Tag = "X";
            }
            box4.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(2,2)
        private void box5_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box5.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box5.Tag = "O";
            }
            else
            {
                box5.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box5.Tag = "X";
            }
            box5.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(3,2)
        private void box6_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box6.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box6.Tag = "O";
            }
            else
            {
                box6.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box6.Tag = "X";
            }
            box6.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(1,3)
        private void box7_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box7.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box7.Tag = "O";
            }
            else
            {
                box7.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box7.Tag = "X";
            }
            box7.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(2,3)
        private void box8_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box8.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box8.Tag = "O";
            }
            else
            {
                box8.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box8.Tag = "X";
            }
            box8.Enabled = false;
            CheckWin();
            turnCounter++;
        }
        //(3,3)
        private void box9_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                box9.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-O.PNG";
                counter++;
                box9.Tag = "O";
            }
            else
            {
                box9.ImageLocation = "c:/users/kuhgelfische/documents/visual studio 2017/Projects/TicTacToe/TicTacToe/Tic-Tac-Toe-X.PNG";
                counter--;
                box9.Tag = "X";
            }
            box9.Enabled = false;
            CheckWin();
            turnCounter++;
        }
#endregion

        //This method checks if a win condition is met
        void CheckWin()
        {
            CheckTurnAndTie();
            //check for O horrizontal win win
            if (box1.Tag == "O" && box2.Tag == "O" && box3.Tag == "O" || box4.Tag == "O" && box5.Tag == "O" && box6.Tag == "O" || 
                box7.Tag == "O" && box8.Tag == "O" && box9.Tag == "O")
            {
                OWins();
            }

            //check for X horrizontal win
            if (box1.Tag == "X" && box2.Tag == "X" && box3.Tag == "X" || box4.Tag == "X" && box5.Tag == "X" && box6.Tag == "X" ||
                box7.Tag == "X" && box8.Tag == "X" && box9.Tag == "X")
            {
                XWins();
                box1.Enabled = false;
                box2.Enabled = false;
                box3.Enabled = false;
                box4.Enabled = false;
                box5.Enabled = false;
                box6.Enabled = false;
                box7.Enabled = false;
                box8.Enabled = false;
                box9.Enabled = false;
            }

            //Check for O vertical win
            if(box1.Tag == "O" && box4.Tag == "O" &&box7.Tag == "O" || box2.Tag == "O" && box5.Tag == "O" && box8.Tag == "O"||
                box3.Tag =="O" && box6.Tag == "O" && box9.Tag == "O")
            {
                OWins();
            }

            //Check for X Vertical win
            if(box1.Tag == "X" && box4.Tag == "X" && box7.Tag == "X" || box2.Tag == "X" && box5.Tag == "X" && box8.Tag == "X" ||
                box3.Tag == "X" && box6.Tag == "X" && box9.Tag == "X")
            {
                XWins();
            }

            //Check for O Diagnol win
            if(box1.Tag == "O" && box5.Tag == "O" && box9.Tag == "O" || box3.Tag == "O" && box5.Tag == "O" && box7.Tag == "O")
            {
                OWins();
            }
            //Check for X Diagnol win
            if(box1.Tag == "X" && box5.Tag == "X" && box9.Tag == "X" || box3.Tag == "X" && box5.Tag == "X" && box7.Tag == "X")
            {
                XWins();
            }

            
        }

        //This method is used when X meets the win condition
        void XWins()
        {
            DisableButtons();
            winnerLabel.Text = "X has won!";
            winnerLabel.Visible = true;
            counter = 1;
            xWinCount++;
            xWins.Text = "Wins: " + xWinCount;
        }

        //This method is used when O meets the win condition
        void OWins()
        {
            DisableButtons();
            winnerLabel.Text = "O has won!";
            winnerLabel.Visible = true;
            counter = 0;
            oWinCount++;
            oWins.Text = "Wins: " + oWinCount;
        }

        //This disables all gameboard buttons
        //This is used when a game is complete 
        void DisableButtons()
        {
            box1.Enabled = false;
            box2.Enabled = false;
            box3.Enabled = false;
            box4.Enabled = false;
            box5.Enabled = false;
            box6.Enabled = false;
            box7.Enabled = false;
            box8.Enabled = false;
            box9.Enabled = false;
        }

        //This method is used when there is a tie game by the tie counter 
        //reaching 8 & noone wins
        void TieGame()
        {
            winnerLabel.Text = "Draw!";
            winnerLabel.Visible = true;
            DisableButtons();
            counter = 0;
        }

        //This method checks whos turn it is & checks for a tie
        void CheckTurnAndTie()
        {
            if(counter == 0)
            {
                oTurn.Visible = true;
                xTurn.Visible = false;
            }
            else
            {
                oTurn.Visible = false;
                xTurn.Visible = true;
            }
            if (turnCounter == 8 )
            {
                TieGame();
            }
        }

        private void resetWinButton_Click(object sender, EventArgs e)
        {
            oWins.Text = "Wins: 0";
            xWins.Text = "Wins: 0";
            xWinCount = 0;
            oWinCount = 0;
        }
    }


}
