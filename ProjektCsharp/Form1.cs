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

        }
    }
}
