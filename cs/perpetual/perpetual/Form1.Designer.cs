namespace perpetual
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.listBoxYear = new System.Windows.Forms.ListBox();
            this.checkBoxLeap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(118, 35);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 20);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 35);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxDay.TabIndex = 1;
            // 
            // listBoxYear
            // 
            this.listBoxYear.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxYear.FormattingEnabled = true;
            this.listBoxYear.ItemHeight = 14;
            this.listBoxYear.Location = new System.Drawing.Point(12, 61);
            this.listBoxYear.Name = "listBoxYear";
            this.listBoxYear.Size = new System.Drawing.Size(181, 88);
            this.listBoxYear.TabIndex = 2;
            // 
            // checkBoxLeap
            // 
            this.checkBoxLeap.AutoSize = true;
            this.checkBoxLeap.Location = new System.Drawing.Point(12, 12);
            this.checkBoxLeap.Name = "checkBoxLeap";
            this.checkBoxLeap.Size = new System.Drawing.Size(103, 17);
            this.checkBoxLeap.TabIndex = 3;
            this.checkBoxLeap.Text = "Is it a leap year?";
            this.checkBoxLeap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxLeap);
            this.Controls.Add(this.listBoxYear);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.ListBox listBoxYear;
        private System.Windows.Forms.CheckBox checkBoxLeap;
    }
}

