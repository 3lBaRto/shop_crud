
namespace Shop_Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCargo = new System.Windows.Forms.TextBox();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(169, 86);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(100, 20);
            this.txUsuario.TabIndex = 0;
            // 
            // txContrasena
            // 
            this.txContrasena.Location = new System.Drawing.Point(169, 127);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(100, 20);
            this.txContrasena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(327, 86);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.Registrar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Documento";
            // 
            // txCargo
            // 
            this.txCargo.Location = new System.Drawing.Point(169, 209);
            this.txCargo.Name = "txCargo";
            this.txCargo.Size = new System.Drawing.Size(100, 20);
            this.txCargo.TabIndex = 6;
            // 
            // txDocumento
            // 
            this.txDocumento.Location = new System.Drawing.Point(169, 168);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(100, 20);
            this.txDocumento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(169, 250);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(100, 20);
            this.txApellido.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCargo);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.txUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCargo;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txApellido;
    }
}

