using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Law_Manegment.DAL
{
    class DataAccessLayer
    {
        SqlConnection SqlConnection;

        public DataAccessLayer()
        {
            SqlConnection = new SqlConnection(@"Server=ADMIN-PC;Database=Law_Mangment;integrated security=True");
        }

        public void Open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }


        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }

        }



        #region Select Data
        public DataTable SelectData(string stored_Proc, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Proc;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region insert ,Updat , Delet ,Data from Database

        public void ExecuteCommand(string stored_Proc, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Proc;
            sqlcmd.Connection = SqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
        #endregion

    }
}
