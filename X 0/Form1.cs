using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace X_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Xor0;
        int n = 0;

        private void ButtonClick(object sender, EventArgs e)
        {
            n++;

            Button Button5 = (Button)sender;
            if (Xor0 == true)
            {
                Button5.Text = "X";

            }
            else
            {
                Button5.Text = "0";
            }
            Button5.Enabled = false;

            Win();
        }



        private void Win()
        {
            bool winner = false;



            if((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled))
            {
                winner = true;
            }
            else if((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            else if((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            else if((A1.Text==B1.Text)&&(B1.Text==C1.Text)&&(!A1.Enabled))
            {
                winner = true;
            }
            else if((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            else if((A1.Text==B2.Text)&&(B2.Text==C3.Text)&&(!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            if(winner==true)
            {
                disableButtons();
                string s = "";
                if(Xor0==true)
                {
                    s = "X";
                }
                else
                {
                    s = "O";
                }
                MessageBox.Show(s + "  Wins!");
            }
            else if(n==9)
            {
                MessageBox.Show("Draw");
            }
        }
        private void disableButtons()
        {
            try 
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
            
        }
        private void XButton(object sender, EventArgs e)
        {
            Xor0 = true;
           
        }

        private void OButton(object sender, EventArgs e)
        {
            Xor0 = false;
            
        }

       

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 0;
            try
            {
                foreach(Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    button10.Text = "X";
                    button11.Text = "O";
                }
              
            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game by Noro");
        }
    }
}
