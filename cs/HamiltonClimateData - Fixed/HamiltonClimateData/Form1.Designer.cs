
namespace HamiltonClimateData
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
            this.listBoxClimateData = new System.Windows.Forms.ListBox();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.pictureBoxSunshineHours = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumidRain = new System.Windows.Forms.PictureBox();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.buttonDrawGraphs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunshineHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidRain)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxClimateData
            // 
            this.listBoxClimateData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClimateData.FormattingEnabled = true;
            this.listBoxClimateData.Location = new System.Drawing.Point(12, 12);
            this.listBoxClimateData.Name = "listBoxClimateData";
            this.listBoxClimateData.Size = new System.Drawing.Size(772, 199);
            this.listBoxClimateData.TabIndex = 0;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Location = new System.Drawing.Point(12, 217);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(772, 200);
            this.pictureBoxTemperature.TabIndex = 1;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // pictureBoxSunshineHours
            // 
            this.pictureBoxSunshineHours.Location = new System.Drawing.Point(12, 427);
            this.pictureBoxSunshineHours.Name = "pictureBoxSunshineHours";
            this.pictureBoxSunshineHours.Size = new System.Drawing.Size(385, 150);
            this.pictureBoxSunshineHours.TabIndex = 2;
            this.pictureBoxSunshineHours.TabStop = false;
            // 
            // pictureBoxHumidRain
            // 
            this.pictureBoxHumidRain.Location = new System.Drawing.Point(399, 427);
            this.pictureBoxHumidRain.Name = "pictureBoxHumidRain";
            this.pictureBoxHumidRain.Size = new System.Drawing.Size(385, 150);
            this.pictureBoxHumidRain.TabIndex = 3;
            this.pictureBoxHumidRain.TabStop = false;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(154, 583);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(116, 23);
            this.buttonGetData.TabIndex = 4;
            this.buttonGetData.Text = "&Get Climate Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // buttonDrawGraphs
            // 
            this.buttonDrawGraphs.Location = new System.Drawing.Point(538, 583);
            this.buttonDrawGraphs.Name = "buttonDrawGraphs";
            this.buttonDrawGraphs.Size = new System.Drawing.Size(93, 23);
            this.buttonDrawGraphs.TabIndex = 5;
            this.buttonDrawGraphs.Text = "&Draw Graphs";
            this.buttonDrawGraphs.UseVisualStyleBackColor = true;
            this.buttonDrawGraphs.Click += new System.EventHandler(this.buttonDrawGraphs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.buttonDrawGraphs);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.pictureBoxHumidRain);
            this.Controls.Add(this.pictureBoxSunshineHours);
            this.Controls.Add(this.pictureBoxTemperature);
            this.Controls.Add(this.listBoxClimateData);
            this.Name = "Form1";
            this.Text = "Hamilton Climate Data 1981-2010";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunshineHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidRain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClimateData;
        private System.Windows.Forms.PictureBox pictureBoxTemperature;
        private System.Windows.Forms.PictureBox pictureBoxSunshineHours;
        private System.Windows.Forms.PictureBox pictureBoxHumidRain;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Button buttonDrawGraphs;
    }
}

