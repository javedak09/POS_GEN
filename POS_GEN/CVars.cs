using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GEN
{
    static class CVars
    {
        static string appName = "POINT OF SALE";
        static string mobNo = "+92-300-0203903";
        static string emailID = "info@cincotek.com";

        static string userid;
        static string username;


        static Form frmlogin;


        public static string getAppName
        {
            get
            {
                return appName;
            }
        }

        public static string getEmailID
        {
            get
            {
                return emailID;
            }
        }

        public static string getMobileNo
        {
            get
            {
                return mobNo;
            }
        }


        public static String setUserID
        {
            get
            {
                return userid;
            }

            set
            {
                userid = value;
            }
        }



        public static String setUserName
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }


        public static Form storeFormObject
        {
            get
            {
                return frmlogin;
            }

            set
            {
                frmlogin = value;
            }
        }
    }
}