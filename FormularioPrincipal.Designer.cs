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
            this.btnAccesoUsuario = new System.Windows.Forms.Button();
            this.btnAccesoAdmin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccesoUsuario
            // 
            this.btnAccesoUsuario.Location = new System.Drawing.Point(50, 50);
            this.btnAccesoUsuario.Name = "btnAccesoUsuario";
            this.btnAccesoUsuario.Size = new System.Drawing.Size(200, 40);
            this.btnAccesoUsuario.TabIndex = 0;
            this.btnAccesoUsuario.Text = "Ingresar Miembro";
            this.btnAccesoUsuario.UseVisualStyleBackColor = true;
            this.btnAccesoUsuario.Click += new System.EventHandler(this.btnAccesoUsuario_Click);
            // 
            // btnAccesoAdmin
            // 
            this.btnAccesoAdmin.Location = new System.Drawing.Point(50, 100);
            this.btnAccesoAdmin.Name = "btnAccesoAdmin";
            this.btnAccesoAdmin.Size = new System.Drawing.Size(200, 40);
            this.btnAccesoAdmin.TabIndex = 1;
            this.btnAccesoAdmin.Text = "Ingreso Administrador";
            this.btnAccesoAdmin.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(75, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Seleccione una opción";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAccesoAdmin);
            this.Controls.Add(this.btnAccesoUsuario);
            this.Name = "FormularioPrincipal";
            this.Text = "Acceso al gimnasio";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccesoUsuario;
        private System.Windows.Forms.Button btnAccesoAdmin;
        private System.Windows.Forms.Label lblTitulo;
    }
}