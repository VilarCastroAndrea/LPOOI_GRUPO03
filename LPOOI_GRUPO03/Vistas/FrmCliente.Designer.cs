namespace Vistas
{
    partial class FrmCliente
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
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.panelContenedor2 = new System.Windows.Forms.Panel();
            this.btnListaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAltaCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.ForeColor = System.Drawing.Color.White;
            this.btnAltaCliente.Location = new System.Drawing.Point(123, 12);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(102, 39);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // panelContenedor2
            // 
            this.panelContenedor2.Location = new System.Drawing.Point(15, 50);
            this.panelContenedor2.Name = "panelContenedor2";
            this.panelContenedor2.Size = new System.Drawing.Size(308, 405);
            this.panelContenedor2.TabIndex = 1;
            // 
            // btnListaCliente
            // 
            this.btnListaCliente.BackColor = System.Drawing.Color.Teal;
            this.btnListaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnListaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCliente.ForeColor = System.Drawing.Color.White;
            this.btnListaCliente.Location = new System.Drawing.Point(15, 12);
            this.btnListaCliente.Name = "btnListaCliente";
            this.btnListaCliente.Size = new System.Drawing.Size(102, 39);
            this.btnListaCliente.TabIndex = 2;
            this.btnListaCliente.Text = "Lista Cliente";
            this.btnListaCliente.UseVisualStyleBackColor = false;
            this.btnListaCliente.Click += new System.EventHandler(this.btnListaCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(351, 467);
            this.Controls.Add(this.btnListaCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.panelContenedor2);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor2;
        private System.Windows.Forms.Button btnListaCliente;
        public System.Windows.Forms.Button btnAltaCliente;
    }
}