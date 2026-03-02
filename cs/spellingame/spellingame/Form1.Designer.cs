namespace spellingame
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
            this.components = new System.ComponentModel.Container();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonNF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 37);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(118, 37);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ReadOnly = true;
            this.textBoxWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxWord.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(118, 37);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 20);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "&Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(12, 8);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(776, 23);
            this.buttonBegin.TabIndex = 3;
            this.buttonBegin.Text = "&Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonNF
            // 
            this.buttonNF.Enabled = false;
            this.buttonNF.Location = new System.Drawing.Point(12, 8);
            this.buttonNF.Name = "buttonNF";
            this.buttonNF.Size = new System.Drawing.Size(776, 23);
            this.buttonNF.TabIndex = 4;
            this.buttonNF.UseVisualStyleBackColor = true;
            this.buttonNF.Visible = false;
            this.buttonNF.Click += new System.EventHandler(this.buttonNF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNF);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonNF;
        private System.Windows.Forms.Label label1;
    }
}

