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
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.panelListaVenta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnBusacar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataVenta = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnFechaInicio = new System.Windows.Forms.Button();
            this.panelListaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(1012, 23);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(136, 46);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.Transparent;
            this.panelVenta.Location = new System.Drawing.Point(875, 68);
            this.panelVenta.Margin = new System.Windows.Forms.Padding(4);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(273, 492);
            this.panelVenta.TabIndex = 26;
            // 
            // panelListaVenta
            // 
            this.panelListaVenta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelListaVenta.Controls.Add(this.btnFechaInicio);
            this.panelListaVenta.Controls.Add(this.label4);
            this.panelListaVenta.Controls.Add(this.label3);
            this.panelListaVenta.Controls.Add(this.cmbMarca);
            this.panelListaVenta.Controls.Add(this.label2);
            this.panelListaVenta.Controls.Add(this.dtpHasta);
            this.panelListaVenta.Controls.Add(this.dtpDesde);
            this.panelListaVenta.Controls.Add(this.label1);
            this.panelListaVenta.Controls.Add(this.cmbClientes);
            this.panelListaVenta.Controls.Add(this.btnBusacar);
            this.panelListaVenta.Controls.Add(this.label7);
            this.panelListaVenta.Controls.Add(this.dataVenta);
            this.panelListaVenta.Location = new System.Drawing.Point(17, 22);
            this.panelListaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.panelListaVenta.Name = "panelListaVenta";
            this.panelListaVenta.Size = new System.Drawing.Size(849, 538);
            this.panelListaVenta.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(650, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(342, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Desde";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(95, 86);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(182, 24);
            this.cmbMarca.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marca";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(561, 88);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(261, 22);
            this.dtpHasta.TabIndex = 8;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(293, 88);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(262, 22);
            this.dtpDesde.TabIndex = 7;
            this.dtpDesde.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(95, 46);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(182, 24);
            this.cmbClientes.TabIndex = 5;
            this.cmbClientes.TextUpdate += new System.EventHandler(this.cmbClientes_TextUpdate);
            // 
            // btnBusacar
            // 
            this.btnBusacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBusacar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusacar.ForeColor = System.Drawing.Color.White;
            this.btnBusacar.Location = new System.Drawing.Point(746, 13);
            this.btnBusacar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusacar.Name = "btnBusacar";
            this.btnBusacar.Size = new System.Drawing.Size(99, 45);
            this.btnBusacar.TabIndex = 4;
            this.btnBusacar.Text = "Buscar";
            this.btnBusacar.UseVisualStyleBackColor = false;
            this.btnBusacar.Click += new System.EventHandler(this.btnBusacar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Buscar";
            // 
            // dataVenta
            // 
            this.dataVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.Location = new System.Drawing.Point(25, 127);
            this.dataVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.RowTemplate.Height = 24;
            this.dataVenta.Size = new System.Drawing.Size(797, 388);
            this.dataVenta.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(875, 22);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(133, 47);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.Text = "Mostrar Venta";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnFechaInicio
            // 
            this.btnFechaInicio.Location = new System.Drawing.Point(434, 39);
            this.btnFechaInicio.Name = "btnFechaInicio";
            this.btnFechaInicio.Size = new System.Drawing.Size(121, 36);
            this.btnFechaInicio.TabIndex = 13;
            this.btnFechaInicio.Text = "El Inicio?";
            this.btnFechaInicio.UseVisualStyleBackColor = true;
            this.btnFechaInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1167, 581);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.panelVenta);
            this.Controls.Add(this.panelListaVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.panelListaVenta.ResumeLayout(false);
            this.panelListaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.Panel panelListaVenta;
        private System.Windows.Forms.Button btnBusacar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dataVenta;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnFechaInicio;
    }
}