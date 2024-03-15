using ST10109482_Mini_Game_ICE_1.SecretFolder;
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

        Random Random = new Random();
        bool goDown, goUp;
        bool goDown2, goUp2;     

        int player1_score = 0;
        int player2_score = 0;

        int playerSpeed = 12;
        int[] i = { 8, 11, 14, 5 };
        int[] j = { 14, 9, 8, 11, 12 };

        public MuiltiplayerPingPongController()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.MovePlayer2Down);
            this.KeyUp += new KeyEventHandler(this.MovePlayer2Up);
            PongTimer.Stop(); 
        }

        //-----------------------------------------------------

        private void GameTimerEvent(object sender, EventArgs e)
        {
            this.MainEvent();
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method is the main event for the game and handles all the game logic and events
        /// </summary>
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
            
            // Check win conditions
            if (Ball.Right > this.ClientSize.Width + 2)
            {
                Ball.Left = 300;
                ballxSpeed = -ballxSpeed;
                player1_score++;
                ChangeFormColor();
            }

            // Handle collisions with paddles
            if (goDown && Player1.Top + Player1.Height < this.ClientSize.Height)
            {
                Player1.Top += playerSpeed;
            }

            // Handle collisions with paddles
            if (goUp && Player1.Top > 0)
            {
                Player1.Top -= playerSpeed;
            }

            // Handle collisions with paddles
            if (goDown2 && Player2.Top + Player2.Height < this.ClientSize.Height)
            {
                Player2.Top += playerSpeed;
            }


            // Handle collisions with paddles
            if (goUp2 && Player2.Top > 0)
            {
                Player2.Top -= playerSpeed;
            }

            // Check for collisions with paddles
            CheckCollision(Ball, Player1, Player1.Right + 5);
            CheckCollision(Ball, Player2, Player2.Left - 35);


            // Check for win conditions
            if (player1_score > 10)
            {
                sound.Stop();
                GameOver($"{playerOneName} Wins");
                sound.SoundLocation = "success-1-6297.wav";
                sound.Play();
            }
            else if (player2_score > 10)
            {
                sound.Stop();
                GameOver($"{playerTwoName} Wins");
                sound.SoundLocation = "success-1-6297.wav";
                sound.Play();
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method handles the key down event for the form while hnalding some game logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Move Player 1 paddle down
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }

            // Move Player 1 paddle up
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }

            // Start the game
            if (e.KeyCode == Keys.Enter)
            {
                sound.Stop();
                sound.SoundLocation = "backgroundSong.wav";
                sound.Play();
                PongTimer.Start();
            }

            // Exit the game
            if (e.KeyCode == Keys.Escape)
            {
                PongTimer.Stop();
                //Application.Exit();

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
        /// This method handles the key up event for the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Move Player 1 paddle down
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            // Move Player 1 paddle up
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method handles the key down event for the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovePlayer2Up(object sender, KeyEventArgs e)
        {
            // Move Player 2 paddle up
            if (e.KeyCode == Keys.L)
            {
                goDown2 = false;
            }

            // Move Player 2 paddle down
            if (e.KeyCode == Keys.O)
            {
                goUp2 = false;
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method handles the key up event for the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovePlayer2Down(object sender, KeyEventArgs e)
        {
            // Move Player 2 paddle down
            if (e.KeyCode == Keys.L)
            {
                goDown2 = true;
            }

            // Move Player 2 paddle up
            if (e.KeyCode == Keys.O)
            {
                goUp2 = true;
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This is the start button click event that starts the game but also has a hidden easter egg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            // This method Hide the start button and textboxes
            DisploseAllControls();

            if(playerOneName == "Rudolf" || playerTwoName == "Rudolf")
            {
                Form parentForm = this.FindForm();

                if (parentForm != null)
                {
                    parentForm.Close();
                }

                SecreteForm secretForm = new SecreteForm();
                secretForm.ShowDialog();                
            }
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method just dispose all the controls on the form and sets text to the player names
        /// </summary>
        public void DisploseAllControls()
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

       
        /// <summary>
        /// This method handles the collision between the ball and the paddles while adding some offset to the ball
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

        /// <summary>
        /// This method handles the game over event and stops the game timer
        /// </summary>
        /// <param name="message"></param>
        private void GameOver(string message)
        {
            PongTimer.Stop();
            MessageBox.Show(message, "Game Over Press enter to start again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            player2_score = 0;
            player1_score = 0;
            ballxSpeed = ballySpeed = 4;            
            sound.SoundLocation = "backgroundSong.wav";
            sound.Play();
        }

        //-----------------------------------------------------

        /// <summary>
        /// This method changes the form color to a random color whenever the ball hits the wall
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

//-------------------------------------------------End of File------------------------------------------------
