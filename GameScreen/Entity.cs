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
        public bool canJump = false;
        
        //Picture Box Stuff
        public PictureBox hitBox;

        //GRAVITY
        public void Gravity(Block bros)
        {
            deltaY = deltaY + (int)1; // Number is acceleration due to gravity
            blockColide(bros);
        }

        /// <summary>
        /// Moves the Entity in the X direction
        /// </summary>
        /// <param name="speed">The amount to move by</param>
        public void DirectionX(int speed)
        {
            hitBox.Location = new Point(hitBox.Location.X + speed, hitBox.Location.Y);
        }

        //JUMP MOVEMENT
        public void Jump(int speed)
        {
            if (canJump == true) { deltaY = deltaY + speed; } //If Mario is able to jump, then add speed to deltaY variable (Jump)
            canJump = false; // Mario can not jump in air
        }

        //COLLISION WITH BLOCKS
        public void blockColide(Block block)
        {
            Rectangle bounds = hitBox.Bounds; //Creates Rectangle around Hitbox
            bounds.Y = bounds.Y + deltaY;
            if (bounds.IntersectsWith(block.hitBox.Bounds)) // Y bounds Check while Mario is going Down
            {
                bounds.Y = bounds.Y - (bounds.Bottom - block.hitBox.Bounds.Y) ;// Move Rectangle Vertically to Checked Location
                deltaY = 0; // While on ground Gravity does not pull Mario through ground
                canJump = true; // Mario can jump on Ground
            }
            hitBox.Location = bounds.Location; // Move mario to new location of Rectangle
        }
    }
}
