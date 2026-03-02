using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfiledialogcsv {
    /// <summary>
    /// Author: ####
    /// Last edited on: 10/02/26
    /// </summary>
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// Open file dialog, throw error if the selected CSV file can't be found, if it can display it as well as the average, minimum and maximum scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e) {
            // Declare variables
            string[] values;
            List<int> scoreValues = new List<int>();
            // Create and configure file dialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "csv files(*.csv)|*.csv";
            try {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    listBoxDisplay.Items.Add("Name".PadRight(15) + "Score");
                    using (StreamReader sr = new StreamReader(dialog.FileName)) {
                        while (!sr.EndOfStream) {
                            values = sr.ReadLine().Split(',');
                            scoreValues.Add(int.Parse(values[1]));
                            listBoxDisplay.Items.Add(values[0].PadRight(15) + values[1]);
                        }
                        listBoxDisplay.Items.Add("");
                        listBoxDisplay.Items.Add($"Average score: {Math.Round(scoreValues.Average())}");
                        listBoxDisplay.Items.Add($"Minimum score: {scoreValues.Min()}");
                        listBoxDisplay.Items.Add($"Maximum score: {scoreValues.Max()}");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Something when wrong when opening file!\n{ex}");
                throw;
            }
        }
    }
}
