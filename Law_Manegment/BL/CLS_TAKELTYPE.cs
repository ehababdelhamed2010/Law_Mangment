using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_TAKELTYPE
    {
        public void TawkelType_Add(string TawkelTypeName, int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@TawkelTypeName", SqlDbType.NVarChar, 50);
            param[0].Value = TawkelTypeName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            DAL.ExecuteCommand("TawkelType_Add", param);

            DAL.Close();
        }

        public DataTable TawkelType_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("TawkelType_Select_All", null);
            return dt;
        }

        public void TawkelType_Update(string TawkelTypeName, int AdminID, int TawkelTypeID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@TawkelTypeName", SqlDbType.NVarChar, 50);
            param[0].Value = TawkelTypeName;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;

            param[2] = new SqlParameter("@TawkelTypeID", SqlDbType.Int);
            param[2].Value = TawkelTypeID;

            DAL.ExecuteCommand("TawkelType_Update", param);

            DAL.Close();
        }

        public void TawkelType_Delete( int AdminID, int TawkelTypeID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[0].Value = AdminID;

            param[1] = new SqlParameter("@TawkelTypeID", SqlDbType.Int);
            param[1].Value = TawkelTypeID;

            DAL.ExecuteCommand("TawkelType_Delete", param);

            DAL.Close();
        }
    }
}
