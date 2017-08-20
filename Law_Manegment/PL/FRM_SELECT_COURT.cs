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
    public partial class FRM_SELECT_COURT : Form
    {
        BL.CLS_SELECT_COURT court = new BL.CLS_SELECT_COURT();

        public void DGV_Display()
        {
            this.DGV_COURT.DataSource = court.Court_SelectAll_Case(TxtSearch.Text);
            this.DGV_COURT.Columns[0].Visible = false;
        }

        public FRM_SELECT_COURT()
        {
            InitializeComponent();

            DGV_Display();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_Display();
        }

        private void DGV_COURT_DoubleClick(object sender, EventArgs e)
        {
            Program.CourtID = this.DGV_COURT.CurrentRow.Cells[0].Value.ToString();
            Program.CourtName = this.DGV_COURT.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
