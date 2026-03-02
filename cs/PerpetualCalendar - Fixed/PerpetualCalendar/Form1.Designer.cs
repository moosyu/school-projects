namespace PerpetualCalendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.checkBoxLeapYear = new System.Windows.Forms.CheckBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which Day is January 1st?";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 32);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(179, 20);
            this.textBoxDay.TabIndex = 1;
            // 
            // checkBoxLeapYear
            // 
            this.checkBoxLeapYear.AutoSize = true;
            this.checkBoxLeapYear.Location = new System.Drawing.Point(12, 58);
            this.checkBoxLeapYear.Name = "checkBoxLeapYear";
            this.checkBoxLeapYear.Size = new System.Drawing.Size(97, 17);
            this.checkBoxLeapYear.TabIndex = 2;
            this.checkBoxLeapYear.Text = "It is a leap year";
            this.checkBoxLeapYear.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 81);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(179, 23);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "&Show Calendar";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 14;
            this.listBoxDates.Location = new System.Drawing.Point(12, 110);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(179, 326);
            this.listBoxDates.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.checkBoxLeapYear);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Perpetual Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.CheckBox checkBoxLeapYear;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ListBox listBoxDates;
    }
}

