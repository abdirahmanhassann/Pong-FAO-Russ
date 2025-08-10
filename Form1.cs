using System.Runtime.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int player1Position = 110;
        private int player2Position=110;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && player1Position < 400)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, player1Position += 10);

            }
            if (e.KeyCode == Keys.Up && player1Position > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, player1Position -= 10);

            }

            if(e.KeyCode == Keys.S && player2Position < 400)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, player2Position += 10);
            }
            if (e.KeyCode == Keys.W && player2Position > 0)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, player2Position -= 10);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(GameTimer);
            myTimer.Interval = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
