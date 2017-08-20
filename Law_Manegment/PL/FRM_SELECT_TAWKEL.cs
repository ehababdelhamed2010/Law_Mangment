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
    public partial class FRM_SELECT_TAWKEL : Form
    {
        BL.CLS_SELECT_TAWKEL tawkel = new BL.CLS_SELECT_TAWKEL();

        public void DGV_Display()
        {
            this.DGV_TAWKEL.DataSource = tawkel.Tawkel_SelectAll_Case(TxtSearch.Text, Convert.ToInt32(Program.TxtCustomerID));
            this.DGV_TAWKEL.Columns[0].Visible = false;
            this.DGV_TAWKEL.Columns[1].Width = 200;
            this.DGV_TAWKEL.Columns[2].Width = 150;

        }

        public FRM_SELECT_TAWKEL()
        {
            InitializeComponent();

            DGV_Display();
        }

        private void FRM_SELECT_TAWKEL_Load(object sender, EventArgs e)
        {
        }

        private void DGV_TAWKEL_DoubleClick(object sender, EventArgs e)
        {

            Program.TawkelID = this.DGV_TAWKEL.CurrentRow.Cells[0].Value.ToString();
            Program.TawkelNO = this.DGV_TAWKEL.CurrentRow.Cells[1].Value.ToString();
            Program.TawkelType = this.DGV_TAWKEL.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_Display();

        }
    }
}
