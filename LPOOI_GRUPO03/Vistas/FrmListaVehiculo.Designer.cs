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
            this.dataVehiculos.Location = new System.Drawing.Point(13, 34);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.RowTemplate.Height = 24;
            this.dataVehiculos.Size = new System.Drawing.Size(385, 357);
            this.dataVehiculos.TabIndex = 0;
            // 
            // FrmListaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.dataVehiculos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListaVehiculo";
            this.Text = "FrmListaVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataVehiculos;
    }
}