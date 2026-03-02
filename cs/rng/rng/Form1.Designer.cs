namespace rng
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxSets = new System.Windows.Forms.ListBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 0;
            // 
            // listBoxSets
            // 
            this.listBoxSets.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSets.FormattingEnabled = true;
            this.listBoxSets.HorizontalScrollbar = true;
            this.listBoxSets.ItemHeight = 14;
            this.listBoxSets.Location = new System.Drawing.Point(12, 38);
            this.listBoxSets.Name = "listBoxSets";
            this.listBoxSets.Size = new System.Drawing.Size(181, 88);
            this.listBoxSets.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(118, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 20);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "&Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(118, 132);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 132);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.listBoxSets);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "Form1";
            this.Text = "Lottery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxSets;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
    }
}

