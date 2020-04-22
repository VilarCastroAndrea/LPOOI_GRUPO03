namespace Vistas
{
    partial class FrmListaCliente
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
            this.dataCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(28, 51);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowTemplate.Height = 24;
            this.dataCliente.Size = new System.Drawing.Size(332, 366);
            this.dataCliente.TabIndex = 0;
            // 
            // FrmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.dataCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListaCliente";
            this.Text = "FrmListaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataCliente;
    }
}