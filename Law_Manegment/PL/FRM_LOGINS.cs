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
    public partial class FRM_LOGINS : Form
    {
        BL.CLS_LOGINS logins = new BL.CLS_LOGINS();
        public FRM_LOGINS()
        {
            InitializeComponent();
        }

        private void FRM_LOGINS_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            #region التحقق من اسم المستخدم
            if (TxtUserName.Text==string.Empty)
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserName.Focus();
                return;
            }
            #endregion

            #region التحقق من كلمة المرور
            if (TxtUserPass.Text == string.Empty)
            {
                MessageBox.Show("يجب ادخال كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserPass.Focus();
                return;
            }
            #endregion

            #region عملية الدخول
            DataTable dt = logins.Logins_Select(TxtUserName.Text, TxtUserPass.Text);
            if (dt.Rows.Count>0)
            {
                #region عملية فتح الفورم والصلاحيات فيما بعد
                this.Hide();
                Program.AdminID =Convert.ToInt32( dt.Rows[0][0]);
                this.Close();
                return;
                #endregion
            }
            MessageBox.Show("خطأ في اسم المستخدم/كلمة المرور", "خطأ دخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxtUserName.Focus();
            return;

            #endregion


        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter&& TxtUserName.Text !=string.Empty)
            {
                TxtUserPass.Focus();

            }
        }

        private void TxtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtUserPass.Text != string.Empty)
            {
                BtnOK.Focus();

            }
        }
    }
}
