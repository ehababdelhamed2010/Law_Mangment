using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_ADMINS
    {


        #region كمبو حالة المستخدم

        public DataTable ComboIsActiveID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboIsActiveID", null);
            return dt;
        }

        #endregion
       
       
        #region اضافة موظف

        public void Admins_Add(
            string AdminName, 
            string AdminMobile,
            string AdminJob,
            string AdminNotes,
            string UserID,
            string UserPassWord,
            int IsActive
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@AdminName", SqlDbType.NVarChar, 50);
            param[0].Value = AdminName;

            param[1] = new SqlParameter("@AdminMobile", SqlDbType.NVarChar, 20);
            param[1].Value = AdminMobile;

            param[2] = new SqlParameter("@AdminJob", SqlDbType.NVarChar, 50);
            param[2].Value = AdminJob;

            param[3] = new SqlParameter("@AdminNotes", SqlDbType.NVarChar, 8000);
            param[3].Value = AdminNotes;

            param[4] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            param[4].Value = UserID;

            param[5] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 50);
            param[5].Value = UserPassWord;

            param[6] = new SqlParameter("@IsActive", SqlDbType.Int);
            param[6].Value = IsActive;

            DAL.ExecuteCommand("Admins_Add", param);

            DAL.Close();
        }
        #endregion

        #region تعديل موظف

        public void Admins_Update(
            string AdminName,
            string AdminMobile,
            string AdminJob,
            string AdminNotes,
            string UserID,
            string UserPassWord,
            int IsActive,
            int AdminID
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@AdminName", SqlDbType.NVarChar, 50);
            param[0].Value = AdminName;

            param[1] = new SqlParameter("@AdminMobile", SqlDbType.NVarChar, 20);
            param[1].Value = AdminMobile;

            param[2] = new SqlParameter("@AdminJob", SqlDbType.NVarChar, 50);
            param[2].Value = AdminJob;

            param[3] = new SqlParameter("@AdminNotes", SqlDbType.NVarChar, 8000);
            param[3].Value = AdminNotes;

            param[4] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            param[4].Value = UserID;

            param[5] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 50);
            param[5].Value = UserPassWord;

            param[6] = new SqlParameter("@IsActive", SqlDbType.Int);
            param[6].Value = IsActive;

            param[6] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[6].Value = AdminID;


            DAL.ExecuteCommand("Admins_Update", param);

            DAL.Close();
        }
        #endregion

        #region اختيار كل الموظفين

        public DataTable Admins_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Admins_Select_All", null);
            return dt;
        }

        #endregion



    }
}
