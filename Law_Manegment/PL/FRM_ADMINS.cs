using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Law_Manegment.PL
{
    public partial class FRM_ADMINS : Form
    {
        #region متغيرات عامة على الفورم


        #region حالة الحفظ للجدولين

        BL.CLS_ADMINS admin = new BL.CLS_ADMINS();
        public string Adminstat = "add";

        public string Loginstat = "add";

        #endregion

        #region متغيرات الادمنز

        #region مسح جميع تكسات الادمنز 

        public void TxtAdminClear()
        {
            TxtAdminName.Text = "";
            TxtAdminMobile.Text = "";
            TxtAdminJob.Text = "";
            TxtAdminNotes.Text = "";
            TxtUserID.Text = "";
            TxtUserPassWord.Text = "";
            ComboIsActiveID.SelectedIndex = -1;
        }

        #endregion

        #region تفعيل  جميع الازرار للادمنز

        public void BTN_Admins_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Admins.Enabled = true;

        }

        #endregion

        #region تعطيل  جميع الازرار للادمنز

        public void BTN_Admins_Disable()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Admins.Enabled = false;
        }

        #endregion

        #region عرض بيانات الادمنز في التكستات

        public void TxtAdminsDisplay()
        {
            TxtAdminName.Text = DGV_Admins.CurrentRow.Cells[1].Value.ToString();
            TxtAdminMobile.Text = DGV_Admins.CurrentRow.Cells[2].Value.ToString();
            TxtAdminJob.Text = DGV_Admins.CurrentRow.Cells[3].Value.ToString();
            TxtAdminNotes.Text = DGV_Admins.CurrentRow.Cells[4].Value.ToString();
            TxtUserID.Text = DGV_Admins.CurrentRow.Cells[5].Value.ToString();
            TxtUserPassWord.Text = DGV_Admins.CurrentRow.Cells[6].Value.ToString();
            ComboIsActiveID.Text = DGV_Admins.CurrentRow.Cells[7].Value.ToString();


        }

        #endregion

        #region تفعيل التكسات

        public void Txt_Admins_Disable()
        {
            TxtAdminName.ReadOnly= true;
            TxtAdminMobile.ReadOnly = true;
            TxtAdminJob.ReadOnly = true;
            TxtAdminNotes.ReadOnly = true;
            TxtUserID.ReadOnly = true;
            TxtUserPassWord.ReadOnly = true;
            ComboIsActiveID.Enabled = false;
        }

        #endregion

        #region تعطيل التكسات

        public void Txt_Admins_Enable()
        {
            TxtAdminName.ReadOnly = false;
            TxtAdminMobile.ReadOnly = false;
            TxtAdminJob.ReadOnly = false;
            TxtAdminNotes.ReadOnly = false;
            TxtUserID.ReadOnly = false;
            TxtUserPassWord.ReadOnly =false;
            ComboIsActiveID.Enabled = true;


        }

        #endregion

        #region الداتا جريد

        public void DGV_Display()
        {
            DGV_Admins.DataSource = admin.Admins_Select_All();
            this.DGV_Admins.Columns[0].Visible = false;
            this.DGV_Admins.Columns[6].Visible = false;
        }

        #endregion

        #endregion



        #endregion



        public FRM_ADMINS()
        {
            InitializeComponent();

            #region متغيرات عند التحميل

            #region الداتا جريد
            DGV_Display();
            #endregion

            #region كمبو حالة المستخدم
            this.ComboIsActiveID.DataSource = admin.ComboIsActiveID();
            ComboIsActiveID.ValueMember = "IsActiveID";
            ComboIsActiveID.DisplayMember = "IsActiveName";
            ComboIsActiveID.SelectedIndex = -1;
            #endregion

            #endregion
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Admins_Click(object sender, EventArgs e)
        {
        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
            #region زر الاضافة
            TxtAdminClear();
            BTN_Admins_Disable();
            Txt_Admins_Enable();
            Adminstat = "add";
            #endregion

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            #region زر الحفظ

            #region التحقق  من ملئ بوكس الكتابة
            if (TxtAdminName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAdminName.Focus();
                return;
            }
            if (TxtAdminMobile.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال جوال الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAdminMobile.Focus();
                return;
            }
            if (TxtAdminJob.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الوظيفة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAdminJob.Focus();
                return;
            }

            if (TxtAdminNotes.Text == string.Empty)
            {
                TxtAdminNotes.Text = "0";
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل



            if (Adminstat == "add")
            {
                admin.Admins_Add(TxtAdminName.Text,
                    TxtAdminMobile.Text,
                    TxtAdminJob.Text,
                    TxtAdminNotes.Text,
                    TxtUserID.Text,
                    TxtUserPassWord.Text,
                    Convert.ToInt32(ComboIsActiveID.SelectedValue)
                    );

                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                admin.Admins_Update(TxtAdminName.Text,
                    TxtAdminMobile.Text,
                    TxtAdminJob.Text,
                    TxtAdminNotes.Text,
                    TxtUserID.Text,
                    TxtUserPassWord.Text,
                    Convert.ToInt32(ComboIsActiveID.SelectedValue),
                    Convert.ToInt32(this.DGV_Admins.CurrentRow.Cells[0].Value)
                    );
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

            Txt_Admins_Disable();
            BTN_Admins_Enble();
            DGV_Display();
            BTN_Admins_Enble();

            #endregion

        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            #region زر التعديل

            #region التحقق من اختيار الموظف
            if (TxtAdminName.Text == String.Empty)
            {
                MessageBox.Show("يجب اختيار الموظف  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            Adminstat = "Edit";
            TxtAdminsDisplay();
            Txt_Admins_Enable();
            BTN_Admins_Disable();

            #endregion

        }

        private void BtnDel_Click_1(object sender, EventArgs e)
        {
            #region زر الحذف
            MessageBox.Show(" لايمكنك حذف الموظف يمكنك تعطيل عمليةالدخول فقط ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            #endregion

        }

        private void BtnUndo_Click_1(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                if (Adminstat == "add")
                {
                    TxtAdminClear();
                }
                else
                {
                    TxtAdminsDisplay();
                }
                DGV_Admins.DataSource = admin.Admins_Select_All();
                Txt_Admins_Disable();
                BTN_Admins_Enble();
            }


            else
            {
                return;
            }

            #endregion

        }

        private void DGV_Admins_Click_1(object sender, EventArgs e)
        {
            if (this.DGV_Admins.Rows.Count > 0)
            {
                TxtAdminsDisplay();
            }

        }
    }
}
