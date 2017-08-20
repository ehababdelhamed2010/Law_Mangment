namespace Law_Manegment.PL
{
    partial class FRM_TAWKELTYPE
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTawkelTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_TawkelType = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TawkelType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUndo);
            this.groupBox3.Controls.Add(this.BtnDel);
            this.groupBox3.Controls.Add(this.BtnEdit);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.BtnNew);
            this.groupBox3.Location = new System.Drawing.Point(10, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 47);
            this.groupBox3.TabIndex = 5;
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
            this.BtnUndo.TabIndex = 8;
            this.BtnUndo.Text = "تراجع";
            this.BtnUndo.UseVisualStyleBackColor = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDel.Location = new System.Drawing.Point(85, 14);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 27);
            this.BtnDel.TabIndex = 7;
            this.BtnDel.Text = "حذف";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(164, 14);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 27);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSave.Enabled = false;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Location = new System.Drawing.Point(243, 14);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 27);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNew.Location = new System.Drawing.Point(322, 14);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 27);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "جديد";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTawkelTypeName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // TxtTawkelTypeName
            // 
            this.TxtTawkelTypeName.Location = new System.Drawing.Point(6, 19);
            this.TxtTawkelTypeName.Name = "TxtTawkelTypeName";
            this.TxtTawkelTypeName.ReadOnly = true;
            this.TxtTawkelTypeName.Size = new System.Drawing.Size(345, 20);
            this.TxtTawkelTypeName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(357, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "الوكالة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_TawkelType);
            this.groupBox1.Location = new System.Drawing.Point(10, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // DGV_TawkelType
            // 
            this.DGV_TawkelType.AllowUserToAddRows = false;
            this.DGV_TawkelType.AllowUserToDeleteRows = false;
            this.DGV_TawkelType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TawkelType.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV_TawkelType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TawkelType.Location = new System.Drawing.Point(6, 19);
            this.DGV_TawkelType.MultiSelect = false;
            this.DGV_TawkelType.Name = "DGV_TawkelType";
            this.DGV_TawkelType.ReadOnly = true;
            this.DGV_TawkelType.RowHeadersVisible = false;
            this.DGV_TawkelType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TawkelType.Size = new System.Drawing.Size(391, 105);
            this.DGV_TawkelType.TabIndex = 2;
            this.DGV_TawkelType.Click += new System.EventHandler(this.DGV_TawkelType_Click);
            // 
            // FRM_TAWKELTYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_TAWKELTYPE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انواع الوكالات";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TawkelType)).EndInit();
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
        private System.Windows.Forms.TextBox TxtTawkelTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_TawkelType;
    }
}