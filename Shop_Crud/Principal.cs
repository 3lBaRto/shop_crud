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
        private Form FormActivo = null;
        private void AbrirForm(Form XForm)
        {
            // ActiveForm obtiene el formulario activo para cuestionar si existe y 
            //cerrarlo
            /*
            if (FormActivo != null) 
            {
                ActiveForm.Close();
            }*/
            //Usamos el form creado anteriormente para coger el parametro
            //luego editamos ese formulario, evitando que sea otra ventana
            //y quitamos su borde para terminar editando su propiedad DOCK
            FormActivo = XForm;
            XForm.TopLevel = false;
            XForm.FormBorderStyle = FormBorderStyle.None;
            XForm.Dock = DockStyle.Fill;

            //Por ultimo lo igualamos al controlador del panel 
            pPrincipal.Controls.Add(XForm);

            //
            pPrincipal.Tag = XForm;
            XForm.BringToFront();
            XForm.Show();


        }

        private void MostrarFac(object sender, EventArgs e)
        {
            Facturacion f = new Facturacion();

            if (f == ActiveForm)
            {
                f.Close();
            }
            else
            {

                AbrirForm(f);
            }
        }

        private void Acerca(object sender, EventArgs e)
        {
            Acerca_de C = new Acerca_de();

            if (C == ActiveForm)
            {
                C.Close();
            }
            else
            {

                AbrirForm(C);
            }

        }
        private void Produc(object sender, EventArgs e)
        {
            productos p = new productos();

            if (p == ActiveForm)
            {
                p.Close();
            }
            else
            {

                AbrirForm(p);
            }
        }
        private void Promo(object sender, EventArgs e)
        {
            Promocion g = new Promocion();

            if (g == ActiveForm)
            {
                g.Close();
            }
            else
            {

                AbrirForm(g);
            }
        }

    }
}
