using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int scoreX = 0;
        int scoreO = 0;
        bool xTurn = true;
        bool OTurn = false;

        public void checkTie()
        {
            if(!checkWinnerO() && !checkWinnerO())
            {
                MessageBox.Show("it is a tie!");
                reset();
                
            }
        }
        public bool checkWinnerX()
        {
            
           
            if(btn00.Text == "X" && btn11.Text=="X" && btn22.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn01.BackColor = Color.Red;
                btn02.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;
            }
            if (btn00.Text == "X" && btn10.Text == "X" && btn20.Text == "X")
            {
                btn00.BackColor = Color.Red;
                btn10.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                btn20.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                btn10.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "X" && btn12.Text == "X" && btn22.Text == "X")
            {
                btn02.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn01.Text == "X" && btn11.Text == "X" && btn21.Text == "X")
            {
                btn01.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "X" && btn11.Text == "X" && btn20.Text == "X")
            {
                btn02.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreX++;
                lbScoreX.Text = scoreX.ToString();
                MessageBox.Show("X is the winner!");
                reset();
                return true;

            }
            return false;

        }
        public bool checkWinnerO()
        {
           

            if (btn00.Text == "O" && btn11.Text == "O" && btn22.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "O" && btn01.Text == "O" && btn02.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn01.BackColor = Color.Red;
                btn02.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn00.Text == "O" && btn10.Text == "O" && btn20.Text == "O")
            {
                btn00.BackColor = Color.Red;
                btn10.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                btn20.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                btn10.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            if (btn02.Text == "O" && btn12.Text == "O" && btn22.Text == "O")
            {
                btn02.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
                

            }
            if (btn01.Text == "O" && btn11.Text == "O" && btn21.Text == "O")
            {
                btn01.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;
            }
            if (btn02.Text == "O" && btn11.Text == "O" && btn20.Text == "O")
            {
                btn02.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                scoreO++;
                lbScoreO.Text = scoreO.ToString();
                MessageBox.Show("O is the winner!");
                reset();
                return true;

            }
            return false;
        }
       public void reset()
        {
            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            

            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

            btn00.BackColor = Color.Gray;
            btn01.BackColor = Color.Gray;
            btn02.BackColor = Color.Gray;
            btn10.BackColor = Color.Gray;
            btn11.BackColor = Color.Gray;
            btn12.BackColor = Color.Gray;
            btn20.BackColor = Color.Gray;
            btn21.BackColor = Color.Gray;
            btn22.BackColor = Color.Gray;

            xTurn = true;
            OTurn = false;


        }
       

        public Form1()
        {
            InitializeComponent();
        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn00.Text = "X";
                xTurn = false;
                OTurn = true;
                btn00.Enabled = false;
            }
            else if(OTurn)
            {
                btn00.Text = "O";
                OTurn = false;
                xTurn = true;
                btn00.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn01.Text = "X";
                xTurn = false;
                OTurn = true;
                btn01.Enabled = false;
            }
            else if (OTurn)
            {
                btn01.Text = "O";
                OTurn = false;
                xTurn = true;
                btn01.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn02.Text = "X";
                xTurn = false;
                OTurn = true;
                btn02.Enabled = false;
            }
            else if (OTurn)
            {
                btn02.Text = "O";
                OTurn = false;
                xTurn = true;
                btn02.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn10.Text = "X";
                xTurn = false;
                OTurn = true;
                btn10.Enabled = false;
            }
            else if (OTurn)
            {
                btn10.Text = "O";
                OTurn = false;
                xTurn = true;
                btn10.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn11.Text = "X";
                xTurn = false;
                OTurn = true;
                btn11.Enabled = false;
            }
            else if (OTurn)
            {
                btn11.Text = "O";
                OTurn = false;
                xTurn = true;
                btn11.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn12.Text = "X";
                xTurn = false;
                OTurn = true;
                btn12.Enabled = false;
            }
            else if (OTurn)
            {
                btn12.Text = "O";
                OTurn = false;
                xTurn = true;
                btn12.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();

        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn20.Text = "X";
                xTurn = false;
                OTurn = true;
                btn20.Enabled = false;
            }
            else if (OTurn)
            {
                btn20.Text = "O";
                OTurn = false;
                xTurn = true;
                btn20.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn21.Text = "X";
                xTurn = false;
                OTurn = true;
                btn21.Enabled = false;
            }
            else if (OTurn)
            {
                btn21.Text = "O";
                OTurn = false;
                xTurn = true;
                btn21.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                btn22.Text = "X";
                xTurn = false;
                OTurn = true;
                btn22.Enabled = false;
            }
            else if (OTurn)
            {
                btn22.Text = "O";
                OTurn = false;
                xTurn = true;
                btn22.Enabled = false;
            }
            checkWinnerX();
            checkWinnerO();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do you want to exit this game?", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            reset();
            lbScoreO.Text = "0";
            lbScoreX.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
