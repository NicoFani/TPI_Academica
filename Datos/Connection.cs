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
            SqlConnection conn = new SqlConnection("Server=Nico;Database=tp2_net;Integrated Security=True;");
            conn.Open();
            return conn;
        }

        public void CloseConnection()
        {
            SqlConnection conn = new SqlConnection("Server=Nico;Database=tp2_net;Integrated Security=True;");
            conn.Close();
            conn = null;
        }
    }
}
