using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_PAID_CREDIT
    {
        #region كمبو المصروفات

        public DataTable comboExpID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("comboExpID", null);
            return dt;
        }

        #endregion

        #region  المصروفات

        public DataTable PaidAmount_Credit_Select_All(string Credit)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("Credit", SqlDbType.NVarChar,50);
            param[0].Value = Credit;


            dt = DAL.SelectData("PaidAmount_Credit_Select_All", param);
            return dt;
        }

        #endregion

        #region اضافة مصروف
        public void PaidAmount_Credit_Add
    (
    int ExpID,
    DateTime PaidDate,
    string CreditAmount,
    string AmountNotes,
    int AdminID
    )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ExpID", SqlDbType.Int);
            param[0].Value = ExpID;

            param[1] = new SqlParameter("@PaidDate", SqlDbType.DateTime);
            param[1].Value = PaidDate;

            param[2] = new SqlParameter("@CreditAmount", SqlDbType.NVarChar,20);
            param[2].Value = CreditAmount;

            param[3] = new SqlParameter("@AmountNotes", SqlDbType.NVarChar,8000);
            param[3].Value = AmountNotes;

            param[4] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[4].Value = AdminID;

            DAL.ExecuteCommand("PaidAmount_Credit_Add", param);

            DAL.Close();
        }

        #endregion

        #region تعديل مصروف
        public void PaidAmount_Credit_Update
    (
    int ExpID,
    DateTime PaidDate,
    string CreditAmount,
    string AmountNotes,
    int AdminID,
    int TransID
    )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ExpID", SqlDbType.Int);
            param[0].Value = ExpID;

            param[1] = new SqlParameter("@PaidDate", SqlDbType.DateTime);
            param[1].Value = PaidDate;

            param[2] = new SqlParameter("@CreditAmount", SqlDbType.NVarChar, 20);
            param[2].Value = CreditAmount;

            param[3] = new SqlParameter("@AmountNotes", SqlDbType.NVarChar, 8000);
            param[3].Value = AmountNotes;

            param[4] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[4].Value = AdminID;

            param[5] = new SqlParameter("@TransID", SqlDbType.Int);
            param[5].Value = TransID;

            DAL.ExecuteCommand("PaidAmount_Credit_Update", param);

            DAL.Close();
        }

        #endregion

        #region حذف مصروف للقضية

        public void PaidAmount_Credit_Delete(int TransID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TransID", SqlDbType.Int);
            param[0].Value = TransID;

            DAL.ExecuteCommand("PaidAmount_Credit_Delete", param);

            DAL.Close();
        }

        #endregion


        #region  كشف حساب المصروفات تفصيلي

        public DataTable PaidAmount_Credit_Ledger_Detail(DateTime date1 , DateTime date2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("date2", SqlDbType.DateTime);
            param[1].Value = date2;


            dt = DAL.SelectData("PaidAmount_Credit_Ledger_Detail", param);
            return dt;
        }

        #endregion

        #region  كشف حساب مصروف معين تفصيلي

        public DataTable PaidAmount_Credit_Ledger_Detail_one(DateTime date1, DateTime date2, int ExpID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("date2", SqlDbType.DateTime);
            param[1].Value = date2;

            param[2] = new SqlParameter("ExpID", SqlDbType.Int);
            param[2].Value = ExpID;



            dt = DAL.SelectData("PaidAmount_Credit_Ledger_Detail_one", param);
            return dt;
        }

        #endregion

        #region  كشف حساب اجمالي مصروفات

        public DataTable PaidAmount_Credit_Ledger_Detail_Total(DateTime date1, DateTime date2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("date2", SqlDbType.DateTime);
            param[1].Value = date2;



            dt = DAL.SelectData("PaidAmount_Credit_Ledger_Detail_Total", param);
            return dt;
        }

        #endregion


        #region  كشف حساب المصروفات والايرادات تفصيلي

        public DataTable PaidAmount__Ledger_Detail(DateTime date1, DateTime date2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("date2", SqlDbType.DateTime);
            param[1].Value = date2;


            dt = DAL.SelectData("PaidAmount__Ledger_Detail", param);
            return dt;
        }

        #endregion




    }
}
