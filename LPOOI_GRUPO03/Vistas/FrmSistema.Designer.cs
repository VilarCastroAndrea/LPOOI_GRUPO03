namespace Vistas
{
    partial class FrmSistema
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
            this.btnListaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaUsuario
            // 
            this.btnListaUsuario.Location = new System.Drawing.Point(73, 65);
            this.btnListaUsuario.Name = "btnListaUsuario";
            this.btnListaUsuario.Size = new System.Drawing.Size(106, 36);
            this.btnListaUsuario.TabIndex = 0;
            this.btnListaUsuario.Text = "ABM Usuario";
            this.btnListaUsuario.UseVisualStyleBackColor = true;
            this.btnListaUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(487, 371);
            this.Controls.Add(this.btnListaUsuario);
            this.Name = "FrmSistema";
            this.Text = "FrmSistema";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaUsuario;
    }
}