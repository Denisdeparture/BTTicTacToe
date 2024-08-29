using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        char pictogram1 = 'X';
        char pictogram2 = '0';
        WorkInterface obj = new WorkInterface();
        string WhoElementWin = "";
        public Form1()
        {
            InitializeComponent();
           
        }

        private void b1_Click(object sender, EventArgs e)
        {
            obj.Task1(b1, pictogram1, pictogram2);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            obj.Task1(b2, pictogram1, pictogram2);
           
        }

        private void b3_Click(object sender, EventArgs e)
        {
            obj.Task1(b3, pictogram1, pictogram2);
           
        }

        private void b4_Click(object sender, EventArgs e)
        {
            obj.Task1(b4, pictogram1,pictogram2);
            
        }

        private void b5_Click(object sender, EventArgs e)
        {
            obj.Task1(b5, pictogram1, pictogram2);
           
        }

        private void b6_Click(object sender, EventArgs e)
        {
            obj.Task1(b6, pictogram1, pictogram2);
          
        }

        private void b7_Click(object sender, EventArgs e)
        {
            obj.Task1(b7, pictogram1, pictogram2);
            
        }

        private void b8_Click(object sender, EventArgs e)
        {
            obj.Task1(b8, pictogram1,pictogram2);
           
        }

        private void b9_Click(object sender, EventArgs e)
        {
            obj.Task1(b9, pictogram1, pictogram2);
           
        }

        private void Check_Click(object sender, EventArgs e)
        {
            bool[] WasWin =
           {
               WorkInterface.CheckWasWin(b1.Text , b2.Text, b3.Text),
               WorkInterface.CheckWasWin(b1.Text , b4.Text, b7.Text),
               WorkInterface.CheckWasWin(b4.Text , b5.Text, b6.Text),
               WorkInterface. CheckWasWin(b2.Text , b5.Text, b8.Text),
               WorkInterface. CheckWasWin(b3.Text , b6.Text, b9.Text),
               WorkInterface. CheckWasWin(b7.Text , b8.Text, b9.Text),
               WorkInterface. CheckWasWin(b7.Text , b5.Text, b3.Text),
               WorkInterface. CheckWasWin(b9.Text , b5.Text, b1.Text),
            };
            for (int i = 0; i < WasWin.Length; i++)
            {
                if (WasWin[i] == true)
                {
                    FormEnd scence = new FormEnd();
                    scence.Show();
                    break;
                }
            }
        }
    }
}


