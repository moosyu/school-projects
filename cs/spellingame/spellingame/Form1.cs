using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spellingame
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        List<string> words = new List<string>() { "green" };
        bool correct;
        int score = 0;
        int currentIndex;
        string currentWord;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.ToUpper() == currentWord.ToUpper())
            {
                MessageBox.Show("Correct");
                correct = true;
                buttonNF.Text = "Next";
                buttonSubmit.Visible = false;
                buttonSubmit.Enabled = false;
                words.Remove(currentWord);
                score++;
                label1.Text = $"Score: {score}";
                if (words.Count == 0)
                {
                    label1.Text = "You win";
                } else
                {
                    buttonNF.Visible = true;
                    buttonNF.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wrong");
                buttonNF.Text = "Exit";
                buttonSubmit.Visible = false;
                buttonSubmit.Enabled = false;
                textBoxInput.Visible = false;
                textBoxInput.Enabled = false;
                textBoxWord.Visible = false;
                textBoxWord.Enabled = false;
            }
        }
        private void StartRound()
        {
            textBoxWord.Visible = true;
            currentIndex = rng.Next(0, words.Count);
            currentWord = words[currentIndex];
            textBoxWord.Text = currentWord;
            textBoxInput.Enabled = false;
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            buttonBegin.Visible = false;
            timer1.Enabled = true;
            StartRound();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxWord.Clear();
            textBoxInput.Enabled = true;
            timer1.Enabled = false;
            textBoxWord.Visible = false;
            buttonSubmit.Visible = true;
            buttonSubmit.Enabled = true;
        }

        private void buttonNF_Click(object sender, EventArgs e)
        {
            if (correct == true)
            {
                StartRound();
                timer1.Enabled = true;
            }
            else
            {
                this.Close();
            }
            buttonNF.Visible = false;
            buttonNF.Enabled = false;
        }
    }
}
