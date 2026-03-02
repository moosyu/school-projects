using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceTestResults
{
    /// <summary>
    /// Author: ***
    /// Date: 08/04/25
    /// </summary>
    public partial class Form1 : Form
    {
        // declare collections
        List<int> results = new List<int>();
        // declaring constants
        const int MIN_SCORE = 0;
        const int MAX_SCORE = 87;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// runs the convert to percentage function and adds the number to the results list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // checks if the input is in range, parseable and a whole number
            if (validityChecker(textBoxInput.Text))
            {
                // calculating the percentage
                results.Add(convertToPercentage(textBoxInput.Text));
            }
            else
            {
                // displaying error messagebox and not adding to list if the validityChecker method returns false
                MessageBox.Show($"Please input a valid whole number in the range of {MIN_SCORE} to {MAX_SCORE} inclusive!");
            }
            textBoxInput.Clear();
            textBoxInput.Focus();
            // sorts data in the list after every new addition
            results.Sort();
        }
        /// <summary>
        /// converts the students score into a percentage
        /// </summary>
        /// <param name="inputResult">the score of the student</param>
        /// <returns>the result converted to a percentage (doesnt include the %)</returns>
        private int convertToPercentage(string inputResult)
        {
            // calculates the percentage, rounds it and returns an int.
            // no need for try parse as validity has already been checked
            return (int)Math.Round(double.Parse(inputResult) / MAX_SCORE * 100);
        }
        /// <summary>
        /// checks if the users input value is in range, parseable and a whole number
        /// </summary>
        /// <param name="inputData">the score of the student</param>
        /// <returns></returns>
        private bool validityChecker(string inputData)
        {
            // trying to parse the string inputData into a double and throwing an error if it fails
            if (double.TryParse(inputData, out double resultDouble))
            {
                // returning true if in range and has no decimal points. if not itll return false.
                // checks if it has any decmial points by checking if the number with no decimal points
                // is the same as the number inputted.
                return resultDouble >= MIN_SCORE && resultDouble <= MAX_SCORE && resultDouble == Math.Floor(resultDouble);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// displays the inputed data in sorted order as well as the average, min, max, number of recorded data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResults_Click(object sender, EventArgs e)
        {
            // clearing any previous data outputs
            listBoxOutput.Items.Clear();
            // checking if any data has been inputed and sending an error if there is none
            if (results.Count != 0)
            {
                // displaying the inputed data in sorted order as well as the average, min, max, number of recorded data.
                // data is converted to 3sf and percentage signs are added when the number is meant to be a percentage
                listBoxOutput.Items.Add($"Average score: {Math.Round(results.Average())}%");
                listBoxOutput.Items.Add($"Smallest score: {results.Min()}%");
                listBoxOutput.Items.Add($"Largest score: {results.Max()}%");
                listBoxOutput.Items.Add($"Total amount of scores: {results.Count()}");
                listBoxOutput.Items.Add("Scores, sorted smallest to largest:");
                // foreach loop that displays all the results inside the list
                foreach (int result in results)
                {
                    listBoxOutput.Items.Add($"{result}%");
                }
            }
            else
            {
                // outputs if the results list has nothing inside
                MessageBox.Show("No results to show!");
            }
        }
        /// <summary>
        /// clears all data (as if the program was restarted)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxInput.Focus();
            results.Clear();
            listBoxOutput.Items.Clear();
        }
    }
}