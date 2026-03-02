using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpetualCalendar
{
    public partial class Form1 : Form
    {
        //Set up collections
        string[] daysArray = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
        string[] monthsArray = { "January", "February", "March", "April", "May", "June", "July", 
            "August", "September", "October", "November", "December" };
        int[] lengths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            listBoxDates.Items.Clear();
            //Declare variables
            int currentDay;
            //Check whether the user has entered a valid day of the week
            if (daysArray.Contains<string>(textBoxDay.Text.ToUpper()))
            {
                //Store the current day
                currentDay = Array.IndexOf(daysArray, textBoxDay.Text.ToUpper());
                //For each month of the year
                foreach (string month in monthsArray)
                {
                    //check if it is February of a leap year
                    if (month == "February" && checkBoxLeapYear.Checked)
                    {
                        //For each day in February
                        for (int i = 1; i <= 29; i++)
                        {
                            //Output the current day and date
                            listBoxDates.Items.Add(daysArray[currentDay % daysArray.Length].PadRight(12)
                                + i.ToString().PadRight(4) + month);
                            //Increment the day of the week
                            currentDay++;
                        }
                    }
                    else
                    {
                        //For each day of the current month
                        for (int j = 1; j <= lengths[Array.IndexOf(monthsArray, month)]; j++)
                        {
                            //Output the current day and date
                            listBoxDates.Items.Add(daysArray[currentDay % daysArray.Length].PadRight(12)
                                + j.ToString().PadRight(4) + month);
                            //Increment the day of the week
                            currentDay++;
                        }
                    }
                }
            }
            else    //Give an error message
            {
                MessageBox.Show("Please check that you have spelt the day of the week correctly, e.g. Wednesday.");
            }
        }
    }
}
