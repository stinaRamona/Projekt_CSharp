namespace ProjektCsharp
{
    public partial class pong : Form
    {
        public pong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //n�r man trycker ner
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //n�r man sl�pper
        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            //n�r tv� bilder m�ter varandra (typ boll och spelare/dator)
        }

        private void GameOver(string message)
        {
            //N�r antingen spelaren eller datorn vinner
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
