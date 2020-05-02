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
            this.panelListaCliente = new System.Windows.Forms.Panel();
            this.btnBusacar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListaCliente
            // 
            this.panelListaCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.panelListaCliente.Controls.Add(this.btnBusacar);
            this.panelListaCliente.Controls.Add(this.label7);
            this.panelListaCliente.Controls.Add(this.txtBuscarC);
            this.panelListaCliente.Controls.Add(this.dataCliente);
            this.panelListaCliente.Location = new System.Drawing.Point(15, 18);
            this.panelListaCliente.Name = "panelListaCliente";
            this.panelListaCliente.Size = new System.Drawing.Size(637, 437);
            this.panelListaCliente.TabIndex = 1;
            // 
            // btnBusacar
            // 
            this.btnBusacar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusacar.ForeColor = System.Drawing.Color.White;
            this.btnBusacar.Location = new System.Drawing.Point(427, 23);
            this.btnBusacar.Name = "btnBusacar";
            this.btnBusacar.Size = new System.Drawing.Size(124, 22);
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
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(19, 63);
            this.dataCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowTemplate.Height = 24;
            this.dataCliente.Size = new System.Drawing.Size(598, 355);
            this.dataCliente.TabIndex = 1;
            this.dataCliente.CurrentCellChanged += new System.EventHandler(this.dataCliente_CurrentCellChanged);
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.Transparent;
            this.panelCliente.Location = new System.Drawing.Point(658, 56);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(205, 399);
            this.panelCliente.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(763, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 38);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Nuevo Cliente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnACliente_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Teal;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(658, 18);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 38);
            this.btnMostrar.TabIndex = 24;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelListaCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panelListaCliente.ResumeLayout(false);
            this.panelListaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelListaCliente;
        private System.Windows.Forms.Panel panelCliente;
        public System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBusacar;
    }
}