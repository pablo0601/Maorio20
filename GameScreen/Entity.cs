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

        // Variable Decleration
        int displacementX = 0;              //entitys displacement on the X plane
        int displacementY = 0;              //entitys displacement on the Y plane
        int velocityX = 0;                  //entitys velocity on the X plane
        int velocityY = 0;
        int gravity = 1;                    //Gravitational pull on planet Mario
        public bool canJump = false;        //bool determining if the entity can jump
        public PictureBox hitBox;           //picture box creating the hitbox of entitys current position
        

        /// <summary>
        /// Makes Mario Jump
        /// </summary>
        /// <param name="velocityY">The velocity of entitys jump</param>
        public void Jump(int velocityY)
        {
            if (canJump == true) displacementY = displacementY + velocityY;  //If Mario is able to jump, then add speed to displacementY variable (Jump)
            canJump = false; // Mario can not jump in air
        }

        


        /// <summary>
        /// Movement and Collision With Blocks
        /// </summary>
        /// <param name="block">The blocks and walls Mario collides with</param>
        /// <param name="speed">The Distance to move by</param>
        public void Movement(List<Block> blocks, int RunSpeed, bool isMove)
        {
            //Gravity
            velocityY = velocityY + gravity;
            displacementY = displacementY + velocityY;

            hitBox.Location.Y.Equals(hitBox.Location.Y + displacementY);
            

            foreach  (Block block in blocks)
            {
                if(block.hitBox.Bounds.IntersectsWith(hitBox.Bounds))
                {

                }

            }
        }

    }
}
