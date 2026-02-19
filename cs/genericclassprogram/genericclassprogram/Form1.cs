using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genericclassprogram {
    public partial class Form1 : Form {
        // Declare collections
        List<MyObject> myList = new List<MyObject>();
        // Declare RNG
        Random random = new Random();
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// Creates a new object and adds it to a list to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonObject_Click(object sender, EventArgs e) {
            MyObject obj = new MyObject(random.Next(101), "hi!!");
            // Add it to the list
            myList.Add(obj);
            // Update DataGridView
            dataGridViewDisplay.DataSource = null;
            dataGridViewDisplay.DataSource = myList;
        }
    }
}