namespace Law_Manegment.PL
{
    partial class FRM_EXP_LEDGER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboExpID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaidDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PaidDate1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Credit = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCreditAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Credit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboExpID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PaidDate2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PaidDate1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // comboExpID
            // 
            this.comboExpID.FormattingEnabled = true;
            this.comboExpID.Location = new System.Drawing.Point(6, 16);
            this.comboExpID.Name = "comboExpID";
            this.comboExpID.Size = new System.Drawing.Size(152, 21);
            this.comboExpID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(164, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "المصــروف";
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
            this.groupBox1.Controls.Add(this.DGV_Credit);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 377);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // DGV_Credit
            // 
            this.DGV_Credit.AllowUserToAddRows = false;
            this.DGV_Credit.AllowUserToDeleteRows = false;
            this.DGV_Credit.AllowUserToResizeColumns = false;
            this.DGV_Credit.AllowUserToResizeRows = false;
            this.DGV_Credit.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Credit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Credit.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Credit.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Credit.Location = new System.Drawing.Point(6, 15);
            this.DGV_Credit.MultiSelect = false;
            this.DGV_Credit.Name = "DGV_Credit";
            this.DGV_Credit.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Credit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Credit.RowHeadersVisible = false;
            this.DGV_Credit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Credit.Size = new System.Drawing.Size(550, 353);
            this.DGV_Credit.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCreditAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BtnDone);
            this.groupBox3.Location = new System.Drawing.Point(12, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // TxtCreditAmount
            // 
            this.TxtCreditAmount.Location = new System.Drawing.Point(6, 14);
            this.TxtCreditAmount.Name = "TxtCreditAmount";
            this.TxtCreditAmount.ReadOnly = true;
            this.TxtCreditAmount.Size = new System.Drawing.Size(110, 20);
            this.TxtCreditAmount.TabIndex = 8;
            this.TxtCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(122, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "الاجمالــــــي";
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDone.Location = new System.Drawing.Point(468, 14);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 27);
            this.BtnDone.TabIndex = 7;
            this.BtnDone.Text = "عرض";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // FRM_EXP_LEDGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(583, 504);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_EXP_LEDGER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب المصروفات";
            this.Load += new System.EventHandler(this.FRM_EXP_LEDGER_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Credit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PaidDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PaidDate1;
        private System.Windows.Forms.ComboBox comboExpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Credit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.TextBox TxtCreditAmount;
        private System.Windows.Forms.Label label4;
    }
}