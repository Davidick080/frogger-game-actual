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
    public partial class difficultyScreen : UserControl
    {
        public difficultyScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
           gameScreen.lives = 3;
           Form1.ChangeScreen(this, new gameScreen());
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            gameScreen.lives = 2;
            Form1.ChangeScreen(this, new gameScreen());
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            gameScreen.lives = 1;
            Form1.ChangeScreen(this, new gameScreen());
        }

        private void extremeHardButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
