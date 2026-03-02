using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicegame
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int userNum;
            int robotNum = rng.Next(1, 6 + 1);
            if (int.TryParse(textBox1.Text, out userNum) && userNum > 0 && userNum <= 6) {
                listBox1.Items.Add($"The computer selected {robotNum}, the user selected {userNum}");
            
                if (userNum > robotNum)
                {
                    listBox1.Items.Add($"User wins!");
                } else if (robotNum > userNum)
                {
                    listBox1.Items.Add($"Robot wins!");
                } else
                {
                    listBox1.Items.Add($"Tie!");
                }
            }
                else
            {
                MessageBox.Show("Enter a number between 1 and 6!");
            }
        }
    }
}
