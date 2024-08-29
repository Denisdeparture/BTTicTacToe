using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public class WorkInterface
    {
        static string winner = "";
        bool redFlag = false;
        public void Task1(Button button, char symb1, char symb2)
        {
            char symb = ' ';
            if(redFlag == false)
            {
                symb = symb1;
                redFlag = true;
                button.Enabled = false;
            }
            else if(redFlag == true)
            {
                symb = symb2;
                redFlag = false;
                button.Enabled = false;
            }
            button.Text = symb.ToString();
        }
        
        public static string whoWin
        {
            get
            {
                return $"битва окончена, победитель {winner}";
            }
        }
        public static bool CheckWasWin(params string[] buttonsNames)
        {
            
            bool Win = false;
            if (buttonsNames[0] != "")
            {
                if (buttonsNames[0] == buttonsNames[1] & buttonsNames[0] == buttonsNames[2])
                {
                    Win = true;
                    winner = buttonsNames[0];
                }
            }
            return Win;
            
        }
    }
}
