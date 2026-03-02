using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12IT1_Recap
{
    /// <summary>
    /// A program which takes the score of a science class, converts them into percentages, then shows the average, top, bottom, and range of the scores.
    /// Last edit: 2026-02-04
    /// Author: ####
    /// </summary>
    public partial class Form1 : Form {
        // Declare constants and collections
        const int MAX_SCORE = 94;
        const int MIN_SCORE = 0;
        List<int> percentList = new List<int>();
        public Form1() {
            InitializeComponent();
            textBoxScore.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            // Declare variables
            int currentScore;

            // Read in the current score from the textbox and validate it
            if (int.TryParse(textBoxScore.Text, out currentScore)) {
                // Check if the input is in range
                if (currentScore <= MAX_SCORE && currentScore >= MIN_SCORE) {
                    // Convert the score to a percentage and add it to a list of percentages
                    percentList.Add(ScoreToPercent(currentScore));
                    // Clear and refocus textbox
                    textBoxScore.Focus();
                    textBoxScore.Clear();
                } else { // Display an out of range error message
                    MessageBox.Show($"Invalid input. Number must be in the range {MIN_SCORE}-{MAX_SCORE} inclusive");
                }
            } else { // Display a parse fail error message
                MessageBox.Show($"Invalid input. Please enter a whole number in the range {MIN_SCORE}-{MAX_SCORE} inclusive, e.g. 64.");
            }
        }

        /// <summary>
        /// If percentages have been recorded, this method displays the statistics for the class.
        /// If nothing has been entered, an error message is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e) {
            // Declare variables

            // Refresh the GUI
            RefreshGui();

            // Check whether any scores have been added
            if (percentList.Count == 0) { // If no scores have been added, show default message
                listBoxResults.Items.Add("No results to show");
            } else { // If scores have been added, perform the relative calculations
                // Sort the list of results
                percentList.Sort();

                // Display the minimum, maximum, and average scores, and the count
                listBoxResults.Items.Add($"The minimum score was {percentList.Min()}%");
                listBoxResults.Items.Add($"The maximum score was {percentList.Max()}%");
                listBoxResults.Items.Add($"The average score was {percentList.Average()}%");
                listBoxResults.Items.Add($"There were {percentList.Count()} students who completed the test.");

                // Display the contents of the list to the listbox
                foreach (int p in percentList) {
                    listBoxResults.Items.Add(p.ToString() + "%");
                }
            }
        }

        /// <summary>
        /// Takes a score and converts it into a percentage.
        /// </summary>
        /// <param name="score">The raw score</param>
        /// <returns>The percentage the student got on the test, rounded to a whole number.</returns>
        private int ScoreToPercent(int score) {
            double percent;
            percent = (double) score / MAX_SCORE * 100;
            return (int) Math.Round(percent);
        }

        /// <summary>
        /// Clears the GUI and the contents of the percent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e) {
            // Clear the GUI
            RefreshGui();
            // Clear the list
            percentList.Clear();
        }

        /// <summary>
        /// Clears the contents of every control on the GUI and refocuses on the textbox.
        /// </summary>
        private void RefreshGui() {
            // Clear the controls of the form
            listBoxResults.Items.Clear();
            textBoxScore.Clear();
            // Refoucus on the textbox
            textBoxScore.Focus();
        }
    }
}