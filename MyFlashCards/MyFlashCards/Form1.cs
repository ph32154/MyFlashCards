using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlashCards
{
    public partial class Form1 : Form
    {
        //global declarations
        Pair displayPair = new Pair();
        int score = 0;
        int position = 0;
        List<Pair> storedPairs;


        /*
              To Do:
              1) 
              2) Read in the pairs list from a .csv file
              3) randomize the pairs so you don't know what's coming next.
              4) Add in "start again" button when we reach the end of the list.  It should randomize the list and reset the score.
              5) pretty up the display


        */






        public Form1()
        {
            InitializeComponent();

            lblTitle.Text = "Test Framework";
            lblScore.Text = score.ToString();

            // initialise the list - will need to get this from a .csv later

            storedPairs = new List<Pair>
            {
                new Pair() {LHS = "hola", RHS = "hello" },
                new Pair() {LHS = "mundo", RHS = "world" }
            };

            storedPairs.Add(new Pair() { LHS = "playa", RHS = "beach" });

            
            //now transfer the stored pairs deck to the actual display
            displayPair.LHS = storedPairs[position].LHS;
            displayPair.RHS = storedPairs[position].RHS;
            lblTitle.Text = "test1";

            //initialise the screen
            lblLeft.Text = displayPair.LHS;
            lblRight.Text = "What's the answer?";
            btnCorrect.Enabled = false;
            btnWrong.Enabled = false;

        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            score += 1;
            moveOn();
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {

            moveOn();
        }

        private void moveOn()
        {
            lblScore.Text = score.ToString();
            
            btnCorrect.Enabled = false;
            btnWrong.Enabled = false;
            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            //show answer on right, move on to next pair, display next question on left.

            position += 1;
            nextPair();
            lblLeft.Text = displayPair.LHS;
            lblRight.Text = "What's the answer?";
            btnShowAnswer.Enabled = true;
        }

        private void nextPair()
        {
            
            if (position < storedPairs.Count)
            {
                displayPair.LHS = storedPairs[position].LHS;
                displayPair.RHS = storedPairs[position].RHS;
            }
            else
            {
                string strFinalText = "You reached the end of the list.  You scored " + score.ToString() + " out of " + storedPairs.Count;
                lblEnd.Text = strFinalText;
                lblEnd.Visible = true;
                displayPair.LHS = "end of list";
                displayPair.RHS = "end of list";
            } 

        }


        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            lblRight.Text = displayPair.RHS;
            btnCorrect.Enabled = true;
            btnWrong.Enabled = true;
            btnShowAnswer.Enabled = false;
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {

        }
    }

    class Pair
    {
        public string LHS { get; set; }
        public string RHS { get; set; }

    }//end class pair

        


}
