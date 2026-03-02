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
        /// calculates the average score, lowest and highest scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // removing any old data from previous calculations as well as refocus on the textBox for further data entry
            cleanValues();
            // ensuring there is at least one value in the list before calculating
            if (scoresList.Count > 0)
            {
                // sort the data lowest to highest
                scoresList.Sort();
                // displays title before displaying net scores
                listBoxOutput.Items.Add("The net scores were:");
                // loop through the list
                foreach (int score in scoresList)
                {
                    // displays the data of the current score being read from the list
                    listBoxOutput.Items.Add(score);
                }
                // displays the collected data
                listBoxOutput.Items.Add($"There were {scoresList.Count} scores added. The average net score was {calculateAverage(scoresList.Sum(), scoresList.Count)}.");
                listBoxOutput.Items.Add($"The highest net score was {scoresList[scoresList.Count - 1]} and the lowest net score was {scoresList[0]}.");
            } else
            {
                MessageBox.Show("Please add some values before calculating!");
            }
        }
        /// <summary>
        /// adds the entered data to the scores list as long as the data is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // converting the string in textBoxScore to an int, if it returns false display a messageBox telling the user to enter a whole number
            if (int.TryParse(textBoxScore.Text, out int scoreRaw))
            {
                // making sure score is in the valid range and displaying a messageBox if it isn't
                if (scoreRaw <= MAX && scoreRaw >= MIN)
                {
                    // adding valid score into the list after converting it to a net score
                    scoresList.Add(scoreRaw - PAR);
                    // running the reset method to refocus and refresh the textBox after data entry
                    cleanValues();
                } else
                {
                    MessageBox.Show("Out of range! Please enter a number greater than 17 and smaller than 401.");
                }
            } else
            {
                MessageBox.Show("Please enter a whole number!");
            }
        }
        /// <summary>
        /// finds the average score using the total number of data pieces and the final total of the score then rounds it to 2dp
        /// </summary>
        /// <param name="scoreTotal"></param>
        /// <param name="listLength"></param>
        /// <returns></returns>
        private string calculateAverage(double scoreTotal, int listLength)
        {
            return (scoreTotal / listLength).ToString("F2");
        }
        /// <summary>
        /// resets everything to its default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            cleanValues();
            scoresList.Clear();
        }
        /// <summary>
        /// function to remove data in the textBoxScore textbox as well as in the list
        /// </summary>
        private void cleanValues()
        {
            textBoxScore.Clear();
            listBoxOutput.Items.Clear();
            textBoxScore.Focus();
        }
        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}