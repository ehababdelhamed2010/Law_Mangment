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
    public partial class FRM_EXP_LEDGER : Form
    {
        BL.CLS_PAID_CREDIT credit = new BL.CLS_PAID_CREDIT();

        #region عرض تفاصيل المصروفات

        public void Dispaly_Details()
        {
            this.DGV_Credit.DataSource = credit.PaidAmount_Credit_Ledger_Detail(PaidDate1.Value,PaidDate2.Value);
            this.DGV_Credit.Columns[0].Width = 95;
            this.DGV_Credit.Columns[1].Width = 100;
            this.DGV_Credit.Columns[2].Width = 250;
            this.DGV_Credit.Columns[3].Width = 100;
        }



        #endregion

        #region عرض تفاصيل مصروف معين

        public void Dispaly_Details_one()
        {
            this.DGV_Credit.DataSource = credit.PaidAmount_Credit_Ledger_Detail_one(PaidDate1.Value, PaidDate2.Value,Convert.ToInt32(comboExpID.SelectedValue));
            this.DGV_Credit.Columns[0].Width = 95;
            this.DGV_Credit.Columns[1].Width = 100;
            this.DGV_Credit.Columns[2].Width = 250;
            this.DGV_Credit.Columns[3].Width = 100;
        }



        #endregion

        #region جمع مبالغ والناتج للقضية

        public void SumAmount()
        {

            if (DGV_Credit.Rows.Count < 1)
            {
                TxtCreditAmount.Text = "0";
            }

            int sum = 0;
            for (int i = 0; i < DGV_Credit.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGV_Credit.Rows[i].Cells[3].Value);
            }

            TxtCreditAmount.Text = sum.ToString();

        }


        #endregion



        public FRM_EXP_LEDGER()
        {
            InitializeComponent();

            #region كمبو المصروفات
            comboExpID.DataSource = credit.comboExpID();
            comboExpID.ValueMember = "ExpID";
            comboExpID.DisplayMember = "ExpName";
            comboExpID.SelectedIndex = -1;
            #endregion

        }

        private void FRM_EXP_LEDGER_Load(object sender, EventArgs e)
        {

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            if ( comboExpID.SelectedIndex == -1)
            {
                Dispaly_Details();
            }

            if ( comboExpID.SelectedValue != null)
            {
                Dispaly_Details_one();
            }
            SumAmount();
        }
    }
}
