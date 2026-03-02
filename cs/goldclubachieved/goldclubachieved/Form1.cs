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
    public partial class Form1 : Form
    {
        // declare collections
        List<int> netScores = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// takes the golfers raw score, coverts it to a net score and adds it to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            netScores.Add(RawToNet(int.Parse(textBoxRawScore.Text)));
            // sort the list
            netScores.Sort();
        }
        /// <summary>
        /// takes a raw score and converts it to a net score by subtracting the course par
        /// </summary>
        /// <param name="rawScore"></param>
        /// <returns></returns>
        private int RawToNet(int rawScore)
        {
            return rawScore - 71;
        }
        /// <summary>
        /// takes the net scores from the list and displays them with stats such as min, max, average, sum and count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // display every net score in the list
            foreach(int netScore in netScores)
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
        }
    }
}
