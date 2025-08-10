using System.Runtime.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int player1Position = 110;
        private int player2Position = 110;
        private int ballX = 485;
        private int ballY = 244;
        private bool ballStateX = true;
        private bool ballstateY = true;
        private int ballSpeed = 10;
        private int player1Score = 0;
        private int player2Score = 0;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && player1Position < this.ClientSize.Height - pictureBox1.Size.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, player1Position += 10);

            }
            if (e.KeyCode == Keys.Up && player1Position > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, player1Position -= 10);

            }

            if (e.KeyCode == Keys.S && player2Position < this.ClientSize.Height - pictureBox2.Size.Height)
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

            myTimer.Interval = 60;
            myTimer.Start();

        }
        void BallLogic()
        {

            Ball.Location = new Point(ballX, ballY);

            if (ballX <= 0)
            {
                ballStateX = true;
            }
            if (ballX >= this.ClientSize.Width)
            {
                ballStateX = false;
            }
            if (ballY <= 5)
            {
                ballstateY = false;
            }
            if (ballY >= this.ClientSize.Height)
            {
                ballstateY = true;
            }


            if (ballStateX == true)
            {
                ballX += ballSpeed;
            }
            else
            {
                ballX -= ballSpeed;

            }


            if (ballstateY == true)
            {
                ballY -= ballSpeed;
            }
            else
            {
                ballY += ballSpeed;
            }


        }

        void GameLogic()
        {
            if (ballX >= this.ClientSize.Width && ballY < player2Position || ballX >= this.ClientSize.Width && ballY > pictureBox2.Size.Height + pictureBox2.Location.Y)
            {
                label1.Text=$"{player1Score += 1}";

                ballX = 485;
                ballY = 244;
            }
            if (ballX <= 0 && ballY < player1Position || ballX <= 0 && ballY > pictureBox1.Size.Height + pictureBox1.Location.Y)
            {
                label2.Text = $"{player2Score += 1}";
                ballX = 485;
                ballY = 244;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer(object sender, EventArgs e)
        {
            BallLogic();
            GameLogic();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Ball_click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
