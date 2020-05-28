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
            this.Buscar = new System.Windows.Forms.GroupBox();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.btnOrdenApellido = new System.Windows.Forms.Button();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelListaCliente.SuspendLayout();
            this.Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListaCliente
            // 
            this.panelListaCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.panelListaCliente.Controls.Add(this.Buscar);
            this.panelListaCliente.Controls.Add(this.btnOrdenApellido);
            this.panelListaCliente.Controls.Add(this.dataCliente);
            this.panelListaCliente.Location = new System.Drawing.Point(15, 18);
            this.panelListaCliente.Name = "panelListaCliente";
            this.panelListaCliente.Size = new System.Drawing.Size(637, 437);
            this.panelListaCliente.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Controls.Add(this.btnBuscar);
            this.Buscar.Controls.Add(this.txtBuscarC);
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(18, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(239, 45);
            this.Buscar.TabIndex = 6;
            this.Buscar.TabStop = false;
            this.Buscar.Text = "Buscar";
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(205, 20);
            this.txtBuscarC.TabIndex = 2;
            // 
            // btnOrdenApellido
            // 
            this.btnOrdenApellido.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrdenApellido.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrdenApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenApellido.ForeColor = System.Drawing.Color.White;
            this.btnOrdenApellido.Location = new System.Drawing.Point(262, 28);
            this.btnOrdenApellido.Name = "btnOrdenApellido";
            this.btnOrdenApellido.Size = new System.Drawing.Size(99, 22);
            this.btnOrdenApellido.TabIndex = 5;
            this.btnOrdenApellido.Text = "Orden Apellido";
            this.btnOrdenApellido.UseVisualStyleBackColor = false;
            this.btnOrdenApellido.Click += new System.EventHandler(this.btnOrdenApellido_Click);
            // 
            // dataCliente
            // 
            this.dataCliente.BackgroundColor = System.Drawing.Color.White;
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
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(208, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.Buscar.ResumeLayout(false);
            this.Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelListaCliente;
        private System.Windows.Forms.Panel panelCliente;
        public System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenApellido;
        private System.Windows.Forms.GroupBox Buscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}