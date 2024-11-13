namespace ProyectoSoplado_1._0_
{
    partial class frm_IniciarSesion
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
            this.lbl_InicioSesion = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnEscanearCodigo = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEscanearQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_InicioSesion
            // 
            this.lbl_InicioSesion.AutoSize = true;
            this.lbl_InicioSesion.Location = new System.Drawing.Point(8, 21);
            this.lbl_InicioSesion.Name = "lbl_InicioSesion";
            this.lbl_InicioSesion.Size = new System.Drawing.Size(102, 16);
            this.lbl_InicioSesion.TabIndex = 0;
            this.lbl_InicioSesion.Text = "Inicio de Sesión";
            this.lbl_InicioSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(10, 50);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(204, 22);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEscanearCodigo
            // 
            this.btnEscanearCodigo.Location = new System.Drawing.Point(10, 90);
            this.btnEscanearCodigo.Name = "btnEscanearCodigo";
            this.btnEscanearCodigo.Size = new System.Drawing.Size(285, 23);
            this.btnEscanearCodigo.TabIndex = 2;
            this.btnEscanearCodigo.Text = "Escanear Codigo de Barras";
            this.btnEscanearCodigo.UseVisualStyleBackColor = true;
            this.btnEscanearCodigo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(220, 50);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEscanearQR
            // 
            this.btnEscanearQR.Location = new System.Drawing.Point(10, 133);
            this.btnEscanearQR.Name = "btnEscanearQR";
            this.btnEscanearQR.Size = new System.Drawing.Size(285, 29);
            this.btnEscanearQR.TabIndex = 4;
            this.btnEscanearQR.Text = "Escanear Código QR\n";
            this.btnEscanearQR.UseVisualStyleBackColor = true;
            // 
            // frm_IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 200);
            this.Controls.Add(this.btnEscanearQR);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnEscanearCodigo);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lbl_InicioSesion);
            this.Name = "frm_IniciarSesion";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_InicioSesion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnEscanearCodigo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEscanearQR;
    }
}

