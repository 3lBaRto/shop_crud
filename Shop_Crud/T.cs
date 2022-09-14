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
        static public bool Admin = false;
        static public int ConfirmarU(Usuario U) 
        {
            DataTable dt = generar(0);
            int x =0;

            

            try
            {
                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    //MessageBox.Show($"{U.Nombre}    {U.Contra1}   esto es usuario , esto es tabla {dt.Rows[i]["nombre"].ToString().Trim().ToLower()}     {dt.Rows[i]["contrasena"].ToString().Trim().ToLower()}");

                    if (U.Nombre == dt.Rows[i]["nombre"].ToString().Trim() && U.Contra1 == dt.Rows[i]["contrasena"].ToString().Trim())
                    {
                        if (dt.Rows[i]["cargo"].ToString().Trim().ToUpper() == "ADMIN")
                        {
                            Admin = true;
                        }

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

        static public DataTable generar(int i) 
        {
            try
            {
                string[] cadena = new string[2];
                cadena[0] = "select * from usuarios";
                cadena[1] = "select * from productos";

                SqlCommand com = new SqlCommand(cadena[i], Conexion.Abrir());

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

        static public bool Insertar_U(Usuario U)
        {
            try
            {
                string cadena = $"insert into usuarios values ('{U.Documento}','{U.Nombre}','{U.Apellido}','{U.Contra1}','{U.Cargo}');";

                SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

                int i = com.ExecuteNonQuery();

                Conexion.cerrar();

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

        static public bool Insertar_P(Producto P)
        {
            try
            {
                string cadena = $"insert into productos values ('{P.Nom_producto}', {P.Precio} , '{P.Seccion}' , '{P.Descrip}');";

                SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

                int i = com.ExecuteNonQuery();

                Conexion.cerrar();

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

        static public bool Eliminar(int index,int id) 
        {
            string cadena="";

            switch (index)
            {
                case 1:
                    cadena = $"delete usuarios where documento='{id}';";
                    break;
                case 2:
                    cadena = $"delete productos where id='{id}';";
                    break;
                default:
                    MessageBox.Show("Error al identificar la tabla");
                    break;
            }

            SqlCommand com = new SqlCommand(cadena, Conexion.Abrir());

            int i = com.ExecuteNonQuery();

            Conexion.cerrar();

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        static public bool Actualizar(int index, int id,Producto P, Usuario U) 
        {
            string cadena = "";
            switch (index)
            {
                case 1:
                    cadena = $"update usuarios set documento='{U.Documento}', nombre='{U.Nombre}', apellido='{U.Apellido}', contrasena='{U.Contra1}', cargo='{U.Cargo}' where documento='{id}';;";
                    break;
                case 2:
                    cadena = $"update productos set NomProduc='{P.Nom_producto}', PrecProduc='{P.Precio}', Seccion='{P.Seccion}', DescriProduc='{P.Descrip}' where documento='{id}';;";
                    break;
                default:
                    MessageBox.Show("Error al identificar la tabla");
                    break;
            }

            SqlCommand com = new SqlCommand(cadena,Conexion.Abrir());

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
    }
}
