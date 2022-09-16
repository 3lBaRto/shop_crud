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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing() 
        {
            panelSeccionSubMenu.Visible = false;
                

        }

        private void hideSubMenu()
        {
            if (panelSeccionSubMenu.Visible == true)
                panelSeccionSubMenu.Visible = false;


            
        }

        private void showSubMenu(Panel  subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;


        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeccionSubMenu);
        }

        private void btnSemillas_Click(object sender, EventArgs e)
        {

            openKidForm(new FormSemillas());
            hideSubMenu();
        }

        private void btnFertilizantes_Click(object sender, EventArgs e)
        {
            openKidForm(new FormFertilizantes());
            hideSubMenu();
        }

        private void btnSustratos_Click(object sender, EventArgs e)
        {
            openKidForm(new FormSustratos());
            hideSubMenu();
        }

        private void btnMateras_Click(object sender, EventArgs e)
        {
            openKidForm(new FormMateras());
            hideSubMenu();
        }

        private void btnClones_Click(object sender, EventArgs e)
        {
            openKidForm(new FormClones());
            hideSubMenu();
        }


        private Form activeForm = null;
        private void openKidForm(Form KidForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = KidForm;
            KidForm.TopLevel = false;
            KidForm.FormBorderStyle = FormBorderStyle.None;
            KidForm.Dock = DockStyle.Fill;
            panelKidForm.Controls.Add(KidForm);
            panelKidForm.Tag = KidForm;
            KidForm.BringToFront();
            KidForm.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void productos_Load(object sender, EventArgs e)
        {

        }
    }



    
    
   
}
