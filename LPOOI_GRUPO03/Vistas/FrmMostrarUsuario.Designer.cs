namespace Vistas
{
    partial class FrmMostrarUsuario
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
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreApellidoUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtNombreApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(140, 170);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 23;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRolUsuario.Location = new System.Drawing.Point(32, 176);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(23, 13);
            this.lblRolUsuario.TabIndex = 22;
            this.lblRolUsuario.Text = "Rol";
            // 
            // lblNombreApellidoUsuario
            // 
            this.lblNombreApellidoUsuario.AutoSize = true;
            this.lblNombreApellidoUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreApellidoUsuario.Location = new System.Drawing.Point(32, 150);
            this.lblNombreApellidoUsuario.Name = "lblNombreApellidoUsuario";
            this.lblNombreApellidoUsuario.Size = new System.Drawing.Size(91, 13);
            this.lblNombreApellidoUsuario.TabIndex = 21;
            this.lblNombreApellidoUsuario.Text = "Nombre y apellido";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(32, 117);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(32, 93);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 19;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIDUsuario.Location = new System.Drawing.Point(32, 58);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblIDUsuario.TabIndex = 18;
            this.lblIDUsuario.Text = "Id Usuario";
            // 
            // txtNombreApellidoUsuario
            // 
            this.txtNombreApellidoUsuario.Location = new System.Drawing.Point(140, 143);
            this.txtNombreApellidoUsuario.Name = "txtNombreApellidoUsuario";
            this.txtNombreApellidoUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtNombreApellidoUsuario.TabIndex = 17;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 86);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtNombreUsuario.TabIndex = 16;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(140, 117);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 20);
            this.txtPass.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(140, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 14;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(161, 242);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 29);
            this.btnEliminarUsuario.TabIndex = 25;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Enabled = false;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(23, 242);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(100, 29);
            this.btnActualizarUsuario.TabIndex = 24;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmMostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(287, 341);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblNombreApellidoUsuario);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.txtNombreApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtId);
            this.Name = "FrmMostrarUsuario";
            this.Text = "FrmMostrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreApellidoUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtNombreApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnActualizarUsuario;
    }
}