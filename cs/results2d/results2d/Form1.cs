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

namespace results2d {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // declare variables
            List<string[]> resultsList = new List<string[]>();
            int counter = 0;
            string line;
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "csv files(*.csv)|*.csv"
            };
            try {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    using (StreamReader sr = new StreamReader(ofd.FileName)) {
                        while ((line = sr.ReadLine()) != null) {
                            string[] tempValues = line.Split(',');

                            resultsList.Add(new string[2]);
                            resultsList[resultsList.Count - 1][0] = tempValues[0];
                            resultsList[resultsList.Count - 1][1] = tempValues[1];
                            listBoxDisplay.Items.Add($"{resultsList[resultsList.Count - 1][0],-15} {resultsList[resultsList.Count - 1][1]}");
                            counter++;
                        }
                    }
                }
                Console.WriteLine(resultsList[0][0]);
            } catch (Exception ex) {
                MessageBox.Show($"You got an error: ${ex}");
                throw;
            }
        }
    }
}
