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
            imageO.Visible = false;
            imageT.Visible = false;
            titleLabel.Text = "Game Menu";
            startLabel.Text = "Start Gameplay";
            howtoplaylabel.Text = "How To Play";
            instructionlabel.Text = "Press Y to start, Press U for how to play";
            //startLabel.Location = new Point(100, 100);
            //startLabel.Text = "H";
        }

        private void mainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }//girl
                else if (scene == 3) { scene = 2; }
            }
            if (e.KeyCode == Keys.U)
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 5; }//guy
            }
            if (e.KeyCode == Keys.I)
            {
            }
            switch (scene)
            {
                case 2: //Start Gameplay
                    imageO.Visible = false;
                    imageT.Visible = false;
                    startLabel.Font = new Font("Impact", 12, FontStyle.Underline);
                    startLabel.Text = "Girl";
                    howtoplaylabel.Text = "Boy";
                    instructionlabel.Text = "Press Y to choose a girl character and Press U to choose a guy character";
                    break;
                case 3: //how to play
                    imageO.Visible = false;
                    imageT.Visible = false;
                    titleLabel.Text = "How to Play";
                    startLabel.Font = new Font("Courier New", 10, FontStyle.Underline);
                    startLabel.Text = "The Living Simulator is inspired by Electronic Arts’ The Sims 3." + "\n" +  "It allows players to choose which" + "\n" +
                        "character they want to be and to give their character " + "\n" + "creative and exclusive names that belong only to" + "\n" +
                        "them. Players can also fill their character’s needs by" + "\n" + " making their character “go to the washroom”, by" + "\n" +
                        "making their character “eat food”, by communicating with" + "\n" + " other characters present in the game, etc. This" + "\n" +
                        "of course means that players are able to move their " + "\n" + "character in desired directions. If needs are not up to a" + "\n" +
                        "certain level, the player’s character can be disliked " + "\n" + "and rejected by other characters or die in the worst" + "\n" +
                        "case scenario. If needs are fulfilled, the character can go" + "\n" + " to work to earn money so that there will be more" + "\n" +
                        "money present in their account. The more money a character has in" + "\n" + " his/her account, the higher the chance" + "\n" +
                        "of them earning likes from other characters. This allows other " + "\n" + "characters to accept certain interactions" + "\n" +
                        "from the player’s character." ; //Instructions and such
                    instructionlabel.Text = "Press Y to proceed";
                    break;
                case 4: //girl
                    titleLabel.Text = "Choosing your character";
                    imageO.Image = Final_Proj.Properties.Resources.girlone;
                    imageT.Image = Final_Proj.Properties.Resources.girltwo;
                    instructionlabel.Location = new Point(12, 350);
                    instructionlabel.Text = "Press Y for the girl on the right and press X for the girl on the left";
                    break;
                case 5: //guy
                    titleLabel.Text = "Choosing your character";
                    break;
                


                
                   
            }

        }

        
    }
}
