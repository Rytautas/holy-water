namespace holy_water
{
    partial class InputDrink
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
            this.dtpDrinkTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGlassVolume = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trkFillPercentage = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFillPercentage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlassVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFillPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink time";
            // 
            // dtpDrinkTime
            // 
            this.dtpDrinkTime.CustomFormat = "yyyy-MM-dd   HH:mm:ss";
            this.dtpDrinkTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDrinkTime.Enabled = false;
            this.dtpDrinkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDrinkTime.Location = new System.Drawing.Point(35, 29);
            this.dtpDrinkTime.Name = "dtpDrinkTime";
            this.dtpDrinkTime.Size = new System.Drawing.Size(279, 20);
            this.dtpDrinkTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Glass volume (ml)";
            // 
            // txtGlassVolume
            // 
            this.txtGlassVolume.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtGlassVolume.Location = new System.Drawing.Point(35, 87);
            this.txtGlassVolume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtGlassVolume.Name = "txtGlassVolume";
            this.txtGlassVolume.Size = new System.Drawing.Size(120, 20);
            this.txtGlassVolume.TabIndex = 3;
            this.txtGlassVolume.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fill percentage";
            // 
            // trkFillPercentage
            // 
            this.trkFillPercentage.Location = new System.Drawing.Point(35, 169);
            this.trkFillPercentage.Maximum = 100;
            this.trkFillPercentage.Minimum = 10;
            this.trkFillPercentage.Name = "trkFillPercentage";
            this.trkFillPercentage.Size = new System.Drawing.Size(419, 45);
            this.trkFillPercentage.SmallChange = 5;
            this.trkFillPercentage.TabIndex = 6;
            this.trkFillPercentage.Value = 100;
            this.trkFillPercentage.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "10%";
            // 
            // lblFillPercentage
            // 
            this.lblFillPercentage.AutoSize = true;
            this.lblFillPercentage.Location = new System.Drawing.Point(244, 149);
            this.lblFillPercentage.Name = "lblFillPercentage";
            this.lblFillPercentage.Size = new System.Drawing.Size(22, 13);
            this.lblFillPercentage.TabIndex = 8;
            this.lblFillPercentage.Text = "X%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "100%";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(318, 231);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(399, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InputDrink
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFillPercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkFillPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGlassVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDrinkTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDrink";
            this.Text = "InputDrink";
            this.Load += new System.EventHandler(this.InputDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGlassVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFillPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDrinkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtGlassVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkFillPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFillPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}