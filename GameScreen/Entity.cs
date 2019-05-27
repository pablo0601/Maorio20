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

        bool canJump = true;
        public PictureBox HitBox;

        public void Gravity()
        {
            deltaY = deltaY + (int)1; // Number is acceleration due to gravity
            HitBox.Location = new Point(HitBox.Location.X, HitBox.Location.Y + deltaY);
        }

        public void DirectionX(int speed)
        {
            HitBox.Location = new Point(HitBox.Location.X + speed, HitBox.Location.Y);
        }

        public void Jump(int speed)
        {
            if (canJump == true) { deltaY = deltaY + speed; }
            canJump = false;
        }

        public void checkColide(Block block)
        {
            
        }
    }
}
