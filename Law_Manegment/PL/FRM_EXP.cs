using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Law_Manegment.PL
{
    public partial class FRM_EXP : Form
    {
        #region متغيرات عامة على الفورم

        BL.CLS_EXP exp = new BL.CLS_EXP();

        public string stat = "add";

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Exp.Enabled = true;
        }

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Exp.Enabled = false;
        }

        #endregion

        public FRM_EXP()
        {
            InitializeComponent();
            #region  ملئ الداتا جريد للمصروفات
            DGV_Exp.DataSource = exp.Expenses_Select_All();
            this.DGV_Exp.Columns[0].Visible = false;

            #endregion

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtExpName.Text = "";
            TxtExpName.ReadOnly = false;
            stat = "add";
            BTN_Disble();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtExpName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtExpName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                exp.Expenses_Add(TxtExpName.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                exp.Expenses_Update(TxtExpName.Text, Program.AdminID, Convert.ToInt32(this.DGV_Exp.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_Exp.DataSource = exp.Expenses_Select_All();
            TxtExpName.Clear();
            TxtExpName.ReadOnly = true;
            BTN_Enble();

            #endregion

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtExpName.Text = DGV_Exp.CurrentRow.Cells[1].Value.ToString();
            TxtExpName.ReadOnly = false;
            stat = "Edit";
            BTN_Disble();

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtExpName.Text = DGV_Exp.CurrentRow.Cells[1].Value.ToString();
                exp.Expenses_Delete(Convert.ToInt32(this.DGV_Exp.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Exp.DataSource = exp.Expenses_Select_All();
            TxtExpName.Clear();

            #endregion

        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_Exp.DataSource = exp.Expenses_Select_All();
            TxtExpName.Clear();
            TxtExpName.ReadOnly = true;
            BTN_Enble();

        }
    }
}
