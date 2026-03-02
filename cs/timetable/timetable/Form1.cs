using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable {
    /// <summary>
    /// Author: ####
    /// Date modified: 12/02/26
    /// </summary>
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// Displays a 7x10 timetable made of rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDraw_Click(object sender, EventArgs e) {
            // Declare variables
            // X and Y are offset by 1 to make up for stroke size
            int x = 1;
            int y = 1;
            int width = pictureBoxTimetable.Width / 7;
            // Declare objects
            Graphics paper = pictureBoxTimetable.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            SolidBrush brush = new SolidBrush(Color.White);
            // Draw table by performing two for loops, the first for the horizontal row and the second for the vertical
            if (int.TryParse(textBoxPeriods.Text, out int periods)) {
                int height = pictureBoxTimetable.Height / periods;
                for (int i = 0; i < 7; i++) {
                    for (int j = 0; j < periods; j++) {
                        // Draws the boxes
                        if (i < 5) {
                            brush.Color = Color.White;
                        } else {
                            brush.Color = Color.Blue;
                        }
                        // FIX LATER... (use different x and y) paper.FillRectangle(brush, x, y, width, height);
                        paper.DrawRectangle(pen, x + (i * width), y + (j * height), width, height);
                        // Displays labels
                        /*
                        Label label = new Label {
                            Text = "Day",
                            Top = Y + (j * height) + (height / 2),
                            Left = X + (i * width) + (width / 2),
                            BackColor = Color.Transparent,
                        };
                        pictureBoxTimetable.Controls.Add(label);
                         */
                    }
                }
            } else {
                MessageBox.Show("Use a whole number");
            }
        }
    }
}
