namespace Vistas
{
    partial class FrmUsuario
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
            this.btnMostrarUsuario = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelListaCliente = new System.Windows.Forms.Panel();
            this.btnBusacarUsuario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.panelListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarUsuario
            // 
            this.btnMostrarUsuario.BackColor = System.Drawing.Color.Teal;
            this.btnMostrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnMostrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnMostrarUsuario.Location = new System.Drawing.Point(656, 18);
            this.btnMostrarUsuario.Name = "btnMostrarUsuario";
            this.btnMostrarUsuario.Size = new System.Drawing.Size(100, 38);
            this.btnMostrarUsuario.TabIndex = 28;
            this.btnMostrarUsuario.Text = "Mostrar";
            this.btnMostrarUsuario.UseVisualStyleBackColor = false;
            this.btnMostrarUsuario.Click += new System.EventHandler(this.btnMostrarUsuario_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(760, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 38);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Nuevo Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.panelUsuario.Location = new System.Drawing.Point(656, 56);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(205, 399);
            this.panelUsuario.TabIndex = 26;
            // 
            // panelListaCliente
            // 
            this.panelListaCliente.BackColor = System.Drawing.Color.Teal;
            this.panelListaCliente.Controls.Add(this.btnBusacarUsuario);
            this.panelListaCliente.Controls.Add(this.label7);
            this.panelListaCliente.Controls.Add(this.txtBuscarUsuario);
            this.panelListaCliente.Controls.Add(this.dgvListaUsuarios);
            this.panelListaCliente.Location = new System.Drawing.Point(13, 18);
            this.panelListaCliente.Name = "panelListaCliente";
            this.panelListaCliente.Size = new System.Drawing.Size(637, 437);
            this.panelListaCliente.TabIndex = 25;
            // 
            // btnBusacarUsuario
            // 
            this.btnBusacarUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBusacarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusacarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBusacarUsuario.Location = new System.Drawing.Point(427, 23);
            this.btnBusacarUsuario.Name = "btnBusacarUsuario";
            this.btnBusacarUsuario.Size = new System.Drawing.Size(85, 22);
            this.btnBusacarUsuario.TabIndex = 4;
            this.btnBusacarUsuario.Text = "Buscar";
            this.btnBusacarUsuario.UseVisualStyleBackColor = false;
            this.btnBusacarUsuario.Click += new System.EventHandler(this.btnBusacarUsuario_Click);
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
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(80, 25);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(331, 20);
            this.txtBuscarUsuario.TabIndex = 2;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(19, 63);
            this.dgvListaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowTemplate.Height = 24;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(598, 355);
            this.dgvListaUsuarios.TabIndex = 1;
            this.dgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentClick);
            this.dgvListaUsuarios.CurrentCellChanged += new System.EventHandler(this.dgvListaUsuarios_CurrentCellChanged);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.btnMostrarUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.panelListaCliente);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panelListaCliente.ResumeLayout(false);
            this.panelListaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelListaCliente;
        private System.Windows.Forms.Button btnBusacarUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        public System.Windows.Forms.DataGridView dgvListaUsuarios;
    }
}