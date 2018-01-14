using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Animacion
{
    class Collision
    {
        public static bool DownWallCollision(PictureBox DownWall, PictureBox animationObject)
        {


            return animationObject.Bounds.IntersectsWith(DownWall.Bounds);
            
        }
        public static bool UpWallCollision(PictureBox UpDownWall, PictureBox animationObject)
        {
            return animationObject.Bounds.IntersectsWith(UpDownWall.Bounds);
        }
        public static bool LeftWallCollision(PictureBox LeftDownWall, PictureBox animationObject)
        {
            return animationObject.Bounds.IntersectsWith(LeftDownWall.Bounds);
        }
        public static bool RightWallCollision(PictureBox RightDownWall, PictureBox animationObject)
        {
            return animationObject.Bounds.IntersectsWith(RightDownWall.Bounds);
        }
    }
}
