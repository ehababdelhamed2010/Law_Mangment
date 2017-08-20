namespace Law_Manegment.PL
{
    partial class FRM_POLICE
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtPoliceNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPoliceAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPoliceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Police = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Police)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUndo);
            this.groupBox3.Controls.Add(this.BtnDel);
            this.groupBox3.Controls.Add(this.BtnEdit);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.BtnNew);
            this.groupBox3.Location = new System.Drawing.Point(17, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 47);
            this.groupBox3.TabIndex = 8;
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
            this.groupBox2.Controls.Add(this.TxtPoliceNotes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtPoliceAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtPoliceName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // TxtPoliceNotes
            // 
            this.TxtPoliceNotes.Location = new System.Drawing.Point(6, 97);
            this.TxtPoliceNotes.Multiline = true;
            this.TxtPoliceNotes.Name = "TxtPoliceNotes";
            this.TxtPoliceNotes.ReadOnly = true;
            this.TxtPoliceNotes.Size = new System.Drawing.Size(343, 55);
            this.TxtPoliceNotes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(361, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ملاحظات";
            // 
            // TxtPoliceAddress
            // 
            this.TxtPoliceAddress.Location = new System.Drawing.Point(6, 58);
            this.TxtPoliceAddress.Name = "TxtPoliceAddress";
            this.TxtPoliceAddress.ReadOnly = true;
            this.TxtPoliceAddress.Size = new System.Drawing.Size(343, 20);
            this.TxtPoliceAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(361, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "العنوان";
            // 
            // TxtPoliceName
            // 
            this.TxtPoliceName.Location = new System.Drawing.Point(6, 19);
            this.TxtPoliceName.Name = "TxtPoliceName";
            this.TxtPoliceName.ReadOnly = true;
            this.TxtPoliceName.Size = new System.Drawing.Size(343, 20);
            this.TxtPoliceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "قسم شرطة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Police);
            this.groupBox1.Location = new System.Drawing.Point(17, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // DGV_Police
            // 
            this.DGV_Police.AllowUserToAddRows = false;
            this.DGV_Police.AllowUserToDeleteRows = false;
            this.DGV_Police.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Police.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Police.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Police.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Police.Location = new System.Drawing.Point(6, 19);
            this.DGV_Police.MultiSelect = false;
            this.DGV_Police.Name = "DGV_Police";
            this.DGV_Police.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Police.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Police.RowHeadersVisible = false;
            this.DGV_Police.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Police.Size = new System.Drawing.Size(407, 105);
            this.DGV_Police.TabIndex = 2;
            // 
            // FRM_POLICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(452, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_POLICE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قسم الشرطة";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Police)).EndInit();
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
        private System.Windows.Forms.TextBox TxtPoliceNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPoliceAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPoliceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Police;
    }
}