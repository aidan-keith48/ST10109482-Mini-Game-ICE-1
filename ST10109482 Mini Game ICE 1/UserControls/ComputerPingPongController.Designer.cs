namespace ST10109482_Mini_Game_ICE_1.UserControls
{
    partial class ComputerPingPongController
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
            this.PongTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.playerOneNameTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.player1scoreLbl = new System.Windows.Forms.Label();
            this.cpuscoreLbl = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.CPU = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PongTimer
            // 
            this.PongTimer.Enabled = true;
            this.PongTimer.Interval = 20;
            this.PongTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(213, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Player One Name:";
            // 
            // playerOneNameTxt
            // 
            this.playerOneNameTxt.Location = new System.Drawing.Point(761, 361);
            this.playerOneNameTxt.Multiline = true;
            this.playerOneNameTxt.Name = "playerOneNameTxt";
            this.playerOneNameTxt.Size = new System.Drawing.Size(319, 50);
            this.playerOneNameTxt.TabIndex = 16;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(761, 470);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(319, 61);
            this.startBtn.TabIndex = 18;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 55);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hello Again Beautiful!!!!!";
            // 
            // player1scoreLbl
            // 
            this.player1scoreLbl.AutoSize = true;
            this.player1scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1scoreLbl.Location = new System.Drawing.Point(174, 48);
            this.player1scoreLbl.Name = "player1scoreLbl";
            this.player1scoreLbl.Size = new System.Drawing.Size(100, 37);
            this.player1scoreLbl.TabIndex = 23;
            this.player1scoreLbl.Text = "Score";
            // 
            // cpuscoreLbl
            // 
            this.cpuscoreLbl.AutoSize = true;
            this.cpuscoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuscoreLbl.Location = new System.Drawing.Point(1154, 63);
            this.cpuscoreLbl.Name = "cpuscoreLbl";
            this.cpuscoreLbl.Size = new System.Drawing.Size(100, 37);
            this.cpuscoreLbl.TabIndex = 24;
            this.cpuscoreLbl.Text = "Score";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.IndianRed;
            this.Player1.Location = new System.Drawing.Point(3, 279);
            this.Player1.Margin = new System.Windows.Forms.Padding(4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(37, 252);
            this.Player1.TabIndex = 22;
            this.Player1.TabStop = false;
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.Color.Tomato;
            this.CPU.Location = new System.Drawing.Point(1407, 279);
            this.CPU.Margin = new System.Windows.Forms.Padding(4);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(35, 252);
            this.CPU.TabIndex = 21;
            this.CPU.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ball.Location = new System.Drawing.Point(705, 146);
            this.Ball.Margin = new System.Windows.Forms.Padding(4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(32, 33);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 13;
            this.Ball.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(181, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 392);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ComputerPingPongController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cpuscoreLbl);
            this.Controls.Add(this.player1scoreLbl);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.playerOneNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ball);
            this.DoubleBuffered = true;
            this.Name = "ComputerPingPongController";
            this.Size = new System.Drawing.Size(1453, 837);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer PongTimer;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerOneNameTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CPU;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Label player1scoreLbl;
        private System.Windows.Forms.Label cpuscoreLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
