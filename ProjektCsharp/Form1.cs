namespace ProjektCsharp
{
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //när man trycker ner
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //när man släpper
        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            //när två bilder möter varandra (typ boll och spelare/dator)
        }

        private void GameOver(string message)
        {
            //När antingen spelaren eller datorn vinner
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //Kod som körs medan timer är igång (alltså typ hela spelet)
        }
    }
}
