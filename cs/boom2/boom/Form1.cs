using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boom {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // Declare variables
        int countdownPoint = 10;
        private void buttonBegin_Click(object sender, EventArgs e) {
            listBoxCounter.Items.Add($"Fssh");
            // Check whether the timer is already on, if it's not then start it
            if (!timerCountdown.Enabled) {
                timerCountdown.Start();
            }
        }
        /// <summary>
        /// Counts from 10 and then says BOOM!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCountdown_Tick(object sender, EventArgs e) {
            if (countdownPoint > 0) {
                // Decreases the countdown by one and displays the new time until detonation
                countdownPoint -= 1;
                listBoxCounter.Items.Add($"Detonating in {countdownPoint + 1}");
            } else {
                // Write boom to listbox when the countdown has finished
                timerCountdown.Stop();
                listBoxCounter.Items.Add("BOOM!");
            }
        }
    }
}
