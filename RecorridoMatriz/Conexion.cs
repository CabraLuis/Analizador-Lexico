using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RecorridoMatriz
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog = matrizTransicion; Server = localhost");
            cn.Open();
            return cn;
        }
    }
}
