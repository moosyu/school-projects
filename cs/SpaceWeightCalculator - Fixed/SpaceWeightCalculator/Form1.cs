using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWeightCalculator
{
    public partial class Form1 : Form
    {
        //Declare collections
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        double[] accelerations = { 3.59, 8.87, 9.81, 3.77, 26.0, 11.1, 10.7, 14.1 };
        const double MAX_MASS = 635;
        const double MIN_MASS = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if the input mass is valid
        /// Calculate and show the weight of that mass on all 8 planets of the solar system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindWeights_Click(object sender, EventArgs e)
        {
            //Declare variables
            double currentMass;
            double currentWeight;
            //Check whether mass is in a valid format
            if (double.TryParse(textBoxMass.Text, out currentMass))
            {
                //Check that the mass is in range
                if (currentMass >= MIN_MASS && currentMass <= MAX_MASS)
                {
                    // print column headings
                    listBoxWeights.Items.Add("Planet".PadRight(10) + "a (m/s/)".PadRight(10) + "Fw (N)");
                    //For each planet in the solar system
                    for (int i = 0; i < planets.Length; i++)
                    {
                        //Calculate the current weight
                        currentWeight = currentMass * accelerations[i];
                        //Output key info to the listbox
                        listBoxWeights.Items.Add(planets[i].PadRight(10) + accelerations[i].ToString().PadRight(10)
                            + currentWeight.ToString("G3"));
                    }
                }
                //Mass is out of range
                else
                {
                    MessageBox.Show($"Mass outside of known human range. Please make sure your mass is between {MIN_MASS} and {MAX_MASS} inclusive.");
                }
            }
            //Mass not correctly formatted
            else
            {
                MessageBox.Show("Invalid input. Please enter your mass as a number, e.g. 65.4");
            }
        }
    }
}
