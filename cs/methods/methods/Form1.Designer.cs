namespace methods
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
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonDifference = new System.Windows.Forms.RadioButton();
            this.radioButtonProduct = new System.Windows.Forms.RadioButton();
            this.radioButtonQuotient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSum.TabIndex = 0;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "&Sum";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // radioButtonDifference
            // 
            this.radioButtonDifference.AutoSize = true;
            this.radioButtonDifference.Location = new System.Drawing.Point(64, 12);
            this.radioButtonDifference.Name = "radioButtonDifference";
            this.radioButtonDifference.Size = new System.Drawing.Size(74, 17);
            this.radioButtonDifference.TabIndex = 1;
            this.radioButtonDifference.TabStop = true;
            this.radioButtonDifference.Text = "&Difference";
            this.radioButtonDifference.UseVisualStyleBackColor = true;
            // 
            // radioButtonProduct
            // 
            this.radioButtonProduct.AutoSize = true;
            this.radioButtonProduct.Location = new System.Drawing.Point(144, 12);
            this.radioButtonProduct.Name = "radioButtonProduct";
            this.radioButtonProduct.Size = new System.Drawing.Size(62, 17);
            this.radioButtonProduct.TabIndex = 2;
            this.radioButtonProduct.TabStop = true;
            this.radioButtonProduct.Text = "&Product";
            this.radioButtonProduct.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuotient
            // 
            this.radioButtonQuotient.AutoSize = true;
            this.radioButtonQuotient.Location = new System.Drawing.Point(212, 12);
            this.radioButtonQuotient.Name = "radioButtonQuotient";
            this.radioButtonQuotient.Size = new System.Drawing.Size(65, 17);
            this.radioButtonQuotient.TabIndex = 3;
            this.radioButtonQuotient.TabStop = true;
            this.radioButtonQuotient.Text = "&Quotient";
            this.radioButtonQuotient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(172, 405);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(616, 36);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(172, 304);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(616, 95);
            this.listBoxOutput.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(713, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "C&lear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonQuotient);
            this.Controls.Add(this.radioButtonProduct);
            this.Controls.Add(this.radioButtonDifference);
            this.Controls.Add(this.radioButtonSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonDifference;
        private System.Windows.Forms.RadioButton radioButtonProduct;
        private System.Windows.Forms.RadioButton radioButtonQuotient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonClear;
    }
}

