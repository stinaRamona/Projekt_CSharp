namespace ProjektCsharp
{
    partial class pong
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
            player1 = new PictureBox();
            Computer = new PictureBox();
            ball = new PictureBox();
            playerScore = new Label();
            cpuScore = new Label();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = Color.White;
            player1.Location = new Point(12, 155);
            player1.Name = "player1";
            player1.Size = new Size(20, 120);
            player1.TabIndex = 0;
            player1.TabStop = false;
            // 
            // Computer
            // 
            Computer.BackColor = Color.Gray;
            Computer.Location = new Point(768, 155);
            Computer.Name = "Computer";
            Computer.Size = new Size(20, 120);
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Black;
            ball.Location = new Point(386, 202);
            ball.Name = "ball";
            ball.Size = new Size(25, 25);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // playerScore
            // 
            playerScore.AutoSize = true;
            playerScore.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerScore.Location = new Point(194, 9);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(33, 34);
            playerScore.TabIndex = 3;
            playerScore.Text = "0";
            // 
            // cpuScore
            // 
            cpuScore.AutoSize = true;
            cpuScore.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpuScore.Location = new Point(586, 9);
            cpuScore.Name = "cpuScore";
            cpuScore.Size = new Size(33, 34);
            cpuScore.TabIndex = 4;
            cpuScore.Text = "0";
            // 
            // pong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(cpuScore);
            Controls.Add(playerScore);
            Controls.Add(ball);
            Controls.Add(Computer);
            Controls.Add(player1);
            DoubleBuffered = true;
            Name = "pong";
            Text = "Pong";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player1;
        private PictureBox Computer;
        private PictureBox ball;
        private Label playerScore;
        private Label cpuScore;
    }
}
