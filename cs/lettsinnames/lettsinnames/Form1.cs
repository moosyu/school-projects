using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lettsinnames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declare collection
        List<string> names = new List<string>();
        // declare constant
        const double AVG_LENGTH = 6.5;
        /// <summary>
        /// adds a name to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // checking if input is empty, returning an error if it is
            if (textBoxNames.Text != "")
            {
                names.Add(textBoxNames.Text);
                // reseting textboxes and cursor position
                textBoxNames.Clear();
                textBoxNames.Focus();
            } else
            {
                MessageBox.Show("Enter a name please!");
            }
        }
        /// <summary>
        /// calculates average length of names entered, as well as the biggest and smallest name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // clear listbox to remove any previous items
            listBox1.Items.Clear();
            // declare variables
            int lengthTotal = 0;
            // make sure the user has added a name
            if (names.Count > 0)
            {
                // declaring inside names.Count > 0 to ensure i dont get an error due to the list being empty
                string longestName = names[0];
                string shortestName = names[0];
                foreach(string name in names)
                {
                    // add all name's lengths to the lengthTotal
                    lengthTotal += name.Length;
                    if (name.Length < shortestName.Length)
                    {
                        // if the name is shorter than the current shortest, make it the new shortest name
                        shortestName = name;
                    }
                    if (name.Length > longestName.Length)
                    {
                        // if the name is longer than the current longest, make it the new longest name
                        longestName = name;
                    }

                }
                // find the average length of names, converting lengthTotal and names.Count to doubles in order for lengthAvg to have decimal places
                double lengthAvg = ((double)lengthTotal / (double)names.Count);
                listBox1.Items.Add($"Total length was {lengthTotal} with an average length of {lengthAvg.ToString("n1")}");
                if (lengthAvg == AVG_LENGTH)
                {
                    listBox1.Items.Add("This is average!");
                } else if (lengthAvg > AVG_LENGTH)
                {
                    listBox1.Items.Add("This is above average!");
                } else
                {
                    listBox1.Items.Add("This is below average!");
                }
                listBox1.Items.Add($"The longest name was {longestName} and the shortest name was {shortestName}");
            }
            else
            {
                MessageBox.Show("Add some names!");
            }
        }
        /// <summary>
        /// resets all textboxes, lists and listboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxNames.Clear();
            names.Clear();
        }
        /// <summary>
        /// closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}