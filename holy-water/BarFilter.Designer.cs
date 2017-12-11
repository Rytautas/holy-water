namespace holy_water
{
    partial class BarFilter
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
            this.rdbFilterByCount = new System.Windows.Forms.RadioButton();
            this.rdbFilterByAverage = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinimumValue = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbTop = new System.Windows.Forms.RadioButton();
            this.rdbBottom = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBottom);
            this.groupBox1.Controls.Add(this.rdbTop);
            this.groupBox1.Controls.Add(this.rdbFilterByCount);
            this.groupBox1.Controls.Add(this.rdbFilterByAverage);
            this.groupBox1.Location = new System.Drawing.Point(43, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter condition";
            // 
            // rdbFilterByCount
            // 
            this.rdbFilterByCount.AutoSize = true;
            this.rdbFilterByCount.Location = new System.Drawing.Point(9, 54);
            this.rdbFilterByCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFilterByCount.Name = "rdbFilterByCount";
            this.rdbFilterByCount.Size = new System.Drawing.Size(118, 21);
            this.rdbFilterByCount.TabIndex = 1;
            this.rdbFilterByCount.Text = "Filter by count";
            this.rdbFilterByCount.UseVisualStyleBackColor = true;
            this.rdbFilterByCount.CheckedChanged += new System.EventHandler(this.rdbFilterByCount_CheckedChanged);
            // 
            // rdbFilterByAverage
            // 
            this.rdbFilterByAverage.AutoSize = true;
            this.rdbFilterByAverage.Checked = true;
            this.rdbFilterByAverage.Location = new System.Drawing.Point(9, 25);
            this.rdbFilterByAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFilterByAverage.Name = "rdbFilterByAverage";
            this.rdbFilterByAverage.Size = new System.Drawing.Size(139, 21);
            this.rdbFilterByAverage.TabIndex = 0;
            this.rdbFilterByAverage.TabStop = true;
            this.rdbFilterByAverage.Text = "Filter by average ";
            this.rdbFilterByAverage.UseVisualStyleBackColor = true;
            this.rdbFilterByAverage.CheckedChanged += new System.EventHandler(this.rdbFilterByAverage_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum value";
            // 
            // txtMinimumValue
            // 
            this.txtMinimumValue.Location = new System.Drawing.Point(52, 227);
            this.txtMinimumValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinimumValue.Name = "txtMinimumValue";
            this.txtMinimumValue.Size = new System.Drawing.Size(237, 22);
            this.txtMinimumValue.TabIndex = 2;
            this.txtMinimumValue.Text = "50";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(146, 300);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Filter";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbTop
            // 
            this.rdbTop.AutoSize = true;
            this.rdbTop.Location = new System.Drawing.Point(9, 82);
            this.rdbTop.Name = "rdbTop";
            this.rdbTop.Size = new System.Drawing.Size(54, 21);
            this.rdbTop.TabIndex = 5;
            this.rdbTop.TabStop = true;
            this.rdbTop.Text = "Top";
            this.rdbTop.UseVisualStyleBackColor = true;
            this.rdbTop.CheckedChanged += new System.EventHandler(this.rdbTop_CheckedChanged);
            // 
            // rdbBottom
            // 
            this.rdbBottom.AutoSize = true;
            this.rdbBottom.Location = new System.Drawing.Point(9, 109);
            this.rdbBottom.Name = "rdbBottom";
            this.rdbBottom.Size = new System.Drawing.Size(73, 21);
            this.rdbBottom.TabIndex = 5;
            this.rdbBottom.TabStop = true;
            this.rdbBottom.Text = "Bottom";
            this.rdbBottom.UseVisualStyleBackColor = true;
            this.rdbBottom.CheckedChanged += new System.EventHandler(this.rdbBottom_CheckedChanged);
            // 
            // BarFilter
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMinimumValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton rdbBottom;
        private System.Windows.Forms.RadioButton rdbTop;
    }
}