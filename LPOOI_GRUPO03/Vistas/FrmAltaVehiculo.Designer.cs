namespace Vistas
{
    partial class FrmAltaVehiculo
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
            this.txtAMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtALinea = new System.Windows.Forms.TextBox();
            this.txtAMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaVeh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtATipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAClase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkGps = new System.Windows.Forms.CheckBox();
            this.cmbCantPuert = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAMatricula
            // 
            this.txtAMatricula.Location = new System.Drawing.Point(19, 25);
            this.txtAMatricula.Name = "txtAMatricula";
            this.txtAMatricula.Size = new System.Drawing.Size(170, 20);
            this.txtAMatricula.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Matricula";
            // 
            // txtALinea
            // 
            this.txtALinea.Location = new System.Drawing.Point(20, 66);
            this.txtALinea.Name = "txtALinea";
            this.txtALinea.Size = new System.Drawing.Size(169, 20);
            this.txtALinea.TabIndex = 2;
            // 
            // txtAMarca
            // 
            this.txtAMarca.Location = new System.Drawing.Point(20, 139);
            this.txtAMarca.Name = "txtAMarca";
            this.txtAMarca.Size = new System.Drawing.Size(169, 20);
            this.txtAMarca.TabIndex = 1;
            this.txtAMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMarca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marca";
            // 
            // btnAltaVeh
            // 
            this.btnAltaVeh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaVeh.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnAltaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaVeh.ForeColor = System.Drawing.Color.White;
            this.btnAltaVeh.Location = new System.Drawing.Point(18, 363);
            this.btnAltaVeh.Name = "btnAltaVeh";
            this.btnAltaVeh.Size = new System.Drawing.Size(172, 23);
            this.btnAltaVeh.TabIndex = 10;
            this.btnAltaVeh.Text = "Agregar";
            this.btnAltaVeh.UseVisualStyleBackColor = false;
            this.btnAltaVeh.Click += new System.EventHandler(this.btnAltaVeh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cantidad de Puertas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "GPS";
            // 
            // txtATipo
            // 
            this.txtATipo.Location = new System.Drawing.Point(20, 245);
            this.txtATipo.Name = "txtATipo";
            this.txtATipo.Size = new System.Drawing.Size(166, 20);
            this.txtATipo.TabIndex = 7;
            this.txtATipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtATipo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tipo de Vehiculo";
            // 
            // txtAClase
            // 
            this.txtAClase.Location = new System.Drawing.Point(20, 284);
            this.txtAClase.Name = "txtAClase";
            this.txtAClase.Size = new System.Drawing.Size(166, 20);
            this.txtAClase.TabIndex = 8;
            this.txtAClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAClase_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Clase de Vehiculo";
            // 
            // txtAPrecio
            // 
            this.txtAPrecio.Location = new System.Drawing.Point(72, 337);
            this.txtAPrecio.Name = "txtAPrecio";
            this.txtAPrecio.Size = new System.Drawing.Size(118, 20);
            this.txtAPrecio.TabIndex = 9;
            this.txtAPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPrecio_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Precio";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkGps
            // 
            this.checkGps.AutoSize = true;
            this.checkGps.ForeColor = System.Drawing.Color.White;
            this.checkGps.Location = new System.Drawing.Point(57, 313);
            this.checkGps.Name = "checkGps";
            this.checkGps.Size = new System.Drawing.Size(35, 17);
            this.checkGps.TabIndex = 6;
            this.checkGps.Text = "Si";
            this.checkGps.UseVisualStyleBackColor = true;
            // 
            // cmbCantPuert
            // 
            this.cmbCantPuert.FormattingEnabled = true;
            this.cmbCantPuert.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbCantPuert.Location = new System.Drawing.Point(138, 205);
            this.cmbCantPuert.Name = "cmbCantPuert";
            this.cmbCantPuert.Size = new System.Drawing.Size(51, 21);
            this.cmbCantPuert.TabIndex = 5;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Rojo",
            "Verde",
            "Gris",
            "Blanco",
            "Amarillo"});
            this.cmbColor.Location = new System.Drawing.Point(71, 97);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(118, 21);
            this.cmbColor.TabIndex = 4;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cmbModelo.Location = new System.Drawing.Point(71, 172);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(118, 21);
            this.cmbModelo.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(98, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "No";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(207, 415);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCantPuert);
            this.Controls.Add(this.checkGps);
            this.Controls.Add(this.txtAPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAClase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtATipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtALinea);
            this.Controls.Add(this.txtAMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaVeh);
            this.Name = "FrmAltaVehiculo";
            this.Text = "FrmAltaVehiculo";
            this.Load += new System.EventHandler(this.FrmAltaVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtALinea;
        private System.Windows.Forms.TextBox txtAMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaVeh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtATipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAClase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkGps;
        private System.Windows.Forms.ComboBox cmbCantPuert;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}