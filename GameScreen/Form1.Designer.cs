namespace GameScreen
{
    partial class MarioBros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Mario1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::GameScreen.Properties.Resources.Ground;
            this.Ground.Location = new System.Drawing.Point(43, 370);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(725, 64);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Mario1
            // 
            this.Mario1.BackColor = System.Drawing.Color.Transparent;
            this.Mario1.Image = global::GameScreen.Properties.Resources.Mario1;
            this.Mario1.Location = new System.Drawing.Point(385, 169);
            this.Mario1.Name = "Mario1";
            this.Mario1.Size = new System.Drawing.Size(10, 15);
            this.Mario1.TabIndex = 1;
            this.Mario1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MarioBros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mario1);
            this.Controls.Add(this.Ground);
            this.Name = "MarioBros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Mario1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox Ground;
    }
}

