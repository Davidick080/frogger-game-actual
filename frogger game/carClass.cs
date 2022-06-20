using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace frogger_game
{
    public class carClass
    {
        public int size = 30;
        public int height = 10;
        public int xSpeed, ySpeed;
        public int width = 15;
        public int x =1 , y=500;

        //random number generator for car width and height 
        
        public carClass(int _x,int _y, int _xSpeed ,int _ySpeed)
        {
            x = _x;
            y = _y; 
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public void Move()
        {
            x += xSpeed;


            //check if car has reached ether edge of screen 
            if (x>=910)
            {
             
            }
        }
            public bool Collision(frogclass f)
            {

                Rectangle carRec = new Rectangle(x, y, 8, 8);
                Rectangle playerRec = new Rectangle(f.x, f.y, f.width, f.height);

                if (carRec.IntersectsWith(playerRec))
                {

                    return true;
                }

                return false;
            }
        }
    }
