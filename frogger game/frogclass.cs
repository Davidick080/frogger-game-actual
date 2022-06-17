using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace frogger_game
{
    public class frogclass
    {
        // blue prints for frog object 
        // object width height and speed 
        public int width = 30;
        public int height = 10;
        public int speed = 1;
        // objects x and y ints 
        public int x, y;
        public frogclass(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move(string direction, Size ss)
        {
            if (direction == "left")
            {
                x -= speed;

                // border code  so frog cant go off screen 
                if (x < 0)
                {
                    x+= speed;
                }
                if (x >0)
                {
                    x -= speed; 
                }
            }

            if (direction == "right")
            {
                x += speed;

                // border code  so frog cant go off screen 
                if ( x> 910)
                {
                    x -= speed;
                }
                if (x <910)
                {
                    x += speed;       
                }
            }

            if (direction == "up" == true)
            {
                y -= speed;

                // border code so frog cant go off screen 
                if (y < 0)
                {
                    y += 0;
                }
            }

            if (direction == "down")
            {
                y += speed;

                // border code so frog cant go off screen 
                if (y >= 500)
                {
               y-= speed;
                }
            
            }
            
        }
    }
}
        
    

    
   


