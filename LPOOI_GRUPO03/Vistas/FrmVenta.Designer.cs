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
            this.filtrarFechas = new System.Windows.Forms.Button();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.btnBusacar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dataVenta = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnRegistrarVenta.Location = new System.Drawing.Point(759, 19);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(102, 37);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.Transparent;
            this.panelVenta.Location = new System.Drawing.Point(656, 55);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(205, 400);
            this.panelVenta.TabIndex = 26;
            // 
            // panelListaVenta
            // 
            this.panelListaVenta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelListaVenta.Controls.Add(this.dateTimePicker1);
            this.panelListaVenta.Controls.Add(this.filtrarFechas);
            this.panelListaVenta.Controls.Add(this.hasta);
            this.panelListaVenta.Controls.Add(this.desde);
            this.panelListaVenta.Controls.Add(this.btnBusacar);
            this.panelListaVenta.Controls.Add(this.label7);
            this.panelListaVenta.Controls.Add(this.txtBuscarC);
            this.panelListaVenta.Controls.Add(this.dataVenta);
            this.panelListaVenta.Location = new System.Drawing.Point(13, 18);
            this.panelListaVenta.Name = "panelListaVenta";
            this.panelListaVenta.Size = new System.Drawing.Size(637, 437);
            this.panelListaVenta.TabIndex = 25;
            // 
            // filtrarFechas
            // 
            this.filtrarFechas.Location = new System.Drawing.Point(432, 1);
            this.filtrarFechas.Name = "filtrarFechas";
            this.filtrarFechas.Size = new System.Drawing.Size(75, 23);
            this.filtrarFechas.TabIndex = 7;
            this.filtrarFechas.Text = "filtrar por fechas";
            this.filtrarFechas.UseVisualStyleBackColor = true;
            this.filtrarFechas.Click += new System.EventHandler(this.filtrarFechas_Click);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(225, 1);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(200, 20);
            this.hasta.TabIndex = 6;
            // 
            // desde
            // 
            this.desde.Location = new System.Drawing.Point(19, 0);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(200, 20);
            this.desde.TabIndex = 5;
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
            // dataVenta
            // 
            this.dataVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.Location = new System.Drawing.Point(19, 63);
            this.dataVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.RowTemplate.Height = 24;
            this.dataVenta.Size = new System.Drawing.Size(598, 355);
            this.dataVenta.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(656, 18);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 38);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.Text = "Mostrar Venta";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.panelVenta);
            this.Controls.Add(this.panelListaVenta);
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
        private System.Windows.Forms.TextBox txtBuscarC;
        public System.Windows.Forms.DataGridView dataVenta;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Button filtrarFechas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}