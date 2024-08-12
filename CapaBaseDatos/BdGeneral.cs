using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaModelo
{
    public class BdGeneral
    {
        public static string cadenaConexion;
        public BdGeneral()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionResortsUned"].ConnectionString;
        }
        
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbHotel;Data Source=Janrosk-AMD\\SQLEXPRESS");
            conectar.Open();
            return conectar;
        }
    }
}
