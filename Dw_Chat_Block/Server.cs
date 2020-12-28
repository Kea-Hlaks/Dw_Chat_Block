using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;


namespace Dw_Chat_Block
{
    public class Server
    {
        private string Ip_Adress;
        private string ServerName;
        public static string GetLocalIPAddress()
        {
            try
            {
                string Server_Name = Dns.GetHostName(), ServerName = Server_Name;

                var host = Dns.GetHostEntry(Server_Name);
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void StartServer()
        {
            Ip_Adress = GetLocalIPAddress();



            TcpListener server = new TcpListener(IPAddress.Parse(Ip_Adress), 8088);
            server.Start();
            Console.WriteLine("Server has started on "+ Ip_Adress +  " .{0}Waiting for a connection...", Environment.NewLine);

            TcpClient client = server.AcceptTcpClient();

            Console.WriteLine("A client connected.");
        }

        public void LogServerInfo(string ip_adr, string Name)
        {
            try
            {
                SqlConnection con = 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}