﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGameProj
{
    public partial class Form1 : Form
    {
        //global variable for page number
        int page = 1;
        
        //creating random generator for answers
        //with multiple potential outcomes
        //and creating variable for using rangen

        Random rangen = new Random();
        int chance;

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You are trapped in the vampire mansion! Where do you go first?";
            option1Label.Text = "Hallway";
            option2Label.Text = "Staircase";
            option3Label.Text = "";
            option3Button.Enabled = false;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //checking page, then flipping to the
            //correct page when option 1 is clicked
            
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                chance = rangen.Next(1, 101);
                if (chance < 40)
                {
                    page = 16;
                }
                else
                {
                    page = 15;
                }
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 13;
            }
            else if (page == 8)
            {
                page = 20;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                chance = rangen.Next(1, 101);
                if (chance < 10)
                {
                    page = 19;
                }
                else
                {
                    page = 17;
                }
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                //note to self: this page only has ONE OPTION. be careful
                page = 3;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }

            //running page info event (sets labels, options, etc)
            pageInfo();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //checking page, then flipping to the
            //correct page when option 2 is clicked

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 5)
            {
                page = 15;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 18;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }

            //running page info event (for labels, options, etc)
            pageInfo();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //checking page, then flipping to the
            //correct page when option 3 is clicked

            if (page == 7)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 3;
            }

            //running page info event ( for labels, options, etc)
            pageInfo();
        }

        private void pageInfo()
        {
            //display corresponding labels and options for page number
            //& disabling/enabling 3rd option button when necessary

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are trapped in the vampire mansion! Where do you go first?";
                    option1Label.Text = "Hallway";
                    option2Label.Text = "Staircase";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 2:
                    outputLabel.Text = "At the end of the hallway are two doors. One is locked. Do you search for the key?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 3:
                    outputLabel.Text = "The stairs lead off in two different directions. Which way do you go?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 4:
                    outputLabel.Text = "You find the key hidden in an urn on a table. Do you unlock the door?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No, go to the staircase instead";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 5:
                    outputLabel.Text = "You open the unlocked door instead. It leads to a dark courtyard with a large pool.";
                    option1Label.Text = "Go for a swim";
                    option2Label.Text = "Look for a way out";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 6:
                    outputLabel.Text = "You go up the stairs to the left and find a room full of very sharp objects.";
                    option1Label.Text = "Take a look around";
                    option2Label.Text = "Go farther down the hallway";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 7:
                    outputLabel.Text = "You go up the stairs to the right and come upon three strange objects";
                    option1Label.Text = "Pick up the silver dagger";
                    option2Label.Text = "Pick up the glass vial";
                    option3Label.Text = "Pick up the wooden stake";
                    option3Button.Enabled = true;
                    break;
                case 8:
                    outputLabel.Text = "Spooky... It's empty except for a coffin in the centre of the room.";
                    option1Label.Text = "Open coffin";
                    option2Label.Text = "Leave room";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 9:
                    outputLabel.Text = "Oh no!! A vampire caught you touching her surgical tools and killed you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 10:
                    outputLabel.Text = "You head on down the dark hallway and make your way onto a large balcony.";
                    option1Label.Text = "Jump down to the ground";
                    option2Label.Text = "Scale the walls to the ground";
                    option3Label.Text = "Go back";
                    option3Button.Enabled = true;
                    break;
                case 11:
                    outputLabel.Text = "You stab all the vampires and make your escape! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 12:
                    outputLabel.Text = "Uh oh! The glass shatters and splatters you with acid. You die a painful death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 13:
                    outputLabel.Text = "You forgot that vampires are immune to regular weapons!! You die a gruesome death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 14:
                    outputLabel.Text = "Good choice. You head back to the stairs.";
                    option1Label.Text = "Ok";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    break;
                case 15:
                    outputLabel.Text = "Dang! The pool boy found you and decided you were a tasty snack. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 16:
                    outputLabel.Text = "You find a hidden passageway under the pool and escape. Congrats!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 17:
                    outputLabel.Text = "Splat! You misjudge the height and fall to your death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 18:
                    outputLabel.Text = "Good job! You use the stone wall to climb down to safety as the sun rises. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;

                    break;
                case 19:
                    outputLabel.Text = "Nice! you land safely and escape. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 20:
                    outputLabel.Text = "You were killed by a very tired and annoyed vampire! Play again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Enabled = false;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing! Visit again soon.... muahahaha";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Enabled = false;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
            }
        }
    }
}