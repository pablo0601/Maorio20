using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    class Block
    {
        PictureBox hitBox;
        public Block(MarioBros bros)
        {
            hitBox = bros.Ground;
        }
    }
}
