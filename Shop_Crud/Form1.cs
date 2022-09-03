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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        public void limpiar() 
        {
            txUsuario.Text = "";
            txContrasena.Text = "";
            txApellido.Text = "";
            txCargo.Text = "";
            txDocumento.Text = "";
        }



        private void Registrar(object sender, EventArgs e)
        {
            Usuario U = new Usuario(txUsuario.Text.Trim(),txContrasena.Text.Trim(),txDocumento.Text.Trim(),txApellido.Text.Trim(),txCargo.Text.Trim());

            if (T.ConfirmarU(U) == true)
            {
                MessageBox.Show("Usuario ya existente");
                limpiar();
            }
            else if (T.Insertar(U) == true)
            {
                MessageBox.Show("se logro registrar con exito");
                limpiar();
            }
            else 
            {
                MessageBox.Show("No se logro registrar ");
            }
        }

       

        
    }
}
