namespace Vistas
{
    partial class FrmVenta
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
            this.btnListaVeh = new System.Windows.Forms.Button();
            this.panelContenedorListaVentas = new System.Windows.Forms.Panel();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaVeh
            // 
            this.btnListaVeh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVeh.ForeColor = System.Drawing.Color.White;
            this.btnListaVeh.Location = new System.Drawing.Point(16, 32);
            this.btnListaVeh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListaVeh.Name = "btnListaVeh";
            this.btnListaVeh.Size = new System.Drawing.Size(136, 48);
            this.btnListaVeh.TabIndex = 2;
            this.btnListaVeh.Text = "Lista Venta";
            this.btnListaVeh.UseVisualStyleBackColor = false;
            this.btnListaVeh.Click += new System.EventHandler(this.btnListaVeh_Click);
            // 
            // panelContenedorListaVentas
            // 
            this.panelContenedorListaVentas.Location = new System.Drawing.Point(16, 87);
            this.panelContenedorListaVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorListaVentas.Name = "panelContenedorListaVentas";
            this.panelContenedorListaVentas.Size = new System.Drawing.Size(1281, 498);
            this.panelContenedorListaVentas.TabIndex = 1;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(160, 32);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(136, 48);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1313, 601);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnListaVeh);
            this.Controls.Add(this.panelContenedorListaVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListaVeh;
        private System.Windows.Forms.Panel panelContenedorListaVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
    }
}