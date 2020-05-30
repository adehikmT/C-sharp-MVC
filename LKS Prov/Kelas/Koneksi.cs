using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LKS_Prov.Kelas
{
    class Koneksi
    {
        SqlConnection con;
        public SqlConnection GetCon()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "SERVER=LAPTOP-8VEI6K7E;Initial Catalog=lksprov;Integrated Security=true;";
                Console.WriteLine("Coonecting the server...");
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
