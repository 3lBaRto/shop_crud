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
            if (pFacturacion.Visible == false)
            {
                pFacturacion.Visible = true;
                pAcerca.Visible = false;
                
            }
            else 
            {
                pFacturacion.Visible = false;
            }
            
        }

        private void btNavAcer_Click(object sender, EventArgs e)
        {
            if (pAcerca.Visible == false)
            {
                pAcerca.Visible = true;
                pProductos.Visible = false;
            }
            else 
            {
                pAcerca.Visible = false;
            }
        }

        private void btNavProd_Click(object sender, EventArgs e)
        {
            if (pProductos.Visible == false)
            {
                pProductos.Visible = true;
                pPromociones.Visible = false;
            }
            else 
            {
                pProductos.Visible = false;
            }
        }

        private void btNavPromo_Click(object sender, EventArgs e)
        {
            if (pPromociones.Visible == false)
            {
                pFacturacion.Visible = true;
                pAcerca.Visible = true;
                pProductos.Visible = true;
                pPromociones.Visible = true;
            }
            else 
            {
                pPromociones.Visible = false;
            }
        }
    }
}
