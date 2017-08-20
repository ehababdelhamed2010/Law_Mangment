using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_LOGINS
    {
        public DataTable Logins_Select(String UserID, String UserPassWord)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            param[0].Value = UserID;
            param[1] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 50);
            param[1].Value = UserPassWord;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Logins_Select", param);
            return dt;
        }
    }
}
