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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        public void limpiar() 
        {
            txUsuario.Text = "";
            txApellido.Text = "";
            txContrasena.Text = "";
            txDocumento.Text = "";
            txCargo.Text = "";
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Usuario U = new Usuario(txUsuario.Text.Trim(), txContrasena.Text.Trim(), txDocumento.Text.Trim(), txApellido.Text.Trim(), txCargo.Text.Trim());

            if (T.ConfirmarU(U) == 1)
            {
                MessageBox.Show("Usuario ya existente");
                limpiar();
            }
            else if (T.ConfirmarU(U) == 0)
            {
                if (T.Insertar_U(U) == true)
                {
                    MessageBox.Show("Usuario registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }
            }
            else
            {
                MessageBox.Show("No registrado, Error");
            }
            
        }
    }
}
