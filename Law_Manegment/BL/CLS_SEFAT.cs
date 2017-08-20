using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Law_Manegment.BL
{
    class CLS_SEFAT
    {
        #region اضافة صفة

        public void Sefat_Add(string SefaName,int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@SefaName", SqlDbType.NVarChar,50);
            param[0].Value = SefaName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            DAL.ExecuteCommand("Sefat_Add", param);

            DAL.Close();
        }
        #endregion

        #region اختيار كل الصفات

        public DataTable Sefat_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Sefat_Select_All", null);
            return dt;
        }

        #endregion

        #region تحديث الصفة

        public void Sefat_Update(string SefaName, int AdminID,int SefaID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@SefaName", SqlDbType.NVarChar, 50);
            param[0].Value = SefaName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            param[2] = new SqlParameter("@SefaID", SqlDbType.Int);
            param[2].Value = SefaID;

            DAL.ExecuteCommand("Sefat_Update", param);

            DAL.Close();
        }


        #endregion

        #region حذف الصفة
        public void Sefat_Delete(int SefaID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SefaID", SqlDbType.Int);
            param[0].Value = SefaID;

            
            DAL.ExecuteCommand("Sefat_Delete", param);

            DAL.Close();
        }

        #endregion
    }
}
