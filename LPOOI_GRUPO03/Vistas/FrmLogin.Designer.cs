namespace Vistas
{
    partial class FrmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnfoUsu = new System.Windows.Forms.Label();
            this.lblInfoContra = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(41, 168);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.MouseLeave += new System.EventHandler(this.txtUsuario_MouseLeave);
            this.txtUsuario.MouseHover += new System.EventHandler(this.txtUsuario_MouseHover);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(41, 205);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(177, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.MouseLeave += new System.EventHandler(this.txtContra_MouseLeave);
            this.txtContra.MouseHover += new System.EventHandler(this.txtContra_MouseHover);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.BorderSize = 25;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(17, 248);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(201, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Vistas.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 165);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblnfoUsu
            // 
            this.lblnfoUsu.AutoSize = true;
            this.lblnfoUsu.BackColor = System.Drawing.Color.Transparent;
            this.lblnfoUsu.ForeColor = System.Drawing.Color.White;
            this.lblnfoUsu.Location = new System.Drawing.Point(41, 189);
            this.lblnfoUsu.Name = "lblnfoUsu";
            this.lblnfoUsu.Size = new System.Drawing.Size(0, 13);
            this.lblnfoUsu.TabIndex = 10;
            // 
            // lblInfoContra
            // 
            this.lblInfoContra.AutoSize = true;
            this.lblInfoContra.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoContra.ForeColor = System.Drawing.Color.White;
            this.lblInfoContra.Location = new System.Drawing.Point(41, 227);
            this.lblInfoContra.Name = "lblInfoContra";
            this.lblInfoContra.Size = new System.Drawing.Size(0, 13);
            this.lblInfoContra.TabIndex = 11;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 168);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 20);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 20;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 205);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(23, 20);
            this.iconPictureBox2.TabIndex = 13;
            this.iconPictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(240, 296);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblInfoContra);
            this.Controls.Add(this.lblnfoUsu);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblnfoUsu;
        private System.Windows.Forms.Label lblInfoContra;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}