using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_NATIONALITY
    {
        public void Nationality_Add(string NationalityName, int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@NationalityName", SqlDbType.NVarChar, 50);
            param[0].Value = NationalityName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            DAL.ExecuteCommand("Nationality_Add", param);

            DAL.Close();
        }

        public DataTable Nationality_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Nationality_Select_All", null);
            return dt;
        }

        public void Nationality_Update(string NationalityName, int AdminID, int NationalityID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@NationalityName", SqlDbType.NVarChar, 50);
            param[0].Value = NationalityName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            param[2] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[2].Value = NationalityID;

            DAL.ExecuteCommand("Nationality_Update", param);

            DAL.Close();
        }

        public void Nationality_Delete(int NationalityID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[0].Value = NationalityID;


            DAL.ExecuteCommand("Nationality_Delete", param);

            DAL.Close();
        }
    }


}
