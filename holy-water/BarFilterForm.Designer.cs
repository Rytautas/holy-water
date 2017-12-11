﻿namespace holy_water
{
    partial class BarFilterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFilterByAverage = new System.Windows.Forms.RadioButton();
            this.rdbFilterByCount = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinimumValue = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFilterByCount);
            this.groupBox1.Controls.Add(this.rdbFilterByAverage);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter condition";
            // 
            // rdbFilterByAverage
            // 
            this.rdbFilterByAverage.AutoSize = true;
            this.rdbFilterByAverage.Checked = true;
            this.rdbFilterByAverage.Location = new System.Drawing.Point(7, 20);
            this.rdbFilterByAverage.Name = "rdbFilterByAverage";
            this.rdbFilterByAverage.Size = new System.Drawing.Size(106, 17);
            this.rdbFilterByAverage.TabIndex = 0;
            this.rdbFilterByAverage.TabStop = true;
            this.rdbFilterByAverage.Text = "Filter by average ";
            this.rdbFilterByAverage.UseVisualStyleBackColor = true;
            // 
            // rdbFilterByCount
            // 
            this.rdbFilterByCount.AutoSize = true;
            this.rdbFilterByCount.Location = new System.Drawing.Point(7, 44);
            this.rdbFilterByCount.Name = "rdbFilterByCount";
            this.rdbFilterByCount.Size = new System.Drawing.Size(91, 17);
            this.rdbFilterByCount.TabIndex = 1;
            this.rdbFilterByCount.Text = "Filter by count";
            this.rdbFilterByCount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum value";
            // 
            // txtMinimumValue
            // 
            this.txtMinimumValue.Location = new System.Drawing.Point(39, 136);
            this.txtMinimumValue.Name = "txtMinimumValue";
            this.txtMinimumValue.Size = new System.Drawing.Size(179, 20);
            this.txtMinimumValue.TabIndex = 2;
            this.txtMinimumValue.Text = "50";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 174);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Filter";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BarFilter
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMinimumValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarFilter";
            this.Text = "Bars filter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFilterByCount;
        private System.Windows.Forms.RadioButton rdbFilterByAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinimumValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}