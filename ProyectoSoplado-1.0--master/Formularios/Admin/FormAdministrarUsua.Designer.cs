﻿namespace ProyectoSoplado_1._0_.Formularios.Admin
{
    partial class FormAdministrarUsua
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
         this.lblBUsuario = new System.Windows.Forms.Label();
         this.txtBusqueda = new System.Windows.Forms.TextBox();
         this.dgvUsuarios = new System.Windows.Forms.DataGridView();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.btnEditar = new System.Windows.Forms.Button();
         this.btnEliminar = new System.Windows.Forms.Button();
         this.btnCrearUsuario = new System.Windows.Forms.Button();
         this.btnRecepcionPago = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
         this.SuspendLayout();
         // 
         // lblBUsuario
         // 
         this.lblBUsuario.AutoSize = true;
         this.lblBUsuario.Location = new System.Drawing.Point(26, 17);
         this.lblBUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lblBUsuario.Name = "lblBUsuario";
         this.lblBUsuario.Size = new System.Drawing.Size(79, 13);
         this.lblBUsuario.TabIndex = 0;
         this.lblBUsuario.Text = "Buscar Usuario";
         // 
         // txtBusqueda
         // 
         this.txtBusqueda.Location = new System.Drawing.Point(28, 41);
         this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtBusqueda.Name = "txtBusqueda";
         this.txtBusqueda.Size = new System.Drawing.Size(134, 20);
         this.txtBusqueda.TabIndex = 1;
         this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
         // 
         // dgvUsuarios
         // 
         this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvUsuarios.Location = new System.Drawing.Point(186, 17);
         this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.dgvUsuarios.Name = "dgvUsuarios";
         this.dgvUsuarios.RowHeadersWidth = 51;
         this.dgvUsuarios.RowTemplate.Height = 24;
         this.dgvUsuarios.Size = new System.Drawing.Size(185, 160);
         this.dgvUsuarios.TabIndex = 2;
         this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // btnBuscar
         // 
         this.btnBuscar.Location = new System.Drawing.Point(28, 63);
         this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(134, 29);
         this.btnBuscar.TabIndex = 3;
         this.btnBuscar.Text = "Buscar";
         this.btnBuscar.UseVisualStyleBackColor = true;
         // 
         // btnEditar
         // 
         this.btnEditar.Location = new System.Drawing.Point(28, 98);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(62, 19);
         this.btnEditar.TabIndex = 4;
         this.btnEditar.Text = "Editar";
         this.btnEditar.UseVisualStyleBackColor = true;
         // 
         // btnEliminar
         // 
         this.btnEliminar.Location = new System.Drawing.Point(94, 98);
         this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(67, 19);
         this.btnEliminar.TabIndex = 5;
         this.btnEliminar.Text = "Eliminar";
         this.btnEliminar.UseVisualStyleBackColor = true;
         // 
         // btnCrearUsuario
         // 
         this.btnCrearUsuario.Location = new System.Drawing.Point(28, 121);
         this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.btnCrearUsuario.Name = "btnCrearUsuario";
         this.btnCrearUsuario.Size = new System.Drawing.Size(134, 28);
         this.btnCrearUsuario.TabIndex = 6;
         this.btnCrearUsuario.Text = "Crear nuevo Usuario";
         this.btnCrearUsuario.UseVisualStyleBackColor = true;
         // 
         // btnRecepcionPago
         // 
         this.btnRecepcionPago.Location = new System.Drawing.Point(29, 154);
         this.btnRecepcionPago.Name = "btnRecepcionPago";
         this.btnRecepcionPago.Size = new System.Drawing.Size(132, 23);
         this.btnRecepcionPago.TabIndex = 7;
         this.btnRecepcionPago.Text = "Recepción de pago";
         this.btnRecepcionPago.UseVisualStyleBackColor = true;
         this.btnRecepcionPago.Click += new System.EventHandler(this.button1_Click);
         // 
         // FormAdministrarUsua
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(383, 192);
         this.Controls.Add(this.btnRecepcionPago);
         this.Controls.Add(this.btnCrearUsuario);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.btnBuscar);
         this.Controls.Add(this.dgvUsuarios);
         this.Controls.Add(this.txtBusqueda);
         this.Controls.Add(this.lblBUsuario);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "FormAdministrarUsua";
         this.Text = "FormAdministrarUsua";
         ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBUsuario;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrearUsuario;
      private System.Windows.Forms.Button btnRecepcionPago;
   }
}