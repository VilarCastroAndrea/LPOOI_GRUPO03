namespace Vistas
{
    partial class FrmListaVehiculo
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
            this.dataVehiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVehiculos
            // 
            this.dataVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculos.Location = new System.Drawing.Point(7, 28);
            this.dataVehiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.RowTemplate.Height = 24;
            this.dataVehiculos.Size = new System.Drawing.Size(289, 290);
            this.dataVehiculos.TabIndex = 0;
            this.dataVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVehiculos_CellContentClick);
            // 
            // FrmListaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.dataVehiculos);
            this.Name = "FrmListaVehiculo";
            this.Text = "FrmListaVehiculo";
            this.Load += new System.EventHandler(this.FrmListaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataVehiculos;
    }
}