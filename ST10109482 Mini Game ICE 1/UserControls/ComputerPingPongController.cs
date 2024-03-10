using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10109482_Mini_Game_ICE_1.UserControls
{
    public partial class ComputerPingPongController : UserControl
    {

        string playerOneName = "";
        string playerTwoName = "";

        int ballxSpeed = 4;
        int ballySpeed = 4;
        int speed = 8;

        Random Random = new Random();
        bool goDown, goUp;

        int computer_speed_change = 50;

        int player1_score = 0;
        int cpuScore = 0;

        int playerSpeed = 12;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };

        


        public ComputerPingPongController()
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

        //-----------------------------------------------------

        private void GameOver(string message)
        {
            PongTimer.Stop();
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cpuScore = 0;
            player1_score = 0;
            ballxSpeed = ballySpeed = 4;
            computer_speed_change = 50;
            PongTimer.Start();
        }

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

        }
        //-----------------------------------------------------

        private void MainEvent()
        {


            Ball.Top -= ballySpeed;
            Ball.Left -= ballxSpeed;

            player1scoreLbl.Text = $"{playerOneName}: {player1_score}";
            cpuscoreLbl.Text = $"{playerTwoName}: {cpuScore}";


            if (Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                ballySpeed = -ballySpeed;
            }

            if (Ball.Left < -2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                cpuScore++;
            }

            if (Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                player1_score++;
            }

            if (CPU.Top <= 1)
            {
                CPU.Top = 0;
            }
            else if (CPU.Bottom >= this.ClientSize.Height)
            {
                CPU.Top = this.ClientSize.Height - CPU.Height;
            }

            if (Ball.Top < CPU.Top + (CPU.Height / 2) && Ball.Left > 300)
            {
                CPU.Top -= speed;
            }

            if (Ball.Top > CPU.Top + (CPU.Height / 2) && Ball.Left > 300)
            {
                CPU.Top += speed;
            }

            computer_speed_change -= 1;

            if (computer_speed_change < 0)
            {
                speed = i[Random.Next(i.Length)];
                computer_speed_change = 50;
            }

            if (goDown && Player1.Top + Player1.Height < this.ClientSize.Height)
            {
                Player1.Top += playerSpeed;
            }

            if (goUp && Player1.Top > 0)
            {
                Player1.Top -= playerSpeed;
            }

            CheckCollision(Ball, Player1, Player1.Right + 5);
            CheckCollision(Ball, CPU, CPU.Left - 35);

            if (cpuScore > 10)
            {
                GameOver("CPU Wins");
            }
            else if (player1_score > 10)
            {
                GameOver("Player 1 Wins");
            }
        }
    }
}
