namespace Fuel_Economy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMilesPrompt = new System.Windows.Forms.Label();
            this.labelGallonsPrompt = new System.Windows.Forms.Label();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxGallons = new System.Windows.Forms.TextBox();
            this.labelOutputDescription = new System.Windows.Forms.Label();
            this.labelMPG = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMilesPrompt
            // 
            this.labelMilesPrompt.AutoSize = true;
            this.labelMilesPrompt.Location = new System.Drawing.Point(12, 15);
            this.labelMilesPrompt.Name = "labelMilesPrompt";
            this.labelMilesPrompt.Size = new System.Drawing.Size(183, 15);
            this.labelMilesPrompt.TabIndex = 0;
            this.labelMilesPrompt.Text = "Enter the number of miles driven:";
            // 
            // labelGallonsPrompt
            // 
            this.labelGallonsPrompt.AutoSize = true;
            this.labelGallonsPrompt.Location = new System.Drawing.Point(34, 44);
            this.labelGallonsPrompt.Name = "labelGallonsPrompt";
            this.labelGallonsPrompt.Size = new System.Drawing.Size(161, 15);
            this.labelGallonsPrompt.TabIndex = 1;
            this.labelGallonsPrompt.Text = "Enter the gallons of gas used:";
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Location = new System.Drawing.Point(201, 12);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiles.TabIndex = 2;
            // 
            // textBoxGallons
            // 
            this.textBoxGallons.Location = new System.Drawing.Point(201, 41);
            this.textBoxGallons.Name = "textBoxGallons";
            this.textBoxGallons.Size = new System.Drawing.Size(100, 23);
            this.textBoxGallons.TabIndex = 3;
            // 
            // labelOutputDescription
            // 
            this.labelOutputDescription.AutoSize = true;
            this.labelOutputDescription.Location = new System.Drawing.Point(105, 91);
            this.labelOutputDescription.Name = "labelOutputDescription";
            this.labelOutputDescription.Size = new System.Drawing.Size(90, 15);
            this.labelOutputDescription.TabIndex = 4;
            this.labelOutputDescription.Text = "Your car\'s MPG:";
            // 
            // labelMPG
            // 
            this.labelMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMPG.Location = new System.Drawing.Point(201, 87);
            this.labelMPG.Name = "labelMPG";
            this.labelMPG.Size = new System.Drawing.Size(100, 23);
            this.labelMPG.TabIndex = 5;
            this.labelMPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(69, 123);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 39);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate MPG";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(150, 123);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 39);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 177);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelMPG);
            this.Controls.Add(this.labelOutputDescription);
            this.Controls.Add(this.textBoxGallons);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.labelGallonsPrompt);
            this.Controls.Add(this.labelMilesPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMilesPrompt;
        private Label labelGallonsPrompt;
        private TextBox textBoxMiles;
        private TextBox textBoxGallons;
        private Label labelOutputDescription;
        private Label labelMPG;
        private Button buttonCalculate;
        private Button buttonExit;
    }
}