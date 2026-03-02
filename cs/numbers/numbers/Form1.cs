using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ask the user to input two numbers and then finds + returns the sum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // declare variables
            int num1, num2, sum;
            // read in the first number from the textbox
            try
            {
                // read first
                num1 = int.Parse(textBoxNum1.Text);
                // read second
                num2 = int.Parse(textBoxNum2.Text);
                // add nums together
                sum = num1 + num2;
                // display sum
                textBoxOutput.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// ask the user to input two numbers and then finds and returns the multiple of the two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // declare variables
            int num1, num2, product;
            // read in the first number from the textbox
            if (int.TryParse(textBoxNum1.Text, out num1))
            {
                // read in the second number from the form
                if (int.TryParse(textBoxNum2.Text, out num2))
                {
                    // multiply the two numbers
                    product = num1 * num2;
                    // display the product
                    textBoxProduct.Text = product.ToString();
                } else // show an error message
                {
                    MessageBox.Show("Invalid number, please make sure the second number is a whole number, e.g. 2.");
                }
            }
            else // show an error message
            {
                MessageBox.Show("Invalid number, please make sure the first number is a whole number, e.g. 2.");
            }
        }
    }
}
