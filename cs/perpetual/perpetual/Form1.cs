using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perpetual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] months = { "Januaray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] lengths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            listBoxYear.Items.Clear();
            int counter = 0;
            int day = 0;
            bool found = false;
            if (checkBoxLeap.Checked == true)
            {
                lengths[1] = 29;
            }
            for (int k = 0; k < 7; k++)
            {
                if (days[k].ToUpper() == textBoxDay.Text.ToUpper())
                {
                    day = k;
                    found = true;
                }
            }
            if (found)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < lengths[counter]; j++)
                    {
                        listBoxYear.Items.Add(months[i] + " " + (j + 1) + " " + days[day]);
                        if (day < 6)
                        {
                            day++;
                        }
                        else
                        {
                            day = 0;
                        }
                    }
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Please check you've spelt the day of the week correctly!");
            }
        }
    }
}