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
    /// Date: 04/04/25
    /// </summary>
    public partial class Form1 : Form
    {
        // declare collections
        List<double> results = new List<double>();
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
            results.Add(convertToPercentage((int.Parse(textBoxInput.Text))));
            textBoxInput.Clear();
            textBoxInput.Focus();
            results.Sort();
        }
        /// <summary>
        /// converts the students score into a percentage
        /// </summary>
        /// <param name="result">the score of the student</param>
        /// <returns>the result converted to a percentage (doesnt include the %)</returns>
        private double convertToPercentage(double inputResult)
        {
            return ((inputResult / 87) * 100);
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
                listBoxOutput.Items.Add($"Average score: {results.Average().ToString("G3")}%");
                listBoxOutput.Items.Add($"Smallest score: {results.Min().ToString("G3")}%");
                listBoxOutput.Items.Add($"Largest score: {results.Max().ToString("G3")}%");
                listBoxOutput.Items.Add($"Total amount of scores: {results.Count()}");
                listBoxOutput.Items.Add("Scores, sorted smallest to largest:");
                foreach (double result in results)
                {
                    listBoxOutput.Items.Add($"{result.ToString("G3")}%");
                }
            } else
            {
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
