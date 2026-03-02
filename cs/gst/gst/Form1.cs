using System;
using System.Windows.Forms;

namespace gst {
    /// <summary>
    /// Author: ####
    /// Date modified: 11/02/26
    /// </summary>
    public partial class FormGST : Form {
        public FormGST() {
            InitializeComponent();
        }
        /// <summary>
        /// Takes input and returns the GST cost and total cost including GST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e) {
            if (double.TryParse(textBoxEntry.Text, out double cost)) { // Try to convert textBoxEntry text to double
                // Declare variables
                double gstCost, finalCost;
                gstCost = cost * 0.15;
                finalCost = cost + gstCost;
                // Display values in text boxes
                textBoxGST.Text = gstCost.ToString("C");
                textBoxTotal.Text = finalCost.ToString("C");
                MessageBox.Show($"The GST applied to an item costing {cost:C} is {cost * 0.15:C}, the final total cost will therefore be {cost * 1.15:C}");
                // Clear and refocus textBoxEntry
                textBoxEntry.Clear();
                textBoxEntry.Focus();
            } else { // If the input can't be converted to double show an error
                MessageBox.Show("Input needs to be a number and don't include symbols eg: nine dollars or $9");
            }

        }
    }
}
