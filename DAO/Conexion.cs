using System.Configuration;
using System.Data.SqlClient;

namespace SistemasEntidades
{
    public class Conexion
    {
        readonly string conexion;
        public Conexion()
        {
            conexion = ConfigurationManager.ConnectionStrings["conexionDBAmonic"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }

    }
}
