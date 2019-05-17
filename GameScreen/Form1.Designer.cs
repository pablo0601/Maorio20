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
            this.MarioHitBox = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarioHitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // MarioHitBox
            // 
            this.MarioHitBox.Image = global::GameScreen.Properties.Resources.Mario1;
            this.MarioHitBox.Location = new System.Drawing.Point(362, 246);
            this.MarioHitBox.Name = "MarioHitBox";
            this.MarioHitBox.Size = new System.Drawing.Size(12, 16);
            this.MarioHitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MarioHitBox.TabIndex = 1;
            this.MarioHitBox.TabStop = false;
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
            // MarioBros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MarioHitBox);
            this.Controls.Add(this.Ground);
            this.Name = "MarioBros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarioHitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox MarioHitBox;
    }
}

