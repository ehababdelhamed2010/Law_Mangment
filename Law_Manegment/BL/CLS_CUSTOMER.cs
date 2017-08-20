using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Law_Manegment.BL
{
    class CLS_CUSTOMER
    {
        public DataTable ComboNationalityID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboNationalityID", null);
            return dt;
        }

        public void Customers_Add(string CustomerName,string ReligionName,int NationalityID,string CustomerAddress,
            string CustomerMobile, string CustomerPhone,string CustomerEmail,string CustomerNotes,int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50);
            param[0].Value = CustomerName;

            param[1] = new SqlParameter("@ReligionName", SqlDbType.NVarChar, 50);
            param[1].Value = ReligionName;

            param[2] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[2].Value = NationalityID;

            param[3] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar,150);
            param[3].Value = CustomerAddress;

            param[4] = new SqlParameter("@CustomerMobile", SqlDbType.NVarChar, 20);
            param[4].Value = CustomerMobile;

            param[5] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 20);
            param[5].Value = CustomerPhone;

            param[6] = new SqlParameter("@CustomerEmail", SqlDbType.NVarChar, 50);
            param[6].Value = CustomerEmail;

            param[7] = new SqlParameter("@CustomerNotes", SqlDbType.NVarChar,1000);
            param[7].Value = CustomerNotes;

            param[8] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[8].Value = AdminID;

            DAL.ExecuteCommand("Customers_Add", param);

            DAL.Close();
        }

        public DataTable Cusomer_Select_All()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Cusomer_Select_All", null);
            return dt;
        }

        public void Customers_Update(string CustomerName, string ReligionName, int NationalityID, string CustomerAddress,
            string CustomerMobile, string CustomerPhone, string CustomerEmail, string CustomerNotes, int AdminID,int CustomerID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50);
            param[0].Value = CustomerName;

            param[1] = new SqlParameter("@ReligionName", SqlDbType.NVarChar, 50);
            param[1].Value = ReligionName;

            param[2] = new SqlParameter("@NationalityID", SqlDbType.Int);
            param[2].Value = NationalityID;

            param[3] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 150);
            param[3].Value = CustomerAddress;

            param[4] = new SqlParameter("@CustomerMobile", SqlDbType.NVarChar, 20);
            param[4].Value = CustomerMobile;

            param[5] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 20);
            param[5].Value = CustomerPhone;

            param[6] = new SqlParameter("@CustomerEmail", SqlDbType.NVarChar, 50);
            param[6].Value = CustomerEmail;

            param[7] = new SqlParameter("@CustomerNotes", SqlDbType.NVarChar, 1000);
            param[7].Value = CustomerNotes;

            param[8] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[8].Value = AdminID;

            param[9] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[9].Value = CustomerID;

            DAL.ExecuteCommand("Customers_Update", param);

            DAL.Close();
        }

        public void Customers_Delete(int CustomerID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = CustomerID;


            DAL.ExecuteCommand("Customers_Delete", param);

            DAL.Close();
        }

        public DataTable ComboTawkelTypeID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
         
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboTawkelTypeID", null);
            return dt;
        }

        public DataTable Tawkel_Select_All(int CustomerID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = CustomerID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Tawkel_Select_All", param);
            return dt;
        }

        public void Tawkel_Add(string TawkelNo,int TawkelTypeID, int CustomerID,string TawkelNotes,int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@TawkelNo", SqlDbType.NVarChar, 50);
            param[0].Value = TawkelNo;

            param[1] = new SqlParameter("@TawkelTypeID", SqlDbType.Int);
            param[1].Value = TawkelTypeID;

            param[2] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[2].Value = CustomerID;

            param[3] = new SqlParameter("@TawkelNotes", SqlDbType.NVarChar, 1000);
            param[3].Value = TawkelNotes;

            param[4] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[4].Value = AdminID;

            DAL.ExecuteCommand("Tawkel_Add", param);

            DAL.Close();
        }

        public void Tawkel_Update(string TawkelNo, int TawkelTypeID, 
            string TawkelNotes, int AdminID, int TawkelID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@TawkelNo", SqlDbType.NVarChar, 50);
            param[0].Value = TawkelNo;

            param[1] = new SqlParameter("@TawkelTypeID", SqlDbType.Int);
            param[1].Value = TawkelTypeID;

            param[2] = new SqlParameter("@TawkelNotes", SqlDbType.NVarChar, 1000);
            param[2].Value = TawkelNotes;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            param[4] = new SqlParameter("@TawkelID", SqlDbType.Int);
            param[4].Value = TawkelID;

            DAL.ExecuteCommand("Tawkel_Update", param);

            DAL.Close();
        }

        public void Tawkel_Delete(int TawkelID,int AdminID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@TawkelID", SqlDbType.Int);
            param[0].Value = TawkelID;

            param[1] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[1].Value = AdminID;


            DAL.ExecuteCommand("Tawkel_Delete", param);

            DAL.Close();
        }
    }
}
