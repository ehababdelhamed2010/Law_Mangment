using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_EXP
    {
        #region اضافة مصروف

        public void Expenses_Add(string ExpName, int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ExpName", SqlDbType.NVarChar, 50);
            param[0].Value = ExpName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            DAL.ExecuteCommand("Expenses_Add", param);

            DAL.Close();
        }
        #endregion

        #region اختيار كل المصروفات

        public DataTable Expenses_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Expenses_Select_All", null);
            return dt;
        }

        #endregion

        #region تحديث المصروف

        public void Expenses_Update(string ExpName, int AdminID, int ExpID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ExpName", SqlDbType.NVarChar, 50);
            param[0].Value = ExpName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            param[2] = new SqlParameter("@ExpID", SqlDbType.Int);
            param[2].Value = ExpID;

            DAL.ExecuteCommand("Expenses_Update", param);

            DAL.Close();
        }


        #endregion


        #region حذف المصروف
        public void Expenses_Delete(int ExpID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ExpID", SqlDbType.Int);
            param[0].Value = ExpID;


            DAL.ExecuteCommand("Expenses_Delete", param);

            DAL.Close();
        }

        #endregion
    }
}
