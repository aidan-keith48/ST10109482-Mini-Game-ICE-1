using ST10109482_Mini_Game_ICE_1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public StartScreenForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (ChoiceCombo.SelectedItem.Equals("CPU MODE"))
            {
                cpu.ShowDialog();
            }
            else if (ChoiceCombo.SelectedItem.Equals("MULTIPLAYER MODE"))
            {
                multiplayer.ShowDialog();
            }
        }
       
    }
}
