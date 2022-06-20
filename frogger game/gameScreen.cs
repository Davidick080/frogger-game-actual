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
        carClass car;

        public Size screenSize;

        //sets keys to false when game screen is first active 
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        // ints for lives and timer and car spawning counter
        public int carCoolD;
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

            //sets the starting cordinates for the frog 
            int startingFrogLocationx = 390;
            int startingFrogLocationy = 490;

            int x = 0;
            int y = 300;

            frog = new frogclass(startingFrogLocationx, startingFrogLocationy);
            car = new carClass(x, y, 20, 30);
            carList.Add(car);

        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            timer.Text = $"{time}";
            livesLabel.Text = $"{lives}";
            // draws the frog
            e.Graphics.FillRectangle(Brushes.GreenYellow, frog.x, frog.y, frog.width, frog.height);
            //draws the car 
            foreach (carClass car in carList)
            {
                e.Graphics.FillEllipse(Brushes.Tomato, car.x, car.y, car.width, car.height);
            }


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
            int x = 1;
            carCoolD++;
            car.x++;
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

            if (carCoolD==900)
            {
              
                int y = 300;
                car = new carClass(x, y, 20, 30);
                carList.Add(car);
                carCoolD = 0;
                
            }
            if (car.x == 900)
            {
             //   car.x = 0;
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