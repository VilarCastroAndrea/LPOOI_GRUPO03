namespace Vistas
{
    partial class FrmAltaCliente
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
            this.btnAltaClinte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtANombre = new System.Windows.Forms.TextBox();
            this.txtAApellido = new System.Windows.Forms.TextBox();
            this.txtATelefono = new System.Windows.Forms.TextBox();
            this.txtADireccion = new System.Windows.Forms.TextBox();
            this.lblClinte = new System.Windows.Forms.Label();
            this.txtADNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltaClinte
            // 
            this.btnAltaClinte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaClinte.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaClinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaClinte.ForeColor = System.Drawing.Color.White;
            this.btnAltaClinte.Location = new System.Drawing.Point(193, 331);
            this.btnAltaClinte.Name = "btnAltaClinte";
            this.btnAltaClinte.Size = new System.Drawing.Size(92, 23);
            this.btnAltaClinte.TabIndex = 0;
            this.btnAltaClinte.Text = "Agregar";
            this.btnAltaClinte.UseVisualStyleBackColor = false;
            this.btnAltaClinte.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // txtANombre
            // 
            this.txtANombre.Location = new System.Drawing.Point(46, 124);
            this.txtANombre.Name = "txtANombre";
            this.txtANombre.Size = new System.Drawing.Size(239, 20);
            this.txtANombre.TabIndex = 5;
            // 
            // txtAApellido
            // 
            this.txtAApellido.Location = new System.Drawing.Point(46, 169);
            this.txtAApellido.Name = "txtAApellido";
            this.txtAApellido.Size = new System.Drawing.Size(239, 20);
            this.txtAApellido.TabIndex = 6;
            // 
            // txtATelefono
            // 
            this.txtATelefono.Location = new System.Drawing.Point(46, 256);
            this.txtATelefono.Name = "txtATelefono";
            this.txtATelefono.Size = new System.Drawing.Size(239, 20);
            this.txtATelefono.TabIndex = 7;
            // 
            // txtADireccion
            // 
            this.txtADireccion.Location = new System.Drawing.Point(46, 214);
            this.txtADireccion.Name = "txtADireccion";
            this.txtADireccion.Size = new System.Drawing.Size(239, 20);
            this.txtADireccion.TabIndex = 8;
            // 
            // lblClinte
            // 
            this.lblClinte.AutoSize = true;
            this.lblClinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinte.ForeColor = System.Drawing.Color.White;
            this.lblClinte.Location = new System.Drawing.Point(135, 24);
            this.lblClinte.Name = "lblClinte";
            this.lblClinte.Size = new System.Drawing.Size(161, 25);
            this.lblClinte.TabIndex = 9;
            this.lblClinte.Text = "Agregar Cliente";
            // 
            // txtADNI
            // 
            this.txtADNI.Location = new System.Drawing.Point(46, 85);
            this.txtADNI.Name = "txtADNI";
            this.txtADNI.Size = new System.Drawing.Size(239, 20);
            this.txtADNI.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DNI";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.txtADNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClinte);
            this.Controls.Add(this.txtADireccion);
            this.Controls.Add(this.txtATelefono);
            this.Controls.Add(this.txtAApellido);
            this.Controls.Add(this.txtANombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaClinte);
            this.Name = "FrmAltaCliente";
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaClinte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtANombre;
        private System.Windows.Forms.TextBox txtAApellido;
        private System.Windows.Forms.TextBox txtATelefono;
        private System.Windows.Forms.TextBox txtADireccion;
        private System.Windows.Forms.Label lblClinte;
        private System.Windows.Forms.TextBox txtADNI;
        private System.Windows.Forms.Label label5;
    }
}