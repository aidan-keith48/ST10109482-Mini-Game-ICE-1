namespace ST10109482_Mini_Game_ICE_1.Forms
{
    partial class CPUScreen
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
            this.computerPingPongController1 = new ST10109482_Mini_Game_ICE_1.UserControls.ComputerPingPongController();
            this.SuspendLayout();
            // 
            // computerPingPongController1
            // 
            this.computerPingPongController1.Location = new System.Drawing.Point(-3, 8);
            this.computerPingPongController1.Name = "computerPingPongController1";
            this.computerPingPongController1.Size = new System.Drawing.Size(1452, 845);
            this.computerPingPongController1.TabIndex = 0;
            // 
            // CPUScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 847);
            this.Controls.Add(this.computerPingPongController1);
            this.Name = "CPUScreen";
            this.Text = "CPUScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ComputerPingPongController computerPingPongController1;
    }
}