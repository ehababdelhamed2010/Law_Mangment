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
    public partial class FRM_POLICE : Form
    {

        BL.CLS_POLICE police = new BL.CLS_POLICE();

        public string stat = "add";

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Police.Enabled = true;
        }

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Police.Enabled = false;
        }

        public void TxtEnable()
        {
            TxtPoliceName.ReadOnly = false;
            TxtPoliceAddress.ReadOnly = false;
            TxtPoliceNotes.ReadOnly = false;
        }

        public void TxtDisable()
        {
            TxtPoliceName.ReadOnly = true;
            TxtPoliceAddress.ReadOnly = true;
            TxtPoliceNotes.ReadOnly = true;
        }

        public void TxtClear()
        {
            TxtPoliceName.Text = "";
            TxtPoliceAddress.Text = "";
            TxtPoliceNotes.Text = "";
        }


        public FRM_POLICE()
        {
            InitializeComponent();
            DGV_Police.DataSource = police.Police_Select_All();
            this.DGV_Police.Columns[0].Visible = false;
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
            if (TxtPoliceName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم قسم الشرطة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPoliceName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                police.Police_Add(TxtPoliceName.Text, TxtPoliceAddress.Text, TxtPoliceNotes.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               police.Police_Update(TxtPoliceName.Text, TxtPoliceAddress.Text, TxtPoliceNotes.Text, Program.AdminID, Convert.ToInt32(DGV_Police.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_Police.DataSource = police.Police_Select_All();
            TxtClear();
            TxtDisable();
            BTN_Enble();

            #endregion
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtPoliceName.Text = DGV_Police.CurrentRow.Cells[1].Value.ToString();
            TxtPoliceAddress.Text = DGV_Police.CurrentRow.Cells[2].Value.ToString();
            TxtPoliceNotes.Text = DGV_Police.CurrentRow.Cells[3].Value.ToString();
            TxtEnable();
            stat = "Edit";
            BTN_Disble();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_Police.DataSource =police.Police_Select_All();
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
                TxtPoliceName.Text = DGV_Police.CurrentRow.Cells[1].Value.ToString();
                TxtPoliceAddress.Text = DGV_Police.CurrentRow.Cells[2].Value.ToString();
                TxtPoliceNotes.Text = DGV_Police.CurrentRow.Cells[3].Value.ToString();
                police.Police_Delete(Convert.ToInt32(this.DGV_Police.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Police.DataSource = police.Police_Select_All();
            TxtClear();

            #endregion
        }
    }
}
