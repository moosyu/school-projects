namespace SpaceWeightCalculator
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
            this.buttonFindWeights = new System.Windows.Forms.Button();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.listBoxWeights = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass (kg):";
            // 
            // buttonFindWeights
            // 
            this.buttonFindWeights.Location = new System.Drawing.Point(12, 32);
            this.buttonFindWeights.Name = "buttonFindWeights";
            this.buttonFindWeights.Size = new System.Drawing.Size(239, 23);
            this.buttonFindWeights.TabIndex = 1;
            this.buttonFindWeights.Text = "&Find Weights";
            this.buttonFindWeights.UseVisualStyleBackColor = true;
            this.buttonFindWeights.Click += new System.EventHandler(this.buttonFindWeights_Click);
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(71, 6);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(180, 20);
            this.textBoxMass.TabIndex = 2;
            // 
            // listBoxWeights
            // 
            this.listBoxWeights.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWeights.FormattingEnabled = true;
            this.listBoxWeights.ItemHeight = 14;
            this.listBoxWeights.Location = new System.Drawing.Point(12, 61);
            this.listBoxWeights.Name = "listBoxWeights";
            this.listBoxWeights.Size = new System.Drawing.Size(239, 242);
            this.listBoxWeights.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxWeights);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.buttonFindWeights);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindWeights;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.ListBox listBoxWeights;
    }
}

