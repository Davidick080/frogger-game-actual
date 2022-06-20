using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace frogger_game
{
    public partial class gameScreen : UserControl
    {
        // builds the frog object and car object 
        frogclass frog;

        public Size screenSize;

        //sets keys to false when game screen is first active 
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        // ints for lives and timer 
        public int time;
        public static int lives = 3;
        // builds the list for the car class 
        List<carClass> carList = new List<carClass>();
        //random generator
        Random randGen = new Random();
        //borders 
        public static int gsWidth = 910;
        public static int gsHeight = 510;
        public gameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            //starts game engine 
            gameEngine.Enabled = true;

            time++;
            //sets the starting cordinates for the frog 
            int startingFrogLocationx = 390;
            int startingFrogLocationy = 490;

            frog = new frogclass(startingFrogLocationx, startingFrogLocationy);

            carList = new carClass();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            timer.Text = $"{time}";
            livesLabel.Text = $"{lives}";
            // draws the frog
            e.Graphics.FillRectangle(Brushes.GreenYellow, frog.x, frog.y, frog.width, frog.height);
            //       foreach (carClass car in carList)
            //  {
            e.Graphics.FillEllipse(Brushes.Tomato, carList.x, carList.y, carList.width, carList.height) ;
         //   }


        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            time++;
            if (leftArrowDown == true)
            {
                frog.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                frog.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                frog.Move("up", screenSize);
            }

            if (downArrowDown == true)
            {
                frog.Move("down", screenSize);
            }

            if (frog.y == 0 || lives == 0)
            {

                gameEngine.Enabled = false;
               
                XmlWriter writter = XmlWriter.Create("Resources/highScoreStore.xml", null);
                writter.WriteStartElement("time");
               
               Form1.ChangeScreen(this, new winnerScreen());
               

            }
           

            Refresh();

        }
    }

}