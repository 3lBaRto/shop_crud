
namespace Shop_Crud
{
    partial class Facturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_Fac = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.cbProduc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrec = new System.Windows.Forms.Label();
            this.pFac = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tot = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.doc = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Fac)).BeginInit();
            this.pFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarProduc);
            // 
            // dtg_Fac
            // 
            this.dtg_Fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Fac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio});
            this.dtg_Fac.Location = new System.Drawing.Point(405, 132);
            this.dtg_Fac.Name = "dtg_Fac";
            this.dtg_Fac.Size = new System.Drawing.Size(243, 313);
            this.dtg_Fac.TabIndex = 2;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.facturar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.eliminarProduc);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Documento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(149, 48);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(198, 20);
            this.txtNom.TabIndex = 7;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(149, 100);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(198, 20);
            this.txtDoc.TabIndex = 8;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(149, 74);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(198, 20);
            this.txtApe.TabIndex = 9;
            // 
            // cbProduc
            // 
            this.cbProduc.FormattingEnabled = true;
            this.cbProduc.Location = new System.Drawing.Point(405, 73);
            this.cbProduc.Name = "cbProduc";
            this.cbProduc.Size = new System.Drawing.Size(121, 21);
            this.cbProduc.TabIndex = 10;
            this.cbProduc.SelectedIndexChanged += new System.EventHandler(this.cargarPre);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(402, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Productos";
            // 
            // lbPrec
            // 
            this.lbPrec.AutoSize = true;
            this.lbPrec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrec.Location = new System.Drawing.Point(546, 76);
            this.lbPrec.Name = "lbPrec";
            this.lbPrec.Size = new System.Drawing.Size(36, 13);
            this.lbPrec.TabIndex = 12;
            this.lbPrec.Text = "precio";
            this.lbPrec.Visible = false;
            // 
            // pFac
            // 
            this.pFac.Controls.Add(this.tot);
            this.pFac.Controls.Add(this.label12);
            this.pFac.Controls.Add(this.doc);
            this.pFac.Controls.Add(this.ape);
            this.pFac.Controls.Add(this.nom);
            this.pFac.Controls.Add(this.label5);
            this.pFac.Controls.Add(this.label6);
            this.pFac.Controls.Add(this.label7);
            this.pFac.Location = new System.Drawing.Point(62, 171);
            this.pFac.Name = "pFac";
            this.pFac.Size = new System.Drawing.Size(256, 274);
            this.pFac.TabIndex = 13;
            this.pFac.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.limpiar);
            // 
            // tot
            // 
            this.tot.AutoSize = true;
            this.tot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tot.Location = new System.Drawing.Point(145, 149);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(19, 13);
            this.tot.TabIndex = 14;
            this.tot.Text = "tot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(77, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total";
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doc.Location = new System.Drawing.Point(145, 120);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(25, 13);
            this.doc.TabIndex = 12;
            this.doc.Text = "doc";
            // 
            // ape
            // 
            this.ape.AutoSize = true;
            this.ape.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ape.Location = new System.Drawing.Point(145, 94);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(25, 13);
            this.ape.TabIndex = 11;
            this.ape.Text = "ape";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nom.Location = new System.Drawing.Point(145, 64);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(27, 13);
            this.nom.TabIndex = 10;
            this.nom.Text = "nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(77, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(77, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(77, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(859, 457);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pFac);
            this.Controls.Add(this.lbPrec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProduc);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtg_Fac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Fac)).EndInit();
            this.pFac.ResumeLayout(false);
            this.pFac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_Fac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.ComboBox cbProduc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel pFac;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label tot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label doc;
        private System.Windows.Forms.Label ape;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}