namespace ST10109482_Mini_Game_ICE_1.Forms
{
    partial class MuiltplayerScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.muiltiplayerPingPongController1 = new ST10109482_Mini_Game_ICE_1.UserControls.MuiltiplayerPingPongController();
            this.SuspendLayout();
            // 
            // muiltiplayerPingPongController1
            // 
            this.muiltiplayerPingPongController1.Location = new System.Drawing.Point(0, 0);
            this.muiltiplayerPingPongController1.Name = "muiltiplayerPingPongController1";
            this.muiltiplayerPingPongController1.Size = new System.Drawing.Size(1493, 915);
            this.muiltiplayerPingPongController1.TabIndex = 0;
            // 
            // MuiltplayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 914);
            this.Controls.Add(this.muiltiplayerPingPongController1);
            this.Name = "MuiltplayerScreen";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MuiltiplayerPingPongController muiltiplayerPingPongController1;
    }
}