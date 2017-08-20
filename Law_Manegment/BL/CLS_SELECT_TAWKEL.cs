using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    
    class CLS_SELECT_TAWKEL
    {
        #region  الوكالات وارقامهم

        public DataTable Tawkel_SelectAll_Case(String Tawkel, int CustomerID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("Tawkel", SqlDbType.NVarChar, 50);
            param[0].Value = Tawkel;

            param[1] = new SqlParameter("CustomerID", SqlDbType.Int);
            param[1].Value = CustomerID;

            dt = DAL.SelectData("Tawkel_SelectAll_Case", param);
            return dt;
        }

        #endregion
    }
}
