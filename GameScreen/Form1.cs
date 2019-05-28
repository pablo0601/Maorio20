using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreen
{
    public partial class MarioBros : Form
    {

        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool upDown = false;
        int runSpeed = 3;

        Mario mario;
        public Block ground;
        public MarioBros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mario = new Mario(this);
            ground = new Block(this);
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftDown = true; }
            if (e.KeyCode == Keys.A) { aDown = true; }
            if (e.KeyCode == Keys.D) { dDown = true; }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftDown = false; }
            if (e.KeyCode == Keys.A) { aDown = false; }
            if (e.KeyCode == Keys.D) { dDown = false; }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aDown == true)
            {
                Debug.WriteLine("A");
                if (dDown != true)
                {
                    mario.DirectionX(-1 * runSpeed);
                }
            }
            if (dDown == true)
            {
                Debug.WriteLine("D");
                if (aDown != true)
                {
                    mario.DirectionX(runSpeed);
                }

            }
            if (leftDown == true)
            {
                Debug.WriteLine("Jump");
                mario.Jump(-15);
            }
            if (upDown == true)
            {
                Debug.WriteLine("Run");
                
                
            }
            mario.Gravity(this);

        }
    }
}
