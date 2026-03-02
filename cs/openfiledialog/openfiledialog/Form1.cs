using System;
using System.IO;
using System.Windows.Forms;

namespace openfiledialog {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// Displays the oepn fie dialog, allowing the user to open and display txt files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e) {
            // Declare variables
            string line;
            // Create and configure an open file dialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files(*.txt)|*.txt";
            try {
                // If the user has successfully selected a file
                if (dialog.ShowDialog() == DialogResult.OK) {
                    // Open a StreamReader and read the text from the file
                    using (StreamReader reader = new StreamReader(dialog.OpenFile())) {
                        // While the end of the file has not been reached, display the next line to the listbox
                        while ((line = reader.ReadLine()) != null) {
                            listBoxDisplay.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"System was unable to load the selected text file:\n{ex}");
                throw;
            }
        }
    }
}