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
            this.panelContenedor3 = new System.Windows.Forms.Panel();
            this.btnListaVeh = new System.Windows.Forms.Button();
            this.btnAVeh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContenedor3
            // 
            this.panelContenedor3.Location = new System.Drawing.Point(12, 50);
            this.panelContenedor3.Name = "panelContenedor3";
            this.panelContenedor3.Size = new System.Drawing.Size(308, 405);
            this.panelContenedor3.TabIndex = 0;
            // 
            // btnListaVeh
            // 
            this.btnListaVeh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnListaVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVeh.ForeColor = System.Drawing.Color.White;
            this.btnListaVeh.Location = new System.Drawing.Point(12, 12);
            this.btnListaVeh.Name = "btnListaVeh";
            this.btnListaVeh.Size = new System.Drawing.Size(102, 39);
            this.btnListaVeh.TabIndex = 1;
            this.btnListaVeh.Text = "Lista Vehiculo";
            this.btnListaVeh.UseVisualStyleBackColor = false;
            this.btnListaVeh.Click += new System.EventHandler(this.btnListaVeh_Click);
            // 
            // btnAVeh
            // 
            this.btnAVeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAVeh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAVeh.ForeColor = System.Drawing.Color.White;
            this.btnAVeh.Location = new System.Drawing.Point(120, 12);
            this.btnAVeh.Name = "btnAVeh";
            this.btnAVeh.Size = new System.Drawing.Size(102, 39);
            this.btnAVeh.TabIndex = 2;
            this.btnAVeh.Text = "Alta Vehiculo";
            this.btnAVeh.UseVisualStyleBackColor = false;
            this.btnAVeh.Click += new System.EventHandler(this.btnAVeh_Click);
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(351, 467);
            this.Controls.Add(this.btnAVeh);
            this.Controls.Add(this.btnListaVeh);
            this.Controls.Add(this.panelContenedor3);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor3;
        private System.Windows.Forms.Button btnListaVeh;
        private System.Windows.Forms.Button btnAVeh;
    }
}