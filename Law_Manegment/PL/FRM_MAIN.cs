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
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGINS frm = new FRM_LOGINS();
            frm.ShowDialog();
        }

        private void القضاياToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_CASE frm = new FRM_CASE();
            frm.ShowDialog();
        }

        private void العملاءوالوكالاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_CUSTOMER frm = new FRM_CUSTOMER();
            frm.ShowDialog();
        }

        private void المحاكمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_COURTS frm = new FRM_COURTS();
            frm.ShowDialog();

        }

        private void اقسامالشرطةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_POLICE frm = new FRM_POLICE();
            frm.ShowDialog();
        }

        private void انواعالوكالاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_TAWKELTYPE frm = new FRM_TAWKELTYPE();
            frm.ShowDialog();

        }

        private void صفاتالعملاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_SEFAT frm = new FRM_SEFAT();
            frm.ShowDialog();

        }

        private void الجنسياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_NATIONALITY frm = new FRM_NATIONALITY();
            frm.ShowDialog();

        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_EXP frm = new PL.FRM_EXP();
            frm.ShowDialog();

        }

        private void مصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_PAID_CREDIT frm = new FRM_PAID_CREDIT();
            frm.ShowDialog();
        }

        private void كشفحسابمصروفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void كشفجميعالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_EXP_LEDGER exp = new FRM_EXP_LEDGER();
            exp.ShowDialog();
        }

        private void الايرداتوالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_EXP_REVUN rev = new FRM_EXP_REVUN();
            rev.ShowDialog();  
        }

        private void المستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADMINS admin = new FRM_ADMINS();
            admin.ShowDialog();

        }

        private void تتبعالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_ADMINS_TRACKING admin = new FRM_ADMINS_TRACKING();
            admin.ShowDialog();
        }
    }
}
