using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10109482_Mini_Game_ICE_1.SecretFolder
{
    public partial class SecreteUsercontrol : UserControl
    {
        //private object playground;
        public int speed_left = 4;
        public int speed_top = 4;
        public int score = 0;

        public SecreteUsercontrol()
        {
            InitializeComponent();
            racket.Top = playground.Bottom - (playground.Bottom / 10);
            this.Width = 500;
            this.Height = 500;
            this.playground.Width = 500;
            this.playground.Height = 500;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            this.scoreLbl.Text = "Score: " + score;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                score++;
                ChangeFormColor();
            }

            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }

            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            //if(ball.Bottom >= playground.Bottom)
            //{
            //    GameOver("You lose");
            //}
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void GameOver(string message)
        {
            racketTimer.Stop();
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            score = 0;
            ball.Top = playground.Bottom - (playground.Bottom / 10);
            racketTimer.Start();
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
