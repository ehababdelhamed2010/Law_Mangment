using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_SELECT_COURT
    {
        #region  جميع المحاكم والبحث

        public DataTable Court_SelectAll_Case(String Court)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("Court", SqlDbType.NVarChar, 50);
            param[0].Value = Court;


            dt = DAL.SelectData("Court_SelectAll_Case", param);
            return dt;
        }

        #endregion
    }
}
