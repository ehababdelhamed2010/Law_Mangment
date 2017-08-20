using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Law_Manegment.BL
{
    class CLS_POLICE
    {

        public void Police_Add(string PoliceName, string PoliceAddress, string PoliceNotes, int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@PoliceName", SqlDbType.NVarChar, 50);
            param[0].Value = PoliceName;

            param[1] = new SqlParameter("@PoliceAddress", SqlDbType.NVarChar, 100);
            param[1].Value = PoliceAddress;

            param[2] = new SqlParameter("@PoliceNotes", SqlDbType.NVarChar, 1000);
            param[2].Value = PoliceNotes;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            DAL.ExecuteCommand("Police_Add", param);

            DAL.Close();
        }

        public DataTable Police_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Police_Select_All", null);
            return dt;
        }

        public void Police_Update(string PoliceName, string PoliceAddress, string PoliceNotes, int AdminID,int PoliceID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@PoliceName", SqlDbType.NVarChar, 50);
            param[0].Value = PoliceName;

            param[1] = new SqlParameter("@PoliceAddress", SqlDbType.NVarChar, 100);
            param[1].Value = PoliceAddress;

            param[2] = new SqlParameter("@PoliceNotes", SqlDbType.NVarChar, 1000);
            param[2].Value = PoliceNotes;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            param[4] = new SqlParameter("@PoliceID", SqlDbType.Int);
            param[4].Value = PoliceID;
            DAL.ExecuteCommand("Police_Update", param);

            DAL.Close();
        }

        public void Police_Delete(int PoliceID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@PoliceID", SqlDbType.Int);
            param[0].Value = PoliceID;


            DAL.ExecuteCommand("Police_Delete", param);

            DAL.Close();
        }
    }

}
