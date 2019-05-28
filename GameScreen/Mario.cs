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
        public Mario(MarioBros bros)
        {
            hitBox = bros.Mario1;
        }

        public void Dissapear()
        {
           hitBox.Visible = false;
        }

    }
}
