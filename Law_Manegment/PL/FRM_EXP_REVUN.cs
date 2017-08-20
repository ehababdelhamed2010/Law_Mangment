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
    public partial class FRM_EXP_REVUN : Form
    {
        BL.CLS_PAID_CREDIT credit = new BL.CLS_PAID_CREDIT();

        #region عرض تفاصيل المصروفات والايرادات

        public void Dispaly_Ledger()
        {
            this.DGV_Credit.DataSource = credit.PaidAmount__Ledger_Detail(PaidDate1.Value, PaidDate2.Value);
            this.DGV_Credit.Columns[0].Width = 95;
            this.DGV_Credit.Columns[1].Width = 100;
            this.DGV_Credit.Columns[2].Width = 190;
            this.DGV_Credit.Columns[3].Width = 80;
            this.DGV_Credit.Columns[4].Width = 80;

        }



        #endregion

        #region جمع مبالغ والناتج للقضية

        public void SumAmount()
        {

            if (DGV_Credit.Rows.Count < 1)
            {
                TxtExp.Text = "0";
                TxtReven.Text = "0";
                TxtNetTotal.Text = "0";

            }

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < DGV_Credit.Rows.Count; ++i)
            {
                sum1 += Convert.ToInt32(DGV_Credit.Rows[i].Cells[3].Value);
                sum2 += Convert.ToInt32(DGV_Credit.Rows[i].Cells[4].Value);

            }

            TxtReven.Text = sum1.ToString();
            TxtExp.Text = sum2.ToString();
            TxtNetTotal.Text = (sum1 - sum2).ToString();

        }


        #endregion


        public FRM_EXP_REVUN()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Dispaly_Ledger();
            SumAmount();

        }
    }
}
