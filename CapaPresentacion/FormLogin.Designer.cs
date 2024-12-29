namespace CapaPresentacion
{
    partial class frmLogin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipbUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.ipbContrasena = new FontAwesome.Sharp.IconPictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblLimpiarCampos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ipbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbContrasena)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Login.Location = new System.Drawing.Point(478, 66);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(102, 39);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtUsuario.Location = new System.Drawing.Point(385, 184);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(308, 30);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtContrasena.Location = new System.Drawing.Point(385, 275);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(308, 30);
            this.txtContrasena.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Silver;
            this.btnIngresar.Location = new System.Drawing.Point(346, 375);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(366, 81);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(212, 656);
            this.pnlLogin.TabIndex = 8;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlEmail.Location = new System.Drawing.Point(385, 218);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(354, 2);
            this.pnlEmail.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(385, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 2);
            this.panel1.TabIndex = 10;
            // 
            // ipbUsuario
            // 
            this.ipbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ipbUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbUsuario.IconSize = 48;
            this.ipbUsuario.Location = new System.Drawing.Point(321, 166);
            this.ipbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbUsuario.Name = "ipbUsuario";
            this.ipbUsuario.Size = new System.Drawing.Size(48, 49);
            this.ipbUsuario.TabIndex = 11;
            this.ipbUsuario.TabStop = false;
            // 
            // ipbContrasena
            // 
            this.ipbContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbContrasena.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ipbContrasena.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbContrasena.IconSize = 48;
            this.ipbContrasena.Location = new System.Drawing.Point(321, 257);
            this.ipbContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbContrasena.Name = "ipbContrasena";
            this.ipbContrasena.Size = new System.Drawing.Size(48, 49);
            this.ipbContrasena.TabIndex = 12;
            this.ipbContrasena.TabStop = false;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblSalir.Location = new System.Drawing.Point(497, 528);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(58, 27);
            this.lblSalir.TabIndex = 4;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblLimpiarCampos.Location = new System.Drawing.Point(598, 326);
            this.lblLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(144, 21);
            this.lblLimpiarCampos.TabIndex = 2;
            this.lblLimpiarCampos.Text = "Limpiar Campos";
            this.lblLimpiarCampos.Click += new System.EventHandler(this.lblLimpiarCampos_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(866, 656);
            this.ControlBox = false;
            this.Controls.Add(this.lblLimpiarCampos);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.ipbContrasena);
            this.Controls.Add(this.ipbUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(866, 656);
            this.MinimumSize = new System.Drawing.Size(866, 656);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ipbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbContrasena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ipbUsuario;
        private FontAwesome.Sharp.IconPictureBox ipbContrasena;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblLimpiarCampos;
    }
}

