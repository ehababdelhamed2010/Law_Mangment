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
    public partial class FRM_COURTS : Form
    {
        #region  متغيرات عامة على الفورم
       
        #region نسخة الكلاس وحالة الحفظ
        BL.CLS_COURTS courts = new  BL.CLS_COURTS();

        public string stat = "add";
        #endregion

        #region تفعيل الازرار

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Courts.Enabled = true;
        }

        #endregion

        #region تعطيل الازرار

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Courts.Enabled = false;
        }

        #endregion

        #region تفعيل التكستات

        public void TxtEnable() 
            {
            TxtCourtName.ReadOnly= false;
            TxtCourtAddress.ReadOnly = false;
            TxtCourtNotes.ReadOnly = false;
        }

        #endregion

        #region تعطيل التكستات

        public void TxtDisable()
        {
            TxtCourtName.ReadOnly = true;
            TxtCourtAddress.ReadOnly = true;
            TxtCourtNotes.ReadOnly = true;
        }

        #endregion

        #region مسح كل التكستات

        public void TxtClear()
        {
            TxtCourtName.Text = "";
            TxtCourtAddress.Text = "";
            TxtCourtNotes.Text = "";
        }

        #endregion

        #endregion

        public FRM_COURTS()
        {
            InitializeComponent();

            #region  متغيرات عند بدء التحميل

            DGV_Courts.DataSource = courts.Courts_Select_All();
            this.DGV_Courts.Columns[0].Visible = false;

            #endregion
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtClear();
            stat = "add";
            BTN_Disble();
            TxtEnable();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtCourtName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المحكمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCourtName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                courts.Courts_Add(TxtCourtName.Text,TxtCourtAddress.Text,TxtCourtNotes.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                courts.Courts_Update(TxtCourtName.Text, TxtCourtAddress.Text, TxtCourtNotes.Text, Program.AdminID, Convert.ToInt32(DGV_Courts.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_Courts.DataSource = courts.Courts_Select_All();
            TxtClear();
            TxtDisable();
            BTN_Enble();

            #endregion

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtCourtName.Text = DGV_Courts.CurrentRow.Cells[1].Value.ToString();
            TxtCourtAddress.Text = DGV_Courts.CurrentRow.Cells[2].Value.ToString();
            TxtCourtNotes.Text = DGV_Courts.CurrentRow.Cells[3].Value.ToString();
            TxtEnable();
            stat = "Edit";
            BTN_Disble();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_Courts.DataSource = courts.Courts_Select_All();
            TxtClear();
            TxtDisable();
            BTN_Enble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtCourtName.Text = DGV_Courts.CurrentRow.Cells[1].Value.ToString();
                TxtCourtAddress.Text = DGV_Courts.CurrentRow.Cells[2].Value.ToString();
                TxtCourtNotes.Text = DGV_Courts.CurrentRow.Cells[3].Value.ToString();
                courts.Courts_Delete(Convert.ToInt32(this.DGV_Courts.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Courts.DataSource = courts.Courts_Select_All();
            TxtClear();

            #endregion
        }
    }
}
