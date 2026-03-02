using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloworlds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when the user clicks the button it says hello world back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxHello.Text = "Hello World!";
        }

        private void textBoxHello_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
