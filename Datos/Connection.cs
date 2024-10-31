using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EJOQVME\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open();
            return conn;
        }

        public void CloseConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EJOQVME\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Close();
            conn = null;
        }
    }
}
