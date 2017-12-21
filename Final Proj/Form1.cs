using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj
{
    public partial class mainMenu : Form
    {
        int scene = 1;

        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                if (scene == 1) { scene = 2; }
                if (scene == 2) { scene = 4; }
            }
            if (e.KeyCode == Keys.U)
            {
                if (scene == 1) { scene = 3; }
                if (scene == 2) { scene = 5; }
            }
            if (e.KeyCode == Keys.I)
            {
            }
            switch (scene)
            {
                case 1: //Game Menu
                    this.BackColor = Color.Black;
                    titleLabel.Text = "Game Menu";
                    startLabel.Text = "Start Gameplay";
                    howtoplaylabel.Text = "How To Play";
                    instructionlabel.Text = "Press Y to start, Press U for how to play";
                    break;
                case 2: //Start Gameplay
                    startLabel.Text = "Girl";
                    howtoplaylabel.Text "Boy";
                    break;
                case 3: //how to play
                    this.BackColor = Color.Black;
                    titleLabel.Text = "How to Play";
                    startLabel.Text = "..."; //Instructions and such
                    break;
            }

        }
    }
}
