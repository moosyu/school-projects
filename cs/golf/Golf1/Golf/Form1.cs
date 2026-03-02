using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class Form1 : Form
    {
        // declare constants
        const int PAR = 71;
        const int MIN = 18;
        const int MAX = 400;
        // declare collections
        List<int> scoresList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sorts the list, displays the data and calculates the average score, lowest and highest scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // sort the data lowest to highest
            scoresList.Sort();
            // declare variables
            double averageScore = 0;
            int highestScore = scoresList[0];
            int lowestScore = scoresList[0];
            // displays title before displaying net scores
            listBoxOutput.Items.Add("The net scores were:");
            // loop through the list
            foreach (int score in scoresList)
            {
                // checks if the score is bigger than the current highest score, if it is make it the new highest score
                if (score > highestScore)
                {
                    highestScore = score;
                }
                // checks if the score is smaller than the current lowest score, if it is make it the new lowest score
                if (score < lowestScore)
                {
                    lowestScore = score;
                }
                listBoxOutput.Items.Add(score);
                // adds current score to the average so once the loop is complete the average will be the total of all scores
                averageScore += score;
            }
            // displays the collected data
            listBoxOutput.Items.Add($"There were {scoresList.Count} scores added. The average net score was {(averageScore / scoresList.Count)}.");
            listBoxOutput.Items.Add($"The highest score was {highestScore} and the lowest score was {lowestScore}.");
        }
        /// <summary>
        /// adds the entered data to the scores list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // add the golfer's raw score to the list
            scoresList.Add(int.Parse(textBoxScore.Text) - PAR);
        }
    }
}
