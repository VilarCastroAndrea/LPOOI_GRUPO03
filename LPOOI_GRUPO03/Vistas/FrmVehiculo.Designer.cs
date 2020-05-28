﻿namespace Vistas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarVehiculo = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnLinea = new System.Windows.Forms.RadioButton();
            this.dataVehiculo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelListaVehiculo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBox.SuspendLayout();
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
            this.panelListaVehiculo.Controls.Add(this.groupBox1);
            this.panelListaVehiculo.Controls.Add(this.gBox);
            this.panelListaVehiculo.Controls.Add(this.dataVehiculo);
            this.panelListaVehiculo.Location = new System.Drawing.Point(13, 18);
            this.panelListaVehiculo.Name = "panelListaVehiculo";
            this.panelListaVehiculo.Size = new System.Drawing.Size(637, 437);
            this.panelListaVehiculo.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarVehiculo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscarVehiculo
            // 
            this.txtBuscarVehiculo.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarVehiculo.Name = "txtBuscarVehiculo";
            this.txtBuscarVehiculo.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarVehiculo.TabIndex = 2;
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.rbtnMarca);
            this.gBox.Controls.Add(this.rbtnLinea);
            this.gBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gBox.Location = new System.Drawing.Point(243, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(181, 52);
            this.gBox.TabIndex = 9;
            this.gBox.TabStop = false;
            this.gBox.Text = "Ordenar segun:";
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnMarca.Location = new System.Drawing.Point(21, 19);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.rbtnMarca.TabIndex = 7;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // rbtnLinea
            // 
            this.rbtnLinea.AutoSize = true;
            this.rbtnLinea.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnLinea.Location = new System.Drawing.Point(115, 19);
            this.rbtnLinea.Name = "rbtnLinea";
            this.rbtnLinea.Size = new System.Drawing.Size(51, 17);
            this.rbtnLinea.TabIndex = 6;
            this.rbtnLinea.TabStop = true;
            this.rbtnLinea.Text = "Linea";
            this.rbtnLinea.UseVisualStyleBackColor = true;
            this.rbtnLinea.CheckedChanged += new System.EventHandler(this.rbtnLinea_CheckedChanged);
            // 
            // dataVehiculo
            // 
            this.dataVehiculo.BackgroundColor = System.Drawing.Color.White;
            this.dataVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculo.Location = new System.Drawing.Point(19, 69);
            this.dataVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.dataVehiculo.Name = "dataVehiculo";
            this.dataVehiculo.RowTemplate.Height = 24;
            this.dataVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVehiculo.Size = new System.Drawing.Size(599, 349);
            this.dataVehiculo.TabIndex = 1;
            this.dataVehiculo.CurrentCellChanged += new System.EventHandler(this.dataVehiculo_CurrentCellChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(185, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListaVeh;
        private System.Windows.Forms.Button btnAVeh;
        private System.Windows.Forms.Panel panelVehiculo;
        private System.Windows.Forms.Panel panelListaVehiculo;
        private System.Windows.Forms.TextBox txtBuscarVehiculo;
        public System.Windows.Forms.DataGridView dataVehiculo;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnLinea;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}