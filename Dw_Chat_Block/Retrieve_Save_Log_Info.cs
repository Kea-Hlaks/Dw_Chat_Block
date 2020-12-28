using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Dw_Chat_Block
{
    public class Retrieve_Save_Log_Info
    {
        #region Declarations
        readonly static string conStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
        SqlConnection con = new SqlConnection(conStr);
        #endregion

        #region Methods

        public void LogServerInfo(string Name, string IpAdr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("LogServerIp", con);
                cmd.Parameters.AddWithValue("@Ip_Adr",)
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
    }
}