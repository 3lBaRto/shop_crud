using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Crud
{
    class T
    {
     
        static public bool ConfirmarU(Usuario U) 
        {
            DataTable dt = generar();

            try
            {
                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                   
                    if (U.Nombre == dt.Rows[i]["nombre"].ToString().Trim() && U.Contra1 == dt.Rows[i]["contrasena"].ToString().Trim())
                    {
                        
                        return true;
                    }
                   

                }
            }
            catch (Exception) 
            {
                return false;
            }

            return false;
        }

        static public DataTable generar() 
        {
            String cadena = "select * from usuarios";

            SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

            SqlDataReader Read = com.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(Read);

            Conexion.cerrar();

            return dt;

        }

        static public bool Insertar(Usuario U) 
        {
            string cadena = $"insert into usuarios values ('{U.Documento}','{U.Nombre}','{U.Apellido}','{U.Contra1}','{U.Cargo}');";

            SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

            int i = com.ExecuteNonQuery();

            if (i == 1)
            {
                return true;
            }

            return false;
        }
    }
}
