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
        string username;

        public mainMenu()
        {
            InitializeComponent();
            
            houseScreen.Visible = false;
            bankmoneyLabel.Visible = false;
            bankLabel.Visible = false;
            workperfLabel.Visible = false;
            hungerlabel.Visible = false;
            hygienelabel.Visible = false;
            loolabel.Visible = false;
            entertainmentlabel.Visible = false;
            imageO.Visible = false;
            imageT.Visible = false;
            titleLabel.Visible = true;
            startLabel.Visible = true;
            howtoplaylabel.Visible = true;
            instructionlabel.Visible = true;
            nameinput.Visible = false;

            titleLabel.Text = "Game Menu";
            startLabel.Text = "Start Gameplay";
            howtoplaylabel.Text = "How To Play";
            instructionlabel.Text = "Press Y to start, Press U for how to play";
            //startLabel.Location = new Point(100, 100);
            //startLabel.Text = "H";
        }
        

        public void needsBar(int needsX, int needsY)
        {
            //creating method to create the needsbar
            Graphics Draw = instructionlabel.CreateGraphics();
            Pen drawNeeds = new Pen(Color.Black, 3);
            SolidBrush fillNeeds = new SolidBrush(Color.LightGreen);
            Draw.DrawRectangle(drawNeeds, needsX, needsY, 120, 20);
            Draw.FillRectangle(fillNeeds, needsX, needsY, 120, 20);
            
        }
        public void workperfBar(int workX, int workY)
        {
            //creating method to create the needsbar
            Graphics Draw = instructionlabel.CreateGraphics();
            Pen drawNeeds = new Pen(Color.Black, 3);
            SolidBrush fillNeeds = new SolidBrush(Color.Yellow);
            Draw.DrawRectangle(drawNeeds, workX, workY, 120, 20);
            Draw.FillRectangle(fillNeeds, workX, workY, 0, 20);

        }
        public void houseRec(int x, int y, int w, int h)
        {
            //creating method to create the needsbar
            Graphics Draw = houseScreen.CreateGraphics();
            Pen draw = new Pen(Color.Black, 3);
            SolidBrush fill = new SolidBrush(Color.Gray);
            Draw.DrawRectangle(draw, x, y, w, h);
            Draw.FillRectangle(fill, x, y, w, h);

        }
        //public void doorRec(int x, int y, int w, int h)
        //{
        //    //creating method to create the needsbar
        //    Graphics Draw = houseScreen.CreateGraphics();
        //    Pen draw = new Pen(Color.Black, 3);
        //    SolidBrush fill = new SolidBrush(Color.Black);
        //    Draw.DrawRectangle(draw, x, y, w, h);
        //    Draw.FillRectangle(fill, x, y, w, h);

        //}


        private void mainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }//girl
                else if (scene == 3) { scene = 2; }
                else if (scene == 4) { scene = 6; }//naming girlone
                else if (scene == 5) { scene = 7; }//naming guyone
                else if (scene == 6) { scene = 10; }//girlone house scene
                else if (scene == 7) { scene = 11; }//guyone house scene
                else if (scene == 8) { scene = 12; }//girltwo house scene
                else if (scene == 9) { scene = 13; }//guytwo house scene

            }
            if (e.KeyCode == Keys.U)
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 5; }//guy
                else if (scene == 4) { scene = 8; }//naming girltwo
                else if (scene == 5) { scene = 9; }//naming guytwo
            }
            if (e.KeyCode == Keys.I)
            {
            }

            switch (scene)
            {
                case 2: //Start Gameplay
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    imageO.Visible = false;
                    imageT.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Location = new Point(274, 170);
                    startLabel.Visible = true;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    nameinput.Visible = false;
                    startLabel.Font = new Font("Impact", 12);
                    howtoplaylabel.Font = new Font("Impact", 12);
                    startLabel.Text = "Girl";
                    howtoplaylabel.Text = "Boy";
                    instructionlabel.Text = "Press Y to choose a girl character and Press U to choose a guy character";
                    break;
                case 3: //how to play
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    imageO.Visible = false;
                    imageT.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = true;
                    howtoplaylabel.Visible = false;
                    instructionlabel.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "How to Play";
                    startLabel.Font = new Font("Courier New", 10);
                    startLabel.Location = new Point(100, 170);
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
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = false;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    imageO.Visible = true;
                    imageT.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "Choosing your character";
                    imageO.Image = Final_Proj.Properties.Resources.girlone;
                    imageT.Image = Final_Proj.Properties.Resources.girltwo;
                    nameinput.Visible = false;
                    instructionlabel.Location = new Point(12, 350);
                    instructionlabel.Text = "Press Y for the girl on the right and press U for the girl on the left";
                    break;
                case 5: //guy
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    startLabel.Visible = false;
                    howtoplaylabel.Visible = true;
                    instructionlabel.Visible = true;
                    imageO.Visible = true;
                    imageT.Visible = true;
                    nameinput.Visible = false;
                    titleLabel.Text = "Choosing your character";
                    imageO.Image = Final_Proj.Properties.Resources.guyone;
                    imageT.Image = Final_Proj.Properties.Resources.guytwo;
                    instructionlabel.Text = "Press Y for the guy on the right and press U for the guy on the left";
                    break;
                case 6: //girlone
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.Pink;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = Final_Proj.Properties.Resources.girlone;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 7: //guyone
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.LightBlue;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = Final_Proj.Properties.Resources.guyone;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 8: //girltwo
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.Pink;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = Final_Proj.Properties.Resources.girltwo;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 9: //guytwo
                    houseScreen.Visible = false;
                    bankmoneyLabel.Visible = false;
                    bankLabel.Visible = false;
                    workperfLabel.Visible = false;
                    hungerlabel.Visible = false;
                    hygienelabel.Visible = false;
                    loolabel.Visible = false;
                    entertainmentlabel.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Naming";
                    startLabel.Location = new Point(100, 170);
                    startLabel.Visible = true;
                    startLabel.Text = "Please Type Character Name";
                    howtoplaylabel.Visible = true;
                    howtoplaylabel.Text = "Press Y to move on";
                    instructionlabel.Location = new Point(12, 400);
                    instructionlabel.Size = new Size(746, 130);
                    instructionlabel.Visible = true;
                    instructionlabel.Text = "";
                    instructionlabel.BackColor = Color.LightBlue;
                    imageO.Location = new Point(12, 400);
                    imageO.Size = new Size(100, 130);
                    imageO.Visible = true;
                    imageO.Image = Final_Proj.Properties.Resources.guytwo;
                    imageT.Visible = false;
                    nameinput.Location = new Point(340, 170);
                    nameinput.Visible = true;
                    username = nameinput.Text;
                    break;
                case 10://girlone house scene
                    houseScreen.Location = new Point(12, 5);
                    houseScreen.Size = new Size(746, 385);
                    houseScreen.Visible = true;
                    //house scene
                    houseRec(250, 0, 5, 80);
                    houseRec(250, 120, 5, 100);
                    houseRec(250, 220, 5, 60);
                    houseRec(250, 325, 5, 60);
                    houseRec(0, 220, 250, 5);
                    houseRec(296, 0, 5, 80);
                    houseRec(296, 120, 5, 120);
                    houseRec(296, 220, 5, 165);
                    houseRec(296, 220, 200, 5);
                    houseRec(541, 220, 200, 5);


                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.Pink;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.Pink;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.Pink;
                    entertainmentlabel.BackColor = Color.Pink;
                    loolabel.BackColor = Color.Pink;
                    hygienelabel.BackColor = Color.Pink;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Visible = false;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274,400);
                    startLabel.Visible = false;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///

                    break;
                case 11://guyone house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.LightBlue;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.LightBlue;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.LightBlue;
                    entertainmentlabel.BackColor = Color.LightBlue;
                    loolabel.BackColor = Color.LightBlue;
                    hygienelabel.BackColor = Color.LightBlue;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Image = null;
                    imageT.Visible = false;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///
                    break;
                case 12://girltwo house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.Pink;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.Pink;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.Pink;
                    entertainmentlabel.BackColor = Color.Pink;
                    loolabel.BackColor = Color.Pink;
                    hygienelabel.BackColor = Color.Pink;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Image = null;
                    imageT.Visible = false;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///
                    break;
                case 13://guytwo house scene
                    bankLabel.Location = new Point(400, 420);
                    bankLabel.BackColor = Color.LightBlue;
                    bankLabel.Text = "Bank";
                    bankLabel.Visible = true;
                    bankmoneyLabel.BackColor = Color.White;
                    bankmoneyLabel.Location = new Point(530, 410);
                    bankmoneyLabel.Visible = true;
                    workperfLabel.Location = new Point(400, 440);
                    workperfLabel.BackColor = Color.LightBlue;
                    workperfLabel.Text = "Work Performance";
                    workperfLabel.Visible = true;

                    workperfBar(520, 40);

                    hungerlabel.BackColor = Color.LightBlue;
                    entertainmentlabel.BackColor = Color.LightBlue;
                    loolabel.BackColor = Color.LightBlue;
                    hygienelabel.BackColor = Color.LightBlue;
                    hungerlabel.Location = new Point(120, 420);
                    entertainmentlabel.Location = new Point(120, 440);
                    loolabel.Location = new Point(120, 460);
                    hygienelabel.Location = new Point(120, 480);
                    hungerlabel.Size = new Size(120, 20);
                    entertainmentlabel.Size = new Size(120, 20);
                    loolabel.Size = new Size(120, 20);
                    hygienelabel.Size = new Size(120, 20);
                    hungerlabel.Visible = true;
                    hygienelabel.Visible = true;
                    loolabel.Visible = true;
                    entertainmentlabel.Visible = true;
                    hungerlabel.Text = "Hunger";
                    entertainmentlabel.Text = "Entertainment";
                    loolabel.Text = "Loo";
                    hygienelabel.Text = "Hygiene";

                    needsBar(250, 10);
                    needsBar(250, 40);
                    needsBar(250, 70);
                    needsBar(250, 100);

                    imageO.Visible = true;///
                    imageT.BackColor = Color.White;
                    imageT.Image = null;
                    imageT.Visible = false;///
                    titleLabel.Visible = false;///
                    startLabel.Location = new Point(274, 400);
                    startLabel.Visible = true;///
                    startLabel.Text = username;
                    howtoplaylabel.Visible = false;///
                    instructionlabel.Visible = true;///
                    nameinput.Visible = false;///
                    break;

            }

        }

        private void nameinput_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
