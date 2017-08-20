using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Law_Manegment.BL
{
   
    class CLS_COURTS
    {
        public void Courts_Add(string CourtName,string CourtAddress,string CourtNotes, int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CourtName", SqlDbType.NVarChar, 50);
            param[0].Value = CourtName;

            param[1] = new SqlParameter("@CourtAddress", SqlDbType.NVarChar,100);
            param[1].Value = CourtAddress;

            param[2] = new SqlParameter("@CourtNotes", SqlDbType.NVarChar,1000);
            param[2].Value = CourtNotes;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            DAL.ExecuteCommand("Courts_Add", param);

            DAL.Close();
        }

        public DataTable Courts_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Courts_Select_All", null);
            return dt;
        }

        public void Courts_Update(string CourtName, string CourtAddress, string CourtNotes, int AdminID,int CourtID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@CourtName", SqlDbType.NVarChar, 50);
            param[0].Value = CourtName;

            param[1] = new SqlParameter("@CourtAddress", SqlDbType.NVarChar, 100);
            param[1].Value = CourtAddress;

            param[2] = new SqlParameter("@CourtNotes", SqlDbType.NVarChar, 1000);
            param[2].Value = CourtNotes;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            param[4] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[4].Value = CourtID;

            DAL.ExecuteCommand("Courts_Update", param);

            DAL.Close();
        }

        public void Courts_Delete(int CourtID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[0].Value = CourtID;


            DAL.ExecuteCommand("Courts_Delete", param);

            DAL.Close();
        }
    }
}
