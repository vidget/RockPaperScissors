using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {

//Intialize the variables to keep score...games = total games played
        int games = 0;
        int won = 0;
        int lost = 0;
        int tied = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            //Plays the Gong sound
            Gong();
        }

//Play sounds Methods. 
        private void Gong()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.gong);
            simpleSound.Play();
        }

        private void Woosh()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Woosh);
            simpleSound.Play();
        }

        private void Cheer()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.cheer);
            simpleSound.Play();
        }

        private void Boo()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.boo);
            simpleSound.Play();
        }

      
// Computers Turn Method, recieves the humans turn as an int 1-3
        private int ComputerTurn(int human)
        {

            int x=0;
//increase game count by 1
            games = games + 1;

//Generates a Random number between 1-3
            Random rand = new Random();
            x = rand.Next(3) + 1;

//turns on the dialog Label above the buttons
            dialogOpen.Visible = false;
            dialogLabel.Visible = true;

//switch uses the random number generated to determine computer move 1=Rock 2=Paper and 3=Scissors
         switch (x)
            {
                case 1:
                 //displays ROCK as the Computer Hand

                    image_Rt_Rock.Visible = true;

                 //determines human hand if win, tie or loss.
                    if (human == 1)
                    {
                        //rock vs rock
                        tied = tied + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "          Rock vs Rock A TIE";
                    }
                    else if (human == 2)
                    {
                        //paper covers rock
                        won = won + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "Paper Covers Rock YOU WIN";
                        
                    }
                    else if (human == 3) 
                    {
                        //rock beats scissors
                        lost = lost + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "Rock beats Scissors YOU LOSE";
                    }
                    break;


                case 2:
                 //displays Paper as the Computer Hand

                    image_Rt_Paper.Visible = true;

                  //determines human hand if win, tie or loss.   
                    if (human == 1)
                    {
                        //paper covers rock
                        dialogLabel.Text = "Paper Covers Rock YOU LOSE";
                        lost = lost + 1;
                        UpdateImageScore();
                       
                    }
                    else if (human == 2)
                    {
                        //paper v paper
                        tied = tied + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "        Paper vs Paper A TIE";
                    }
                    else if (human == 3)
                    {
                        //scissors cut paper
                        dialogLabel.Text = "Scissors cut Paper YOU WIN";
                        won = won + 1;
                        UpdateImageScore();
                       
                    }
                     break;

                case 3:

                 //displays Scissors as the Computer Hand   
                    image_Rt_Scissors.Visible = true;

                    //determines human hand if win, tie or loss.  

                    if (human == 1)
                    {
                        //rock breaks scissor
                        won = won + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "Rock beats Scissors YOU WIN";
                        
                    }
                    else if (human == 2)
                    {
                        //scissors cut paper
                        lost = lost + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "Scissors cut Paper YOU LOSE";
                       
                    }
                    else if (human == 3)
                    {
                        //scissor v scissors
                        tied = tied + 1;
                        UpdateImageScore();
                        dialogLabel.Text = "  Scissors vs Scissors A TIE";
                    }


                    break;

                    default:
                    MessageBox.Show("UT-OH");
                    break;
                    }
            
            return x;

            }

        private void UpdateImageScore()
        {
            wonTextLabel.Text = won.ToString();
            lostTextLabel.Text = lost.ToString();
            tiedTextLabel.Text = tied.ToString();

            labelWin.Visible = true;
            labelTie.Visible = true;
            labelLosses.Visible = true;

            wonTextLabel.Visible = true;
            lostTextLabel.Visible = true;
            tiedTextLabel.Visible = true;
        }

        private void ClearComputer()
        {
            image_Rt_Rock.Visible = false;
            image_Rt_Paper.Visible = false;
            image_Rt_Scissors.Visible = false;
        }


        


        private void buttonRock_Click(object sender, EventArgs e)
        {
            int select=1;
            ClearComputer();
            ComputerTurn(select);
            Woosh();

            selectPrompt.Visible = false;
            image_Lt_Rock.Visible = true;
            image_Lt_Paper.Visible = false;
            image_Lt_Scissors.Visible = false;

            
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            int select = 2;
            ClearComputer();
            ComputerTurn(select);
            Woosh();

            selectPrompt.Visible = false;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = true;
            image_Lt_Scissors.Visible = false;


        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            int select = 3;
            ClearComputer();
            ComputerTurn(select);
            Woosh();

            selectPrompt.Visible = false;
            image_Lt_Scissors.Visible = true;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = false;
            image_Lt_Scissors.Visible = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearComputer();
            Gong();
            dialogLabel.Visible = false;
            dialogOpen.Visible = true;
            games = 0;
            won = 0;
            lost = 0;
            tied = 0;
            UpdateImageScore();

            buttonBack.Visible = false;

            tiedStat.Visible = false;
            wonStat.Visible = false;
            lostStat.Visible = false;
            gamesStat.Visible = false;
           

            labelGamesPlayed.Visible = false;
            labelWon.Visible = false;
            labelLost.Visible = false;
            labelTied.Visible = false;
            


            buttonPaper.Visible = true;
            buttonRock.Visible = true;
            buttonScissors.Visible = true;
            
            
            selectPrompt.Visible = true;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = false;
            image_Lt_Scissors.Visible = false;
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogLabel.Visible = false;
            dialogOpen.Visible = false;

            buttonBack.Visible = true;
            labelWin.Visible = false;
            labelTie.Visible = false;
            labelLosses.Visible = false;


            wonTextLabel.Visible = false;
            lostTextLabel.Visible = false;
            tiedTextLabel.Visible = false;
           

//This is resets all images to false in order to display the stats below
            selectPrompt.Visible = false;
            image_Lt_Scissors.Visible = false;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = false;

            image_Rt_Scissors.Visible = false;
            image_Rt_Rock.Visible = false;
            image_Rt_Paper.Visible = false;

            buttonPaper.Visible = false;
            buttonRock.Visible = false;
            buttonScissors.Visible = false;

//Stats Menu images are loaded here
            labelGamesPlayed.Visible = true;
            labelWon.Visible = true;
            labelLost.Visible = true;
            labelTied.Visible = true;
            

            wonStat.Text = won.ToString();
            lostStat.Text = lost.ToString();
            tiedStat.Text = tied.ToString();
            gamesStat.Text = games.ToString();
            

            gamesStat.Visible = true;
            tiedStat.Visible = true;
            wonStat.Visible = true;
            lostStat.Visible = true;

            //plays sound Methods based on won vs lost 
            if (won > lost)
            {
                Cheer();
            }
            else
            {
                Boo();
            }
           

        }

        private void bACKToGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gong();
            dialogLabel.Visible = false;
            dialogOpen.Visible = true;
            buttonBack.Visible = false;
            labelWin.Visible = true;
            labelTie.Visible = true;
            labelLosses.Visible = true;

           

            wonTextLabel.Visible = true;
            lostTextLabel.Visible = true;
            tiedTextLabel.Visible = true;


            //This is resets all images to false in order to display the stats below
            selectPrompt.Visible = true;
            image_Lt_Scissors.Visible = false;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = false;

            image_Rt_Scissors.Visible = false;
            image_Rt_Rock.Visible = false;
            image_Rt_Paper.Visible = false;

            buttonPaper.Visible = true;
            buttonRock.Visible = true;
            buttonScissors.Visible = true;

            //Stats Menu images are loaded here
            labelGamesPlayed.Visible = false;
            labelWon.Visible = false;
            labelLost.Visible = false;
            labelTied.Visible = false;
            

            gamesStat.Visible = false;
            tiedStat.Visible = false;
            wonStat.Visible = false;
            lostStat.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Gong(); 

            buttonBack.Visible = false;
            labelWin.Visible = true;
            labelTie.Visible = true;
            labelLosses.Visible = true;
            dialogOpen.Visible = true;


            wonTextLabel.Visible = true;
            lostTextLabel.Visible = true;
            tiedTextLabel.Visible = true;


            //This is resets all images to false in order to display the stats below
            selectPrompt.Visible = true;
            image_Lt_Scissors.Visible = false;
            image_Lt_Rock.Visible = false;
            image_Lt_Paper.Visible = false;

            image_Rt_Scissors.Visible = false;
            image_Rt_Rock.Visible = false;
            image_Rt_Paper.Visible = false;

            buttonPaper.Visible = true;
            buttonRock.Visible = true;
            buttonScissors.Visible = true;

            //Stats Menu images are loaded here
            labelGamesPlayed.Visible = false;
            labelWon.Visible = false;
            labelLost.Visible = false;
            labelTied.Visible = false;


            gamesStat.Visible = false;
            tiedStat.Visible = false;
            wonStat.Visible = false;
            lostStat.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
