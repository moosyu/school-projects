using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goldclubachieved
{
    /// <summary>
    /// author: Minghan Zhou
    /// last edit: 02/04/25
    /// </summary>
    public partial class Form1 : Form
    {
        // declare collections
        List<int> netScores = new List<int>();
        // declare constants
        const int PAR = 71;
        const int MIN_RAW_SCORE = 18;
        const int MAX_RAW_SCORE = 400;
        /// <summary>
        /// opens the form ready for a new user
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            textBoxRawScore.Focus();
        }


        /// <summary>
        /// takes the golfers raw score, coverts it to a net score and adds it to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // validate raw score entered
            if (int.TryParse(textBoxRawScore.Text, out int rawScore))
            {
                // check raw score in range, convert it to net score, add it to the list and resort the list
                if (rawScore <= MAX_RAW_SCORE && rawScore >= MIN_RAW_SCORE)
                {
                    netScores.Add(RawToNet(rawScore));
                    netScores.Sort();
                    textBoxRawScore.Focus();
                    textBoxRawScore.Clear();
                }
                else
                {
                    // display an error
                    MessageBox.Show($"Scores must be in the range {MIN_RAW_SCORE}-{MAX_RAW_SCORE} inclusive.");
                }
            } else
            {
                // display an error
                MessageBox.Show("Invalid input. Please make sure raw score is a whole number e.g. 64.");
            }
        }
        /// <summary>
        /// takes a raw score and converts it to a net score by subtracting the course par
        /// </summary>
        /// <param name="rawScore"></param>
        /// <returns></returns>
        private int RawToNet(int rawScore)
        {
            return rawScore - PAR;
        }
        /// <summary>
        /// takes the net scores from the list and displays them with stats such as min, max, average, sum and count
        /// </summary>
        /// <param name="sender">the raw score that the golfer has</param>
        /// <param name="e">the net score is the raw score - par for the course</param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // clear current listbox contents
            listBoxScores.Items.Clear();
            // makes sure the data has been added to the list
            if (netScores.Count > 0)
            {
                // display every net score in the list
                foreach (int netScore in netScores)
                {
                    listBoxScores.Items.Add(netScore.ToString());
                }
                // display the average net score
                listBoxScores.Items.Add("The average net score of all golfers was " + netScores.Average());
                // display the minimum and maximum net score
                listBoxScores.Items.Add("The minimum net score of all golfers was " + netScores.Min() + " the max was " + netScores.Max());
                // display the sum
                listBoxScores.Items.Add("The sum of all scores was " + netScores.Sum());
                // display the count
                listBoxScores.Items.Add(netScores.Count() + " golfer's scores were recorded");
            } else
            {
                MessageBox.Show("No data has been entered.");
            }
        }
        /// <summary>
        /// clears the previously scored
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear the scores
            netScores.Clear();
            // refresh the display
            textBoxRawScore.Clear();
            listBoxScores.Items.Clear();
            textBoxRawScore.Focus();
        }
        /// <summary>
        /// closes the form application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}