using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkout
{
    public partial class Form1 : Form
    {
        // declare collections
        List<string> items = new List<string>();
        List<int> quantities = new List<int>();
        List<decimal> cost = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
            listBoxItems.Items.Add("Items".PadRight(15) + "Quantity".PadRight(12) + "Cost per item".PadRight(17) + "Actual cost");
        }
        /// <summary>
        /// takes info about the current item and adds it to the relevant lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // declare variables
            int currentQty;
            decimal currentCost;

            // check that a valid quantity has been set
            if (int.TryParse(textBoxQuantity.Text, out currentQty))
            {
                // check that a valid cost has been set
                if (decimal.TryParse(textBoxCost.Text, out currentCost))
                {
                    // if all data is valid, add to the lists
                    items.Add(textBoxItem.Text);
                    quantities.Add(currentQty);
                    cost.Add(currentCost);
                    // clear the textboxes and refocus
                    textBoxCost.Clear();
                    textBoxItem.Clear();
                    textBoxQuantity.Clear();
                    textBoxItem.Focus();
                } else
                {
                    MessageBox.Show("Invalid cost. Please make sure the cost is in numeric form e.g. 2.50");
                }
            } else
            {
                MessageBox.Show("Invalid quantity. Please make sure the quantity is a whole number e.g. 12.");
            }
        }
        /// <summary>
        /// display the contents of all three lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            // decimal variables
            decimal actualCost;
            decimal totalCost = 0;
            // clear listbox
            listBoxItems.Items.Clear();
            // add column headings
            listBoxItems.Items.Add("Items".PadRight(15) + "Quantity".PadRight(12) + "Cost per item".PadRight(17) + "Actual cost");
            // display each item on the list and its associated quantity and costs
            for (int i = 0; i < items.Count; i++)
            {
                // calculate actual cost
                actualCost = quantities[i] * cost[i];
                // display all info into the listbox
                listBoxItems.Items.Add(items[i].PadRight(15) + quantities[i].ToString().PadRight(12) + cost[i].ToString("C").PadRight(17) + actualCost.ToString("C"));
                totalCost = totalCost + actualCost;
            }
            listBoxItems.Items.Add("Total cost: " + totalCost.ToString("C"));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCost.Clear();
            textBoxItem.Clear();
            textBoxQuantity.Clear();
            listBoxItems.Items.Clear();
            items.Clear();
            quantities.Clear();
            cost.Clear();
            listBoxItems.Items.Add("Items".PadRight(15) + "Quantity".PadRight(12) + "Cost per item".PadRight(17) + "Actual cost");
        }
    }
}