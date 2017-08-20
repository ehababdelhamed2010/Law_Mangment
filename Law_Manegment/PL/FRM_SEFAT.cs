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
    public partial class FRM_SEFAT : Form
    {

        #region متغيرات عامة على الفورم

        BL.CLS_SEFAT sefat = new BL.CLS_SEFAT();

        public string stat = "add";

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Sefat.Enabled = true;
        }

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Sefat.Enabled = false;
        }

        #endregion

        public FRM_SEFAT()
        {
            InitializeComponent();

            #region عند بدء تحميل الفورم

            #region  ملئ الداتا جريد للصفات
            DGV_Sefat.DataSource = sefat.Sefat_Select_All();
            this.DGV_Sefat.Columns[0].Visible = false;

            #endregion

            #endregion

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtSefaName.Text = "";
            TxtSefaName.ReadOnly = false;
            stat = "add";
            BTN_Disble();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtSefaName.Text==string.Empty)
            {
                MessageBox.Show("يجب ادخال الصفة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSefaName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                sefat.Sefat_Add(TxtSefaName.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sefat.Sefat_Update(TxtSefaName.Text, Program.AdminID,Convert.ToInt32( this.DGV_Sefat.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_Sefat.DataSource = sefat.Sefat_Select_All();
            TxtSefaName.Clear();
            TxtSefaName.ReadOnly = true;
            BTN_Enble();

            #endregion

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtSefaName.Text = DGV_Sefat.CurrentRow.Cells[1].Value.ToString();
            TxtSefaName.ReadOnly = false;
            stat = "Edit";
            BTN_Disble();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_Sefat.DataSource = sefat.Sefat_Select_All();
            TxtSefaName.Clear();
            TxtSefaName.ReadOnly = true;
            BTN_Enble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtSefaName.Text = DGV_Sefat.CurrentRow.Cells[1].Value.ToString();
                sefat.Sefat_Delete(Convert.ToInt32(this.DGV_Sefat.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Sefat.DataSource = sefat.Sefat_Select_All();
            TxtSefaName.Clear();

            #endregion
        }
    }
}
