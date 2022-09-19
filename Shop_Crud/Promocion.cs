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
    public partial class panelPromocion : Form
    {
        public panelPromocion()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSubmenupromo.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubmenupromo.Visible == true)
                panelSubmenupromo.Visible = false;

        }
        private void showSubMenupromo(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;


        }

    

        private void btnListapromo_Click(object sender, EventArgs e)
        {
            showSubMenupromo(panelSubmenupromo);
        }

        private void btnSoloesta_Click(object sender, EventArgs e)
        {
            openpromo(new FormPromocionesSemanales());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openpromo(Form Promocion)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Promocion;
            Promocion.TopLevel = false;
            Promocion.FormBorderStyle = FormBorderStyle.None;
            Promocion.Dock = DockStyle.Fill;
            panelMenupromo.Controls.Add(Promocion);
            panelMenupromo.Tag = Promocion;
            Promocion.BringToFront();
            Promocion.Show();


        }

        private void btnPromomes_Click(object sender, EventArgs e)
        {
            openpromo(new FormPromocionesSemanales());
            hideSubMenu();
        }

        private void btnPromonucacambia_Click(object sender, EventArgs e)
        {
            openpromo(new FormPromocionesSemanales());
            hideSubMenu();
        }
    }
}
