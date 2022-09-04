namespace Shop_Crud
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pNav = new System.Windows.Forms.Panel();
            this.btNavFac = new System.Windows.Forms.Button();
            this.pbNavegador = new System.Windows.Forms.PictureBox();
            this.btNavAcer = new System.Windows.Forms.Button();
            this.btNavProd = new System.Windows.Forms.Button();
            this.btNavPromo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pFacturacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNavegador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pPrincipal.SuspendLayout();
            this.pFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNav
            // 
            this.pNav.BackColor = System.Drawing.Color.Olive;
            this.pNav.Controls.Add(this.pictureBox1);
            this.pNav.Controls.Add(this.btNavPromo);
            this.pNav.Controls.Add(this.btNavProd);
            this.pNav.Controls.Add(this.btNavAcer);
            this.pNav.Controls.Add(this.btNavFac);
            this.pNav.Controls.Add(this.pbNavegador);
            this.pNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNav.Location = new System.Drawing.Point(0, 0);
            this.pNav.Name = "pNav";
            this.pNav.Size = new System.Drawing.Size(800, 60);
            this.pNav.TabIndex = 0;
            // 
            // btNavFac
            // 
            this.btNavFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNavFac.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNavFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNavFac.Location = new System.Drawing.Point(100, 0);
            this.btNavFac.Name = "btNavFac";
            this.btNavFac.Size = new System.Drawing.Size(93, 60);
            this.btNavFac.TabIndex = 13;
            this.btNavFac.Text = "Facturacion";
            this.btNavFac.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btNavFac.UseVisualStyleBackColor = true;
            this.btNavFac.Click += new System.EventHandler(this.Facturar);
            // 
            // pbNavegador
            // 
            this.pbNavegador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbNavegador.Location = new System.Drawing.Point(0, 0);
            this.pbNavegador.Name = "pbNavegador";
            this.pbNavegador.Size = new System.Drawing.Size(100, 60);
            this.pbNavegador.TabIndex = 0;
            this.pbNavegador.TabStop = false;
            // 
            // btNavAcer
            // 
            this.btNavAcer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNavAcer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNavAcer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNavAcer.Location = new System.Drawing.Point(193, 0);
            this.btNavAcer.Name = "btNavAcer";
            this.btNavAcer.Size = new System.Drawing.Size(93, 60);
            this.btNavAcer.TabIndex = 14;
            this.btNavAcer.Text = "Acerca de nosotros";
            this.btNavAcer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btNavAcer.UseVisualStyleBackColor = true;
            // 
            // btNavProd
            // 
            this.btNavProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNavProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNavProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNavProd.Location = new System.Drawing.Point(286, 0);
            this.btNavProd.Name = "btNavProd";
            this.btNavProd.Size = new System.Drawing.Size(93, 60);
            this.btNavProd.TabIndex = 15;
            this.btNavProd.Text = "Productos";
            this.btNavProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btNavProd.UseVisualStyleBackColor = true;
            // 
            // btNavPromo
            // 
            this.btNavPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNavPromo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNavPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNavPromo.Location = new System.Drawing.Point(379, 0);
            this.btNavPromo.Name = "btNavPromo";
            this.btNavPromo.Size = new System.Drawing.Size(93, 60);
            this.btNavPromo.TabIndex = 16;
            this.btNavPromo.Text = "Promociones";
            this.btNavPromo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btNavPromo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(760, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pPrincipal.Controls.Add(this.pFacturacion);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 60);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(800, 390);
            this.pPrincipal.TabIndex = 1;
            // 
            // pFacturacion
            // 
            this.pFacturacion.Controls.Add(this.label1);
            this.pFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFacturacion.Location = new System.Drawing.Point(0, 0);
            this.pFacturacion.Name = "pFacturacion";
            this.pFacturacion.Size = new System.Drawing.Size(800, 390);
            this.pFacturacion.TabIndex = 0;
            this.pFacturacion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "aqui es panel facturacion";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pNav);
            this.Name = "Principal";
            this.Text = "Principal";
            this.pNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNavegador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            this.pFacturacion.ResumeLayout(false);
            this.pFacturacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNav;
        private System.Windows.Forms.Button btNavFac;
        private System.Windows.Forms.PictureBox pbNavegador;
        private System.Windows.Forms.Button btNavPromo;
        private System.Windows.Forms.Button btNavProd;
        private System.Windows.Forms.Button btNavAcer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel pFacturacion;
        private System.Windows.Forms.Label label1;
    }
}