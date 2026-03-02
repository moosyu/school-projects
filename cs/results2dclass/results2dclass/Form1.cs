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
using System.Xml.Linq;

namespace results2dclass {
    public partial class Form1 : Form {
        // declare collections
        List<_2DList> myList = new List<_2DList>();
        public Form1() {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e) {
            // declare variables
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "csv files(*.csv)|*.csv"
            };
            try {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    using (StreamReader sr = new StreamReader(ofd.FileName)) {
                        while (!sr.EndOfStream) {
                            string[] tempValues = sr.ReadLine().Split(',');
                            _2DList studentObj = new _2DList(tempValues[0], int.Parse(tempValues[1]));
                            myList.Add(studentObj);
                            dataGridViewDisplay.DataSource = null;
                            dataGridViewDisplay.DataSource = myList;
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"You got an error: ${ex}");
                throw;
            }
        }
    }
}
