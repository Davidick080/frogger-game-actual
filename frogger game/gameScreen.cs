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
        carClass car2;
        carClass car3;
        public Size screenSize;
        //ints for car lists 
        public int x = 0;
        public int y = 300;
        public int y2 = 200;
        public int y3 = 150;
        //sets keys to false when game screen is first active 
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        // ints for lives and timer and car spawning counter
        public int carCoolD;
        static public int time;
        public static int lives = 3;
        // builds the list for the car class 
        List<carClass> carList = new List<carClass>();
        List<carClass> carList2 = new List<carClass>();
        List<carClass> carList3 = new List<carClass>();
   
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
            //creates the game objects
            frog = new frogclass(startingFrogLocationx, startingFrogLocationy);
            car = new carClass(x, y, 20, 30);
            car2 = new carClass(x, y2, 20, 30);
            car3 = new carClass(x, y3, 20, 30);
            //addes the cars objects to lists 
            carList.Add(car);
            carList2.Add(car);
            carList3.Add(car);

        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //sets lives and timer to be shown on screen
            timer.Text = $"{time}";
            livesLabel.Text = $"{lives}";
            // draws the frog
            e.Graphics.FillRectangle(Brushes.GreenYellow, frog.x, frog.y, frog.width, frog.height);
            //draws the car objects 
            foreach (carClass car in carList)
            {
                e.Graphics.FillEllipse(Brushes.Tomato, car.x, car.y, car.width, car.height);
            }
            foreach (carClass car2 in carList2)
            {
                e.Graphics.FillEllipse(Brushes.Tomato, car2.x, car2.y, car2.width, car2.height);
            }
            foreach (carClass car3 in carList3)
            {
                e.Graphics.FillEllipse(Brushes.Tomato, car3.x, car3.y, car3.width, car3.height);
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
            //moves x for each car object 
            foreach (carClass car in carList)
            {
                car.x++;
            }
            foreach (carClass car in carList2)
            {
                car.x++;
            }
            foreach (carClass car in carList3)
            {
                car.x++;
            }
            //count down for car spawner
            carCoolD++;
            //timer 
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

            //count down for when to respawn car objects 
            if (carCoolD == 100)
            {

                car = new carClass(x, y, 20, 30);
                car2 = new carClass(x, y2, 20, 40);
                car3 = new carClass(x, y3, 20, 40);
                carList.Add(car);
                carList2.Add(car2);
                carList3.Add(car3);
                carCoolD = 0;
            }

                //if car x hits right wall it will respawn
                if (car.x == 900)
                {
                    car.x = 0;
                }
                foreach (carClass car in carList)
                {
                    if (car.Collision(frog))
                    {
                        lives--;
                        frog.y = 450;
                        frog.x = 400;

                    }
                }
                foreach (carClass car2 in carList2)
                {
                    if (car2.Collision(frog))
                    {
                        lives--;
                        frog.y = 450;
                        frog.x = 400;
                    }
                }
            
            foreach (carClass car3 in carList3)
            {
                if (car3.Collision(frog))
                {
                    lives--;
                    frog.y = 450;
                    frog.x = 400;
                }
            }



            //was trying to get time recorded to xml file and loaded apon winner screen
            //          XmlWriter writter = XmlWriter.Create("Resources/highScoreStore.xml", null);
            //        writter.WriteStartElement("time");

            if (lives == 0)
            {
                gameEngine.Enabled = false;
                Form1.ChangeScreen(this, new winnerScreen());

            }


            Refresh();

        } 
    }
}
    
   
