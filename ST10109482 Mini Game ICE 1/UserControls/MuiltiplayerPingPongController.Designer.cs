namespace ST10109482_Mini_Game_ICE_1.UserControls
{
    partial class MuiltiplayerPingPongController
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player2scoreLbl = new System.Windows.Forms.Label();
            this.player1scoreLbl = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.playerTwoNameTxt = new System.Windows.Forms.TextBox();
            this.playerOneNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.PongTimer = new System.Windows.Forms.Timer(this.components);
            this.instructoinLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player2scoreLbl
            // 
            this.player2scoreLbl.AutoSize = true;
            this.player2scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2scoreLbl.Location = new System.Drawing.Point(1165, 75);
            this.player2scoreLbl.Name = "player2scoreLbl";
            this.player2scoreLbl.Size = new System.Drawing.Size(100, 37);
            this.player2scoreLbl.TabIndex = 36;
            this.player2scoreLbl.Text = "Score";
            // 
            // player1scoreLbl
            // 
            this.player1scoreLbl.AutoSize = true;
            this.player1scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1scoreLbl.Location = new System.Drawing.Point(177, 75);
            this.player1scoreLbl.Name = "player1scoreLbl";
            this.player1scoreLbl.Size = new System.Drawing.Size(100, 37);
            this.player1scoreLbl.TabIndex = 35;
            this.player1scoreLbl.Text = "Score";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.IndianRed;
            this.Player1.Location = new System.Drawing.Point(6, 306);
            this.Player1.Margin = new System.Windows.Forms.Padding(4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(37, 252);
            this.Player1.TabIndex = 34;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Tomato;
            this.Player2.Location = new System.Drawing.Point(1454, 306);
            this.Player2.Margin = new System.Windows.Forms.Padding(4);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(35, 252);
            this.Player2.TabIndex = 33;
            this.Player2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 55);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hello Again Beautiful!!!!!";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(764, 619);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(319, 61);
            this.startBtn.TabIndex = 30;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // playerTwoNameTxt
            // 
            this.playerTwoNameTxt.Location = new System.Drawing.Point(764, 508);
            this.playerTwoNameTxt.Multiline = true;
            this.playerTwoNameTxt.Name = "playerTwoNameTxt";
            this.playerTwoNameTxt.Size = new System.Drawing.Size(319, 50);
            this.playerTwoNameTxt.TabIndex = 29;
            // 
            // playerOneNameTxt
            // 
            this.playerOneNameTxt.Location = new System.Drawing.Point(764, 388);
            this.playerOneNameTxt.Multiline = true;
            this.playerOneNameTxt.Name = "playerOneNameTxt";
            this.playerOneNameTxt.Size = new System.Drawing.Size(319, 50);
            this.playerOneNameTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(216, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 51);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter Player Two Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(216, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Player One Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(184, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 499);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ball.Location = new System.Drawing.Point(708, 173);
            this.Ball.Margin = new System.Windows.Forms.Padding(4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(32, 33);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 25;
            this.Ball.TabStop = false;
            // 
            // PongTimer
            // 
            this.PongTimer.Enabled = true;
            this.PongTimer.Interval = 20;
            this.PongTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // instructoinLbl
            // 
            this.instructoinLbl.AutoSize = true;
            this.instructoinLbl.BackColor = System.Drawing.Color.SkyBlue;
            this.instructoinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructoinLbl.Location = new System.Drawing.Point(746, 446);
            this.instructoinLbl.Name = "instructoinLbl";
            this.instructoinLbl.Size = new System.Drawing.Size(0, 31);
            this.instructoinLbl.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 733);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 42);
            this.label4.TabIndex = 38;
            // 
            // MuiltiplayerPingPongController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instructoinLbl);
            this.Controls.Add(this.player2scoreLbl);
            this.Controls.Add(this.player1scoreLbl);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.playerTwoNameTxt);
            this.Controls.Add(this.playerOneNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ball);
            this.Name = "MuiltiplayerPingPongController";
            this.Size = new System.Drawing.Size(1493, 922);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovePlayer2Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MovePlayer2Up);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player2scoreLbl;
        private System.Windows.Forms.Label player1scoreLbl;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox playerTwoNameTxt;
        private System.Windows.Forms.TextBox playerOneNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer PongTimer;
        private System.Windows.Forms.Label instructoinLbl;
        private System.Windows.Forms.Label label4;
    }
}
