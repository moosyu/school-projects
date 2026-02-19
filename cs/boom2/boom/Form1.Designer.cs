namespace boom {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.listBoxCounter = new System.Windows.Forms.ListBox();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(299, 415);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(120, 23);
            this.buttonBegin.TabIndex = 0;
            this.buttonBegin.Text = "Begin...";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // listBoxCounter
            // 
            this.listBoxCounter.FormattingEnabled = true;
            this.listBoxCounter.Location = new System.Drawing.Point(299, 12);
            this.listBoxCounter.Name = "listBoxCounter";
            this.listBoxCounter.Size = new System.Drawing.Size(120, 303);
            this.listBoxCounter.TabIndex = 1;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCounter);
            this.Controls.Add(this.buttonBegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.ListBox listBoxCounter;
        private System.Windows.Forms.Timer timerCountdown;
    }
}

