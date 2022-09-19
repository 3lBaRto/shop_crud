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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            cbProduc.Items.Add("N/A");
            GenerarCB();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void GenerarCB() 
        {
            DataTable dt = T.generar(1);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                
               cbProduc.Items.Add(dt.Rows[i]["nom_produc"].ToString());
                
                
            }
        }

        

        private void cargarPre(object sender, EventArgs e)
        {
            DataTable dt = T.generar(1);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cbProduc.Text.ToString() == dt.Rows[i]["nom_produc"].ToString())
                {
                    
                   lbPrec.Visible = true;
                   lbPrec.Text = dt.Rows[i]["pre_produc"].ToString();


                }
            }

            if(cbProduc.Text == "N/A") 
            {
                lbPrec.Text = "";
            }
        }

        private void agregarProduc(object sender, EventArgs e)
        {
            try
            {
                string producto = cbProduc.Text.ToString();
                int precio = Convert.ToInt32(lbPrec.Text);

                

                if(producto == "N/A") 
                {
                    MessageBox.Show("seleccione algo para agregar");
                }
                else 
                {
                    int i = dtg_Fac.Rows.Add();
                    dtg_Fac.Rows[i].Cells["Producto"].Value = producto;
                    dtg_Fac.Rows[i].Cells["Precio"].Value = precio;

                }
                
            }
            catch (Exception)
            {

               
            }
            
            
            

        }

        private void eliminarProduc(object sender, EventArgs e)
        {
            try
            {
                if (dtg_Fac.SelectedRows.Count > 0)
                {

                    int i = dtg_Fac.CurrentRow.Index;
                    dtg_Fac.Rows.RemoveAt(i);
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila");
                }

            }
            catch (Exception)
            {

                
            }
            
            
            
        }

        private void facturar(object sender, EventArgs e)
        {
            string nombre = txtNom.Text.ToString();
            string apellido = txtApe.Text.ToString();
            string documento = txtDoc.Text.ToString();
            int total = 0;

            for (int i = 0; i < dtg_Fac.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(dtg_Fac.Rows[i].Cells["Precio"].Value);
            }

            if (nombre.Length > 2 && apellido.Length > 2 && documento.Length >= 9)
            {
                pFac.Visible = true;

                nom.Text = nombre;
                ape.Text = apellido;
                doc.Text = documento;
                tot.Text = Convert.ToString(total);
            }
            else 
            {
                MessageBox.Show("No se cumplen los parametros para facturar");
            }
        }

        private void limpiar(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtApe.Text = "";
            txtDoc.Text = "";
            cbProduc.Text = "N/A";
            dtg_Fac.Rows.Clear();
            pFac.Visible = false;
        }
    }
}
