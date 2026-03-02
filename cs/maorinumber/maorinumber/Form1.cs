using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace maorinumber
{
    public partial class Form1 : Form
    {
        string[] numbers010 = {"kore", "tahi", "rua", "toru", "wha", "rima", "ono", "whitu", "waru", "iwa", "tekau" };
        string[] additions = { "tekau", "rua tekau", "toru tekau", "wha tekau", "rima tekau", "ono tekau", "whitu tekau", "waru tekau", "iwa tekau" };
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxNumber.Text) >= 0 && int.Parse(textBoxNumber.Text) < 11)
            {
                textBoxMaori.Text = numbers010[int.Parse(textBoxNumber.Text)];
            } else if (int.Parse(textBoxNumber.Text) > 10 && int.Parse(textBoxNumber.Text) <= 100)
            {
                if (int.Parse(textBoxNumber.Text) % 10 == 0) // if it can divide by 10 into a whole number (10,20,30,40,50 etc)
                {
                    textBoxMaori.Text = additions[getFirstInt(int.Parse(textBoxNumber.Text), 0)];
                } else
                {
                    textBoxMaori.Text = additions[getFirstInt(int.Parse(textBoxNumber.Text), 0) - 1] + " ma " + numbers010[getFirstInt(int.Parse(textBoxNumber.Text), 1)];
                }
            }
        }
        static int getFirstInt(int num, int slot)
        {
            return int.Parse(num.ToString()[slot].ToString());
        }
    }
}