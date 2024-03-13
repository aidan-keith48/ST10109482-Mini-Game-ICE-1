namespace ST10109482_Mini_Game_ICE_1.SecretFolder
{
    partial class SecreteForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.secreteUsercontrol1 = new ST10109482_Mini_Game_ICE_1.SecretFolder.SecreteUsercontrol();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // secreteUsercontrol1
            // 
            this.secreteUsercontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(96)))), ((int)(((byte)(139)))));
            this.secreteUsercontrol1.Location = new System.Drawing.Point(0, 0);
            this.secreteUsercontrol1.Name = "secreteUsercontrol1";
            this.secreteUsercontrol1.Size = new System.Drawing.Size(1196, 877);
            this.secreteUsercontrol1.TabIndex = 0;
            // 
            // SecreteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 1228);
            this.Controls.Add(this.secreteUsercontrol1);
            this.Name = "SecreteForm";
            this.Text = "SecreteForm";
            this.Load += new System.EventHandler(this.SecreteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private SecreteUsercontrol secreteUsercontrol1;
    }
}