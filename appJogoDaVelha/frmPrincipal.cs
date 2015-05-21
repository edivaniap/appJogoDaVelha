using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appJogoDaVelha
{
    public partial class frmPrincipal : Form
    {
        bool turnp1;
        bool turnp2;

        Players players;

        public frmPrincipal()
        {
            InitializeComponent();
            players = new Players();
            turnp1 = true;
            turnp2 = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            players.ShowDialog();
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            btnReiniciar.Enabled = true;
            btnIniciar.Enabled = false;

            lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            players.ShowDialog();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            cliqueiB1 = false;
            cliqueiB2 = false;
            cliqueiB3 = false;
            cliqueiB4 = false;
            cliqueiB5 = false;
            cliqueiB6 = false;
            cliqueiB7 = false;
            cliqueiB8 = false;
            cliqueiB9 = false;

            turnp1 = true;
            turnp2 = false;

            lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Encerrar aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        bool cliqueiB1 = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cliqueiB1 == false)
            {
                cliqueiB1 = true;

                if (turnp1 == true)
                {
                    button1.Text = "X";
                    button1.ForeColor = Color.Blue;

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button1.Text = "O";
                    button1.ForeColor = Color.Red;

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB2 = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (cliqueiB2 == false)
            {
                cliqueiB2 = true;

                if (turnp1 == true)
                {
                    button2.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button2.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB3 = false;

        private void button3_Click(object sender, EventArgs e)
        {
            if (cliqueiB3 == false)
            {
                cliqueiB3 = true;

                if (turnp1 == true)
                {
                    button3.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button3.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB4 = false;

        private void button4_Click(object sender, EventArgs e)
        {
            if (cliqueiB4 == false)
            {
                cliqueiB4 = true;

                if (turnp1 == true)
                {
                    button4.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button4.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB5 = false;

        private void button5_Click(object sender, EventArgs e)
        {
            if (cliqueiB5 == false)
            {
                cliqueiB5 = true;

                if (turnp1 == true)
                {
                    button5.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button5.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB6 = false;

        private void button6_Click(object sender, EventArgs e)
        {
            if (cliqueiB6 == false)
            {
                cliqueiB6 = true;
                if (turnp1 == true)
                {
                    button6.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button6.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB7 = false;

        private void button7_Click(object sender, EventArgs e)
        {
            if (cliqueiB7 == false)
            {
                cliqueiB7 = true;

                if (turnp1 == true)
                {
                    button7.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button7.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB8 = false;

        private void button8_Click(object sender, EventArgs e)
        {
            if (cliqueiB8 == false)
            {
                cliqueiB8 = true;

                if (turnp1 == true)
                {
                    button8.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button8.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool cliqueiB9 = false;

        private void button9_Click(object sender, EventArgs e)
        {
            if (cliqueiB9 == false)
            {
                cliqueiB9 = true;

                if (turnp1 == true)
                {
                    button9.Text = "X";

                    turnp1 = false;
                    turnp2 = true;

                    lbStatus.Text = "STATUS: " + players.P2 + ", it's ur turn!";
                }
                else if (turnp2 == true)
                {
                    button9.Text = "O";

                    turnp1 = true;
                    turnp2 = false;

                    lbStatus.Text = "STATUS: " + players.P1 + ", it's ur turn!";
                }

                IsWinner();
            }
        }

        bool gameOver = false;

        public void IsWinner()
        {
            Winner winner;

            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";                    
                }
                else if (button1.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button1.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button1.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button3.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button3.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button7.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button5.Text != "" && button5.Text == button2.Text && button5.Text == button8.Text)
            {
                if (button5.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button5.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }
            else if (button5.Text != "" && button5.Text == button4.Text && button5.Text == button6.Text)
            {
                if (button5.Text == "X")
                {
                    winner = new Winner(players.P1);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P1 + ", you're the winner!";
                }
                else if (button5.Text == "O")
                {
                    winner = new Winner(players.P2);
                    winner.ShowDialog();
                    lbStatus.Text = "STATUS: " + players.P2 + ", you're the winner!";
                }

                gameOver = true;
            }

            if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" 
                && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != ""
                && button9.Text != "" && gameOver == false)
            {
                winner = new Winner("Deu velha");
                winner.ShowDialog();
                lbStatus.Text = "STATUS: Deu velha!";
                gameOver = true;
            }

            if (gameOver == true)
            {
                turnp1 = true;
                turnp2 = false;
                btnIniciar.Enabled = true;
                btnReiniciar.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                cliqueiB1 = false;
                cliqueiB2 = false;
                cliqueiB3 = false;
                cliqueiB4 = false;
                cliqueiB5 = false;
                cliqueiB6 = false;
                cliqueiB7 = false;
                cliqueiB8 = false;
                cliqueiB9 = false;

                gameOver = false;
            }
        }
    }
}
