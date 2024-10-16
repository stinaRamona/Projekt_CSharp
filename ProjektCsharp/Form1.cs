namespace ProjektCsharp
{
    public partial class Pong : Form
    {
        //Variabler f�r fart f�r datorn och bollen.
        int ComputerDirection = 5;
        int BallXCoordinate = 5;
        int BallYCoordinate = 5;
        //Variabler f�r att h�lla koll p� po�ng 
        int PlayerScore = 0;
        int CpuScore = 0;
        //Variabler f�r storlek p� spelbanan 
        int BottomBoundry;
        int CenterPoint;
        int YMidpoint;
        int XMidpoint;
        //F�r att detektera r�relse hos spelaren 
        bool PlrDetectedUp;
        bool PlrDetectedDown;
        //F�r att pausa spelet 
        int SpaceBarClicked;

        public Pong()
        {
            InitializeComponent();
            //g�r s� att man inte kan r�ra sig utanf�r spelbanan 
            BottomBoundry = ClientSize.Height - player1.Height;
            XMidpoint = ClientSize.Width / 2;
            YMidpoint = ClientSize.Height / 2; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Kod som k�rs medan timer �r ig�ng (allts� typ hela spelet)
        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //kod f�r var bollen kan fara
            Random NewBallSpot = new Random();
            int NewSpot = NewBallSpot.Next(100, ClientSize.Height - 100);
           
            //kod f�r hur bollen r�r sig 
            ball.Top -= BallYCoordinate;
            ball.Left -= BallXCoordinate;
            
            //kod f�r att datorn ska kunna r�ra sig 
            Computer.Top += ComputerDirection;
            
            //kolla om datorn har n�tt toppen eller botten av spelbanan 
            if (Computer.Top < 0 || Computer.Top > BottomBoundry)
            {
                //Datorn r�r sig �t det andra h�llet 
                ComputerDirection = -ComputerDirection;
            }

            //kolla om daton har f�tt po�ng 
            if (ball.Left < 0)
            {
                //bollen spanar i mitten av spelplanen, men p� en random h�jd
                ball.Left = XMidpoint;
                ball.Top = NewSpot;

                //Bollen b�rjar r�ra sig �t andra h�llet
                BallXCoordinate = -BallXCoordinate;

                //Datorn f�r po�ng... 
                CpuScore++;
                //... Och labeln p� spelet uppdateras med det nya v�rdet
                cpuScoreLabel.Text = CpuScore.ToString(); 
            }

            //kolla om spelaren har f�tt po�ng 
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                //bollen spanar i mitten av spelplanen, men p� en random h�jd
                ball.Left = XMidpoint;
                ball.Top = NewSpot;

                //Bollen b�rjar r�ra sig �t andra h�llet
                BallXCoordinate = -BallXCoordinate;

                //spelaren f�r po�ng... 
                PlayerScore++;
                //... Och labeln p� spelet uppdateras med det nya v�rdet
                playerScoreLabel.Text = PlayerScore.ToString();
            }

            //Kontroll s� att bollen �r i sprlbanan 
            if(ball.Top < 0 || ball.Top + Height > ClientSize.Height)
            {
                //bollen g�r �t motsatt h�ll
                BallYCoordinate = -BallYCoordinate; 
            }

            //Kontroll ifall bollen nuddar antingen spelarens racket eller datorns racket 
            if(ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(Computer.Bounds))
            {
                //bollen �ker i en annan riktning 
                BallXCoordinate = -BallXCoordinate; 
            }

            //kontroll av spelarens r�relser upp�t
            if(PlrDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10; 
            }

            //kontroll av spelarens r�relser ned�t 
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
