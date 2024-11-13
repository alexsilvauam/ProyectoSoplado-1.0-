namespace ProyectoSoplado_1._0_
{
    partial class FormularioPrincipal
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
         this.btnAccesoUsuario = new System.Windows.Forms.Button();
         this.btnAccesoAdmin = new System.Windows.Forms.Button();
         this.lblTitulo = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnAccesoUsuario
         // 
         this.btnAccesoUsuario.Location = new System.Drawing.Point(297, 107);
         this.btnAccesoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnAccesoUsuario.Name = "btnAccesoUsuario";
         this.btnAccesoUsuario.Size = new System.Drawing.Size(150, 43);
         this.btnAccesoUsuario.TabIndex = 0;
         this.btnAccesoUsuario.Text = "Ingresar Miembro";
         this.btnAccesoUsuario.UseVisualStyleBackColor = true;
         this.btnAccesoUsuario.Click += new System.EventHandler(this.btnAccesoUsuario_Click);
         // 
         // btnAccesoAdmin
         // 
         this.btnAccesoAdmin.Location = new System.Drawing.Point(297, 166);
         this.btnAccesoAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnAccesoAdmin.Name = "btnAccesoAdmin";
         this.btnAccesoAdmin.Size = new System.Drawing.Size(150, 43);
         this.btnAccesoAdmin.TabIndex = 1;
         this.btnAccesoAdmin.Text = "Ingreso Administrador";
         this.btnAccesoAdmin.UseVisualStyleBackColor = true;
         // 
         // lblTitulo
         // 
         this.lblTitulo.AutoSize = true;
         this.lblTitulo.Location = new System.Drawing.Point(315, 84);
         this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lblTitulo.Name = "lblTitulo";
         this.lblTitulo.Size = new System.Drawing.Size(116, 13);
         this.lblTitulo.TabIndex = 2;
         this.lblTitulo.Text = "Seleccione una opción";
         this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(235, 247);
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // FormularioPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 261);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.lblTitulo);
         this.Controls.Add(this.btnAccesoAdmin);
         this.Controls.Add(this.btnAccesoUsuario);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "FormularioPrincipal";
         this.ShowInTaskbar = false;
         this.Text = "Acceso al gimnasio";
         this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccesoUsuario;
        private System.Windows.Forms.Button btnAccesoAdmin;
        private System.Windows.Forms.Label lblTitulo;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}