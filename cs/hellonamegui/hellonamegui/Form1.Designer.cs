namespace hellonamegui
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.clickMe = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type here to change text:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxName.Location = new System.Drawing.Point(230, 145);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(126, 13);
            this.textBoxName.TabIndex = 1;
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(362, 140);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(75, 23);
            this.clickMe.TabIndex = 2;
            this.clickMe.Text = "&Click me";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(230, 164);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(126, 20);
            this.output.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1476, 821);
            this.Controls.Add(this.output);
            this.Controls.Add(this.clickMe);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.TextBox output;
    }
}

