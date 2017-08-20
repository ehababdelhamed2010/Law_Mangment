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
    public partial class FRM_CUSTOMER : Form
    {
        BL.CLS_CUSTOMER customer = new BL.CLS_CUSTOMER();

        #region حالة الحفظ للجدولين

        public string Customerstat = "add";

        public string Tawkelstat = "add";

        #endregion

        #region مسح جميع التكستات 

        public void TxtAllClear()
        {
            TxtCustomerName.Text = "";
            TxtReligionName.Text = "";
            ComboNationalityID.Text = "";
            TxtCustomerMobile.Text = "";
            TxtCustomerPhone.Text = "";
            TxtCustomerAddress.Text = "";
            TxtCustomerEmail.Text = "";
            TxtCustomerNotes.Text = "";
            TxtClear();
        }

        #endregion

        #region تفعيل  جميع الازرار العلوية

        public void BTN_All_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Customers.Enabled = true;
        }

        #endregion

        #region  تعطيل جميع الازرار العلوية
        public void BTN_All_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_Customers.Enabled = false;
        }
        #endregion

        #region تفعيل التكتسات العلوية

        public void TxtAllEnable()
        {
            TxtCustomerName.ReadOnly=false;
            TxtReligionName.ReadOnly = false;
            ComboNationalityID.Enabled = true;
            TxtCustomerMobile.ReadOnly = false;
            TxtCustomerPhone.ReadOnly = false;
            TxtCustomerAddress.ReadOnly = false;
            TxtCustomerEmail.ReadOnly = false;
            TxtCustomerNotes.ReadOnly = false;
        }

        public void TxtAllDisable()
        {
            TxtCustomerName.ReadOnly = true; 
            TxtReligionName.ReadOnly = true;
            ComboNationalityID.Enabled = false;
            TxtCustomerMobile.ReadOnly = true;
            TxtCustomerPhone.ReadOnly = true;
            TxtCustomerAddress.ReadOnly = true;
            TxtCustomerEmail.ReadOnly = true;
            TxtCustomerNotes.ReadOnly = true;
        }

        #endregion

        #region عرض بيانات العميل في التكستات
        public void TxtAllDisplay()
        {
            TxtCustomerName.Text = DGV_Customers.CurrentRow.Cells[1].Value.ToString();
            TxtReligionName.Text = DGV_Customers.CurrentRow.Cells[2].Value.ToString();
            ComboNationalityID.SelectedValue = Convert.ToInt32(DGV_Customers.CurrentRow.Cells[9].Value);
            TxtCustomerMobile.Text = DGV_Customers.CurrentRow.Cells[4].Value.ToString();
            TxtCustomerPhone.Text = DGV_Customers.CurrentRow.Cells[5].Value.ToString();
            TxtCustomerAddress.Text = DGV_Customers.CurrentRow.Cells[6].Value.ToString();
            TxtCustomerEmail.Text = DGV_Customers.CurrentRow.Cells[7].Value.ToString();
            TxtCustomerNotes.Text = DGV_Customers.CurrentRow.Cells[8].Value.ToString();
            DGv_Display();
        }
        #endregion

        #region تعطيل الازرار السفلية في حالة العمل على العلوية
        public void BtnDisableS()
        {
            BtnNewS.Enabled = false;
            BtnSaveS.Enabled = false;
            BtnEditS.Enabled = false;
            BtnDelS.Enabled = false;
            BtnUndoS.Enabled = false;
        }
        #endregion

        #region تعطيل الازار العلوية في حالة العمل في السفلي

        public void BtnDisableUp()
        {
            BtnNew.Enabled = false;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnUndo.Enabled = false;
            this.DGV_Customers.Enabled = false;
        }

        #endregion


        //عمليات التوكيل السفلية 

        #region مسح تكسات التوكيل

        public void TxtClear()
        {
            TxtTawkelNo.Text = "";
            ComboTawkelTypeID.SelectedValue = -1;
            TxtTawkelNotes.Text = "";
        }

        #endregion

        #region تفعيل الازار الخاصة بالتوكيل

        public void BTNEnble()
        {
            BtnNewS.Enabled = true;
            BtnEditS.Enabled = true;
            BtnDelS.Enabled = true;
            BtnSaveS.Enabled = false;
            BtnUndoS.Enabled = false;
            DGV_Tawkel.Enabled = true;
            DGV_Customers.Enabled = true;
        }

        #endregion

        #region تعطيل الازرار الخاصة بالتوكيل

        public void BTNDisble()
        {
            BtnNewS.Enabled = false;
            BtnEditS.Enabled = false;
            BtnDelS.Enabled = false;
            BtnSaveS.Enabled = true;
            BtnUndoS.Enabled = true;
            DGV_Customers.Enabled = false;
            DGV_Tawkel.Enabled = false;
        }

        #endregion

        #region تعطيل التكستات الخاصة بالتوكيل

        public void TxtDisable()
        {
            TxtTawkelNo.ReadOnly =true;
            ComboTawkelTypeID.Enabled=false;
            TxtTawkelNotes.ReadOnly = true;
            DGV_Customers.Enabled =true;
            DGV_Tawkel.Enabled =true;
        }


        #endregion

        #region تفعيل التكستات الخاصة بالتوكيل

        public void TxtEnable()
        {
            TxtTawkelNo.ReadOnly =false;
            ComboTawkelTypeID.Enabled = true;
            TxtTawkelNotes.ReadOnly = false;
            DGV_Customers.Enabled =false;
            DGV_Tawkel.Enabled = false;
        }

        #endregion


         #region ملئ داتا جريد الوكالات
            public void DGv_Display()
            {
            DGV_Tawkel.DataSource = customer.Tawkel_Select_All(Convert.ToInt32(this.DGV_Customers.CurrentRow.Cells[0].Value));
            this.DGV_Tawkel.Columns[0].Visible = false;
            this.DGV_Tawkel.Columns[2].Visible = false;
            this.DGV_Tawkel.Columns[4].Visible = false;
            }

        #endregion

        #region عرض بيانات التوكيل في التكستات

        public void TxtDisplayS()
        {
            TxtTawkelNo.Text = this.DGV_Tawkel.CurrentRow.Cells[1].Value.ToString();
            ComboTawkelTypeID.SelectedValue= Convert.ToUInt32(this.DGV_Tawkel.CurrentRow.Cells[2].Value);
            TxtTawkelNotes.Text= this.DGV_Tawkel.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion


        public FRM_CUSTOMER()
        {
           
            InitializeComponent();
            

            #region ملئ كمبو الجنسيات

            ComboNationalityID.DataSource = customer.ComboNationalityID();
            ComboNationalityID.ValueMember = "NationalityID";
            ComboNationalityID.DisplayMember = "NationalityName";
            ComboNationalityID.SelectedValue = -1;

            #endregion

            #region ملئ كمبو انواع التوكيل
            ComboTawkelTypeID.DataSource = customer.ComboTawkelTypeID();
            ComboTawkelTypeID.ValueMember = "TawkelTypeID";
            ComboTawkelTypeID.DisplayMember = "TawkelTypeName";
            ComboTawkelTypeID.SelectedValue = -1;
            #endregion

            #region ملئ داتا جريد العملاء
            DGV_Customers.DataSource = customer.Cusomer_Select_All();
            this.DGV_Customers.Columns[0].Visible = false;
            this.DGV_Customers.Columns[9].Visible = false;
            #endregion

            


        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtAllClear();
            BTN_All_Disble();
            TxtAllEnable();
            Customerstat = "add";
            
            DGV_Tawkel.DataSource = null;

            BtnDisableS();
            

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            #region التحقق  من ملئ بوكس الكتابة
            if (TxtCustomerName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCustomerName.Focus();
                return;
            }
            if (ComboNationalityID.SelectedIndex == -1)
            {
                MessageBox.Show("يجب ادخال الجنسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboNationalityID.Focus();
                return;
            }


            if (TxtCustomerMobile.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال الجوال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCustomerMobile.Focus();
                return;
            }



            #endregion

            #region عملية الحفظ او التعديل
            if (Customerstat == "add")
            {
                customer.Customers_Add(TxtCustomerName.Text,TxtReligionName.Text,Convert.ToInt32(ComboNationalityID.SelectedValue),
                    TxtCustomerAddress.Text,TxtCustomerMobile.Text,TxtCustomerPhone.Text,TxtCustomerEmail.Text,TxtCustomerNotes.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                customer.Customers_Update(TxtCustomerName.Text, TxtReligionName.Text, Convert.ToInt32(ComboNationalityID.SelectedValue),
                    TxtCustomerAddress.Text, TxtCustomerMobile.Text, TxtCustomerPhone.Text, TxtCustomerEmail.Text, TxtCustomerNotes.Text, Program.AdminID, Convert.ToInt32(DGV_Customers.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

            TxtAllDisable();
            TxtAllClear();
            BTN_All_Enble();
            DGV_Customers.DataSource = customer.Cusomer_Select_All();
            BTNEnble();

        }

        private void DGV_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DGV_Customers.Rows.Count>0)
            {
               TxtAllDisplay();
            }
            return;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            #region التحقق من اختيار العميل
            if (TxtCustomerName.Text==String.Empty)
            {
                MessageBox.Show("يجب اختيار العميل  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            Customerstat = "Edit";
            TxtAllDisplay();
            TxtAllEnable();
            BTN_All_Disble();
            BtnDisableS();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TxtAllClear();
            TxtAllDisable();
            BTN_All_Enble();
            DGV_Customers.DataSource = customer.Cusomer_Select_All();
            BTNEnble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            #region التحقق من اختيار العميل
            if (TxtCustomerName.Text == String.Empty)
            {
                MessageBox.Show("يجب اختيار العميل  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region التحقق من عدم وجود وكالات للعميل

            if (DGV_Tawkel.Rows.Count>0)
            {
                MessageBox.Show("لايمكن حذف عميل توجد له وكالات  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                TxtAllDisplay();
                customer.Customers_Delete(Convert.ToInt32(this.DGV_Customers.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_Tawkel.DataSource = null;
                #endregion
            }
            else
            {
                return;
            }

            DGV_Customers.DataSource = customer.Cusomer_Select_All();
            TxtAllClear();

            #endregion
        }

        private void BtnNewS_Click(object sender, EventArgs e)
        {
            if (TxtCustomerName.Text==string.Empty)
            {
                MessageBox.Show("يجب اختيار العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TxtClear();
            BTNDisble();
            TxtEnable();
            Tawkelstat = "add";
            BtnDisableUp();
        }

        private void BtnSaveS_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtTawkelNo.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال رقم الوكالة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTawkelNo.Focus();
                return;
            }
            if (ComboTawkelTypeID.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اختيار نوع الوكالة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboTawkelTypeID.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (Tawkelstat == "add")
            {
                customer.Tawkel_Add(TxtTawkelNo.Text, Convert.ToInt32(ComboTawkelTypeID.SelectedValue), 
                    Convert.ToInt32(DGV_Customers.CurrentRow.Cells[0].Value),
                    TxtTawkelNotes.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                customer.Tawkel_Update(TxtTawkelNo.Text, Convert.ToInt32(ComboTawkelTypeID.SelectedValue),
                     TxtTawkelNotes.Text, Program.AdminID, Convert.ToInt32(this.DGV_Tawkel.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

            TxtDisable();
            TxtClear();
            BTNEnble();
            DGv_Display();
            BTN_All_Enble();
        }

        private void DGV_Tawkel_Click(object sender, EventArgs e)
        {
            if (this.DGV_Tawkel.Rows.Count>0)
            {
            TxtDisplayS();
            }
            return;
        }

        private void BtnEditS_Click(object sender, EventArgs e)
        {
            #region التحقق من الاختيار قبل التعديل
            if (TxtTawkelNo.Text==string.Empty)
            {
                MessageBox.Show("يجب اختيار العميل و الوكالة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            BTNDisble();
            TxtEnable();
            Tawkelstat = "Edit";
            BtnDisableUp();
            BtnDisableUp();
            
            
        }

        private void BtnUndoS_Click(object sender, EventArgs e)
        {
            TxtClear();
            TxtDisable();
            BTNEnble();
            DGv_Display();
            BTNEnble();
            BTN_All_Enble();
        }

        private void BtnDelS_Click(object sender, EventArgs e)


        {

            if (TxtTawkelNo.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار العميل و  الوكالة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                
                customer.Tawkel_Delete(Convert.ToInt32(this.DGV_Tawkel.CurrentRow.Cells[0].Value), Program.AdminID);
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGv_Display();
                #endregion
            }
            else
            {
                return;
            }

            DGV_Customers.DataSource = customer.Cusomer_Select_All();
            TxtAllClear();

            #endregion
        }
    }
}
