using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coincounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            total = double.Parse(textBox1.Text) + total;
            textBox2.Text = total.ToString();
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
