using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rng
{
    public partial class Form1 : Form
    {
        // declare random number generator
        Random random = new Random();
        // declare constants
        const int MIN = 1;
        const int MAX = 40;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// takes a number from the user to define the size of the set
        /// generates and displays a set of five numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // declare variables
            string line = "";
            int count;
            // read the count from the textbox
            if (int.TryParse(textBoxNumber.Text, out count)) {
                // generate 5 numbers
                for (int i = 0; i < count; i++)
                {
                    line += random.Next(MIN, MAX + 1).ToString().PadRight(4);
                }
                listBoxSets.Items.Add(line);
            } else
            {
                MessageBox.Show("Invalid input. Add a whole number into the textbox please");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxSets.Items.Clear();
            textBoxNumber.Text = "";
            textBoxNumber.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
