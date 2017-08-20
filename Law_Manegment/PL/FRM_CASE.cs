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
using System.Globalization;


namespace Law_Manegment.PL
{
    public partial class FRM_CASE : Form


    {

        #region تعريفات عامة على الفورم
        public static string CustomerID;

        #region استنساخ الكلاس الخاص بالقضايا
        BL.CLS_CASE Case = new BL.CLS_CASE();
        public string stat = "add";
        public string statImage = "add";
        public string statAmount = "add";
        public string statJalsa = "add";

        #endregion

        #region تفعيل الازرار

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_Case.Enabled = true;
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
            DGV_Case.Enabled = false;
        }

        #endregion

        #region الصورة تفعيل الازرار

        public void BTN_Enble_Image()
        {
            BtnNewImage.Enabled = true;
            BtnEditeImage.Enabled = true;
            BtnDelImage.Enabled = true;
            BtnSaveImage.Enabled = false;
            BtnUndoImage.Enabled = false;
            BtnAddImage.Enabled = false;
            DGV_IMAGES.Enabled = true;
        }

        #endregion

        #region الصورة تعطيل الازرار

        public void BTN_Disble_Image()
        {
            BtnNewImage.Enabled = false;
            BtnEditeImage.Enabled = false;
            BtnDelImage.Enabled = false;
            BtnSaveImage.Enabled = true;
            BtnUndoImage.Enabled = true;
            BtnAddImage.Enabled = true;
            DGV_IMAGES.Enabled = false;
        }

        #endregion

        #region  تفعيل الازرار المبالغ

        public void BTN_Enble_Amount()
        {
            BtnNewAmount.Enabled = true;
            BtnEditAmount.Enabled = true;
            BtnDelAmount.Enabled = true;
            BtnSaveAmount.Enabled = false;
            BtnUndoAmount.Enabled = false;
            DGV_CaseAmount.Enabled = true;
        }

        #endregion

        #region تعطيل الازرار المبالغ

        public void BTN_Disble_Amount()
        {
            BtnNewAmount.Enabled = false;
            BtnEditAmount.Enabled = false;
            BtnDelAmount.Enabled = false;
            BtnSaveAmount.Enabled = true;
            BtnUndoAmount.Enabled = true;
            DGV_CaseAmount.Enabled = false;
        }

        #endregion

        #region  تفعيل الازرار الجلسات

        public void BTN_Enble_Jalsa()
        {
            BtnJalsaNew.Enabled = true;
            BtnJalsaEdit.Enabled = true;
            BtnJalsaDel.Enabled = true;
            BtnJalsaSave.Enabled = false;
            BtnJalsaUndo.Enabled = false;
            DGV_Jalsat.Enabled = true;
        }

        #endregion

        #region تعطيل الازرار الجلسات

        public void BTN_Disble_Jalsa()
        {
            BtnJalsaNew.Enabled = false;
            BtnJalsaEdit.Enabled = false;
            BtnJalsaDel.Enabled = false;
            BtnJalsaSave.Enabled = true;
            BtnJalsaUndo.Enabled = true;
            DGV_Jalsat.Enabled = false;
        }

        #endregion

        #region تعطيل التكسات المبالغ
        public void TxtDisableAmount()
        {
            TxtDebitAmount.ReadOnly = true;
            TxtAmountNotes.ReadOnly = true;
            PaidDate.Enabled = false;
        }
        #endregion

        #region تفعيل التكسات المبالغ
        public void TxtEnableAmount()
        {
            TxtDebitAmount.ReadOnly = false;
            TxtAmountNotes.ReadOnly = false;
            PaidDate.Enabled = true;
        }
        #endregion

        #region مسح التكسات المبالغ
        public void TxtClearAmount()
        {
            TxtDebitAmount.Text="";
            TxtAmountNotes.Text="";
            PaidDate.Text="";
        }
        #endregion

        #region تعطيل التكسات الجلسات
        public void TxtDisableJalsa()
        {
            JalsaDate.Enabled = false;
            ComboAdminID.Enabled = false;
            TxtJalsaRequer.ReadOnly = true;
            TxtJalsaResult.ReadOnly = true;
        }
        #endregion

