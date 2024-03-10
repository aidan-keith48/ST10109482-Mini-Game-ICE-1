using ST10109482_Mini_Game_ICE_1.Forms;
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

namespace ST10109482_Mini_Game_ICE_1
{
    public partial class StartScreenForm : Form
    {
        //Declare objects
        CPUScreen cpu = new CPUScreen();
        MuiltplayerScreen multiplayer = new MuiltplayerScreen();
        SoundPlayer sound = new SoundPlayer();
        SoundPlayer startSound = new SoundPlayer();


        public StartScreenForm()
        {
            InitializeComponent();
            ChoiceCombo.SelectedIndex = 0;   
            startMessage();
        }

        //----------------------------------------------------------

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (ChoiceCombo.SelectedItem.Equals("CPU MODE"))
            {
                startSound.Stop();
                cpuStartMessage();
                cpu.ShowDialog();
                sound.Stop();                            
            }
            else if (ChoiceCombo.SelectedItem.Equals("MULTIPLAYER MODE"))
            {
                startSound.Stop();
                MultiplayerStartMessage();
                multiplayer.ShowDialog();
                sound.Stop();                              
            }
        }

        //----------------------------------------------------------

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.Stop();
        }

        //----------------------------------------------------------

        private void SoundOnBtn_Click(object sender, EventArgs e)
        {
            sound.SoundLocation = "backgroundSong.wav";
            sound.PlayLooping();
        }

        //----------------------------------------------------------

        private void startMessage()
        {
            startSound.SoundLocation = "startvoice.wav";

            startSound.Play();
        }

        //----------------------------------------------------------

        public void cpuStartMessage()
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = "cpuvoice.wav";
            sound.Play();
        }

        //----------------------------------------------------------

        public void MultiplayerStartMessage()
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = "speech.wav";
            sound.Play();
        }

        //----------------------------------------------------------
    }
}
