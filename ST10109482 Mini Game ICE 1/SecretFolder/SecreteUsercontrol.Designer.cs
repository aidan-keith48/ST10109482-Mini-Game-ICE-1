namespace ST10109482_Mini_Game_ICE_1.SecretFolder
{
    partial class SecreteUsercontrol
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
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racketTimer = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(496, 831);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(307, 50);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            this.racket.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.IndianRed;
            this.ball.Location = new System.Drawing.Point(642, 718);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(34, 32);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racketTimer
            // 
            this.racketTimer.Enabled = true;
            this.racketTimer.Interval = 20;
            this.racketTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.scoreLbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1286, 884);
            this.playground.TabIndex = 2;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(46, 38);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(116, 42);
            this.scoreLbl.TabIndex = 2;
            this.scoreLbl.Text = "Score";
            // 
            // SecreteUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.playground);
            this.Name = "SecreteUsercontrol";
            this.Size = new System.Drawing.Size(1286, 884);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer racketTimer;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label scoreLbl;
    }
}
