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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }
        
        private string p1;
        private string p2;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPlayer1.Text == "" || txtPlayer2.Text == "")
            {
                MessageBox.Show("Nome(s) vazio(s).");
            }
            else if (txtPlayer1.Text == txtPlayer2.Text)
            {
                MessageBox.Show("Nome dos jogadores estão iguais! Diferencie-os.");
            }
            else
            {
                p1 = txtPlayer1.Text;
                p2 = txtPlayer2.Text;
                Close();  
            }          
        }

        public string P1
        {
            get { return p1; }
        }

        public string P2
        {
            get { return p2; }
        }
    }
}
