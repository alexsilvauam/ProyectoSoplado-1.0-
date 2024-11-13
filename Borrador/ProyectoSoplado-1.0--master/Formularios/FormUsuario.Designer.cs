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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IniciarSesion));
         this.lbl_InicioSesion = new System.Windows.Forms.Label();
         this.txtNombreUsuario = new System.Windows.Forms.TextBox();
         this.btnEscanearCodigo = new System.Windows.Forms.Button();
         this.btnIngresar = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // lbl_InicioSesion
         // 
         this.lbl_InicioSesion.AutoSize = true;
         this.lbl_InicioSesion.Location = new System.Drawing.Point(301, 87);
         this.lbl_InicioSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lbl_InicioSesion.Name = "lbl_InicioSesion";
         this.lbl_InicioSesion.Size = new System.Drawing.Size(99, 13);
         this.lbl_InicioSesion.TabIndex = 0;
         this.lbl_InicioSesion.Text = "Registrar asistencia";
         this.lbl_InicioSesion.Click += new System.EventHandler(this.label1_Click);
         // 
         // txtNombreUsuario
         // 
         this.txtNombreUsuario.Location = new System.Drawing.Point(303, 111);
         this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtNombreUsuario.Name = "txtNombreUsuario";
         this.txtNombreUsuario.Size = new System.Drawing.Size(154, 20);
         this.txtNombreUsuario.TabIndex = 1;
         this.txtNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // btnEscanearCodigo
         // 
         this.btnEscanearCodigo.Location = new System.Drawing.Point(304, 152);
         this.btnEscanearCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnEscanearCodigo.Name = "btnEscanearCodigo";
         this.btnEscanearCodigo.Size = new System.Drawing.Size(238, 31);
         this.btnEscanearCodigo.TabIndex = 2;
         this.btnEscanearCodigo.Text = "Escanear Codigo de Barras";
         this.btnEscanearCodigo.UseVisualStyleBackColor = true;
         this.btnEscanearCodigo.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnIngresar
         // 
         this.btnIngresar.Location = new System.Drawing.Point(460, 106);
         this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(81, 28);
         this.btnIngresar.TabIndex = 3;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = true;
         this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 32);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(235, 247);
         this.pictureBox1.TabIndex = 5;
         this.pictureBox1.TabStop = false;
         // 
         // frm_IniciarSesion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(552, 297);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnIngresar);
         this.Controls.Add(this.btnEscanearCodigo);
         this.Controls.Add(this.txtNombreUsuario);
         this.Controls.Add(this.lbl_InicioSesion);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "frm_IniciarSesion";
         this.Text = "Iniciar Sesión";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_InicioSesion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnEscanearCodigo;
        private System.Windows.Forms.Button btnIngresar;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}

