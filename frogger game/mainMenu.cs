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
    public partial class mainMenu : UserControl
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void difficultyButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new difficultyScreen());
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new tutorialScreen());
        }
    }
}
