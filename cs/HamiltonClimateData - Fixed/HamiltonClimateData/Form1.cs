using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamiltonClimateData
{
    public partial class Form1 : Form
    {
        //Scale factor for the graphs
        const int SCALE_FACTOR = 6;
        const int DIVIDE_FACTOR = 2;
        //Create climate data arrays
        string[] monthsArray = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        double[] highTempArray = { 23.9, 24.3, 22.7, 19.9, 16.9, 14.3, 13.8, 14.7, 16.5, 17.9, 19.8, 21.9 };
        double[] meanTempArray = { 18.4, 18.8, 17.1, 14.5, 11.9, 9.5, 8.9, 9.8, 11.6, 13.2, 14.9, 16.9 };
        double[] lowTempArray = { 12.9, 13.2, 11.4, 9.1, 6.9, 4.7, 4.0, 4.9, 6.7, 8.4, 9.9, 11.9 };
        double[] avgRainfall = { 76.3, 68.7, 79.4, 80.3, 99.7, 113.2, 118.2, 103.4, 91.5, 91.9, 85.0, 100.7 };
        double[] avgHumidity = { 80.5, 84.3, 84.7, 86.4, 89.9, 91.4, 90.8, 88.2, 83.2, 81.9, 79.1, 79.9 };
        double[] avgSunshineHours = { 229.8, 192.9, 193.3, 165.1, 138.3, 112.8, 126.4, 144.1, 147.5, 174.8, 187.1, 207.6 };
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// takes the data from the arrays and uses it to create 3 proportional bar/line graphs
        /// these graphs represent temperature averages per month, sunshine hours per month,
        /// and rainfall humidity per month respectively
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawGraphs_Click(object sender, EventArgs e)
        {
            
            //Create graphics objects

            Graphics tempGraphics = pictureBoxTemperature.CreateGraphics();
            Graphics sunshineGraphics = pictureBoxSunshineHours.CreateGraphics();
            Graphics rainGraphics = pictureBoxHumidRain.CreateGraphics();
            //Declare objects
            Brush tempBrush = new SolidBrush(Color.Red);
            SolidBrush sunshineBrush = new SolidBrush(Color.Yellow);
            SolidBrush rainBrush = new SolidBrush(Color.LightBlue);
            Pen pen1 = new Pen(Color.Black, 3);
            //Declare variables
            int columnWidth = pictureBoxTemperature.Width / monthsArray.Length;
            int x = 0;
            //Draw the temperature graph
            for(int i = 0; i < monthsArray.Length; i++)
            {
                tempBrush = new SolidBrush(Color.Red);
                tempGraphics.FillRectangle(tempBrush, x, 
                    pictureBoxTemperature.Height - (float)highTempArray[i]*SCALE_FACTOR, 
                    columnWidth, (float)highTempArray[i]*SCALE_FACTOR);
                tempBrush = new SolidBrush(Color.Green);
                tempGraphics.FillRectangle(tempBrush, x, 
                    pictureBoxTemperature.Height - (float)meanTempArray[i] * SCALE_FACTOR, 
                    columnWidth, (float)meanTempArray[i] * SCALE_FACTOR);
                tempBrush = new SolidBrush(Color.Blue);
                tempGraphics.FillRectangle(tempBrush, x, 
                    pictureBoxTemperature.Height - (float)lowTempArray[i] * SCALE_FACTOR, 
                    columnWidth, (float)lowTempArray[i] * SCALE_FACTOR);
                //increment to the next column
                x += columnWidth;
            }
            //Draw the sunshine hours graph
            columnWidth = pictureBoxSunshineHours.Width / monthsArray.Length;
            x = 0;
            foreach(double d in avgSunshineHours)
            {
                sunshineBrush.Color = Color.FromArgb(255, (int)d, (int)d, 0);
                sunshineGraphics.FillRectangle(sunshineBrush, x, 
                    pictureBoxSunshineHours.Height - (float)d/DIVIDE_FACTOR,
                    columnWidth, (float)d/DIVIDE_FACTOR);
                x += columnWidth;
            }
            //Draw the rainfall and humidity graph
            x = 0;
            for(int j = 0; j < monthsArray.Length; j++)
            {
                rainGraphics.FillRectangle(rainBrush, x, 
                    pictureBoxHumidRain.Height - (float)avgRainfall[j], 
                    columnWidth, (float)avgRainfall[j]);
                float currY = 1-(float)avgHumidity[j]/100;
                float nextY = 1-(float)avgHumidity[(j + 1) % 12]/100;
                float prevY = 1 - (float)avgHumidity[(j + 11) % 12] / 100;
                float start = (currY + prevY) / 2;
                float end = (currY + nextY) / 2;
                rainGraphics.DrawRectangle(pen1, x + columnWidth/2 - 1, pictureBoxHumidRain.Height * currY - 1,
                    2, 2);
                rainGraphics.DrawLine(pen1, x, 
                    pictureBoxHumidRain.Height * start, 
                    x + columnWidth,
                    pictureBoxHumidRain.Height * end); // note: edited
                x += columnWidth;
            }

        }

        /// <summary>
        /// displays the array data from 1981-2010
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetData_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            listBoxClimateData.Items.Clear();
            //Add column headers
            listBoxClimateData.Items.Add("Month".PadRight(10) + 
                "High (C)".PadRight(10) + "Mean (C)".PadRight(10) + 
                "Low (C)".PadRight(10) + "Avg Rainfall (mm)".PadRight(20) + 
                "Avg Humidity (%)".PadRight(20) + "Avg Sunshine (h)");
            //Add data for each column, row-by-row
            for(int i = 0; i < monthsArray.Length; i++)
            {
                listBoxClimateData.Items.Add(monthsArray[i].PadRight(10) +
                    highTempArray[i].ToString().PadRight(10) 
                    + meanTempArray[i].ToString().PadRight(10)
                    + lowTempArray[i].ToString().PadRight(10) 
                    + avgRainfall[i].ToString().PadRight(20)
                    + avgHumidity[i].ToString().PadRight(20)
                    + avgSunshineHours[i].ToString());
            }
        }
    }
}
