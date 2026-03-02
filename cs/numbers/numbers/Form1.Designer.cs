namespace numbers
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(12, 37);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(1449, 20);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(12, 76);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(1449, 20);
            this.textBoxNum2.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 115);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(1449, 20);
            this.textBoxOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 141);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(12, 170);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.ReadOnly = true;
            this.textBoxProduct.Size = new System.Drawing.Size(1449, 20);
            this.textBoxProduct.TabIndex = 6;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(93, 141);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "&Multiply";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 648);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Button buttonMultiply;
    }
}

