using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fizzbuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    listBox1.Items.Add("Fizz");
                } else if (i % 5 == 0 && i % 3 != 0)
                {
                    listBox1.Items.Add("Buzz");
                } else if (i % 5 == 0 && i % 3 == 0)
                {
                    listBox1.Items.Add("Fizz Buzz");
                } else
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
