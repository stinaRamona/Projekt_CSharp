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

        }
    }
}
