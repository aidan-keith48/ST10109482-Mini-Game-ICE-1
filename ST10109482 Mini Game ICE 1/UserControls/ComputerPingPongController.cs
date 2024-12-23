﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10109482_Mini_Game_ICE_1.UserControls
{
    public partial class ComputerPingPongController : UserControl
    {
        SoundPlayer sound = new SoundPlayer();

        string playerOneName = "";

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

        /// <summary>
        /// This method is used to handle the key down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (e.KeyCode == Keys.Enter)
            {
                sound.Stop();
                sound.SoundLocation = "backgroundSong.wav";
                sound.Play();
                PongTimer.Start();
            }

            if (e.KeyCode == Keys.Escape)
            {               
                PongTimer.Stop();
                // Find the parent Form and remove this UserControl
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method is used to handle the key up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is used to check the collision between the ball and the player
        /// </summary>
        /// <param name="box1"></param>
        /// <param name="box2"></param>
        /// <param name="offset"></param>
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

        /// <summary>
        /// This method is used to handle the game over event
        /// </summary>
        /// <param name="message"></param>
        private void GameOver(string message)
        {
            PongTimer.Stop();
            MessageBox.Show(message, "Game Over Press Enter to start Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cpuScore = 0;
            player1_score = 0;
            ballxSpeed = ballySpeed = 4;
            computer_speed_change = 50;
            sound.SoundLocation = "backgroundSong.wav";
            sound.Play();
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method is used to handle the start button click event and dispose all the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            DisploseAllControls();
        }
        //-----------------------------------------------------

        /// <summary>
        ///  This nmethod is used to dispose all the controls
        /// </summary>
        public void DisploseAllControls()
        {
            playerOneName = playerOneNameTxt.Text;
            PongTimer.Start();
            startBtn.Dispose();
            playerOneNameTxt.Dispose();
            label1.Dispose();
           
            this.pictureBox1.Dispose();
            this.label3.Dispose();
            this.SoundBtn.Dispose();
            this.SoundOnBtn.Dispose();
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method is used to handle the main event and all the game logic that happens in the game
        /// </summary>
        private void MainEvent()
        {
            Ball.Top -= ballySpeed;
            Ball.Left -= ballxSpeed;

            player1scoreLbl.Text = $"{playerOneName}: {player1_score}";
            cpuscoreLbl.Text = $"CPU: {cpuScore}";


            if (Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                ballySpeed = -ballySpeed;
            }

            if (Ball.Left < -2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                cpuScore++;
                ChangeFormColor();
            }

            if (Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                player1_score++;
                ChangeFormColor();
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

            if (cpuScore > 1)
            {      
                sound.Stop();
                GameOver("CPU Wins");
                sound.SoundLocation = "success-1-6297.wav";
                sound.Play();
            }
            else if (player1_score > 1)
            {               
                sound.Stop();
                GameOver("Player 1 Wins");
                sound.SoundLocation = "success-1-6297.wav";
                sound.Play();
            }
        }

        //-----------------------------------------------------

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.Stop();
        }

        //-----------------------------------------------------

        private void SoundOnBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.PlayLooping();
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method is used to change the form color on collision
        /// </summary>
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

//----------------------------------------------------End of File------------------------------------------------
