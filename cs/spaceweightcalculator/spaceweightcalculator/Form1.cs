using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceweightcalculator
{
    public partial class Form1 : Form
    {
        double[] accelerations = { 3.59, 8.87, 9.81, 3.77, 26.0, 11.1, 10.7, 14.1 };
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", " Saturn", "Uranus", "Neptune" };
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double weight;
            if (double.TryParse(textBoxWeight.Text, out weight))
            {
                if (weight > 635 || weight < 0)
                {
                    MessageBox.Show("Weight out of range, please enter a number between 0 and 635.");
                } else
                {
                    for (int i = 0; i < planets.Length; i++)
                    {
                        listBox1.Items.Add($"Your weight on {planets[i]} is {RoundToSignificantDigits(weight * accelerations[i], 3)}N");
                    }
                }
            } else
            {
                MessageBox.Show("Enter a valid number! E.g. 27.4");
            }
        }
        private double RoundToSignificantDigits(double d, int digits)
        {
            if (d == 0)
                return 0;

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
            return scale * Math.Round(d / scale, digits);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxWeight.Clear();
            listBox1.Items.Clear();
            textBoxWeight.Focus();
        }
    }
}
