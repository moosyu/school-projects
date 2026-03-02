using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peakwindspeed
{
    public partial class Form1 : Form
    {
        string[] days = new string[7];
        int[] speeds = new int[7];
        // declare variables
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// add the day of the week and the wind speed to the relevant arrays
        /// if both arrays are full, shows an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // try to add data to the arrays
            try
            {
                // try to add windspeed data to the array
                if (int.TryParse(textBoxWind.Text, out speeds[counter]))
                {
                    // add the day to the days array
                    days[counter] = textBoxDay.Text;
                    // move to nxet index in array
                    counter++;
                    // clear the textboxes and refocus
                    textBoxDay.Clear();
                    textBoxWind.Clear();
                    textBoxDay.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please make sure your wind speed is a whole number e.g. 24");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have already added a week of data!\n" + ex.ToString());
            }
        }

        /// <summary>
        /// takes all data in the arrays and displays them in a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            if (days[days.Length - 1] != null)
            {
                // column headings
                listBoxDisplay.Items.Add("Day".PadRight(15) + "Peak Wind Speed (km/h)");
                // display data in arrays
                for (int i = 0; i < days.Length; i++)
                {
                    listBoxDisplay.Items.Add(days[i].PadRight(15) + speeds[i].ToString());
                }
            } else
            {
                MessageBox.Show("Please enter seven days of data before pressing display!\n");
            }
        }
    }
}
