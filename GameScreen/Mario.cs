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
        MarioBros bross;

 

        public Mario(int x , int y, MarioBros bros)
        {
            bross = bros;
            HitBox = bros.Mario1;
        }

        public void Dissapear()
        {
           HitBox.Visible = false;
        }
    }
}
