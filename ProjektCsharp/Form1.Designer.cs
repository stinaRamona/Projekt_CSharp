namespace ProjektCsharp
{
    partial class Pong
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
            components = new System.ComponentModel.Container();
            player1 = new PictureBox();
            Computer = new PictureBox();
            ball = new PictureBox();
            playerScoreLabel = new Label();
            cpuScoreLabel = new Label();
            pongTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            WinnerLabel = new Label();
            ResetLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // playerScoreLabel
            // 
            playerScoreLabel.AutoSize = true;
            playerScoreLabel.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerScoreLabel.Location = new Point(194, 9);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(33, 34);
            playerScoreLabel.TabIndex = 3;
            playerScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            cpuScoreLabel.AutoSize = true;
            cpuScoreLabel.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpuScoreLabel.Location = new Point(586, 9);
            cpuScoreLabel.Name = "cpuScoreLabel";
            cpuScoreLabel.Size = new Size(33, 34);
            cpuScoreLabel.TabIndex = 4;
            cpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            pongTimer.Enabled = true;
            pongTimer.Tick += pongTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(397, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 450);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WinnerLabel.Location = new Point(239, 67);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(338, 57);
            WinnerLabel.TabIndex = 6;
            WinnerLabel.Text = "Grattis, du vann!";
            // 
            // ResetLabel
            // 
            ResetLabel.AutoSize = true;
            ResetLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetLabel.Location = new Point(156, 124);
            ResetLabel.Name = "ResetLabel";
            ResetLabel.Size = new Size(508, 32);
            ResetLabel.TabIndex = 7;
            ResetLabel.Text = "Tryck på mellanslag för att spela igen";
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetLabel);
            Controls.Add(WinnerLabel);
            Controls.Add(cpuScoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(ball);
            Controls.Add(Computer);
            Controls.Add(player1);
            Controls.Add(pictureBox1);
            Name = "Pong";
            Text = "Pong";
            KeyDown += Pong_KeyDown;
            KeyUp += Pong_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player1;
        private PictureBox Computer;
        private PictureBox ball;
        private Label playerScoreLabel;
        private Label cpuScoreLabel;
        private System.Windows.Forms.Timer pongTimer;
        private PictureBox pictureBox1;
        private Label WinnerLabel;
        private Label ResetLabel;
    }
}
