namespace ProjektCsharp
{
    public partial class Pong : Form
    {
        //Variabler för fart för datorn och bollen.
        int ComputerDirection = 15;
        int BallXCoordinate = 15;
        int BallYCoordinate = 15;
        //Variabler för att hålla koll på poäng 
        int PlayerScore = 0;
        int CpuScore = 0;
        //Variabler för storlek på spelbanan 
        int BottomBoundry;
        int CenterPoint;
        int YMidpoint;
        int XMidpoint;
        //För att detektera rörelse hos spelaren 
        bool PlrDetectedUp;
        bool PlrDetectedDown;
        //För att pausa spelet 
        int SpaceBarClicked;

        public Pong()
        {
            InitializeComponent();
            //gör så att man inte kan röra sig utanför spelbanan 
            BottomBoundry = ClientSize.Height - player1.Height;
            XMidpoint = ClientSize.Width / 2;
            YMidpoint = ClientSize.Height / 2;

            //gör så man inte ser den labeln förens någon vunnit 
            WinnerLabel.Visible = false;
            ResetLabel.Visible = false; 
        }


        //Kod som körs medan timer är igång (alltså typ hela spelet)
        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //kod för var bollen kan fara
            Random NewBallSpot = new Random();
            int NewSpot = NewBallSpot.Next(100, ClientSize.Height - 100);

            //kod för hur bollen rör sig 
            ball.Top -= BallYCoordinate;
            ball.Left -= BallXCoordinate;

            //kod för att datorn ska kunna röra sig 
            Computer.Top += ComputerDirection;

            //gör att datorn blir bättre om spelaren har 2 poäng eller fler  
            if (PlayerScore > 1)
            {
                //Gör så att datorn följer bollen inom begränsningarna av spelplanen 
                Computer.Top = Math.Max(0, Math.Min(ball.Top + 25, BottomBoundry));
            }

            //kolla om datorn har nått toppen eller botten av spelbanan 
            if (Computer.Top < 0 || Computer.Top > BottomBoundry)
            {
                //Datorn rör sig åt det andra hållet 
                ComputerDirection = -ComputerDirection;
            }

            //kolla om daton har fått poäng 
            if (ball.Left < 0)
            {
                //bollen spanar i mitten av spelplanen, men på en random höjd
                ball.Left = XMidpoint;
                ball.Top = NewSpot;

                //Bollen börjar röra sig åt andra hållet
                BallXCoordinate = -BallXCoordinate;

                //Datorn får poäng... 
                CpuScore++;
                //... Och labeln på spelet uppdateras med det nya värdet
                cpuScoreLabel.Text = CpuScore.ToString();
            }

            //kolla om spelaren har fått poäng 
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                //bollen spanar i mitten av spelplanen, men på en random höjd
                ball.Left = XMidpoint;
                ball.Top = NewSpot;

                //Bollen börjar röra sig åt andra hållet
                BallXCoordinate = -BallXCoordinate;

                //spelaren får poäng... 
                PlayerScore++;
                //... Och labeln på spelet uppdateras med det nya värdet
                playerScoreLabel.Text = PlayerScore.ToString();
            }

            //Kontroll så att bollen är i sprlbanan 
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                //bollen går åt motsatt håll
                BallYCoordinate = -BallYCoordinate;
            }

            //Kontroll ifall bollen nuddar antingen spelarens racket eller datorns racket 
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(Computer.Bounds))
            {
                //bollen åker i en annan riktning 
                BallXCoordinate = -BallXCoordinate;
            }

            //kontroll av spelarens rörelser uppåt
            if (PlrDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10;
            }

            //kontroll av spelarens rörelser nedåt 
            if (PlrDetectedDown == true && player1.Top < BottomBoundry)
            {
                player1.Top += 10;
            }

            //kontroll om spelaren har vunnit 
            if (PlayerScore >= 5)
            {
                WinnerLabel.Text = "Grattis, du vann!";
                WinnerLabel.Visible = true;
                ResetLabel.Visible = true;
                pongTimer.Stop();
            }

            //kontroll om datorn har vunnit 
            if (CpuScore >= 5)
            {
                WinnerLabel.Text = "Synd, datorn vann";
                WinnerLabel.Visible = true;
                ResetLabel.Visible = true; 
                pongTimer.Stop();
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //Om spelaren släpper på upp-knappen slutar racketen röra sig 
            if (e.KeyCode == Keys.Up)
            {
                PlrDetectedUp = false;
            }

            //samma fast ner
            if (e.KeyCode == Keys.Down)
            {
                PlrDetectedDown = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //Om spelaren trycker på upp-knappen ska racketen skickas uppåt 
            if (e.KeyCode == Keys.Up)
            {
                PlrDetectedUp = true;
            }

            //Ner knappen så åker den neråt
            if (e.KeyCode == Keys.Down)
            {
                PlrDetectedDown = true;
            }

            //space bar gör att spelet pausas
            if (e.KeyCode == Keys.Space)
            {
                if(PlayerScore >= 5 || CpuScore >= 5)
                {
                    //om någon har vunnit kan man resetta med mellanslag
                    ResetGame(); 
                }
                else
                {
                    if (SpaceBarClicked % 2 == 0)
                    {
                        pongTimer.Stop();
                    }
                    else
                    {
                        pongTimer.Start();
                    }
                }
            }
            SpaceBarClicked++;
        }

        private void ResetGame()
        {
            //återställer poängen 
            PlayerScore = 0;
            CpuScore = 0;
            playerScoreLabel.Text = "0";
            cpuScoreLabel.Text = "0";

            // Återställ bollens position
            ball.Left = XMidpoint;
            ball.Top = YMidpoint;

            // Återställ spelarens och datorns positioner
            player1.Top = YMidpoint - player1.Height / 2;
            Computer.Top = YMidpoint - Computer.Height / 2;

            // Återställ bollens hastighet
            BallXCoordinate = 15;
            BallYCoordinate = 15;

            // Göm vinstmeddelandet
            WinnerLabel.Visible = false;
            ResetLabel.Visible = false; 

            // Starta om spelet
            pongTimer.Start();
        }
    }
}
