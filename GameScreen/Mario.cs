using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    class Mario : Entity
    {
        int NetX;
        int NetY;

        PictureBox MarioHitBox ;

        public Mario(int x , int y)
        {
            MarioHitBox = new PictureBox();
            MarioHitBox.Location = new Point(x, y);
            MarioHitBox.Enabled = true;
            MarioHitBox.Fo;
        }

        public void Dissapear()
        {
            MarioHitBox.Enabled = false;
        }
    }
}
