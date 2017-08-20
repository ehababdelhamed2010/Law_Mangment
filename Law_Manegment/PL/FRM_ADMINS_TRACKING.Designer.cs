namespace Law_Manegment.PL
{
    partial class FRM_ADMINS_TRACKING
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboAdminID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaidDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PaidDate1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Tracking = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDone = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tracking)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboAdminID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PaidDate2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PaidDate1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 45);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // comboAdminID
            // 
            this.comboAdminID.FormattingEnabled = true;
            this.comboAdminID.Location = new System.Drawing.Point(6, 16);
            this.comboAdminID.Name = "comboAdminID";
            this.comboAdminID.Size = new System.Drawing.Size(152, 21);
            this.comboAdminID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(164, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "المستخــــدم";
            // 
            // PaidDate2
            // 
            this.PaidDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaidDate2.Location = new System.Drawing.Point(235, 16);
            this.PaidDate2.Name = "PaidDate2";
            this.PaidDate2.RightToLeftLayout = true;
            this.PaidDate2.Size = new System.Drawing.Size(95, 20);
            this.PaidDate2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(336, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "التاريخ من:";
            // 
            // PaidDate1
            // 
            this.PaidDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaidDate1.Location = new System.Drawing.Point(397, 16);
            this.PaidDate1.Name = "PaidDate1";
            this.PaidDate1.RightToLeftLayout = true;
            this.PaidDate1.Size = new System.Drawing.Size(95, 20);
            this.PaidDate1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(498, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "التاريخ من:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Tracking);
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 362);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // DGV_Tracking
            // 
            this.DGV_Tracking.AllowUserToAddRows = false;
            this.DGV_Tracking.AllowUserToDeleteRows = false;
            this.DGV_Tracking.AllowUserToResizeColumns = false;
            this.DGV_Tracking.AllowUserToResizeRows = false;
            this.DGV_Tracking.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tracking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Tracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tracking.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Tracking.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tracking.Location = new System.Drawing.Point(6, 15);
            this.DGV_Tracking.MultiSelect = false;
            this.DGV_Tracking.Name = "DGV_Tracking";
            this.DGV_Tracking.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tracking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Tracking.RowHeadersVisible = false;
            this.DGV_Tracking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tracking.Size = new System.Drawing.Size(550, 341);
            this.DGV_Tracking.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDone);
            this.groupBox3.Location = new System.Drawing.Point(10, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 47);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDone.Location = new System.Drawing.Point(10, 14);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 27);
            this.BtnDone.TabIndex = 7;
            this.BtnDone.Text = "عرض";
            this.BtnDone.UseVisualStyleBackColor = false;
            // 
            // FRM_ADMINS_TRACKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADMINS_TRACKING";
            this.Text = "تتبع المستخدمين";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tracking)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboAdminID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PaidDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PaidDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Tracking;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDone;
    }
}