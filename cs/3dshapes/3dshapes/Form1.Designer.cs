namespace _3dshapes {
    partial class FormShapes {
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
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.radioButtonPrism = new System.Windows.Forms.RadioButton();
            this.radioButtonCube = new System.Windows.Forms.RadioButton();
            this.radioButtonPyramid = new System.Windows.Forms.RadioButton();
            this.radioButtonCylinder = new System.Windows.Forms.RadioButton();
            this.radioButtonSphere = new System.Windows.Forms.RadioButton();
            this.radioButtonCone = new System.Windows.Forms.RadioButton();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 10);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Height:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 30);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width:";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(12, 50);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(39, 13);
            this.labelDepth.TabIndex = 2;
            this.labelDepth.Text = "Depth:";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(59, 7);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Enabled = false;
            this.textBoxWidth.Location = new System.Drawing.Point(59, 27);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 7;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Enabled = false;
            this.textBoxDepth.Location = new System.Drawing.Point(59, 47);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepth.TabIndex = 8;
            // 
            // radioButtonPrism
            // 
            this.radioButtonPrism.AutoSize = true;
            this.radioButtonPrism.Location = new System.Drawing.Point(180, 10);
            this.radioButtonPrism.Name = "radioButtonPrism";
            this.radioButtonPrism.Size = new System.Drawing.Size(111, 17);
            this.radioButtonPrism.TabIndex = 9;
            this.radioButtonPrism.Text = "Rectangular Prism";
            this.radioButtonPrism.UseVisualStyleBackColor = true;
            this.radioButtonPrism.CheckedChanged += new System.EventHandler(this.radioButtonPrism_CheckedChanged);
            // 
            // radioButtonCube
            // 
            this.radioButtonCube.AutoSize = true;
            this.radioButtonCube.Location = new System.Drawing.Point(180, 30);
            this.radioButtonCube.Name = "radioButtonCube";
            this.radioButtonCube.Size = new System.Drawing.Size(50, 17);
            this.radioButtonCube.TabIndex = 10;
            this.radioButtonCube.Text = "Cube";
            this.radioButtonCube.UseVisualStyleBackColor = true;
            this.radioButtonCube.CheckedChanged += new System.EventHandler(this.radioButtonCube_CheckedChanged);
            // 
            // radioButtonPyramid
            // 
            this.radioButtonPyramid.AutoSize = true;
            this.radioButtonPyramid.Location = new System.Drawing.Point(180, 50);
            this.radioButtonPyramid.Name = "radioButtonPyramid";
            this.radioButtonPyramid.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPyramid.TabIndex = 11;
            this.radioButtonPyramid.Text = "Pyramid";
            this.radioButtonPyramid.UseVisualStyleBackColor = true;
            this.radioButtonPyramid.CheckedChanged += new System.EventHandler(this.radioButtonPyramid_CheckedChanged);
            // 
            // radioButtonCylinder
            // 
            this.radioButtonCylinder.AutoSize = true;
            this.radioButtonCylinder.Location = new System.Drawing.Point(300, 50);
            this.radioButtonCylinder.Name = "radioButtonCylinder";
            this.radioButtonCylinder.Size = new System.Drawing.Size(62, 17);
            this.radioButtonCylinder.TabIndex = 14;
            this.radioButtonCylinder.Text = "Cylinder";
            this.radioButtonCylinder.UseVisualStyleBackColor = true;
            this.radioButtonCylinder.CheckedChanged += new System.EventHandler(this.radioButtonCylinder_CheckedChanged);
            // 
            // radioButtonSphere
            // 
            this.radioButtonSphere.AutoSize = true;
            this.radioButtonSphere.Location = new System.Drawing.Point(300, 30);
            this.radioButtonSphere.Name = "radioButtonSphere";
            this.radioButtonSphere.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSphere.TabIndex = 13;
            this.radioButtonSphere.Text = "Sphere";
            this.radioButtonSphere.UseVisualStyleBackColor = true;
            this.radioButtonSphere.CheckedChanged += new System.EventHandler(this.radioButtonSphere_CheckedChanged);
            // 
            // radioButtonCone
            // 
            this.radioButtonCone.AutoSize = true;
            this.radioButtonCone.Location = new System.Drawing.Point(300, 10);
            this.radioButtonCone.Name = "radioButtonCone";
            this.radioButtonCone.Size = new System.Drawing.Size(50, 17);
            this.radioButtonCone.TabIndex = 12;
            this.radioButtonCone.Text = "Cone";
            this.radioButtonCone.UseVisualStyleBackColor = true;
            this.radioButtonCone.CheckedChanged += new System.EventHandler(this.radioButtonCone_CheckedChanged);
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(10, 102);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.Size = new System.Drawing.Size(610, 336);
            this.dataGridViewDisplay.TabIndex = 15;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(10, 73);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(149, 23);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Calculate &Volume";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(209, 73);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(149, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(10, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(610, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "&Save and Exit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 476);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.radioButtonCylinder);
            this.Controls.Add(this.radioButtonSphere);
            this.Controls.Add(this.radioButtonCone);
            this.Controls.Add(this.radioButtonPyramid);
            this.Controls.Add(this.radioButtonCube);
            this.Controls.Add(this.radioButtonPrism);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Name = "FormShapes";
            this.Text = "3D Shapes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.RadioButton radioButtonPrism;
        private System.Windows.Forms.RadioButton radioButtonCube;
        private System.Windows.Forms.RadioButton radioButtonPyramid;
        private System.Windows.Forms.RadioButton radioButtonCylinder;
        private System.Windows.Forms.RadioButton radioButtonSphere;
        private System.Windows.Forms.RadioButton radioButtonCone;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}

