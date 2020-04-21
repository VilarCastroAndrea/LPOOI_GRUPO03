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
            this.lblClinte = new System.Windows.Forms.Label();
            this.txtAModelo = new System.Windows.Forms.TextBox();
            this.txtAColor = new System.Windows.Forms.TextBox();
            this.txtALinea = new System.Windows.Forms.TextBox();
            this.txtAMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaVeh = new System.Windows.Forms.Button();
            this.txtAPuertas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtATipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAClase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkGps = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAMatricula
            // 
            this.txtAMatricula.Location = new System.Drawing.Point(16, 79);
            this.txtAMatricula.Name = "txtAMatricula";
            this.txtAMatricula.Size = new System.Drawing.Size(123, 20);
            this.txtAMatricula.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Matricula";
            // 
            // lblClinte
            // 
            this.lblClinte.AutoSize = true;
            this.lblClinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinte.ForeColor = System.Drawing.Color.White;
            this.lblClinte.Location = new System.Drawing.Point(119, 22);
            this.lblClinte.Name = "lblClinte";
            this.lblClinte.Size = new System.Drawing.Size(177, 25);
            this.lblClinte.TabIndex = 21;
            this.lblClinte.Text = "Agregar Vehiculo";
            // 
            // txtAModelo
            // 
            this.txtAModelo.Location = new System.Drawing.Point(161, 129);
            this.txtAModelo.Name = "txtAModelo";
            this.txtAModelo.Size = new System.Drawing.Size(125, 20);
            this.txtAModelo.TabIndex = 20;
            this.txtAModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAModelo_KeyPress);
            // 
            // txtAColor
            // 
            this.txtAColor.Location = new System.Drawing.Point(16, 183);
            this.txtAColor.Name = "txtAColor";
            this.txtAColor.Size = new System.Drawing.Size(123, 20);
            this.txtAColor.TabIndex = 19;
            this.txtAColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAColor_KeyPress);
            // 
            // txtALinea
            // 
            this.txtALinea.Location = new System.Drawing.Point(15, 129);
            this.txtALinea.Name = "txtALinea";
            this.txtALinea.Size = new System.Drawing.Size(124, 20);
            this.txtALinea.TabIndex = 18;
            // 
            // txtAMarca
            // 
            this.txtAMarca.Location = new System.Drawing.Point(161, 79);
            this.txtAMarca.Name = "txtAMarca";
            this.txtAMarca.Size = new System.Drawing.Size(125, 20);
            this.txtAMarca.TabIndex = 17;
            this.txtAMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMarca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 63);
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
            this.btnAltaVeh.Location = new System.Drawing.Point(192, 340);
            this.btnAltaVeh.Name = "btnAltaVeh";
            this.btnAltaVeh.Size = new System.Drawing.Size(92, 23);
            this.btnAltaVeh.TabIndex = 12;
            this.btnAltaVeh.Text = "Agregar";
            this.btnAltaVeh.UseVisualStyleBackColor = false;
            this.btnAltaVeh.Click += new System.EventHandler(this.btnAltaVeh_Click);
            // 
            // txtAPuertas
            // 
            this.txtAPuertas.Location = new System.Drawing.Point(163, 183);
            this.txtAPuertas.Name = "txtAPuertas";
            this.txtAPuertas.Size = new System.Drawing.Size(123, 20);
            this.txtAPuertas.TabIndex = 25;
            this.txtAPuertas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPuertas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cantidad de Puertas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "GPS";
            // 
            // txtATipo
            // 
            this.txtATipo.Location = new System.Drawing.Point(163, 239);
            this.txtATipo.Name = "txtATipo";
            this.txtATipo.Size = new System.Drawing.Size(123, 20);
            this.txtATipo.TabIndex = 29;
            this.txtATipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtATipo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(162, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tipo de Vehiculo";
            // 
            // txtAClase
            // 
            this.txtAClase.Location = new System.Drawing.Point(16, 292);
            this.txtAClase.Name = "txtAClase";
            this.txtAClase.Size = new System.Drawing.Size(123, 20);
            this.txtAClase.TabIndex = 31;
            this.txtAClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAClase_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Clase de Vehiculo";
            // 
            // txtAPrecio
            // 
            this.txtAPrecio.Location = new System.Drawing.Point(161, 292);
            this.txtAPrecio.Name = "txtAPrecio";
            this.txtAPrecio.Size = new System.Drawing.Size(123, 20);
            this.txtAPrecio.TabIndex = 33;
            this.txtAPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPrecio_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(160, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Precio";
            // 
            // checkGps
            // 
            this.checkGps.AutoSize = true;
            this.checkGps.ForeColor = System.Drawing.Color.White;
            this.checkGps.Location = new System.Drawing.Point(18, 239);
            this.checkGps.Name = "checkGps";
            this.checkGps.Size = new System.Drawing.Size(35, 17);
            this.checkGps.TabIndex = 34;
            this.checkGps.Text = "Si";
            this.checkGps.UseVisualStyleBackColor = true;
            // 
            // FrmAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.checkGps);
            this.Controls.Add(this.txtAPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAClase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtATipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAPuertas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClinte);
            this.Controls.Add(this.txtAModelo);
            this.Controls.Add(this.txtAColor);
            this.Controls.Add(this.txtALinea);
            this.Controls.Add(this.txtAMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaVeh);
            this.Name = "FrmAltaVehiculo";
            this.Text = "FrmAltaVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClinte;
        private System.Windows.Forms.TextBox txtAModelo;
        private System.Windows.Forms.TextBox txtAColor;
        private System.Windows.Forms.TextBox txtALinea;
        private System.Windows.Forms.TextBox txtAMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaVeh;
        private System.Windows.Forms.TextBox txtAPuertas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtATipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAClase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkGps;
    }
}