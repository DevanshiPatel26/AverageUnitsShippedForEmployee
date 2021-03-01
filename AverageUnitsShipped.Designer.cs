
namespace AverageUnitsShipped
{
    partial class formAverageUnitsShipped
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
            this.components = new System.ComponentModel.Container();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnitsInput = new System.Windows.Forms.TextBox();
            this.textBoxEmployee1Entries = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelOverallAverage = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmployee2Entries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3Entries = new System.Windows.Forms.TextBox();
            this.labelEmployee1Prompt = new System.Windows.Forms.Label();
            this.labelEmployee1Average = new System.Windows.Forms.Label();
            this.labelEmployee2Average = new System.Windows.Forms.Label();
            this.labelEmployee3Average = new System.Windows.Forms.Label();
            this.labelEmployee2Prompt = new System.Windows.Forms.Label();
            this.labelEmployee3Prompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.Location = new System.Drawing.Point(45, 66);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(73, 31);
            this.labelUnits.TabIndex = 1;
            this.labelUnits.Text = "&Units:";
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(124, 63);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(80, 31);
            this.textBoxUnitsInput.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxUnitsInput, "Please enter the units that are shipped.");
            // 
            // textBoxEmployee1Entries
            // 
            this.textBoxEmployee1Entries.Location = new System.Drawing.Point(28, 156);
            this.textBoxEmployee1Entries.Multiline = true;
            this.textBoxEmployee1Entries.Name = "textBoxEmployee1Entries";
            this.textBoxEmployee1Entries.Size = new System.Drawing.Size(158, 187);
            this.textBoxEmployee1Entries.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxEmployee1Entries, "It shows the list of valid inputs for Employee 1.");
            // 
            // labelDays
            // 
            this.labelDays.Location = new System.Drawing.Point(45, 21);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(95, 31);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "Day 1";
            this.toolTip.SetToolTip(this.labelDays, "It shows the different days.");
            // 
            // labelOverallAverage
            // 
            this.labelOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOverallAverage.Location = new System.Drawing.Point(28, 407);
            this.labelOverallAverage.Name = "labelOverallAverage";
            this.labelOverallAverage.Size = new System.Drawing.Size(500, 26);
            this.labelOverallAverage.TabIndex = 12;
            this.labelOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelOverallAverage, "It shows that overall average of the units shipped.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(28, 446);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter\r\n\r\n";
            this.toolTip.SetToolTip(this.buttonEnter, "Please Click Enter to input the value.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(219, 446);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Please Click Reset to enter the input again.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(410, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Please Click Exit to come out of the form.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxEmployee2Entries
            // 
            this.textBoxEmployee2Entries.Location = new System.Drawing.Point(200, 156);
            this.textBoxEmployee2Entries.Multiline = true;
            this.textBoxEmployee2Entries.Name = "textBoxEmployee2Entries";
            this.textBoxEmployee2Entries.Size = new System.Drawing.Size(158, 187);
            this.textBoxEmployee2Entries.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxEmployee2Entries, "It shows the list of valid inputs for Employee 2.");
            // 
            // textBoxEmployee3Entries
            // 
            this.textBoxEmployee3Entries.Location = new System.Drawing.Point(370, 156);
            this.textBoxEmployee3Entries.Multiline = true;
            this.textBoxEmployee3Entries.Name = "textBoxEmployee3Entries";
            this.textBoxEmployee3Entries.Size = new System.Drawing.Size(158, 187);
            this.textBoxEmployee3Entries.TabIndex = 10;
            this.toolTip.SetToolTip(this.textBoxEmployee3Entries, "It shows the list of valid inputs for Employee 3.");
            // 
            // labelEmployee1Prompt
            // 
            this.labelEmployee1Prompt.Location = new System.Drawing.Point(28, 110);
            this.labelEmployee1Prompt.Name = "labelEmployee1Prompt";
            this.labelEmployee1Prompt.Size = new System.Drawing.Size(158, 31);
            this.labelEmployee1Prompt.TabIndex = 3;
            this.labelEmployee1Prompt.Text = "Employee &1";
            this.labelEmployee1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee1Prompt, "Employee 1");
            // 
            // labelEmployee1Average
            // 
            this.labelEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee1Average.Location = new System.Drawing.Point(28, 361);
            this.labelEmployee1Average.Name = "labelEmployee1Average";
            this.labelEmployee1Average.Size = new System.Drawing.Size(158, 35);
            this.labelEmployee1Average.TabIndex = 5;
            this.labelEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee1Average, "Average of Employee 1.");
            // 
            // labelEmployee2Average
            // 
            this.labelEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee2Average.Location = new System.Drawing.Point(200, 361);
            this.labelEmployee2Average.Name = "labelEmployee2Average";
            this.labelEmployee2Average.Size = new System.Drawing.Size(150, 35);
            this.labelEmployee2Average.TabIndex = 8;
            this.labelEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee2Average, "Average of Employee 2.");
            // 
            // labelEmployee3Average
            // 
            this.labelEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee3Average.Location = new System.Drawing.Point(370, 361);
            this.labelEmployee3Average.Name = "labelEmployee3Average";
            this.labelEmployee3Average.Size = new System.Drawing.Size(158, 35);
            this.labelEmployee3Average.TabIndex = 11;
            this.labelEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee3Average, "Average of Employee 3.");
            // 
            // labelEmployee2Prompt
            // 
            this.labelEmployee2Prompt.Location = new System.Drawing.Point(200, 110);
            this.labelEmployee2Prompt.Name = "labelEmployee2Prompt";
            this.labelEmployee2Prompt.Size = new System.Drawing.Size(158, 31);
            this.labelEmployee2Prompt.TabIndex = 6;
            this.labelEmployee2Prompt.Text = "Employee &2";
            this.labelEmployee2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee2Prompt, "Employee 2");
            // 
            // labelEmployee3Prompt
            // 
            this.labelEmployee3Prompt.Location = new System.Drawing.Point(364, 110);
            this.labelEmployee3Prompt.Name = "labelEmployee3Prompt";
            this.labelEmployee3Prompt.Size = new System.Drawing.Size(158, 31);
            this.labelEmployee3Prompt.TabIndex = 9;
            this.labelEmployee3Prompt.Text = "Employee &3";
            this.labelEmployee3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee3Prompt, "Employee 3");
            this.labelEmployee3Prompt.Click += new System.EventHandler(this.label4_Click);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 492);
            this.Controls.Add(this.labelEmployee3Average);
            this.Controls.Add(this.labelEmployee2Average);
            this.Controls.Add(this.textBoxEmployee3Entries);
            this.Controls.Add(this.textBoxEmployee2Entries);
            this.Controls.Add(this.labelEmployee3Prompt);
            this.Controls.Add(this.labelEmployee2Prompt);
            this.Controls.Add(this.labelEmployee1Average);
            this.Controls.Add(this.labelEmployee1Prompt);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOverallAverage);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxEmployee1Entries);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.labelUnits);
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.Load += new System.EventHandler(this.formAverageUnitsShipped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.TextBox textBoxEmployee1Entries;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelEmployee1Prompt;
        private System.Windows.Forms.Label labelEmployee1Average;
        private System.Windows.Forms.Label labelEmployee2Prompt;
        private System.Windows.Forms.Label labelEmployee3Prompt;
        private System.Windows.Forms.TextBox textBoxEmployee2Entries;
        private System.Windows.Forms.TextBox textBoxEmployee3Entries;
        private System.Windows.Forms.Label labelEmployee2Average;
        private System.Windows.Forms.Label labelEmployee3Average;
        private System.Windows.Forms.Label labelOverallAverage;
    }
}

