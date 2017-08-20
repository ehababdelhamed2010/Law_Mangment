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
    public partial class FRM_SELECT_CUSTOMER : Form
    {
        BL.CLS_SELECT_CUSTOMER CUSTOMERS = new BL.CLS_SELECT_CUSTOMER();
        public FRM_SELECT_CUSTOMER()
        {
            InitializeComponent();
            this.TxtSearch.Focus();

            #region جميع العملاء

            DGV_CUSTOMERS.DataSource = CUSTOMERS.Customer_SelectAll_Case(TxtSearch.Text);
            this.DGV_CUSTOMERS.Columns[0].Visible = false;
            this.DGV_CUSTOMERS.Columns[1].Width = 220;
            this.DGV_CUSTOMERS.Columns[2].Width = 100;

            #endregion

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            #region بحث سريع في العملاء

            DataTable dt = new DataTable();
            dt =CUSTOMERS.Customer_SelectAll_Case(TxtSearch.Text);
            DGV_CUSTOMERS.DataSource =dt;
            this.DGV_CUSTOMERS.Columns[0].Visible = false;
            this.DGV_CUSTOMERS.Columns[1].Width = 220;
            this.DGV_CUSTOMERS.Columns[2].Width = 100;

            #endregion
        }

        private void DGV_CUSTOMERS_DoubleClick(object sender, EventArgs e)
        {
            Program.TxtCustomerID = this.DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
            Program.TxtCustomerName = this.DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
            Program.TxtCustomerMobile = this.DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }
    }
}
