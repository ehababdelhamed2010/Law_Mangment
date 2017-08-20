using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Law_Manegment.BL
{
    class CLS_CASE
    {


        #region تفاصيل القضية

        #region كمبو صفات العميل

        public DataTable ComboSefaID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboSefaID", null);
            return dt;
        }

        #endregion

        #region كمبو درجات التقاضي

        public DataTable ComboTakadiDegreID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboTakadiDegreID", null);
            return dt;
        }

        #endregion

        #region  القضايا والبحث

        public DataTable Case_Select_All(String Case)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("Case", SqlDbType.NVarChar, 50);
            param[0].Value = Case;

            dt = DAL.SelectData("Case_Select_All", param);
            return dt;
        }

        #endregion

        #region اضافة قضية

        public void Case_Add(

            int CourtID
            , string CaseName
            , int CustomerID
            , int SefaID
            , int TawkelID
            , int TakadiDegreID
            , DateTime CaseDate
            , string DefinseName,
            string DefinseAddress
            , string DefinseSefa
            , DateTime ReciveDate
            , string CaseTopic
            , string CaseNotes
            , int AdminID
            , string CaseAmount
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[0].Value = CourtID;

            param[1] = new SqlParameter("@CaseName", SqlDbType.NVarChar, 50);
            param[1].Value = CaseName;

            param[2] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[2].Value = CustomerID;

            param[3] = new SqlParameter("@SefaID", SqlDbType.Int);
            param[3].Value = SefaID;

            param[4] = new SqlParameter("@TawkelID", SqlDbType.Int);
            param[4].Value = TawkelID;

            param[5] = new SqlParameter("@TakadiDegreID", SqlDbType.Int);
            param[5].Value = TakadiDegreID;

            param[6] = new SqlParameter("@CaseDate", SqlDbType.DateTime);
            param[6].Value = CaseDate;

            param[7] = new SqlParameter("@DefinseName", SqlDbType.NVarChar, 50);
            param[7].Value = DefinseName;

            param[8] = new SqlParameter("@DefinseAddress", SqlDbType.NVarChar, 150);
            param[8].Value = DefinseAddress;

            param[9] = new SqlParameter("@DefinseSefa", SqlDbType.NVarChar, 20);
            param[9].Value = DefinseSefa;

            param[10] = new SqlParameter("@ReciveDate", SqlDbType.DateTime);
            param[10].Value = ReciveDate;

            param[11] = new SqlParameter("@CaseTopic", SqlDbType.NVarChar, 8000);
            param[11].Value = CaseTopic;

            param[12] = new SqlParameter("@CaseNotes", SqlDbType.NVarChar, 8000);
            param[12].Value = CaseNotes;

            param[13] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[13].Value = AdminID;

            param[14] = new SqlParameter("@CaseAmount", SqlDbType.NVarChar, 20);
            param[14].Value = CaseAmount;


            DAL.ExecuteCommand("Case_Add", param);

            DAL.Close();
        }

        #endregion


        #region تعديل قضية

        public void Case_Update(

            int CourtID
            , string CaseName
            , int CustomerID
            , int SefaID
            , int TawkelID
            , int TakadiDegreID
            , DateTime CaseDate
            , string DefinseName,
            string DefinseAddress
            , string DefinseSefa
            , DateTime ReciveDate
            , string CaseTopic
            , string CaseNotes
            , int AdminID
            , int CaseID
            , string CaseAmount
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[0].Value = CourtID;

            param[1] = new SqlParameter("@CaseName", SqlDbType.NVarChar, 50);
            param[1].Value = CaseName;

            param[2] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[2].Value = CustomerID;

            param[3] = new SqlParameter("@SefaID", SqlDbType.Int);
            param[3].Value = SefaID;

            param[4] = new SqlParameter("@TawkelID", SqlDbType.Int);
            param[4].Value = TawkelID;

            param[5] = new SqlParameter("@TakadiDegreID", SqlDbType.Int);
            param[5].Value = TakadiDegreID;

            param[6] = new SqlParameter("@CaseDate", SqlDbType.DateTime);
            param[6].Value = CaseDate;

            param[7] = new SqlParameter("@DefinseName", SqlDbType.NVarChar, 50);
            param[7].Value = DefinseName;

            param[8] = new SqlParameter("@DefinseAddress", SqlDbType.NVarChar, 150);
            param[8].Value = DefinseAddress;

            param[9] = new SqlParameter("@DefinseSefa", SqlDbType.NVarChar, 20);
            param[9].Value = DefinseSefa;

            param[10] = new SqlParameter("@ReciveDate", SqlDbType.DateTime);
            param[10].Value = ReciveDate;

            param[11] = new SqlParameter("@CaseTopic", SqlDbType.NVarChar, 8000);
            param[11].Value = CaseTopic;

            param[12] = new SqlParameter("@CaseNotes", SqlDbType.NVarChar, 8000);
            param[12].Value = CaseNotes;

            param[13] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[13].Value = AdminID;

            param[14] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[14].Value = CaseID;

            param[15] = new SqlParameter("@CaseAmount", SqlDbType.NVarChar, 20);
            param[15].Value = CaseAmount;

            DAL.ExecuteCommand("Case_Update", param);

            DAL.Close();
        }

        #endregion

        #region حذف قضية

        public void Case_Delete(int CaseID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            DAL.ExecuteCommand("Case_Delete", param);

            DAL.Close();
        }

        #endregion


        #endregion

        #region سداد المستحقات

        #region  المبالغ

        public DataTable PaidAmount_Debit_Select_All(int  CaseID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            dt = DAL.SelectData("PaidAmount_Debit_Select_All", param);
            return dt;
        }


        #endregion

        #region اضافة مبلغ سداد

        public void PaidAmount_Debit_Add
            (
            int CaseID,
            DateTime PaidDate,
            string DebitAmount,
            string AmountNotes,
            int AdminID
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            param[1] = new SqlParameter("@PaidDate", SqlDbType.Date);
            param[1].Value = PaidDate;

            param[2] = new SqlParameter("@DebitAmount", SqlDbType.NVarChar,20);
            param[2].Value = DebitAmount;

            param[3] = new SqlParameter("@AmountNotes", SqlDbType.NVarChar, 8000);
            param[3].Value = AmountNotes;

            param[4] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[4].Value = AdminID;



            DAL.ExecuteCommand("PaidAmount_Debit_Add", param);

            DAL.Close();
        }

        #endregion

        #region تعديل مبلغ سداد

        public void PaidAmount_Debit_Update
            (
            int TransID,
            DateTime PaidDate,
            string DebitAmount,
            string AmountNotes
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@TransID", SqlDbType.Int);
            param[0].Value = TransID;

            param[1] = new SqlParameter("@PaidDate", SqlDbType.Date);
            param[1].Value = PaidDate;

            param[2] = new SqlParameter("@DebitAmount", SqlDbType.NVarChar, 20);
            param[2].Value = DebitAmount;

            param[3] = new SqlParameter("@AmountNotes", SqlDbType.NVarChar, 8000);
            param[3].Value = AmountNotes;

            DAL.ExecuteCommand("PaidAmount_Debit_Update", param);

            DAL.Close();
        }

        #endregion

        #region حذف مبلغ سداد

        public void PaidAmount_Debit_Delete
            (
            int TransID
          
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TransID", SqlDbType.Int);
            param[0].Value = TransID;

            DAL.ExecuteCommand("PaidAmount_Debit_Delete", param);

            DAL.Close();
        }

        #endregion

        #endregion

        #region مستندات القضية

        #region  الصور والمستندات

        public DataTable CaseImage_Select_All(String image, int CaseID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("image", SqlDbType.NVarChar, 50);
            param[0].Value = image;

            param[1] = new SqlParameter("CaseID", SqlDbType.Int);
            param[1].Value = CaseID;

            dt = DAL.SelectData("CaseImage_Select_All", param);
            return dt;
        }

        #endregion

        #region اضافة صورة للقضية

        public void CaseImage_Add(

            int CaseID
            , string ImageName
            ,byte[] CaseImage
            , int AdminID
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            param[1] = new SqlParameter("@ImageName", SqlDbType.NVarChar, 50);
            param[1].Value = ImageName;

            param[2] = new SqlParameter("@CaseImage", SqlDbType.Image);
            param[2].Value = CaseImage;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            DAL.ExecuteCommand("CaseImage_Add", param);

            DAL.Close();
        }

        #endregion

        #region تعديل صورة للقضية

        public void CaseImage_Update(

            int CaseID
            , string ImageName
            , byte[] CaseImage
            , int AdminID
            , int ImageID
            )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            param[1] = new SqlParameter("@ImageName", SqlDbType.NVarChar, 50);
            param[1].Value = ImageName;

            param[2] = new SqlParameter("@CaseImage", SqlDbType.Image);
            param[2].Value = CaseImage;

            param[3] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[3].Value = AdminID;

            param[4] = new SqlParameter("@ImageID", SqlDbType.Int);
            param[4].Value = ImageID;


            DAL.ExecuteCommand("CaseImage_Update", param);

            DAL.Close();
        }

        #endregion

        #region حذف صورة للقضية

        public void CaseImage_Delete(int ImageID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ImageID", SqlDbType.Int);
            param[0].Value = ImageID;

            DAL.ExecuteCommand("CaseImage_Delete", param);

            DAL.Close();
        }

        #endregion

        #endregion

        #region الجلسات

        #region كمبو المحامين

        public DataTable ComboAdminID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ComboAdminID", null);
            return dt;
        }

        #endregion

        #region اضافة جلسة
        public void Jalsat_Add
    (
    int CourtID,
    int CaseID,
    int AdminID,
    DateTime JalsaDate,
    string JalsaRequer,
    string JalsaResult
    )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[0].Value = CourtID;

            param[1] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[1].Value = CaseID;

            param[2] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[2].Value = AdminID;

            param[3] = new SqlParameter("@JalsaDate", SqlDbType.Date);
            param[3].Value = JalsaDate;

            param[4] = new SqlParameter("@JalsaRequer", SqlDbType.NVarChar, 8000);
            param[4].Value = JalsaRequer;

            param[5] = new SqlParameter("@JalsaResult", SqlDbType.NVarChar, 8000);
            param[5].Value = JalsaResult;


            DAL.ExecuteCommand("Jalsat_Add", param);

            DAL.Close();
        }

        #endregion

        #region تعديل جلسة
        public void Jalsat_Update
    (
    int CourtID,
    int CaseID,
    int AdminID,
    DateTime JalsaDate,
    string JalsaRequer,
    string JalsaResult,
    int JalsaID

    )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@CourtID", SqlDbType.Int);
            param[0].Value = CourtID;

            param[1] = new SqlParameter("@CaseID", SqlDbType.Int);
            param[1].Value = CaseID;

            param[2] = new SqlParameter("@AdminID", SqlDbType.Int);
            param[2].Value = AdminID;

            param[3] = new SqlParameter("@JalsaDate", SqlDbType.Date);
            param[3].Value = JalsaDate;

            param[4] = new SqlParameter("@JalsaRequer", SqlDbType.NVarChar, 8000);
            param[4].Value = JalsaRequer;

            param[5] = new SqlParameter("@JalsaResult", SqlDbType.NVarChar, 8000);
            param[5].Value = JalsaResult;

            param[6] = new SqlParameter("@JalsaID", SqlDbType.Int);
            param[6].Value = JalsaID;


            DAL.ExecuteCommand("Jalsat_Update", param);

            DAL.Close();
        }

        #endregion

        #region  الجلسات

        public DataTable Jalsat_Select_All(int CaseID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("CaseID", SqlDbType.Int);
            param[0].Value = CaseID;

            dt = DAL.SelectData("Jalsat_Select_All", param);
            return dt;
        }

        #endregion

        #region حذف جلسة للقضية

        public void Jalsat_Delete(int JalsaID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@JalsaID", SqlDbType.Int);
            param[0].Value = JalsaID;

            DAL.ExecuteCommand("Jalsat_Delete", param);

            DAL.Close();
        }

        #endregion


        #endregion


    }
}
