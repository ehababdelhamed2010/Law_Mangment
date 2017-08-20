using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Law_Manegment.BL
{
    class CLS_SELECT_CUSTOMER
    {

        #region  العملاء وارقام جوالاتهم

        public DataTable Customer_SelectAll_Case(String Customer)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("Customer", SqlDbType.NVarChar, 50);
            param[0].Value = Customer;

            dt = DAL.SelectData("Customer_SelectAll_Case", param);
            return dt;
        }

        #endregion




    }
}
