using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CsvInput {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// Load and display CSV contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e) {
            // Declare variables
            string line;
            string[] values;
            // Write the column headers
            listBoxDisplay.Items.Add("Name".PadRight(15) + "Score:");
            try {
                // Open the StreamReader
                using (StreamReader reader = new StreamReader("results.csv")) {
                    // While there is still text in the file, read it in
                    while ((line = reader.ReadLine()) != null) {
                        // Store the values in a array
                        values = line.Split('\u002C');
                        // Display tyhe values in columns
                        listBoxDisplay.Items.Add(values[0].PadRight(15) + values[1]);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"The CSV didn't load properly:\n{ex}");
                throw;
            }
        }
    }
}
