using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evenodd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // label even and odd listboxes
            listBoxEven.Items.Add("Even numbers:");
            listBoxOdd.Items.Add("Odd numbers:");
        }

        /// <summary>
        /// takes a number from the textbox, sorts the number into even or odd listboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // declare variables
            double num;
            // get number from the textbox
            if (double.TryParse(textBoxNumber.Text, out num))
            {
                // sort number into even or odd
                if (num%2 == 0)
                {
                    listBoxEven.Items.Add(num.ToString());
                } else
                {
                    listBoxOdd.Items.Add(num.ToString());
                }
                // clear the textbox, ready for more input
                textBoxNumber.Clear();
                textBoxNumber.Focus();
            } else
            {
                MessageBox.Show("Invalid! Please enter a whole number, e.g. 12");
            }
        }

        /// <summary>
        /// clear every control on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear all controls
            textBoxNumber.Clear();
            listBoxEven.Items.Clear();
            listBoxOdd.Items.Clear();
            // label textboxes
            listBoxEven.Items.Add("Even numbers:");
            listBoxOdd.Items.Add("Odd numbers:");
            // focus on textbox
            textBoxNumber.Focus();
        }

        /// <summary>
        /// clear the form and stop the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
