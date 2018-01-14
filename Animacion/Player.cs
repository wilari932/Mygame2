using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Animacion
{
    class Player
    {
        private static int Y = 765;
        private static int X = 770;

        public static void MoveDown(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X, Y += speed);
        }
        public static void MoveUp(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X, Y -= speed);
        }
        public static void MoveLeft(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X -= speed, Y);
        }
        public static void MoveRight(PictureBox animationObject, int speed)
        {
            animationObject.Location = new Point(X += speed, Y);
        }

    }
}
