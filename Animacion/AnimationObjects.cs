using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Animacion
{
    class AnimationObjects
    {
        private static int Y = 16;
        private static int X = 770;
        public static void ChangeImage(PictureBox animationObject )
        {
            Random r = new Random();
          int choise =   r.Next(1, 6);
            switch (choise)
            {

                case 1:
                    animationObject.Image = Properties.Resources.Untitled1;
                    break;
                case 2:
                    animationObject.Image = Properties.Resources._2;
                    break;
                case 3:
                    animationObject.Image = Properties.Resources._3;
                    break;
                case 4:
                    animationObject.Image = Properties.Resources._4;
                    break;
                    
                case 5:
                    animationObject.Image = Properties.Resources._5;
                    break;

                  
            }
           
        }
        public static void MoveDown(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X,Y += speed);
        }
        public static void RestarPosition(PictureBox animationObject)
        {
            X = 770;
            Y = 16;
            animationObject.Location = new Point(X, Y);
        }
        public static void MoveUp(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X, Y-= speed);
        }
        public static void MoveLeft(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X-= speed, Y);
        }
        public static void MoveRight(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X+= speed, Y);
        }
    }
}
