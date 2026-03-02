namespace peakwindspeed
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
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWind = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(44, 7);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peak Wind Speed (km/h)";
            // 
            // textBoxWind
            // 
            this.textBoxWind.Location = new System.Drawing.Point(284, 7);
            this.textBoxWind.Name = "textBoxWind";
            this.textBoxWind.Size = new System.Drawing.Size(100, 20);
            this.textBoxWind.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(390, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 21);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(390, 33);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 5;
            this.buttonDisplay.Text = "&Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 14;
            this.listBoxDisplay.Location = new System.Drawing.Point(15, 33);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(369, 396);
            this.listBoxDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxWind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDay);
            this.Name = "Form1";
            this.Text = "Wind speeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWind;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.ListBox listBoxDisplay;
    }
}

