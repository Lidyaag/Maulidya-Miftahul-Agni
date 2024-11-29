using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProjectUjian
{
    internal class Koneksi
    {
        public SqlConnection Getconn ()
        {
            SqlConnection conn = null;
            conn = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; database = Aplikasi; integrated security = SSPI");
            return conn;
        }
    }
}
