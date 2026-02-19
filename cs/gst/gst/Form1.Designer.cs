namespace gst {
    partial class FormGST {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxGST = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelGST = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Location = new System.Drawing.Point(99, 12);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.Size = new System.Drawing.Size(689, 20);
            this.textBoxEntry.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 12);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(81, 20);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxGST
            // 
            this.textBoxGST.Location = new System.Drawing.Point(99, 392);
            this.textBoxGST.Name = "textBoxGST";
            this.textBoxGST.ReadOnly = true;
            this.textBoxGST.Size = new System.Drawing.Size(81, 20);
            this.textBoxGST.TabIndex = 2;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(99, 418);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(81, 20);
            this.textBoxTotal.TabIndex = 3;
            // 
            // labelGST
            // 
            this.labelGST.AutoSize = true;
            this.labelGST.Location = new System.Drawing.Point(27, 399);
            this.labelGST.Name = "labelGST";
            this.labelGST.Size = new System.Drawing.Size(66, 13);
            this.labelGST.TabIndex = 4;
            this.labelGST.Text = "GST Added:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(35, 425);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Cost:";
            // 
            // FormGST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelGST);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxGST);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxEntry);
            this.Name = "FormGST";
            this.Text = "GST calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxGST;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelGST;
        private System.Windows.Forms.Label labelTotal;
    }
}

