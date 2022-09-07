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
            tbDesc.Text = "";
        }

        private void InsertarP(object sender, EventArgs e)
        {
            if(tbProducto.Text.Length > 1 && tbPrecio.Text.Length > 2 && tbDesc.Text.Length > 5) 
            {
                Producto p = new Producto(tbProducto.Text.Trim(),Convert.ToInt16(tbPrecio.Text),tbDesc.Text.Trim());
                if (T.Insertar_P(p) == true) 
                {
                    MessageBox.Show("Producto registrado correctamente");
                    Limpiar();

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

        private void Eliminar(object sender, EventArgs e)
        {
            int i = dtg_admin.CurrentRow.Index;

            int id = dtg_admin.Rows[i].Cells["id"]
                //aqui continuar


        }
    }
}
