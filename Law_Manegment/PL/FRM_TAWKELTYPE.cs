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
    public partial class FRM_TAWKELTYPE : Form
    {
        BL.CLS_TAKELTYPE tawkeltype = new BL.CLS_TAKELTYPE();

        public string stat = "add";

        public void BTN_Enble()
        {
            BtnNew.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDel.Enabled = true;
            BtnSave.Enabled = false;
            BtnUndo.Enabled = false;
            DGV_TawkelType.Enabled = true;
        }

        public void BTN_Disble()
        {
            BtnNew.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnSave.Enabled = true;
            BtnUndo.Enabled = true;
            DGV_TawkelType.Enabled = false;
        }

        public FRM_TAWKELTYPE()
        {

            InitializeComponent();
            DGV_TawkelType.DataSource = tawkeltype.TawkelType_Select_All();
            DGV_TawkelType.Columns[0].Visible = false;

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtTawkelTypeName.Text = "";
            TxtTawkelTypeName.ReadOnly = false;
            stat = "add";
            BTN_Disble();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region التحقق  من ملئ بوكس الكتابة
            if (TxtTawkelTypeName.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال نوع التوكيل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTawkelTypeName.Focus();
                return;
            }
            #endregion

            #region عملية الحفظ او التعديل
            if (stat == "add")
            {
                tawkeltype.TawkelType_Add(TxtTawkelTypeName.Text, Program.AdminID);
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tawkeltype.TawkelType_Update(TxtTawkelTypeName.Text, Program.AdminID, Convert.ToInt32(this.DGV_TawkelType.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGV_TawkelType.DataSource = tawkeltype.TawkelType_Select_All();
            TxtTawkelTypeName.Clear();
            TxtTawkelTypeName.ReadOnly = true;
            BTN_Enble();

            #endregion
        }

        private void DGV_TawkelType_Click(object sender, EventArgs e)
        {
            TxtTawkelTypeName.Text = this.DGV_TawkelType.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)

        {


            #region التحقق من الاختيار قبل التعديل
            if (TxtTawkelTypeName.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار نوع الوكالة اولاً ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            
            TxtTawkelTypeName.ReadOnly = false;
            stat = "Edit";
            BTN_Disble();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DGV_TawkelType.DataSource = tawkeltype.TawkelType_Select_All();
            TxtTawkelTypeName.Clear();
            TxtTawkelTypeName.ReadOnly= true;
            BTN_Enble();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            #region التحقق من الاختيار قبل التعديل
            if (TxtTawkelTypeName.Text == string.Empty)
            {
                MessageBox.Show("يجب اختيار نوع الوكالة اولاً ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region التحقق من عدم وجودعمليات على نوع الوكالة

            //if (DGV_Tawkel.Rows.Count > 0)
            //{
            //    MessageBox.Show("لايمكن حذف عميل توجد له وكالات  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            #endregion

            #region عملية الحذف ورسالة التاكيد عليها 
            DialogResult m = MessageBox.Show("هل انت متأكد من عملية الحذف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (m == DialogResult.OK)
            {
                #region عملية الحذف

                tawkeltype.TawkelType_Delete(Program.AdminID
                     , Convert.ToInt32(
                     (this.DGV_TawkelType.CurrentRow.Cells[0].Value)));
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                #endregion
            }
            else
            {
                return;
            }

            DGV_TawkelType.DataSource = tawkeltype.TawkelType_Select_All();
            TxtTawkelTypeName.Clear();

            #endregion
        }
    }
}
        

       
    
