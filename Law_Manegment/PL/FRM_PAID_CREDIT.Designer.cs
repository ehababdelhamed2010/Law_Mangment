namespace Law_Manegment.PL
{
    partial class FRM_PAID_CREDIT
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaidDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboExpID = new System.Windows.Forms.ComboBox();
            this.TxtAmountNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCreditAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_Credit = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Credit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUndo);
            this.groupBox3.Controls.Add(this.BtnDel);
            this.groupBox3.Controls.Add(this.BtnEdit);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.BtnNew);
            this.groupBox3.Location = new System.Drawing.Point(12, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 47);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // BtnUndo
            // 
            this.BtnUndo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnUndo.Enabled = false;
            this.BtnUndo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUndo.Location = new System.Drawing.Point(6, 14);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(75, 27);
            this.BtnUndo.TabIndex = 7;
            this.BtnUndo.Text = "تراجع";
            this.BtnUndo.UseVisualStyleBackColor = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDel.Location = new System.Drawing.Point(89, 14);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 27);
            this.BtnDel.TabIndex = 6;
            this.BtnDel.Text = "حذف";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(172, 14);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 27);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSave.Enabled = false;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Location = new System.Drawing.Point(255, 14);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 27);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNew.Location = new System.Drawing.Point(338, 14);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 27);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "جديد";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PaidDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboExpID);
            this.groupBox2.Controls.Add(this.TxtAmountNotes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtCreditAmount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 355);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // PaidDate
            // 
            this.PaidDate.Enabled = false;
            this.PaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaidDate.Location = new System.Drawing.Point(239, 25);
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.RightToLeftLayout = true;
            this.PaidDate.Size = new System.Drawing.Size(110, 20);
            this.PaidDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(352, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "التــــــاريخ";
            // 
            // comboExpID
            // 
            this.comboExpID.Enabled = false;
            this.comboExpID.FormattingEnabled = true;
            this.comboExpID.Location = new System.Drawing.Point(239, 69);
            this.comboExpID.Name = "comboExpID";
            this.comboExpID.Size = new System.Drawing.Size(110, 21);
            this.comboExpID.TabIndex = 10;
            // 
            // TxtAmountNotes
            // 
            this.TxtAmountNotes.Location = new System.Drawing.Point(6, 116);
            this.TxtAmountNotes.Multiline = true;
            this.TxtAmountNotes.Name = "TxtAmountNotes";
            this.TxtAmountNotes.ReadOnly = true;
            this.TxtAmountNotes.Size = new System.Drawing.Size(343, 233);
            this.TxtAmountNotes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(352, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "بيـــــــــان";
            // 
            // TxtCreditAmount
            // 
            this.TxtCreditAmount.Location = new System.Drawing.Point(6, 70);
            this.TxtCreditAmount.Name = "TxtCreditAmount";
            this.TxtCreditAmount.ReadOnly = true;
            this.TxtCreditAmount.Size = new System.Drawing.Size(110, 20);
            this.TxtCreditAmount.TabIndex = 2;
            this.TxtCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(122, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "المبـــــــلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(355, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "المصــروف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DGV_Credit);
            this.groupBox1.Location = new System.Drawing.Point(437, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 408);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(6, 19);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(289, 20);
            this.TxtSearch.TabIndex = 22;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(301, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "ابحـــــث";
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
            this.DGV_Credit.Location = new System.Drawing.Point(6, 48);
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
            this.DGV_Credit.Size = new System.Drawing.Size(343, 353);
            this.DGV_Credit.TabIndex = 2;
            this.DGV_Credit.Click += new System.EventHandler(this.DGV_Credit_Click);
            // 
            // FRM_PAID_CREDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(804, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PAID_CREDIT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مصروف";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Credit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker PaidDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboExpID;
        private System.Windows.Forms.TextBox TxtAmountNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCreditAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Credit;
        public System.Windows.Forms.TextBox TxtSearch;
        public System.Windows.Forms.Label label8;
    }
}