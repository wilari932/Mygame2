using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animacion
{
    public partial class Form1 : Form
    {
        private bool CollisionDown = false;
        private bool SideCollision = false;
        private int Points = 0;
        private int Time = 1000;
        private int Level =1;
        private int playerSize = 100;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Time--;
            TimerLabel.Text = "Time: " + Time;
            if (Time > 0 && Points < LevelStandar())
            {
               

                AnimationObjects.ChangeImage(AnimationObject);
                CheckDown();
                CheckSides();
                CheckPlayerAndGamObejct();
                



            }
            else
            {
                AnimationObjects.RestarPosition(AnimationObject);
                if(Points < LevelStandar())
                {
                    LabelGameOver.Text = "You Win!";
                }
                else
                {
                    LabelGameOver.Text = "You Lose!";
                }
                LabelGameOver.Visible = true;

                labelNewGame.Visible = true;
                timer1.Stop();
               
               
            }


        }
        private void test()
        {
               
            if (Collision.DownWallCollision(WallDown, AnimationObject))
            {
                Points++;
                labellose.Text = "Loses: "+ Points.ToString();
            }
        }
        private void CheckPlayerAndGamObejct()
        {
            if(Collision.DownWallCollision(Playerbox, AnimationObject))
            {
             
                CollisionDown = true;
               AnimationObject.Image = Properties.Resources._6;

            }
        }
        private int LevelStandar()
        {
            if (Level < 10)
                return 2 ;


            else if (Level >= 10 && Level < 30)
                return 4;
            else if (Level >= 30 && Level < 50)
                return 5 ;
            else if (Level <= 50 && Level < 100)
            {
                return 7;
            }
            else if (Level > 100)
            {
                return 10;
            }
            else
            {
                return 10;
            }
        }
        private void CheckSides()
        {
            if (SideCollision == false || Collision.LeftWallCollision(WallRight, AnimationObject))
            {
                AnimationObjects.MoveLeft(AnimationObject, checkLevel());

                SideCollision = false;

            }
            if (SideCollision == true || Collision.RightWallCollision(WallLeft, AnimationObject))
            {
                AnimationObjects.MoveRight(AnimationObject, checkLevel());

                SideCollision = true;
            }

        }

        private void CheckDown()
        {

         
        if(CollisionDown == false || Collision.UpWallCollision(Walltop, AnimationObject))
            {
                AnimationObjects.MoveDown(AnimationObject, checkLevel());
            
                    CollisionDown = false;
              
            }
        if(CollisionDown == true || Collision.DownWallCollision(WallDown, AnimationObject))
            {
                test();
                AnimationObjects.MoveUp(AnimationObject, checkLevel());
                
                CollisionDown = true;
                
            }

        }
       private int checkLevel()
        {
            int a = 0; 
            for( int i =0; i <= Level; i++)
            {
                a++;
            }
          
            return a;
           
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            Playerbox.Size = new Size(playerSize, 50);
            timer1.Start();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    if (!Collision.RightWallCollision(WallLeft, Playerbox))
                    Player.MoveLeft(Playerbox, 50);
                    break;
                case Keys.D:
                    if(!Collision.LeftWallCollision(WallRight, Playerbox))
                    Player.MoveRight(Playerbox, 50);
                    break;

            }

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void labelNewGame_Click(object sender, EventArgs e)
        {
         
      
            if (Points < LevelStandar())
            {
              
                    Level++;
                    Time = Level*100 + 1000;

                if(Level < 40)
                {
                    Playerbox.Size = new Size(playerSize +=10, 50);
                }

                labellevel.Text = "Level: " + Level;

               
            }
            LabelGameOver.Visible = false;
            labelNewGame.Visible = false;
           
            
            Points = 0;
            labellose.Text = "Loses: " + Points.ToString();

            timer1.Start();
            
        }
    }
}
