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
        Mario mario;
        public MarioBros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mario = new Mario(99, 99, this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.A)
            {
                Debug.WriteLine("A");
                mario.DirectionX(-3);
            }
            if (e.KeyCode == Keys.D)
            {
                Debug.WriteLine("D");
                mario.DirectionX(3);
            }
            if (e.KeyCode == Keys.Left)
            {
                Debug.WriteLine("Jump");
                mario.DirectionY();
            }
            if (e.KeyCode == Keys.Up)
            {
                Debug.WriteLine("Run");
                mario.Dissapear();
            }
        }
    }
}
