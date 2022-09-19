
namespace Shop_Crud
{
    partial class panelPromocion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelPromocion));
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenupromo = new System.Windows.Forms.Panel();
            this.panelSubmenupromo = new System.Windows.Forms.Panel();
            this.btnPromonucacambia = new System.Windows.Forms.Button();
            this.btnPromomes = new System.Windows.Forms.Button();
            this.btnSoloesta = new System.Windows.Forms.Button();
            this.btnListapromo = new System.Windows.Forms.Button();
            this.Panellogopromo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenupromo.SuspendLayout();
            this.panelSubmenupromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panelMenupromo
            // 
            this.panelMenupromo.Controls.Add(this.panelSubmenupromo);
            this.panelMenupromo.Controls.Add(this.btnListapromo);
            this.panelMenupromo.Controls.Add(this.Panellogopromo);
            this.panelMenupromo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenupromo.Location = new System.Drawing.Point(0, 0);
            this.panelMenupromo.Name = "panelMenupromo";
            this.panelMenupromo.Size = new System.Drawing.Size(200, 450);
            this.panelMenupromo.TabIndex = 1;
            // 
            // panelSubmenupromo
            // 
            this.panelSubmenupromo.BackColor = System.Drawing.Color.Olive;
            this.panelSubmenupromo.Controls.Add(this.btnPromonucacambia);
            this.panelSubmenupromo.Controls.Add(this.btnPromomes);
            this.panelSubmenupromo.Controls.Add(this.btnSoloesta);
            this.panelSubmenupromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenupromo.Location = new System.Drawing.Point(0, 118);
            this.panelSubmenupromo.Name = "panelSubmenupromo";
            this.panelSubmenupromo.Size = new System.Drawing.Size(200, 90);
            this.panelSubmenupromo.TabIndex = 2;
            // 
            // btnPromonucacambia
            // 
            this.btnPromonucacambia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromonucacambia.FlatAppearance.BorderSize = 0;
            this.btnPromonucacambia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromonucacambia.Location = new System.Drawing.Point(0, 59);
            this.btnPromonucacambia.Name = "btnPromonucacambia";
            this.btnPromonucacambia.Size = new System.Drawing.Size(200, 27);
            this.btnPromonucacambia.TabIndex = 2;
            this.btnPromonucacambia.Text = "Las promos que nunca cambian";
            this.btnPromonucacambia.UseVisualStyleBackColor = true;
            this.btnPromonucacambia.Click += new System.EventHandler(this.btnPromonucacambia_Click);
            // 
            // btnPromomes
            // 
            this.btnPromomes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromomes.FlatAppearance.BorderSize = 0;
            this.btnPromomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromomes.Location = new System.Drawing.Point(0, 31);
            this.btnPromomes.Name = "btnPromomes";
            this.btnPromomes.Size = new System.Drawing.Size(200, 28);
            this.btnPromomes.TabIndex = 1;
            this.btnPromomes.Text = "Promociones mensuales";
            this.btnPromomes.UseVisualStyleBackColor = true;
            this.btnPromomes.Click += new System.EventHandler(this.btnPromomes_Click);
            // 
            // btnSoloesta
            // 
            this.btnSoloesta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoloesta.FlatAppearance.BorderSize = 0;
            this.btnSoloesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoloesta.Location = new System.Drawing.Point(0, 0);
            this.btnSoloesta.Name = "btnSoloesta";
            this.btnSoloesta.Size = new System.Drawing.Size(200, 31);
            this.btnSoloesta.TabIndex = 0;
            this.btnSoloesta.Text = "Solo por esta semana";
            this.btnSoloesta.UseVisualStyleBackColor = true;
            this.btnSoloesta.Click += new System.EventHandler(this.btnSoloesta_Click);
            // 
            // btnListapromo
            // 
            this.btnListapromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListapromo.FlatAppearance.BorderSize = 0;
            this.btnListapromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListapromo.Location = new System.Drawing.Point(0, 83);
            this.btnListapromo.Name = "btnListapromo";
            this.btnListapromo.Size = new System.Drawing.Size(200, 35);
            this.btnListapromo.TabIndex = 1;
            this.btnListapromo.Text = "Lista de promociones";
            this.btnListapromo.UseVisualStyleBackColor = true;
            this.btnListapromo.Click += new System.EventHandler(this.btnListapromo_Click);
            // 
            // Panellogopromo
            // 
            this.Panellogopromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panellogopromo.Location = new System.Drawing.Point(0, 0);
            this.Panellogopromo.Name = "Panellogopromo";
            this.Panellogopromo.Size = new System.Drawing.Size(200, 83);
            this.Panellogopromo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenupromo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "panelPromocion";
            this.Text = "Promocion";
            this.panelMenupromo.ResumeLayout(false);
            this.panelSubmenupromo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenupromo;
        private System.Windows.Forms.Panel panelSubmenupromo;
        private System.Windows.Forms.Button btnPromomes;
        private System.Windows.Forms.Button btnSoloesta;
        private System.Windows.Forms.Button btnListapromo;
        private System.Windows.Forms.Panel Panellogopromo;
        private System.Windows.Forms.Button btnPromonucacambia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}