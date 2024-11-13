namespace ProyectoSoplado_1._0_
{
    partial class FormAdmin
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
         this.lblPanel = new System.Windows.Forms.Label();
         this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
         this.btnRegistrarUsuario = new System.Windows.Forms.Button();
         this.btnReportesAsistencia = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblPanel
         // 
         this.lblPanel.AutoSize = true;
         this.lblPanel.Location = new System.Drawing.Point(22, 17);
         this.lblPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lblPanel.Name = "lblPanel";
         this.lblPanel.Size = new System.Drawing.Size(115, 13);
         this.lblPanel.TabIndex = 0;
         this.lblPanel.Text = "Panel de Administrador";
         // 
         // btnAdministrarUsuarios
         // 
         this.btnAdministrarUsuarios.Location = new System.Drawing.Point(24, 45);
         this.btnAdministrarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
         this.btnAdministrarUsuarios.Size = new System.Drawing.Size(113, 29);
         this.btnAdministrarUsuarios.TabIndex = 1;
         this.btnAdministrarUsuarios.Text = "Administrar Usuarios";
         this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
         this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnad_Click);
         // 
         // btnRegistrarUsuario
         // 
         this.btnRegistrarUsuario.Location = new System.Drawing.Point(25, 79);
         this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
         this.btnRegistrarUsuario.Size = new System.Drawing.Size(113, 29);
         this.btnRegistrarUsuario.TabIndex = 2;
         this.btnRegistrarUsuario.Text = "Registrar Usuario";
         this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
         // 
         // btnReportesAsistencia
         // 
         this.btnReportesAsistencia.Location = new System.Drawing.Point(25, 114);
         this.btnReportesAsistencia.Name = "btnReportesAsistencia";
         this.btnReportesAsistencia.Size = new System.Drawing.Size(112, 36);
         this.btnReportesAsistencia.TabIndex = 3;
         this.btnReportesAsistencia.Text = "Reportes de asistencia";
         this.btnReportesAsistencia.UseVisualStyleBackColor = true;
         // 
         // FormAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(557, 275);
         this.Controls.Add(this.btnReportesAsistencia);
         this.Controls.Add(this.btnRegistrarUsuario);
         this.Controls.Add(this.btnAdministrarUsuarios);
         this.Controls.Add(this.lblPanel);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "FormAdmin";
         this.Text = "FormAdmin";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
      private System.Windows.Forms.Button btnRegistrarUsuario;
      private System.Windows.Forms.Button btnReportesAsistencia;
   }
}