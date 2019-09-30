using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    class Entity
    {
        //-------------------------------------------------//
        //-------------------MOVEMENT----------------------//
        //-------------------------------------------------//
        //Variable Decleration
        int displacementX = 0;
        int velocityX = 0;

        int displacementY = 0;

        public bool canJump = false;

        //Picture Box Stuff
        public PictureBox hitBox;
        

        /// <summary>
        /// Makes Mario Jump
        /// </summary>
        /// <param name="velocityY">The velocity of marios jump</param>
        public void Jump(int velocityY)
        {
            if (canJump == true) displacementY = displacementY + velocityY;  //If Mario is able to jump, then add speed to deltaY variable (Jump)
            canJump = false; // Mario can not jump in air
        }



        /// <summary>
        /// Movement and Collision With Blocks
        /// </summary>
        /// <param name="block">The blocks and walls Mario collides with</param>
        /// <param name="speed">The Distance to move by</param>
        public void Movement(List<Block> blocks, int RunSpeed, bool isMove)
        {

            //deltaX = 
            //    isMove ? RunSpeed :          //is Mario Moving?
            //    deltaX > 0 ? deltaX - 1 :    //is Mario moving Left?
            //    deltaX == 0 ? deltaX :       //
            //    deltaX + 1;

            //bounds.Y = bounds.Y + deltaY;
            //bounds.X = bounds.X + deltaX;


            //deltaY = deltaY + (int)1; // Number is acceleration due to gravity
            //isUp = deltaY > 0 ? false : true;



            //-----------------------------------------//
            //--------------- COLISION ----------------//
            //-----------------------------------------//

            foreach  (Block block in blocks)
            {

            }
        }

    }
}
