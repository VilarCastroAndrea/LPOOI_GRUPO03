namespace Vistas
{
    partial class FrmVehiculo
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
            this.btnAVeh = new System.Windows.Forms.Button();
            this.panelVehiculo = new System.Windows.Forms.Panel();
            this.panelListaVehiculo = new System.Windows.Forms.Panel();
            this.btnBusacar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dataVehiculo = new System.Windows.Forms.DataGridView();
            this.panelListaVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaVeh
            // 
            this.btnListaVeh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVeh.ForeColor = System.Drawing.Color.White;
            this.btnListaVeh.Location = new System.Drawing.Point(656, 18);
            this.btnListaVeh.Name = "btnListaVeh";
            this.btnListaVeh.Size = new System.Drawing.Size(100, 38);
            this.btnListaVeh.TabIndex = 1;
            this.btnListaVeh.Text = "Mostrar";
            this.btnListaVeh.UseVisualStyleBackColor = false;
            this.btnListaVeh.Click += new System.EventHandler(this.btnListaVeh_Click);
            // 
            // btnAVeh
            // 
            this.btnAVeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAVeh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAVeh.ForeColor = System.Drawing.Color.White;
            this.btnAVeh.Location = new System.Drawing.Point(760, 18);
            this.btnAVeh.Name = "btnAVeh";
            this.btnAVeh.Size = new System.Drawing.Size(100, 38);
            this.btnAVeh.TabIndex = 2;
            this.btnAVeh.Text = "Nuevo Vehiculo";
            this.btnAVeh.UseVisualStyleBackColor = false;
            this.btnAVeh.Click += new System.EventHandler(this.btnAVeh_Click);
            // 
            // panelVehiculo
            // 
            this.panelVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.panelVehiculo.Location = new System.Drawing.Point(656, 56);
            this.panelVehiculo.Name = "panelVehiculo";
            this.panelVehiculo.Size = new System.Drawing.Size(205, 399);
            this.panelVehiculo.TabIndex = 26;
            // 
            // panelListaVehiculo
            // 
            this.panelListaVehiculo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelListaVehiculo.Controls.Add(this.btnBusacar);
            this.panelListaVehiculo.Controls.Add(this.label7);
            this.panelListaVehiculo.Controls.Add(this.txtBuscarC);
            this.panelListaVehiculo.Controls.Add(this.dataVehiculo);
            this.panelListaVehiculo.Location = new System.Drawing.Point(13, 18);
            this.panelListaVehiculo.Name = "panelListaVehiculo";
            this.panelListaVehiculo.Size = new System.Drawing.Size(637, 437);
            this.panelListaVehiculo.TabIndex = 25;
            // 
            // btnBusacar
            // 
            this.btnBusacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBusacar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusacar.ForeColor = System.Drawing.Color.White;
            this.btnBusacar.Location = new System.Drawing.Point(427, 23);
            this.btnBusacar.Name = "btnBusacar";
            this.btnBusacar.Size = new System.Drawing.Size(85, 22);
            this.btnBusacar.TabIndex = 4;
            this.btnBusacar.Text = "Buscar";
            this.btnBusacar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Buscar";
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(80, 25);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(331, 20);
            this.txtBuscarC.TabIndex = 2;
            // 
            // dataVehiculo
            // 
            this.dataVehiculo.BackgroundColor = System.Drawing.Color.White;
            this.dataVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculo.Location = new System.Drawing.Point(19, 63);
            this.dataVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.dataVehiculo.Name = "dataVehiculo";
            this.dataVehiculo.RowTemplate.Height = 24;
            this.dataVehiculo.Size = new System.Drawing.Size(598, 355);
            this.dataVehiculo.TabIndex = 1;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.panelVehiculo);
            this.Controls.Add(this.panelListaVehiculo);
            this.Controls.Add(this.btnListaVeh);
            this.Controls.Add(this.btnAVeh);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.panelListaVehiculo.ResumeLayout(false);
            this.panelListaVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListaVeh;
        private System.Windows.Forms.Button btnAVeh;
        private System.Windows.Forms.Panel panelVehiculo;
        private System.Windows.Forms.Panel panelListaVehiculo;
        private System.Windows.Forms.Button btnBusacar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarC;
        public System.Windows.Forms.DataGridView dataVehiculo;
    }
}