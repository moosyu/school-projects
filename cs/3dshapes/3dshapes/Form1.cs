using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _3dshapes {
    public partial class FormShapes : Form {
        // define collections
        List<Shape3D> shapesList = new List<Shape3D>();

        public FormShapes() {
            InitializeComponent();
        }

        private void radioButtonPrism_CheckedChanged(object sender, EventArgs e) {
            enableHeightWidth();
            textBoxDepth.Enabled = true;
        }

        private void radioButtonCube_CheckedChanged(object sender, EventArgs e) {
            textBoxHeight.Enabled = true;
            textBoxDepth.Enabled = false;
            textBoxWidth.Enabled = false;
        }

        private void radioButtonPyramid_CheckedChanged(object sender, EventArgs e) {
            enableHeightWidth();
            textBoxDepth.Enabled = true;
        }

        private void radioButtonCone_CheckedChanged(object sender, EventArgs e) {
            enableHeightWidth();
            textBoxDepth.Enabled = false;
        }

        private void radioButtonSphere_CheckedChanged(object sender, EventArgs e) {
            textBoxHeight.Enabled = true;
            textBoxDepth.Enabled = false;
            textBoxWidth.Enabled = false;
        }

        private void radioButtonCylinder_CheckedChanged(object sender, EventArgs e) {
            enableHeightWidth();
            textBoxDepth.Enabled = false;
        }
        /// <summary>
        /// Enables textBoxHeight and textBoxWidth
        /// </summary>
        void enableHeightWidth() {
            textBoxHeight.Enabled = true;
            textBoxWidth.Enabled = true;
        }
        /// <summary>
        /// Adds the shape to the list and updates the dataGridView 
        /// </summary>
        /// <param name="shape">The selected shape class</param>
        void createShape(Shape3D shape) {
            shapesList.Add(shape);
            dataGridViewDisplay.DataSource = null;
            dataGridViewDisplay.DataSource = shapesList;
        }
        /// <summary>
        /// Display the volume of the selected shape or throw an error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e) {
            // Parse height
            if (!double.TryParse(textBoxHeight.Text, out double height)) {
                MessageBox.Show("Enter a height!");
                return;
            }
            // Parse width unless cube or sphere radio buttons have been checked
            if (!double.TryParse(textBoxWidth.Text, out double width) && !radioButtonCube.Checked && !radioButtonSphere.Checked) {
                MessageBox.Show("Enter a width!");
                return;
            }
            // Parse depth if either the rectangular prism or pyramid radio buttons have been checked
            if (!double.TryParse(textBoxDepth.Text, out double depth) && (radioButtonPrism.Checked || radioButtonPyramid.Checked)) {
                MessageBox.Show("Enter a depth!");
                return;
            }

            // Create shapes depending on selected radio buttons
            if (radioButtonPrism.Checked) {
                createShape(new RectangularPrism(height, width, depth));
            } else if (radioButtonCube.Checked) {
                createShape(new Cube(height));
            } else if (radioButtonPyramid.Checked) {
                createShape(new Pyramid(height, width, depth));
            } else if (radioButtonCone.Checked) {
                createShape(new Cone(height, width));
            } else if (radioButtonSphere.Checked) {
                createShape(new Sphere(height));
            } else if (radioButtonCylinder.Checked) {
                createShape(new Cylinder(height, width));
            } else {
                MessageBox.Show("No shape selected");
            }
         
        }
        /// <summary>
        /// Clear the interface, textboxes and list contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e) {
            // Clear textboxes
            textBoxWidth.Clear();
            textBoxHeight.Clear();
            textBoxDepth.Clear();
            // Clear list
            shapesList.Clear();
            // Clear interface
            dataGridViewDisplay.DataSource = null;
        }
        /// <summary>
        /// Moves all info from the list to a .csv file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e) {

            // Open and begin using new streamwriter
            using (StreamWriter sw = new StreamWriter("output.csv")) {
                // For each object in the list
                foreach (Shape3D shape in shapesList) {
                    // organise properties into string to the output document
                    sw.WriteLine($"{shape.Name},{shape.Height},{shape.Width},{shape.Depth},{shape.Volume}");
                }
            }
            // Exit the program
            this.Close();
        }
    }
}
