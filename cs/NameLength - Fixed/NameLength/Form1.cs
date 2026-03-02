using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameLength
{
    public partial class Form1 : Form
    {
        //Declare collections
        List<string> namesList = new List<string>();
        //Declare constants
        const double AVG_LENGTH = 6.5;
        int MIN_LENGTH = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks whether the user has input a valid name
        /// Adds that name to the list if so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Check whether the user has input a valid name
            if(textBoxName.Text.Length > MIN_LENGTH)
            {
                //If it is a valid name, add it to the list
                namesList.Add(textBoxName.Text);
                //Clear and focus on the textbox, ready for the next name
                textBoxName.Clear();
            }
            else    //Display an error message
            {
                MessageBox.Show("Please make sure you have entered a name into the textbox before clicking add.");
            }
        }

        /// <summary>
        /// Checks to see whether any names have been added
        /// If there are names in the list, shows the min, max and average lengths
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            //Declare variables
            double currentAvg = 0;
            string min, max;
            //Check whether there are any names in the list
            if(namesList.Count > 0)
            {
                //Clear the listbox ready for new information
                listBoxNames.Items.Clear();
                //Set the min and max to their starting values
                min = namesList[0];
                max = namesList.Max();
                //For each name in the list
                foreach(string name in namesList)
                {
                    //Add to the average
                    currentAvg += (double)name.Length;
                    //Check whether it is the shortest so far
                    if(name.Length < min.Length)
                    {
                        min = name;
                    }
                    //Check whether it is the longest so far
                    if(name.Length > max.Length)
                    {
                        max = name;
                    }
                }
                //Calculate the final average
                currentAvg /= (double)namesList.Count;
                //Output all info to the listbox
                listBoxNames.Items.Add("The shortest name was " + min + " at " 
                    + min.Length + " characters long.");
                listBoxNames.Items.Add("The longest name was " + max + " at "
                    + max.Length + " characters long.");
                listBoxNames.Items.Add("The average length of all names was " + currentAvg.ToString("N1") + " characters.");
                //Check whether the average was above, below, or equal to the global average
                if(currentAvg == AVG_LENGTH)
                {
                    listBoxNames.Items.Add("This is equal to the global average of " + AVG_LENGTH);
                }
                else if(currentAvg > AVG_LENGTH)
                {
                    listBoxNames.Items.Add("This is greater than the global average of " + AVG_LENGTH);
                }
                else
                {
                    listBoxNames.Items.Add("This is less than the global average of " + AVG_LENGTH);
                }
            }
            else    //Display an error message
            {
                MessageBox.Show("There are no names to compare.");
            }
        }
    }
}
