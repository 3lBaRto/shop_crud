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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pNav.Height == 60)
            {
                pbNavegador.Visible = false;
                btNavProd.Visible = false;
                btNavFac.Visible = false;
                btNavAcer.Visible = false;
                btNavPromo.Visible = false;
                pNav.Height = 36;
            }
            else
            {
                pbNavegador.Visible = true;
                btNavProd.Visible = true;
                btNavFac.Visible = true;
                btNavAcer.Visible = true;
                btNavPromo.Visible = true;
                pNav.Height = 60;
            }
        }

        private void Facturar(object sender, EventArgs e)
        {
            pFacturacion.Visible = true;
        }
    }
}
