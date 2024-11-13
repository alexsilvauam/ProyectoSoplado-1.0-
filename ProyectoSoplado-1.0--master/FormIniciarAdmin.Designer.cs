namespace ProyectoSoplado_1._0_
{
   partial class FormIniciarAdmin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarAdmin));
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btnIngresar = new System.Windows.Forms.Button();
         this.txtNombreUsuario = new System.Windows.Forms.TextBox();
         this.lbl_InicioSesion = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.lblContraseña = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(235, 247);
         this.pictureBox1.TabIndex = 10;
         this.pictureBox1.TabStop = false;
         // 
         // btnIngresar
         // 
         this.btnIngresar.Location = new System.Drawing.Point(252, 121);
         this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(81, 28);
         this.btnIngresar.TabIndex = 9;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = true;
         // 
         // txtNombreUsuario
         // 
         this.txtNombreUsuario.Location = new System.Drawing.Point(252, 33);
         this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
         this.txtNombreUsuario.Name = "txtNombreUsuario";
         this.txtNombreUsuario.Size = new System.Drawing.Size(154, 20);
         this.txtNombreUsuario.TabIndex = 7;
         // 
         // lbl_InicioSesion
         // 
         this.lbl_InicioSesion.AutoSize = true;
         this.lbl_InicioSesion.Location = new System.Drawing.Point(249, 18);
         this.lbl_InicioSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lbl_InicioSesion.Name = "lbl_InicioSesion";
         this.lbl_InicioSesion.Size = new System.Drawing.Size(96, 13);
         this.lbl_InicioSesion.TabIndex = 6;
         this.lbl_InicioSesion.Text = "Nombre de usuario";
         this.lbl_InicioSesion.Click += new System.EventHandler(this.lbl_InicioSesion_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(252, 86);
         this.textBox1.Margin = new System.Windows.Forms.Padding(2);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(154, 20);
         this.textBox1.TabIndex = 12;
         // 
         // lblContraseña
         // 
         this.lblContraseña.AutoSize = true;
         this.lblContraseña.Location = new System.Drawing.Point(249, 71);
         this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lblContraseña.Name = "lblContraseña";
         this.lblContraseña.Size = new System.Drawing.Size(61, 13);
         this.lblContraseña.TabIndex = 11;
         this.lblContraseña.Text = "Contraseña";
         // 
         // FormIniciarAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(425, 212);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.lblContraseña);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnIngresar);
         this.Controls.Add(this.txtNombreUsuario);
         this.Controls.Add(this.lbl_InicioSesion);
         this.Name = "FormIniciarAdmin";
         this.Text = "FormIniciarAdmin";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button btnIngresar;
      private System.Windows.Forms.TextBox txtNombreUsuario;
      private System.Windows.Forms.Label lbl_InicioSesion;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label lblContraseña;
   }
}