        #region تفعيل التكسات الجلسات
        public void TxtEnableJalsa()
        {
            JalsaDate.Enabled = true;
            ComboAdminID.Enabled = true;
            TxtJalsaRequer.ReadOnly = false;
            TxtJalsaResult.ReadOnly = false;
        }
        #endregion

        #region مسح التكسات الجلسات
        public void TxtClearJalsa()
        {
            TxtJalsaID.Text = "";
            JalsaDate.Text = "";
            ComboAdminID.SelectedIndex=-1;
            ComboAdminID.Text = "";
            TxtJalsaRequer.Text = "";
            TxtJalsaResult.Text = "";
        }
        #endregion


        #region جمع مبالغ والناتج للقضية
        public void SumAmount()
        {
            TxtDebitAmountTOtal.Text = TxtCaseAmount.Text;

            if (DGV_CaseAmount.Rows.Count < 1)
            {
                TxtCreditAmountTOtal.Text = "0";
            }

            int sum = 0;
            for (int i = 0; i < DGV_CaseAmount.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGV_CaseAmount.Rows[i].Cells[2].Value);
            }

            
            #region تحويل الرقم الى عملة 
            TxtCreditAmountTOtal.Text = sum.ToString();
            #endregion
            int debit = Convert.ToInt32(this.DGV_Case.CurrentRow.Cells[12].Value.ToString());
            int balance = debit - sum;
            TxtBalanceAmountTOtal.Text = balance.ToString();

        }


        #endregion

        #region تعطيل التكسات الصورة
        public void TxtDisableImage()
        {
            TxtImageName.ReadOnly = true;
            PBCaseImage.Enabled = false;
        }
        #endregion

        #region تفعيل التكسات الصورة
        public void TxtEnableImage()
        {
            TxtImageName.ReadOnly = false;
            PBCaseImage.Enabled = true;
        }
        #endregion

        #region مسح التكسات الصورة
        public void TxtClearImage()
        {
            TxtImageName.Text="";
            PBCaseImage.Image = null;
        }
        #endregion


        #region تفعيل التكستات

        public void TxtEnable()
        {
            //العميل
            BtnCustomerSearch.Enabled = true;
            BtnTawkelSearch.Enabled = true;
            ComboSefaID.Enabled = true;
            //الخصم
            TxtDefinseName.ReadOnly = false;
            TxtDefinseAddress.ReadOnly = false;
            TxtDefinseSefa.ReadOnly = false;
            // القضية
            TxtCaseAmount.ReadOnly = false;
            TxtCaseName.ReadOnly = false;
            DateCase.Enabled = true;
            BtnCourtSearch.Enabled = true;
            ComboTakadiDegreID.Enabled = true;
            DateReciveCase.Enabled = true;
            TxtCaseTopic.ReadOnly = false;
            TxtCaseNotes.ReadOnly = false;
            //البحث
            TxtSearch.ReadOnly = true;


        }

        #endregion

        #region تعطيل التكستات

        public void TxtDisable()
        {
            // الازرار
            BtnCourtSearch.Enabled = false;
            BtnCustomerSearch.Enabled = false;
            BtnTawkelSearch.Enabled = false;
            //العميل
            BtnCustomerSearch.Enabled = false;
            BtnTawkelSearch.Enabled = false;
            ComboSefaID.Enabled = false;
            //الخصم
            TxtDefinseName.ReadOnly = true;
            TxtDefinseAddress.ReadOnly = true;
            TxtDefinseSefa.ReadOnly = true;
            // القضية
            TxtCaseAmount.ReadOnly = true;
            TxtCaseName.ReadOnly = true;
            DateCase.Enabled = false;
            BtnCourtSearch.Enabled = false;
            ComboTakadiDegreID.Enabled = false;
            DateReciveCase.Enabled = false;
            TxtCaseTopic.ReadOnly = true;
            TxtCaseNotes.ReadOnly = true;
            //البحث
            TxtSearch.ReadOnly = false;


        }

        #endregion

        #region مسح  التكستات

        public void TxtClear()
        {
            // الازرار
            BtnCourtSearch.Enabled = true;
            BtnCustomerSearch.Enabled = true;
            BtnTawkelSearch.Enabled = true;

            //العميل
            TxtCaseID.Text = "";
            TxtCustomerID.Text = "";
            TxtCustomerMobile.Text = "";
            TxtCustomerName.Text = "";
            TxtTawkelID.Text = "";
            TxtTawkelNO.Text = "";
            TxtTawkelType.Text = "";
            ComboSefaID.SelectedIndex = -1;
            //الخصم
            TxtDefinseName.Text = "";
            TxtDefinseAddress.Text = "";
            TxtDefinseSefa.Text = "";
            // القضية
            TxtCourtID.Text = "";
            TxtCourtName.Text = "";
            TxtCaseName.Text = "";
            DateCase.Text = "";
            ComboTakadiDegreID.SelectedIndex = -1;
            DateReciveCase.Text = "";
            TxtCaseTopic.Text = "";
            TxtCaseNotes.Text = "";
            //البحث
            TxtSearch.Text = "";


        }

        #endregion

        #region جميع القضايا

        public void DGV_Display()
        {
            DGV_Case.DataSource = Case.Case_Select_All(TxtSearch.Text);
            DGV_Case.Columns[0].Visible = false;
            DGV_Case.Columns[1].Visible = false;
            DGV_Case.Columns[4].Visible = false;
            DGV_Case.Columns[6].Visible = false;
            DGV_Case.Columns[8].Visible = false;
            DGV_Case.Columns[11].Visible = false;
            DGV_Case.Columns[21].Visible = false;

            DGV_Case.Columns[2].Width = 100;
            DGV_Case.Columns[3].Width = 100;
            DGV_Case.Columns[5].Width = 200;
            DGV_Case.Columns[7].Width = 50;
            DGV_Case.Columns[9].Width = 100;
            DGV_Case.Columns[10].Width = 100;
            DGV_Case.Columns[12].Width = 100;

            DGV_Case.Columns[13].Width = 100;
            DGV_Case.Columns[14].Width = 100;
            DGV_Case.Columns[15].Width = 200;
            DGV_Case.Columns[16].Width = 200;
            DGV_Case.Columns[17].Width = 50;
            DGV_Case.Columns[18].Width = 100;
            DGV_Case.Columns[19].Width = 500;
            DGV_Case.Columns[20].Width = 500;



        }

        #endregion

        #region جميع الصور

        public void DGVImage_Display()
        {
            DGV_IMAGES.DataSource = Case.CaseImage_Select_All(TxtSearchImage.Text,Convert.ToInt32(TxtCaseID.Text));
            DGV_IMAGES.Columns[0].Visible = false;
            DGV_IMAGES.Columns[1].Visible = false;
            DGV_IMAGES.Columns[3].Visible = false;
        }

        #endregion

        #region جميع المبالغ

        public void DGVAmount_Display()
        {
           DGV_CaseAmount.DataSource=Case.PaidAmount_Debit_Select_All(Convert.ToInt32(TxtCaseID.Text));

            DGV_CaseAmount.Columns[0].Visible = false;

            DGV_CaseAmount.Columns[1].Width = 80;
            DGV_CaseAmount.Columns[2].Width = 80;
            DGV_CaseAmount.Columns[3].Width = 300;

        }

        #endregion

        #region جميع الجلسات

        public void DGVJalsat_Display()
        {
            DGV_Jalsat.DataSource = Case.Jalsat_Select_All(Convert.ToInt32(TxtCaseID.Text));

            DGV_Jalsat.Columns[0].Visible = false;
            DGV_Jalsat.Columns[2].Visible = false;
            DGV_Jalsat.Columns[1].Width = 80;
            DGV_Jalsat.Columns[3].Width = 80;
            DGV_Jalsat.Columns[4].Width = 300;
            DGV_Jalsat.Columns[5].Width = 300;


        }

        #endregion


        #region عرض البيانات على التكستات
        public void TxtDisplay()
        {
            TxtCaseID.Text = this.DGV_Case.CurrentRow.Cells[0].Value.ToString();
            TxtCourtID.Text = this.DGV_Case.CurrentRow.Cells[1].Value.ToString();
            TxtCourtName.Text = this.DGV_Case.CurrentRow.Cells[2].Value.ToString();
            TxtCaseName.Text = this.DGV_Case.CurrentRow.Cells[3].Value.ToString();
            TxtCustomerID.Text = this.DGV_Case.CurrentRow.Cells[4].Value.ToString();
            TxtCustomerName.Text = this.DGV_Case.CurrentRow.Cells[5].Value.ToString();
            TxtSefaID.Text = this.DGV_Case.CurrentRow.Cells[6].Value.ToString();
            ComboSefaID.Text = this.DGV_Case.CurrentRow.Cells[7].Value.ToString();
            TxtTawkelID.Text = this.DGV_Case.CurrentRow.Cells[8].Value.ToString();
            TxtTawkelNO.Text = this.DGV_Case.CurrentRow.Cells[9].Value.ToString();
            TxtTawkelType.Text = this.DGV_Case.CurrentRow.Cells[10].Value.ToString();
            TxtTakadiDegreID.Text = this.DGV_Case.CurrentRow.Cells[11].Value.ToString();
            TxtCaseAmount.Text = this.DGV_Case.CurrentRow.Cells[12].Value.ToString();
            TxtCaseAmount.Text= this.DGV_Case.CurrentRow.Cells[12].Value.ToString();
            ComboTakadiDegreID.Text = this.DGV_Case.CurrentRow.Cells[13].Value.ToString();
            DateCase.Text = this.DGV_Case.CurrentRow.Cells[14].Value.ToString();
            TxtDefinseName.Text = this.DGV_Case.CurrentRow.Cells[15].Value.ToString();
            TxtDefinseAddress.Text = this.DGV_Case.CurrentRow.Cells[16].Value.ToString();
            TxtDefinseSefa.Text = this.DGV_Case.CurrentRow.Cells[17].Value.ToString();
            DateReciveCase.Text = this.DGV_Case.CurrentRow.Cells[18].Value.ToString();
            TxtCaseTopic.Text = this.DGV_Case.CurrentRow.Cells[19].Value.ToString();
            TxtCaseNotes.Text = this.DGV_Case.CurrentRow.Cells[20].Value.ToString();
            TxtCustomerMobile.Text = this.DGV_Case.CurrentRow.Cells[22].Value.ToString();


        }

        #endregion

        #region عرض الصور من الداتا جريد
        public void Image_DisPlay()
        {
            byte[] imagee = (byte[])
             this.DGV_IMAGES.CurrentRow.Cells[3].Value;
            MemoryStream ms = new MemoryStream(imagee);
            PBCaseImage.Image = Image.FromStream(ms);
            TxtImageName.Text = this.DGV_IMAGES.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion

        #region عرض المبلغ من الداتا جريد
        public void Amount_DisPlay()
        {
            TxtDebitAmount.Text = this.DGV_CaseAmount.CurrentRow.Cells[2].Value.ToString();
            PaidDate.Text = this.DGV_CaseAmount.CurrentRow.Cells[1].Value.ToString();
            TxtAmountNotes.Text = this.DGV_CaseAmount.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion

        #region عرض الجلسة من الداتا جريد
        public void Jalsa_DisPlay()
        {
            TxtJalsaID.Text = this.DGV_Jalsat.CurrentRow.Cells[0].Value.ToString();
            JalsaDate.Text = this.DGV_Jalsat.CurrentRow.Cells[3].Value.ToString();
            ComboAdminID.Text = this.DGV_Jalsat.CurrentRow.Cells[6].Value.ToString();
            TxtJalsaRequer.Text = this.DGV_Jalsat.CurrentRow.Cells[4].Value.ToString();
            TxtJalsaResult.Text = this.DGV_Jalsat.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion


        #endregion


        public FRM_CASE()
        {
            InitializeComponent();

            #region متغيرات عند بدء التحميل

            #region كمبو صفات العملاء

            ComboSefaID.DataSource = Case.ComboSefaID();
            ComboSefaID.ValueMember = "SefaID";
            ComboSefaID.DisplayMember = "SefaName";
            ComboSefaID.SelectedIndex = -1;
            #endregion

            #region كمبو درجات التقاضي

            ComboTakadiDegreID.DataSource = Case.ComboTakadiDegreID();
            ComboTakadiDegreID.ValueMember = "TakadiDegreID";
            ComboTakadiDegreID.DisplayMember = "TakadiDegreName";
            ComboTakadiDegreID.SelectedIndex = -1;
            #endregion

            #region كمبو صفات العملاء
            ComboAdminID.DataSource = Case.ComboAdminID();
            ComboAdminID.ValueMember = "AdminID";
            ComboAdminID.DisplayMember = "AdminName";
            ComboAdminID.SelectedIndex = -1;
            #endregion

            #region كل القضايا والبحث
            DGV_Display();
            #endregion

            #endregion
        }

        private void FRM_CASE_Load(object sender, EventArgs e)
        {


        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            stat = "add";
            TxtEnable();
            TxtClear();
            BTN_Disble();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق من التكستات

            if (TxtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار اسم العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnCustomerSearch.Focus();
                return;
            }
            if (TxtSefaID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار صفة العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboSefaID.Focus();
                return;
            }
            if (TxtTawkelID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار الوكالة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnTawkelSearch.Focus();
                return;
            }
            if (TxtDefinseName.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار اسم الخصم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDefinseName.Focus();
                return;
            }

            if (TxtCaseName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال رقم القضية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCaseName.Focus();
                return;
            }

            if (TxtCourtID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار المحكمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnCourtSearch.Focus();
                return;
            }
            if (TxtTakadiDegreID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار درجة التقاضي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboTakadiDegreID.Focus();
                return;
            }

            if (TxtCaseTopic.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال موضوع القضية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCaseTopic.Focus();
                return;
            }

            if (TxtCaseAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اتعاب القضية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCaseAmount.Focus();
                return;
            }


            #endregion

            #region عملية الحفظ والتعديل

            if (stat == "add")
            {
                Case.Case_Add(
                    int.Parse(TxtCourtID.Text),
                    TxtCaseName.Text,
                    int.Parse(TxtCustomerID.Text),
                    int.Parse(TxtSefaID.Text),
                    int.Parse(TxtTawkelID.Text),
                    int.Parse(TxtTakadiDegreID.Text),
                    DateTime.Parse(DateCase.Text),
                    TxtDefinseName.Text,
                    TxtDefinseAddress.Text,
                    TxtDefinseSefa.Text,
                    DateTime.Parse(DateReciveCase.Text),
                    TxtCaseTopic.Text,
                    TxtCaseNotes.Text,
                    Program.AdminID,
                    TxtCaseAmount.Text
               
                    );
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Case.Case_Update(
                    int.Parse(TxtCourtID.Text),
                    TxtCaseName.Text,
                    int.Parse(TxtCustomerID.Text),
                    int.Parse(TxtSefaID.Text),
                    int.Parse(TxtTawkelID.Text),
                    int.Parse(TxtTakadiDegreID.Text),
                    DateTime.Parse(DateCase.Text),
                    TxtDefinseName.Text,
                    TxtDefinseAddress.Text,
                    TxtDefinseSefa.Text,
                    DateTime.Parse(DateReciveCase.Text),
                    TxtCaseTopic.Text,
                    TxtCaseNotes.Text,
                    Program.AdminID,
                    Convert.ToInt32(this.DGV_Case.CurrentRow.Cells[0].Value),
                    TxtCaseAmount.Text
                    );
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            #endregion

            #region عملية التحديث بعد الحفظ والتعديل


            DGV_Display();
            TxtDisable();
            BTN_Enble();

            #endregion


        }

        private void ComboCustomerID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboCustomerID_ValueMemberChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            #region فتح فورم البحث للعملاء
            PL.FRM_SELECT_CUSTOMER frm = new FRM_SELECT_CUSTOMER();
            frm.ShowDialog();

            TxtCustomerID.Text = Program.TxtCustomerID;
            TxtCustomerName.Text = Program.TxtCustomerName;
            TxtCustomerMobile.Text = Program.TxtCustomerMobile;
            #endregion
        }

        private void TxtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDefinseSefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTawkelSearch_Click(object sender, EventArgs e)
        {
            #region فتح فورم التوكيلات بعد التأكد من اختيار العميل
            if (TxtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار العميل اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PL.FRM_SELECT_TAWKEL frm = new FRM_SELECT_TAWKEL();
            frm.ShowDialog();
            TxtTawkelID.Text = Program.TawkelID;
            TxtTawkelNO.Text = Program.TawkelNO;
            TxtTawkelType.Text = Program.TawkelType;
            #endregion

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCourtSearch_Click(object sender, EventArgs e)
        {
            #region فتح فورم المحاكم
            PL.FRM_SELECT_COURT frm = new FRM_SELECT_COURT();
            frm.ShowDialog();
            TxtCourtID.Text = Program.CourtID;
            TxtCourtName.Text = Program.CourtName;
            #endregion
        }


        private void ComboTakadiDegreID_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtTakadiDegreID.Text = Convert.ToString(ComboTakadiDegreID.SelectedValue);
        }

        private void ComboSefaID_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtSefaID.Text = Convert.ToString(ComboSefaID.SelectedValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DateCase.Value.ToString("dd/MM/yyyy"), "");
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_Display();
        }

        private void DGV_Case_Click(object sender, EventArgs e)
        {
            #region احداث عند الضغط كليك على الداتا جريد الاساسية
            if (this.DGV_Case.Rows.Count > 0)
            {
                TxtDisplay();
                #region كل الصور والبحث
                DGVImage_Display();
                #endregion
                TxtClearImage();
                #region كل المبالغ
                DGVAmount_Display();
                SumAmount();
                #endregion
                TxtClearAmount();

                #region كل الجلسات
                DGVJalsat_Display();
                #endregion
                TxtClearJalsa();


            }


            return;
            #endregion
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            #region التحقق قبل التعديل
            if (TxtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار القضية اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            stat = "edit";
            TxtEnable();
            BTN_Disble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            #region التحقق قبل الحذف
            if (TxtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار القضية اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                Case.Case_Delete(Convert.ToInt32(this.DGV_Case.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }
            TxtClear();
            DGV_Display();


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

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region الغاء الانتقال الى شاشة صور المستندات في حالة عدم اختيار قضية
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"] && TxtCaseID.Text==string.Empty)
            {
                MessageBox.Show("يجب اختيار القضية اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            }
            #endregion

            #region الغاء الانتقال الى شاشة المستحقات في حالة عدم اختيار قضية
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"] && TxtCaseID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار القضية اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            }
            #endregion

            #region الغاء الانتقال الى شاشة الجلسات في حالة عدم اختيار قضية
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"] && TxtCaseID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار القضية اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            }
            #endregion


        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            #region فتح مربع الملف لاختيار صورة
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PBCaseImage.Image = Image.FromFile(ofd.FileName);
            }
            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region التحقق من التكستات

            if (TxtImageName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم للصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtImageName.Focus();
                return;
            }

            if (PBCaseImage.Image == null)
            {
                MessageBox.Show("يجب اختيار الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnAddImage.Focus();
                return;
            }



            #endregion

            #region تحويل الصورة الى الثنائي
            MemoryStream MS = new MemoryStream();
            PBCaseImage.Image.Save(MS, PBCaseImage.Image.RawFormat);
            byte[] byteimage = MS.ToArray();
            #endregion

            #region عملية الحفظ والتعديل

            if (statImage == "add")
            {
                Case.CaseImage_Add(
                    Convert.ToInt32(TxtCaseID.Text),
                    TxtImageName.Text,
                    byteimage,
                    Program.AdminID
                    );
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Case.CaseImage_Update(
                    Convert.ToInt32(TxtCaseID.Text),
                    TxtImageName.Text,
                    byteimage,
                    Program.AdminID,
                    Convert.ToInt32(this.DGV_IMAGES.CurrentRow.Cells[0].Value)
                    );
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            #endregion

            #region عملية التحديث بعد الحفظ والتعديل


            DGVImage_Display();
            TxtDisableImage();
            BTN_Enble_Image();

            #endregion



        }

        private void BtnNewImage_Click(object sender, EventArgs e)
        {
            #region اضافة صورة جديدة
            statImage = "add";
            TxtEnableImage();
            TxtClearImage();
            BTN_Disble_Image();
            #endregion

        }

        private void TxtSearchImage_TextChanged(object sender, EventArgs e)
        {
            DGVImage_Display();
        }

        private void DGV_IMAGES_Click(object sender, EventArgs e)
        {
            Image_DisPlay();
        }

        private void BtnEditeImage_Click(object sender, EventArgs e)
        {
            #region اضافة صورة جديدة
            statImage = "Edit";
            TxtEnableImage();
            BTN_Disble_Image();
            #endregion

        }

        private void BtnDelImage_Click(object sender, EventArgs e)
        {
            #region التحقق من التكستات

            if (TxtImageName.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيارالصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                Case.CaseImage_Delete(Convert.ToInt32(this.DGV_IMAGES.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }
            TxtClearImage();
            DGVImage_Display();

            #endregion


            #endregion

        }

        private void BtnUndoImage_Click(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                if (statImage == "add")
                {
                    TxtClearImage();
                }
                else
                {
                    Image_DisPlay();
                }
                DGVImage_Display();
                TxtDisableImage();
                BTN_Enble_Image();
                }


            else
              {
                return;
              }

            #endregion

        }

        private void TxtCaseAmount_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void TxtCaseAmount_Leave(object sender, EventArgs e)
        {
        }

        private void TxtCaseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region منع كتابة الحروف داخل المبلغ
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }

            #endregion

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void BtnNewAmount_Click(object sender, EventArgs e)
        {
            #region اضافة مبلغ جديدة
            statAmount = "add";
            TxtEnableAmount();
            TxtClearAmount();
            BTN_Disble_Amount();
            #endregion

        }

        private void BtnSaveAmount_Click(object sender, EventArgs e)
        {
            #region التحقق من التكستات

            if (TxtDebitAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال المبلغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDebitAmount.Focus();
                return;
            }

            if (TxtAmountNotes.Text == string.Empty)
            {
                TxtAmountNotes.Text = "0";
            }

            #endregion

            #region عملية الحفظ لجديد او تعديل
            if (statAmount == "add")
            {
                Case.PaidAmount_Debit_Add
                                    (
                                        Convert.ToInt32(TxtCaseID.Text),
                                        PaidDate.Value,
                                        TxtDebitAmount.Text,
                                        TxtAmountNotes.Text,
                                        Program.AdminID
                                     );
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (statAmount=="edit")
            {
                Case.PaidAmount_Debit_Update(
                    Convert.ToInt32(this.DGV_CaseAmount.CurrentRow.Cells[0].Value),
                    PaidDate.Value,
                    TxtDebitAmount.Text,
                    TxtAmountNotes.Text
                    );
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            #endregion

            #region عمليات مابعد الحفظ

            DGVAmount_Display();
            TxtDisableAmount();
            BTN_Enble_Amount();
            DGV_CaseAmount.Enabled = true;
            SumAmount();
            #endregion

        }

        private void TxtDebitAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDebitAmount_Leave(object sender, EventArgs e)
        {
            

        }

        private void BtnEditAmount_Click(object sender, EventArgs e)
        {

            #region التحقق من اختيار المبلغ للتعديل
            if (TxtDebitAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار المبلغ اولا قبل التعديل", "خطأ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            #endregion
           
            
            #region تعديل مبلغ 
            statAmount = "edit";
            TxtEnableAmount();
            BTN_Disble_Amount();
            #endregion

        }

        private void DGV_CaseAmount_Click(object sender, EventArgs e)
        {
            Amount_DisPlay();
        }

        private void BtnDelAmount_Click(object sender, EventArgs e)
        {
            #region التحقق من اختيار المبلغ للحذف
            if (TxtDebitAmount.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار المبلغ اولا قبل الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                Case.PaidAmount_Debit_Delete(Convert.ToInt32(this.DGV_CaseAmount.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }
            #endregion

            #region عمليات مابعد الحفظ

            DGVAmount_Display();
            TxtDisableAmount();
            BTN_Enble_Amount();
            SumAmount();
            #endregion




        }

        private void BtnUndoAmount_Click(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                if (statAmount == "add")
                {
                    TxtClearAmount();
                }
                else
                {
                    Amount_DisPlay();
                }

                #region عمليات مابعد الحفظ
                DGVAmount_Display();
                TxtDisableAmount();
                BTN_Enble_Amount();
                SumAmount();
                #endregion

            }


            else
            {
                return;
            }

            #endregion

        }

        private void BtnJalsaNew_Click(object sender, EventArgs e)
        {
            #region اضافة جلسة جديدة
            statJalsa = "add";
            TxtEnableJalsa();
            TxtClearJalsa();
            BTN_Disble_Jalsa();
            #endregion

        }

        private void BtnJalsaSave_Click(object sender, EventArgs e)
        {
            #region التحقق من التكستات

            if (ComboAdminID.SelectedIndex == -1)
            {
                MessageBox.Show("يجب ادخال المحامي المُكلف بحضور الجلسة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboAdminID.Focus();
                return;
            }

            #endregion

            #region عملية الحفظ لجديد او تعديل
            if (statJalsa == "add")
            {
                Case.Jalsat_Add
                    (
                    Convert.ToInt32(TxtCourtID.Text),
                    Convert.ToInt32(TxtCaseID.Text),
                    Convert.ToInt32(ComboAdminID.SelectedValue),
                    DateTime.Parse(JalsaDate.Text),
                    TxtJalsaRequer.Text,
                    TxtJalsaResult.Text
                    );
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (statJalsa == "edit")
            {
                  Case.Jalsat_Update
                  (
                  Convert.ToInt32(TxtCourtID.Text),
                  Convert.ToInt32(TxtCaseID.Text),
                  Convert.ToInt32(ComboAdminID.SelectedValue),
                  DateTime.Parse(JalsaDate.Text),
                  TxtJalsaRequer.Text,
                  TxtJalsaResult.Text,
                  Convert.ToInt32(this.DGV_Jalsat.CurrentRow.Cells[0].Value)
                  );
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            #endregion

            #region عمليات مابعد الحفظ

            DGVJalsat_Display();
            TxtDisableJalsa();
            BTN_Enble_Jalsa();
            DGV_Jalsat.Enabled = true;
            #endregion


        }

        private void BtnJalsaEdit_Click(object sender, EventArgs e)
        {
            #region التحقق من اختيار الجلسة للتعديل
            if (TxtJalsaID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار الجلسة اولا قبل التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion


            #region تعديل مبلغ 
            statJalsa = "edit";
            TxtEnableJalsa();
            BTN_Disble_Jalsa();
            #endregion


        }

        private void BtnJalsaUndo_Click(object sender, EventArgs e)
        {
            #region عملية التراجع ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية التراجع", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                if (statJalsa == "add")
                {
                    TxtClearJalsa();
                }
                else
                {
                    Jalsa_DisPlay();
                }

                #region عمليات مابعد الحفظ
                DGVJalsat_Display();
                TxtDisableJalsa();
                BTN_Enble_Jalsa();
                #endregion

            }


            else
            {
                return;
            }

            #endregion

        }

        private void BtnJalsaDel_Click(object sender, EventArgs e)
        {
            #region التحقق من اختيار الجلسة للحذف
            if (TxtJalsaID.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار الجلسة اولا قبل الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف
                Case.Jalsat_Delete(Convert.ToInt32(TxtJalsaID.Text));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }
            else
            {
                return;
            }
            #endregion

            #region عمليات مابعد الحفظ

            DGVJalsat_Display();
            TxtDisableJalsa();
            BTN_Enble_Jalsa();
           
            #endregion


        }

        private void DGV_Jalsat_Click(object sender, EventArgs e)
        {
            Jalsa_DisPlay();
        }
    }
}
