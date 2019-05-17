using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScreen
{
    class Entity
    {
        int deltaX;
        int deltaY;

        private void Gravity()
        {
            deltaY = deltaY + (int)9.81; // Number is acceleration due to gravity
        }

        public void DirectionX(int speed)
        {
            deltaX = deltaX + speed;
            //Console.WriteLine("Forgot To Implement");
        }
       
    }
}
