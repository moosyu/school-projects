using System;
using System.Drawing;
using System.Windows.Forms;

namespace drawingshapes {
    public partial class FormDrawing : Form {
        public FormDrawing() {
            InitializeComponent();
        }

        /// <summary>
        /// Draws a rectangle in the top left corner of the picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRectangle_Click(object sender, EventArgs e) {
            // Declare variables
            int width = 200;
            int height = 100;
            int x = 0;
            int y = 0;
            // Declare objects
            Graphics paper = pictureBoxGraphics.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 2);
            // Draw a rectangle
            paper.DrawRectangle(pen, x, y, width, height);
        }

        private void buttonSquare_Click(object sender, EventArgs e) {
            // Declare variables
            int widthHeight = 100;
            int x = 0;
            int y = 0;
            // Declare objects
            Graphics paper = pictureBoxGraphics.CreateGraphics();
            Pen pen = new Pen(Color.Orange, 2);
            // Draw a rectangle
            paper.DrawRectangle(pen, x, y, widthHeight, widthHeight);
        }

        private void buttonCircle_Click(object sender, EventArgs e) {
            // Declare variables
            int widthHeight = 10;
            int x = 150;
            int y = 100;
            // Declare objects
            Graphics paper = pictureBoxGraphics.CreateGraphics();
            Pen pen = new Pen(Color.Purple, 2);
            // Draw a rectangle
            paper.DrawEllipse(pen, x, y, widthHeight, widthHeight);
        }

        private void buttonTriangle_Click(object sender, EventArgs e) {
            // Declare variables
            int width = 200;
            int height = 100;
            int x = 0;
            int y = 0;
            // Declare objects
            Graphics paper = pictureBoxGraphics.CreateGraphics();
            Pen pen = new Pen(Color.Cyan, 2);
            // Draw a triangle
            paper.DrawLine(pen, x, y, width, height);
            paper.DrawLine(pen, x, height, width, height);
            paper.DrawLine(pen, x, y, x, height);
        }
        
        /// <summary>
        /// Clears the picture box of any previously drawn graphics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e) {
            pictureBoxGraphics.Refresh();
        }
    }
}
