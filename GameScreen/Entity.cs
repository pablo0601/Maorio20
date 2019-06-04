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
        int deltaY;
        int deltaX;
        public bool canJump = false;

        //Picture Box Stuff
        public PictureBox hitBox;

        //GRAVITY
        public void Gravity(List<Block> blocks)
        {
            deltaY = deltaY + (int)1; // Number is acceleration due to gravity
           
                Movement(blocks,0);
            

        }

        /// <summary>
        /// Makes Mario Jump
        /// </summary>
        /// <param name="speed">How much to YEET Mario up by</param>
        public void Jump(int speed)
        {
            if (canJump == true) { deltaY = deltaY + speed; } //If Mario is able to jump, then add speed to deltaY variable (Jump)
            canJump = false; // Mario can not jump in air
        }

        /// <summary>
        /// Movement and Collision With Blocks
        /// </summary>
        /// <param name="block">The blocks and walls Mario collides with</param>
        /// <param name="speed">The Distance to move by</param>
        public void Movement(List<Block> blocks, int speed)
        {
            Rectangle bounds = hitBox.Bounds; //Creates Rectangle around Hitbox
            bounds.Y = bounds.Y + deltaY;
            bounds.X = bounds.X + speed;
            foreach (Block block in blocks)
            {
                if (bounds.IntersectsWith(block.hitBox.Bounds)) // Y bounds Check while Mario is going Down
                {
                    bounds.Y = bounds.Y - (bounds.Bottom - block.hitBox.Bounds.Y);// Move Rectangle Vertically to Checked Location
                    deltaY = 0; // While on ground Gravity does not pull Mario through ground
                    canJump = true; // Mario can jump on Ground
                } 
            }
            hitBox.Location = bounds.Location; // Move mario to new location of Rectangle
        }
    }
}
