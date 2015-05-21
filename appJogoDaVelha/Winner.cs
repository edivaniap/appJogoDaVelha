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
    public partial class Winner : Form
    {
        public Winner(string winner)
        {
            InitializeComponent();
            if(winner == "Deu velha")
                lbWinner.Text = winner + "! :S";
            else
                lbWinner.Text = winner + ", you win! :D";
        }
    }
}
