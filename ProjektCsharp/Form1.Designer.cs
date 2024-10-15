namespace ProjektCsharp
{
    partial class Player
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Computer = new PictureBox();
            ball = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Computer
            // 
            Computer.BackColor = Color.Red;
            Computer.Location = new Point(680, 155);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Black;
            ball.Location = new Point(365, 347);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(Computer);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Player";
            Text = "Pong";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Computer;
        private PictureBox ball;
    }
}
