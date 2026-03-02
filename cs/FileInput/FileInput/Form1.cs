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

namespace FileInput {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e) {
            // Declare variables
            string line;
            try {
                // Create the instance of the StreamReader
                using (StreamReader reader = new StreamReader("input.txt")) {
                    // Keep reading lines untiul the end of the file is reached
                    while ((line = reader.ReadLine()) != null) {
                        // Display the line to the user
                        listBoxDisplay.Items.Add(line);
                    }
                }
            } catch (Exception ex) { // If the file cannot be accessed, tell the user.
                MessageBox.Show($"File could not be accessed:\n{ex}");
                throw;
            }
        }
    }
}