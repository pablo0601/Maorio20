using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
     public class Block
     {
        public PictureBox hitBox;
        
        //BLOCK CONSTRUCTOR
        public Block(PictureBox bros)
        {
            hitBox = bros;
        }
     }
}
