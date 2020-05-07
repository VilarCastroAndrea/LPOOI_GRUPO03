namespace Vistas
{
    partial class FrmListaVenta
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
            this.dataVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVentas
            // 
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(12, 36);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.Size = new System.Drawing.Size(736, 318);
            this.dataVentas.TabIndex = 0;
            // 
            // FrmListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(773, 366);
            this.Controls.Add(this.dataVentas);
            this.Name = "FrmListaVenta";
            this.Text = "Lista de Ventas ";
            this.Load += new System.EventHandler(this.FrmListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVentas;
    }
}