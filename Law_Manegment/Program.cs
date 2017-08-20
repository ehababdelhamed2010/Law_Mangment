using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Law_Manegment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        #region متغيرات عامة على البرنامج

        #region رقم المستخدم
        public static int AdminID;
        #endregion

        #region بيانات خاصة بالعميل
        public static String TxtCustomerID;
        public static String TxtCustomerName;
        public static String TxtCustomerMobile;
        #endregion

        #region بيانات خاصة التوكيل
        public static String TawkelID;
        public static String TawkelNO;
        public static String TawkelType;
        #endregion

        #region بيانات خاصة بالمحكمة
        public static String CourtID;
        public static String CourtName;
        #endregion


        #endregion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.FRM_MAIN());
        }
    }
}

