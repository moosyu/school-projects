namespace goldclubachieved
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxRawScore = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxRawScore
            // 
            this.textBoxRawScore.Location = new System.Drawing.Point(12, 12);
            this.textBoxRawScore.Name = "textBoxRawScore";
            this.textBoxRawScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxRawScore.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(118, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 20);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 38);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(181, 20);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate scores";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.Location = new System.Drawing.Point(12, 64);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(776, 368);
            this.listBoxScores.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRawScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRawScore;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxScores;
    }
}

