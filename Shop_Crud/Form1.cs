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
            
        }



        private void Registrar(object sender, EventArgs e)
        {
            Registrarse f = new Registrarse();
            f.ShowDialog();
        }

        private void iniciar(object sender, EventArgs e)
        {
            
            Principal f = new Principal();
            Usuario U = new Usuario(txUsuario.Text.Trim(), txContrasena.Text.Trim(), "", "", "");
            if (T.ConfirmarU(U) == true)
            {
                this.Hide();
                f.ShowDialog();
                
            } else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }
    }
}
