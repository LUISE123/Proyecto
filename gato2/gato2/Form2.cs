using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace gato2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        string nombre;

        private void Form2_Load(object sender, EventArgs e)
        {
            XWin.Text = "X:" + s1;
            OWin.Text = "0:" + s2;
            Draws.Text = "Draws:" + sd;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;

                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game");
                    sd++;
                    NewGame();
                }
                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Gano");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Gano");
                        s2++;
                        NewGame();
                    }
                }
            }

        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X:" + s1;
            OWin.Text = "0:" + s2;
            Draws.Text = "Draws:" + sd;
            
        }

        public void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

       
        private void EButton_Click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
               
            }
            else if (result == DialogResult.No)
            {
            }
            

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
        bool CheckDraw()
        {
            if ((turns == 9) )

                return true;
            else
                return false;

        }
        bool CheckWinner()
        {
            //horizonatal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
