using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frogger_game
{
    public partial class winnerScreen : UserControl
    {
        public winnerScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rMainMenuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new mainMenu());

        }
    }
}

