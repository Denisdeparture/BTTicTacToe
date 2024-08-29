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
    public partial class FormEnd : Form
    {
        public FormEnd()
        {
            InitializeComponent();
        }

        private void FormEnd_Load(object sender, EventArgs e)
        {
            EndTextFromScence.Text = WorkInterface.whoWin;
        }

        
    }
}
