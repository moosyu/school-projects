using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// identifies which option user has chosen, takes both numbers from the textboxes and applies that mathmatical function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // declare variables
            double num1, num2;
            // start by checking that all values are valid

            if (radioButtonDifference.Checked || radioButtonProduct.Checked || radioButtonQuotient.Checked || radioButtonSum.Checked)
            {
                if (double.TryParse(textBox1.Text, out num1))
                {
                    if (double.TryParse(textBox2.Text, out num2))
                    {
                        // identify and perform the selected calculation
                        if (radioButtonSum.Checked)
                        {
                            listBoxOutput.Items.Add($"The sum of {num1} + {num2} = {Sum(num1, num2)}");
                        } else if (radioButtonDifference.Checked)
                        {
                            listBoxOutput.Items.Add($"The difference of {num1} - {num2} = {Difference(num1, num2)}");
                        }
                        else if (radioButtonProduct.Checked)
                        {
                            listBoxOutput.Items.Add($"The product of {num1} x {num2} = {Product(num1, num2)}");
                        }
                        else
                        {
                            listBoxOutput.Items.Add($"The quotient of {num1} / {num2} = {Quotient(num1, num2)}");
                        }
                    } else
                    {
                        // second number is not in valid format
                        MessageBox.Show("Please enter a number into the second number textbox e.g. 94.2!");
                    }
                }
                else
                {
                    // first number is not in valid format
                    MessageBox.Show("Please enter a number into the first number textbox e.g. 2.49!");
                }
            }
            else
            {
                // shows an error message if the user has not selected a function
                MessageBox.Show("Select an option of the four mathmatical functions!");
            }
        }

        /// <summary>
        /// Clears everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Resafresh();
            listBoxOutput.Items.Clear();
        }

        /// <summary>
        /// takes two values and returns the sum
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <returns>the sum of the first and second value</returns>
        private double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// takes two values and returns the difference
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <returns>the difference of the first and second value</returns>
        private double Difference(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// takes two values and returns the product
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <returns>the product of the first and second value</returns>
        private double Product(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// takes two values and returns the quotient
        /// </summary>
        /// <param name="a">the first value</param>
        /// <param name="b">the second value</param>
        /// <returns>the quotient of the first and second value</returns>
        private string Quotient(double a, double b)
        {
            // if the denominator is 0, go to infinity 
            if (b == 0)
            {
                return $"{a}/0 goes to infinity";
            } else
            {
                return $"The quotient of {a} / {b} is {a / b}";
            }
        }

        /// <summary>
        /// Clear everything except listbox
        /// </summary>
        private void Resafresh()
        {
            // empty controls except for listbox
            textBox1.Clear();
            textBox2.Clear();
            // change the check radiobutton to sum
            radioButtonSum.Checked = true;
            // refocus on the first textbox
            textBox1.Focus();
        }
    }
}