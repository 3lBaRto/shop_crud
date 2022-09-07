using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Crud
{
    class Conexion
    {
        static SqlConnection conx = new SqlConnection("server=localhost\\SQLEXPRESS;database=geosmina;integrated security=true");

        static public SqlConnection Abrir() 
        {
            if (conx.State == ConnectionState.Closed)
            {
                conx.Open();
                return conx;
                



            }
            else 
            {
                return null;
            }
            
        }

        static public void cerrar() 
        {
            conx.Close();
        }
    }
}
