namespace ProjektCsharp
{
    public partial class Pong : Form
    {
        //Variabler för fart för datorn och bollen.
        int ComputerDirection = 5;
        int BallXCoordinate = 5;
        int BallYCoordinate = 5;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if(ball.Top < 0 || ball.Top + Height > ClientSize.Height)
            {
                //bollen går åt motsatt håll
                BallYCoordinate = -BallYCoordinate; 
            }

            //Kontroll ifall bollen nuddar antingen spelarens racket eller datorns racket 
            if(ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(Computer.Bounds))
            {
                //bollen åker i en annan riktning 
                BallXCoordinate = -BallXCoordinate; 
            }

            //kontroll av spelarens rörelser uppåt
            if(PlrDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10; 
            }

            //kontroll av spelarens rörelser nedåt 
            if(PlrDetectedDown == true && player1.Top < BottomBoundry)
            {
                player1.Top += 10; 
            }
            
            //kontroll om det finns en vinnare 
            if(PlayerScore >= 5)
            {
                pongTimer.Stop();
            }
        }
    }
}
