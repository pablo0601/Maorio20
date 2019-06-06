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
        //Creating Variables
        public bool isRight = true;
        bool aDown = false;
        bool dDown = false;
        bool sDown = false;
        bool wDown = false;
        bool leftDown = false;
        bool upDown = false;
        int direction;
        public int runSpeed = 3;
        public Block ground;
        public Block wall;
        Mario mario;
        List<Block> blocks = new List<Block>();
        //Initialize Components
        public MarioBros()
        {
            InitializeComponent();
        }

        //Creating Objects and starting Game Timer
        private void Form1_Load(object sender, EventArgs e)
        {
            mario = new Mario(this);
            ground = new Block(Ground);
            wall = new Block(Wall_1);
            timer1.Start();
            blocks.Add(ground);
            blocks.Add(wall);
        }

        // Checking for Key Pressed down 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftDown = true; }
            if (e.KeyCode == Keys.Up) { upDown = true; }
            if (e.KeyCode == Keys.A) { aDown = true; }
            if (e.KeyCode == Keys.D) { dDown = true; }
            if (e.KeyCode == Keys.W) { wDown = true; }
            if (e.KeyCode == Keys.S) { sDown = true; }

        }

        // Checking for Key Released
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftDown = false; }
            if (e.KeyCode == Keys.Up) { upDown = false; }
            if (e.KeyCode == Keys.A) { aDown = false; }
            if (e.KeyCode == Keys.D) { dDown = false; }
            if (e.KeyCode == Keys.W) { wDown = false; }
            if (e.KeyCode == Keys.S) { sDown = false; }
        }


        // What happens when Timer Ticks
        private void timer1_Tick(object sender, EventArgs e)
        {

            // if Key Pressed Manipulate Mario
            if (mario.canJump == true)
            {
                //Checks the runflag and sets the walking speed accordingly
                runSpeed = leftDown ? 6 : 3;
                direction = 0;
                if (aDown == true)
                {
                    Debug.WriteLine("A");
                    if (dDown != true) // making sure mario stays still if left and right pressed
                    {
                        direction = -1;
                    }
                }
                if (dDown == true)
                {
                    Debug.WriteLine("D");
                    if (aDown != true) // making sure mario stays still if left and right pressed
                    {
                        direction = 1;
                    }
                }
            }
            if (wDown == true)              //No Function in Mario, Just added if Needed
            {
                Debug.WriteLine("W");
            }
            if (sDown == true)              //Mario Down Pipe
            {
                Debug.WriteLine("S");
            }
            if (upDown == true)             //Mario Jump
            {
                Debug.WriteLine("Jump");
                mario.Jump(-15);
            }

            isRight = direction >0 ? true : false;
            mario.Movement(blocks, runSpeed * direction, isRight);
            

             
            

        }
    }
}
