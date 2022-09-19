using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Crud
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = T.generar(0);
                dtg_admin.DataSource = dt.DefaultView;
                index = 1;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = T.generar(1);
                dtg_admin.DataSource = dt.DefaultView;
                index = 2;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void Limpiar() 
        {
            tbProducto.Text = "";
            tbPrecio.Text = "";
            tbSec.Text = "";
            tbDesc.Text = "";
        }
        public void limbiarDTG() 
        {
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            dtg_admin.Columns.Clear();
        }
        private void InsertarP(object sender, EventArgs e)
        {
            if(tbProducto.Text.Length > 1 && tbPrecio.Text.Length > 2 && tbSec.Text.Length > 5) 
            {
                Producto p = new Producto(tbProducto.Text.Trim(),Convert.ToInt32(tbPrecio.Text),tbSec.Text.Trim(),tbDesc.Text.Trim());

                if (T.Insertar_P(p) == true) 
                {
                    MessageBox.Show("Producto registrado correctamente");
                    Limpiar();
                    limbiarDTG();

                }
                else 
                {
                    MessageBox.Show("Proucto no registrado, Error");
                }
            }
            else 
            {
                MessageBox.Show("No se cumplen los parametros para insertar producto");
            }
        }

        int index = 0;
        private void Eliminar(object sender, EventArgs e)
        {
            if(index!=0)
            {
                int i = dtg_admin.CurrentRow.Index;
                int id = 0;
                if (index == 1)
                {
                    id = Convert.ToInt32(dtg_admin.Rows[i].Cells["documento"].Value);
                    if (T.Eliminar(index, id) == true) 
                    {
                        MessageBox.Show("ELiminado con exito");
                        limbiarDTG();
                    }
                    else 
                    {
                        MessageBox.Show("Fracaso al eliminar");
                    }
                }
                else if (index == 2)
                {
                    id = Convert.ToInt32(dtg_admin.Rows[i].Cells["id"].Value);
                    if (T.Eliminar(index, id) == true)
                    {
                        MessageBox.Show("ELiminado con exito");
                        limbiarDTG();
                    }
                    else
                    {
                        MessageBox.Show("Fracaso al eliminar");
                    }
                }




                
            }else
            {

                MessageBox.Show("Debes seleccionar una tabla");
            }
            
                


        }

        private void Actualizar(object sender, EventArgs e)
        {
            if (index != 0) 
            {
                int i = dtg_admin.CurrentRow.Index;
                int id;

                Usuario U = null;
                Producto P = null;

                if (index == 1)
                {
                    id = Convert.ToInt32(dtg_admin.Rows[i].Cells["documento"].Value);



                    //Usuario
                    string nameU = dtg_admin.Rows[i].Cells["nombre"].Value.ToString();
                    string apellidoU = dtg_admin.Rows[i].Cells["apellido"].Value.ToString();
                    string contraU = dtg_admin.Rows[i].Cells["contrasena"].Value.ToString();
                    string cargoU = dtg_admin.Rows[i].Cells["cargo"].Value.ToString();
                    string documenU = dtg_admin.Rows[i].Cells["documento"].Value.ToString();

                    U = new Usuario(nameU, contraU, documenU, apellidoU, cargoU);

                    if (T.Actualizar(index, id, P, U) == true)
                    {
                        MessageBox.Show("Se actualizo con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar");
                    }


                }
                else if (index == 2)
                {
                    id = Convert.ToInt32(dtg_admin.Rows[i].Cells["id"].Value);

                    //producto
                    string nombrePro = dtg_admin.Rows[i].Cells["nom_produc"].Value.ToString();
                    int precioPro = Convert.ToInt32(dtg_admin.Rows[i].Cells["pre_produc"].Value);
                    string seccionPro = dtg_admin.Rows[i].Cells["secc_produc"].Value.ToString();
                    string DescriProc = dtg_admin.Rows[i].Cells["descri_produc"].Value.ToString();

                    P = new Producto(nombrePro, precioPro, DescriProc, seccionPro);

                    if (T.Actualizar(index, id, P, U) == true)
                    {
                        MessageBox.Show("Se actualizo con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar");
                    }

                }
            }else 
            {
                MessageBox.Show("Debes seleccionar una tabla");
            }





            

            

        }
    }
}
