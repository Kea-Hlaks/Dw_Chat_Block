using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dw_Chat_Block
{
    public class CommonObjects
    {
        private static CommonObjects common;
        public string UsersName = string.Empty;
        public int UserId = 0;
        public int intRoleID = 0;
        public string UserFullNames = string.Empty;
        public string Email;
        public int LoginAttempts;
        public string UserIpAdress;
        public string ServerIpAdr;
        /// <summary>
        /// Creating one object for one session (Singleton design architecture)
        /// </summary>
        public static CommonObjects Object
        {
            get
            {
                object objCurUser = HttpContext.Current.Session["CurrentUser"];
                if (objCurUser == null)
                {
                    HttpContext.Current.Session["CurrentUser"] = new CommonObjects();
                }
                return HttpContext.Current.Session["CurrentUser"] as CommonObjects;
            }

        }

        /// <summary>
        /// Method to reset object
        /// </summary>
        public void Reset()
        {
            common = new CommonObjects();
        }

    }
}