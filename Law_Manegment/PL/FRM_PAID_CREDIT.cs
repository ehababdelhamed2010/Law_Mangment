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
    public partial class FRM_PAID_CREDIT : Form
    {
        #region  متغيرات عامة على الفورم

        #region نسخة الكلاس وحالة الحفظ

        BL.CLS_PAID_CREDIT credit = new BL.CLS_PAID_CREDIT();

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
            DGV_Credit.Enabled = true;
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
            DGV_Credit.Enabled = false;
        }

        #endregion

        #region تفعيل التكستات

        public void TxtEnable()
        {
            PaidDate.Enabled = true;
            comboExpID.Enabled = true;
            TxtCreditAmount.ReadOnly = false;
            TxtAmountNotes.ReadOnly = false;
        }

        #endregion

        #region تعطيل التكستات

        public void TxtDisable()
        {
            PaidDate.Enabled = false;
            comboExpID.Enabled = false;
            TxtCreditAmount.ReadOnly = true;
            TxtAmountNotes.ReadOnly = true;
        }

        #endregion

        #region مسح كل التكستات

        public void TxtClear()
        {
            PaidDate.Text="";
            comboExpID.SelectedIndex=-1;
            TxtCreditAmount.Text="";
            TxtAmountNotes.Text="";
        }

        #endregion

        #region الداتا جريد

        public void DGV_Display()
        {
            this.DGV_Credit.DataSource = credit.PaidAmount_Credit_Select_All(TxtSearch.Text);
            this.DGV_Credit.Columns[0].Visible = false;
            this.DGV_Credit.Columns[1].Visible = false;
            this.DGV_Credit.Columns[2].Width = 100;
            this.DGV_Credit.Columns[3].Width = 100;
            this.DGV_Credit.Columns[4].Width = 100;
            this.DGV_Credit.Columns[5].Width = 200;
        }

        #endregion

        #region  عرض البيانات على التكستات
        public void TxtDisplay()
        {
            if (this.DGV_Credit.Rows.Count>0)
            {
                PaidDate.Text = this.DGV_Credit.CurrentRow.Cells[2].Value.ToString();
                comboExpID.Text = this.DGV_Credit.CurrentRow.Cells[3].Value.ToString();
                TxtCreditAmount.Text = this.DGV_Credit.CurrentRow.Cells[4].Value.ToString();
                TxtAmountNotes.Text = this.DGV_Credit.CurrentRow.Cells[5].Value.ToString();

            }

        }

        #endregion


        #endregion

        public FRM_PAID_CREDIT()
        {
            InitializeComponent();


            #region عند التحميل

            #region  الداتا جريد
            DGV_Display();
            #endregion

            #region كمبو المصروفات
            comboExpID.DataSource = credit.comboExpID();
            comboExpID.ValueMember = "ExpID";
            comboExpID.DisplayMember = "ExpName";
            comboExpID.SelectedIndex = -1;
            #endregion



            #endregion
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtClear();
            stat = "add";
            BTN_Disble();
            TxtEnable();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            #region التحقق من اختيار العميل
            if (TxtCreditAmount.Text == String.Empty)
            {
                MessageBox.Show("يجب اختيار المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtDisplay();
                credit.PaidAmount_Credit_Delete(Convert.ToInt32(this.DGV_Credit.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }

            DGV_Display();
            TxtClear();

            #endregion

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtCreditAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال مبلغ المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCreditAmount.Focus();
                return;
            }
            if (comboExpID.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboExpID.Focus();
                return;
            }


            if (TxtAmountNotes.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال بيان للمصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAmountNotes.Focus();
                return;
            }



            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                credit.PaidAmount_Credit_Add
                    (
                    Convert.ToInt32(comboExpID.SelectedValue),
                    PaidDate.Value,
                    TxtCreditAmount.Text,
                    TxtAmountNotes.Text,
                    Program.AdminID
                    );
                    MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    credit.PaidAmount_Credit_Update
                   (
                   Convert.ToInt32(comboExpID.SelectedValue),
                   PaidDate.Value,
                   TxtCreditAmount.Text,
                   TxtAmountNotes.Text,
                   Program.AdminID,
                   Convert.ToInt32(this.DGV_Credit.CurrentRow.Cells[0].Value.ToString())
                   );

                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

            #region مابعد الحفظ
            TxtDisable();
            BTN_Enble();
            DGV_Display();
            BTN_Enble();
            #endregion

        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                if (stat == "add")
                {
                    TxtClear();
                }
                else
                {
                    TxtDisplay();
                }
                DGV_Display();
                TxtDisable();
                BTN_Enble();
            }


            else
            {
                return;
            }

            #endregion

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            #region التحقق قبل التعديل
            if (TxtCreditAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار المصروف اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            stat = "edit";
            TxtEnable();
            BTN_Disble();

        }

        private void DGV_Credit_Click(object sender, EventArgs e)
        {
            TxtDisplay();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_Display();
        }
    }
}
