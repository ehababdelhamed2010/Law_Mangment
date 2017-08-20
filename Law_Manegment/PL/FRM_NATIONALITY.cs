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
    public partial class FRM_NATIONALITY : Form
    {
        BL.CLS_NATIONALITY Nationality = new BL.CLS_NATIONALITY();

        public string stat = "add";

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Nationality.Enabled = true;
        }

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Nationality.Enabled = false;
        }

        public FRM_NATIONALITY()
        {
            InitializeComponent();
            DGV_Nationality.DataSource = Nationality.Nationality_Select_All();
            this.DGV_Nationality.Columns[0].Visible = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtNationalityName.Text = "";
            TxtNationalityName.ReadOnly = false;
            stat = "add";
            BTN_Disble();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtNationalityName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجنسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNationalityName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                Nationality.Nationality_Add(TxtNationalityName.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Nationality.Nationality_Update(TxtNationalityName.Text, Program.AdminID, Convert.ToInt32(this.DGV_Nationality.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_Nationality.DataSource = Nationality.Nationality_Select_All();
            TxtNationalityName.Clear();
            TxtNationalityName.ReadOnly = true;
            BTN_Enble();

            #endregion
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtNationalityName.Text = DGV_Nationality.CurrentRow.Cells[1].Value.ToString();
            TxtNationalityName.ReadOnly= false;
            stat = "Edit";
            BTN_Disble();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_Nationality.DataSource = Nationality.Nationality_Select_All();
            TxtNationalityName.Clear();
            TxtNationalityName.ReadOnly = true;
            BTN_Enble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtNationalityName.Text = DGV_Nationality.CurrentRow.Cells[1].Value.ToString();
                Nationality.Nationality_Delete(Convert.ToInt32(this.DGV_Nationality.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Nationality.DataSource = Nationality.Nationality_Select_All();
            TxtNationalityName.Clear();

            #endregion
        }
    }
}
