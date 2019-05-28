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
        int deltaY;

        bool canJump = false;
        public PictureBox hitBox;

        public void Gravity(MarioBros bros)
        {
            deltaY = deltaY + (int)1; // Number is acceleration due to gravity
            blockColide(bros.ground);
            //hitBox.Location = new Point(hitBox.Location.X, hitBox.Location.Y + deltaY);

        }

        public void DirectionX(int speed)
        {
            hitBox.Location = new Point(hitBox.Location.X + speed, hitBox.Location.Y);
        }

        public void Jump(int speed)
        {
            if (canJump == true) { deltaY = deltaY + speed; }
            canJump = false;
        }

        public void blockColide(Block block)
        {
            Rectangle bounds = hitBox.Bounds;
            bounds.Y = bounds.Y + deltaY;
            if (bounds.IntersectsWith(block.hitBox.Bounds)) // Y bounds Check while Down
            {
                bounds.Y = bounds.Y - (bounds.Bottom - block.hitBox.Bounds.Y) ;
                deltaY = 0;
                canJump = true;
            }
            hitBox.Location = bounds.Location;
        }
    }
}
