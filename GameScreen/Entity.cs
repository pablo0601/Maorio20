using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    class Entity
    {
        //IMPROVE RUN TO FIT ALL CONDITIONS
        //ADD SIDE COLISION

        //Variable Decleration
        int deltaY = 0;
        int deltaX = 0;
        public bool canJump = false;

        //Picture Box Stuff
        public PictureBox hitBox;
        

        /// <summary>
        /// Makes Mario Jump
        /// </summary>
        /// <param name="speed">How much to YEET Mario up by</param>
        public void Jump(int speed)
        {
            if (canJump == true) deltaY = deltaY + speed;  //If Mario is able to jump, then add speed to deltaY variable (Jump)
            canJump = false; // Mario can not jump in air
        }



        /// <summary>
        /// Movement and Collision With Blocks
        /// </summary>
        /// <param name="block">The blocks and walls Mario collides with</param>
        /// <param name="speed">The Distance to move by</param>
        public void Movement(List<Block> blocks, int RunSpeed, bool isMove)
        {
            bool isUp = false;
            Rectangle boundsY = hitBox.Bounds; //Creates Y Rectangle around Hitbox
            Rectangle boundsX = hitBox.Bounds; //Creates X Rectangle around Hitbox
            deltaX = 
                isMove ? RunSpeed :          //is Mario Moving?
                deltaX > 0 ? deltaX - 1 :    //is Mario moving Left?
                deltaX == 0 ? deltaX :       //
                deltaX + 1;

            boundsY.Y = boundsY.Y + deltaY;
            boundsX.X = boundsX.X + deltaX;


            deltaY = deltaY + (int)1; // Number is acceleration due to gravity
            isUp = deltaY > 0 ? false : true;



            //-----------------------------------------//
            //--------------- COLISION ----------------//
            //-----------------------------------------//
            // if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = boundsX.X - (boundsX.Right - block.hitBox.Bounds.X);
            //^if mario X checker intersects with block hitbox^     ^ mario X checker moves to right side of block^

            // if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = block.hitBox.Left + block.hitBox.Width;
            //^if mario X checker intersects with block hitbox^    ^ mario X checker moves to left side of block^


            foreach (Block block in blocks)
            {
                if (block.hitBox.Location.X > (boundsX.Location.X + 100) || (block.hitBox.Location.X < (boundsX.Location.X - 100)))
                    
                    
                    
                    
                    
                    //LR Collision
                    switch (RunSpeed)
                    {
                    case (3):
                        if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = boundsX.X - (boundsX.Right - block.hitBox.Bounds.X);
                        break;
                    case (6):
                        if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = boundsX.X - (boundsX.Right - block.hitBox.Bounds.X);
                        break;
                    case (-3):
                        if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = block.hitBox.Left + block.hitBox.Width;
                        break;
                    case (-6):
                        if (boundsX.IntersectsWith(block.hitBox.Bounds)) boundsX.X = block.hitBox.Left + block.hitBox.Width;
                        break;

                }

                //Up Down Collision
                switch (isUp)
                {
                    case true:
                        if (boundsY.IntersectsWith(block.hitBox.Bounds))
                        {
                            boundsY.Y = block.hitBox.Top + block.hitBox.Height;
                            deltaY = 0;
                            //canJump = true; // uncoment this line for SPIDERMAN
                        }
                        break;
                    case false:

                        if (boundsY.IntersectsWith(block.hitBox.Bounds)) //If mario intersects with block
                        {
                            boundsY.Y = boundsY.Y - (boundsY.Bottom - block.hitBox.Bounds.Y);//moves bounds to outside of block
                            deltaY = 0; // While on ground Gravity does not pull Mario through ground
                            canJump = true; // Mario can jump on Ground
                        }
                        break;
                }
            }
            hitBox.Location = new Point(boundsX.Left, boundsY.Top);    // Move mario to rectangle location
        }

    }
}
