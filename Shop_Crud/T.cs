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
     
        static public int ConfirmarU(Usuario U) 
        {
            DataTable dt = generar();
            int x =0;
            try
            {
                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    //MessageBox.Show($"{U.Nombre}    {U.Contra1}   esto es usuario , esto es tabla {dt.Rows[i]["nombre"].ToString().Trim().ToLower()}     {dt.Rows[i]["contrasena"].ToString().Trim().ToLower()}");

                    if (U.Nombre == dt.Rows[i]["nombre"].ToString().Trim() && U.Contra1 == dt.Rows[i]["contrasena"].ToString().Trim())
                    {

                        x = 1;
                        return x;
                    }
                    else if (U.Nombre == dt.Rows[i]["nombre"].ToString().Trim() || U.Contra1 == dt.Rows[i]["contrasena"].ToString().Trim())
                    {
                        x = 2;
                        return x;

                    }




                }

                return x;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al confirmar usuario");
            }
                
            
            

            return 0;
        }

        static public DataTable generar() 
        {
            try
            {
                String cadena = "select * from usuarios";

                SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

                SqlDataReader Read = com.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(Read);

                Conexion.cerrar();

                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error 404");
            }
            return null;

        }

        static public bool Insertar(Usuario U)
        {
            try
            {
                string cadena = $"insert into usuarios values ('{U.Documento}','{U.Nombre}','{U.Apellido}','{U.Contra1}','{U.Cargo}');";

                SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

                int i = com.ExecuteNonQuery();

                if (i == 1)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error 404");
            }

            return false;

        }
    }
}
