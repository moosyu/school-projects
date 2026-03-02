using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hellonamegui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// takes the users name from a textbox
        /// says hello name back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clickMe_Click(object sender, EventArgs e)
        {
            // declare variables
            string name;
            // collect users name from the texbox
            name = textBoxName.Text;
            // check if the string is empty
            if (name != "")
            {
                // greet the user
                output.Text = "Hello " + name;
            } else
            {
                MessageBox.Show("Invalid name. Please enter your name into the textbox.");
            }
        }
    }
}
