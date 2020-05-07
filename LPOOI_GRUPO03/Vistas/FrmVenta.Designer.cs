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
            this.panelContenedorListaVentas = new System.Windows.Forms.Panel();
            this.btnListaVeh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContenedorListaVentas
            // 
            this.panelContenedorListaVentas.Location = new System.Drawing.Point(12, 71);
            this.panelContenedorListaVentas.Name = "panelContenedorListaVentas";
            this.panelContenedorListaVentas.Size = new System.Drawing.Size(308, 405);
            this.panelContenedorListaVentas.TabIndex = 1;
            // 
            // btnListaVeh
            // 
            this.btnListaVeh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVeh.ForeColor = System.Drawing.Color.White;
            this.btnListaVeh.Location = new System.Drawing.Point(12, 26);
            this.btnListaVeh.Name = "btnListaVeh";
            this.btnListaVeh.Size = new System.Drawing.Size(102, 39);
            this.btnListaVeh.TabIndex = 2;
            this.btnListaVeh.Text = "Lista Venta";
            this.btnListaVeh.UseVisualStyleBackColor = false;
            this.btnListaVeh.Click += new System.EventHandler(this.btnListaVeh_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(985, 488);
            this.Controls.Add(this.btnListaVeh);
            this.Controls.Add(this.panelContenedorListaVentas);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorListaVentas;
        private System.Windows.Forms.Button btnListaVeh;
    }
}