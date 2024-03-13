using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10109482_Mini_Game_ICE_1.UserControls
{
    public partial class MuiltiplayerPingPongController : UserControl
    {
        SoundPlayer sound = new SoundPlayer();

        string playerOneName = "";
        string playerTwoName = "";

        int ballxSpeed = 4;
        int ballySpeed = 4;
        int speed = 8;

        Random Random = new Random();
        bool goDown, goUp;
        bool goDown2, goUp2;

        int computer_speed_change = 50;

        int player1_score = 0;
        int player2_score = 0;

        int playerSpeed = 12;
        int[] i = { 8, 11, 14, 5 };
        int[] j = { 14, 9, 8, 11, 12 };

        public MuiltiplayerPingPongController()
        {
            InitializeComponent();
            PongTimer.Stop();   
        }

        //-----------------------------------------------------

        private void GameTimerEvent(object sender, EventArgs e)
        {
            this.MainEvent();
        }

        //-----------------------------------------------------

        public void MainEvent()
        {
            Ball.Top -= ballySpeed;
            Ball.Left -= ballxSpeed;

            // Update score labels for both players
            player1scoreLbl.Text = $"{playerOneName}: {player1_score}";
            player2scoreLbl.Text = $"{playerTwoName}: {player2_score}";

            // Handle collisions with walls
            if (Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                ballySpeed = -ballySpeed;
            }

            // Check win conditions
            if (Ball.Left < -2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                player2_score++;
                ChangeFormColor();
            }

            if (Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                player1_score++;
                ChangeFormColor();
            }

            if (goDown && Player1.Top + Player1.Height < this.ClientSize.Height)
            {
                Player1.Top += playerSpeed;
            }

            if (goUp && Player1.Top > 0)
            {
                Player1.Top -= playerSpeed;
            }

            if (goDown2 && Player2.Top + Player2.Height < this.ClientSize.Height)
            {
                Player2.Top += playerSpeed;
            }

            if (goUp2 && Player2.Top > 0)
            {
                Player2.Top -= playerSpeed;
            }

            CheckCollision(Ball, Player1, Player1.Right + 5);
            CheckCollision(Ball, Player2, Player2.Left - 35);

            if (player1_score > 10)
            {
                GameOver($"{playerOneName} Wins");
            }
            else if (player2_score > 10)
            {
                GameOver($"{playerTwoName} Wins");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }

            if(e.KeyCode == Keys.Escape)
            {
                PongTimer.Stop();
                this.Dispose();
            }
        }

        //-----------------------------------------------------

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
        }

        //-----------------------------------------------------

        private void MovePlayer2Up(object sender, KeyEventArgs e)
        {
            // Move Player 2 paddle up
            if (e.KeyCode == Keys.L)
            {
                goDown2 = false;
            }

            if (e.KeyCode == Keys.O)
            {
                goUp2 = false;
            }
        }

        //-----------------------------------------------------

        private void MovePlayer2Down(object sender, KeyEventArgs e)
        {
            // Move Player 2 paddle down
            if (e.KeyCode == Keys.L)
            {
                goDown2 = true;
            }

            if (e.KeyCode == Keys.O)
            {
                goUp2 = true;
            }
        }

        //-----------------------------------------------------

        private void startBtn_Click(object sender, EventArgs e)
        {
            playerOneName = playerOneNameTxt.Text;
            playerTwoName = playerTwoNameTxt.Text;
            PongTimer.Start();
            startBtn.Dispose();
            playerTwoNameTxt.Dispose();
            playerOneNameTxt.Dispose();
            label1.Dispose();
            label2.Dispose();
            this.pictureBox1.Dispose();
            this.label3.Dispose();
            this.SoundBtn.Dispose();
            this.SoundOnBtn.Dispose();
        }

        //-----------------------------------------------------

        private void CheckCollision(PictureBox box1, PictureBox box2, int offset)
        {
            if (box1.Bounds.IntersectsWith(box2.Bounds))
            {
                box1.Left = offset;

                int x = j[Random.Next(j.Length)];
                int y = j[Random.Next(i.Length)];

                if (ballxSpeed < 0)
                {
                    ballxSpeed = x;
                }
                else
                {
                    ballxSpeed = -x;
                }

                if (ballySpeed < 0)
                {
                    ballySpeed = -y;
                }
                else
                {
                    ballySpeed = y;
                }

            }
        }

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.Stop();
        }

        private void SoundOnBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.PlayLooping();
        }

        //-----------------------------------------------------

        private void GameOver(string message)
        {
            PongTimer.Stop();
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            player2_score = 0;
            player1_score = 0;
            ballxSpeed = ballySpeed = 4;
            computer_speed_change = 50;
            PongTimer.Start();
        }

        //-----------------------------------------------------

        private void ChangeFormColor()
        {
            Random random = new Random();

            int red = random.Next(0, 256); // Generate a random value between 0 and 255 for red component
            int green = random.Next(0, 256); // Generate a random value between 0 and 255 for green component
            int blue = random.Next(0, 256); // Generate a random value between 0 and 255 for blue component

            // Create a new Color object with the random RGB values
            Color randomColor = Color.FromArgb(red, green, blue);

            // Set the form's background color to the random color
            this.BackColor = randomColor;
        }

        //-----------------------------------------------------
    }
}

//-------------------------------------------------End of File------------------------------------------------
