namespace CapaPresentacion
{
    partial class frmMenu
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
            this.pnlPanelizquierdo = new System.Windows.Forms.Panel();
            this.ibtnGuiaUsuario = new FontAwesome.Sharp.IconButton();
            this.ibtnConfig = new FontAwesome.Sharp.IconButton();
            this.ibtnAdmin = new FontAwesome.Sharp.IconButton();
            this.ibtnPropietarios = new FontAwesome.Sharp.IconButton();
            this.ibtnConsorcios = new FontAwesome.Sharp.IconButton();
            this.ibtnRegistro = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.ipbHome = new FontAwesome.Sharp.IconPictureBox();
            this.ipbSalir = new FontAwesome.Sharp.IconPictureBox();
            this.pnlMenuCentro = new System.Windows.Forms.Panel();
            this.pnlPanelizquierdo.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSalir)).BeginInit();
            this.pnlMenuCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPanelizquierdo
            // 
            this.pnlPanelizquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlPanelizquierdo.Controls.Add(this.ibtnGuiaUsuario);
            this.pnlPanelizquierdo.Controls.Add(this.ibtnConfig);
            this.pnlPanelizquierdo.Controls.Add(this.ibtnAdmin);
            this.pnlPanelizquierdo.Controls.Add(this.ibtnPropietarios);
            this.pnlPanelizquierdo.Controls.Add(this.ibtnConsorcios);
            this.pnlPanelizquierdo.Controls.Add(this.ibtnRegistro);
            this.pnlPanelizquierdo.Controls.Add(this.pnlLogo);
            this.pnlPanelizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPanelizquierdo.Location = new System.Drawing.Point(10, 0);
            this.pnlPanelizquierdo.Name = "pnlPanelizquierdo";
            this.pnlPanelizquierdo.Size = new System.Drawing.Size(158, 550);
            this.pnlPanelizquierdo.TabIndex = 0;
            // 
            // ibtnGuiaUsuario
            // 
            this.ibtnGuiaUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnGuiaUsuario.FlatAppearance.BorderSize = 0;
            this.ibtnGuiaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGuiaUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnGuiaUsuario.ForeColor = System.Drawing.Color.Silver;
            this.ibtnGuiaUsuario.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ibtnGuiaUsuario.IconColor = System.Drawing.Color.Silver;
            this.ibtnGuiaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuiaUsuario.IconSize = 40;
            this.ibtnGuiaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGuiaUsuario.Location = new System.Drawing.Point(0, 500);
            this.ibtnGuiaUsuario.Name = "ibtnGuiaUsuario";
            this.ibtnGuiaUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnGuiaUsuario.Size = new System.Drawing.Size(158, 50);
            this.ibtnGuiaUsuario.TabIndex = 5;
            this.ibtnGuiaUsuario.Text = "Guia Usuario";
            this.ibtnGuiaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGuiaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnGuiaUsuario.UseVisualStyleBackColor = true;
            // 
            // ibtnConfig
            // 
            this.ibtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnConfig.FlatAppearance.BorderSize = 0;
            this.ibtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnConfig.ForeColor = System.Drawing.Color.Silver;
            this.ibtnConfig.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.ibtnConfig.IconColor = System.Drawing.Color.Silver;
            this.ibtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConfig.Location = new System.Drawing.Point(0, 300);
            this.ibtnConfig.Name = "ibtnConfig";
            this.ibtnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnConfig.Size = new System.Drawing.Size(158, 50);
            this.ibtnConfig.TabIndex = 4;
            this.ibtnConfig.Text = "Config";
            this.ibtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnConfig.UseVisualStyleBackColor = true;
            this.ibtnConfig.Click += new System.EventHandler(this.ibtnConfig_Click);
            // 
            // ibtnAdmin
            // 
            this.ibtnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAdmin.FlatAppearance.BorderSize = 0;
            this.ibtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdmin.ForeColor = System.Drawing.Color.Silver;
            this.ibtnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibtnAdmin.IconColor = System.Drawing.Color.Silver;
            this.ibtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAdmin.Location = new System.Drawing.Point(0, 250);
            this.ibtnAdmin.Name = "ibtnAdmin";
            this.ibtnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnAdmin.Size = new System.Drawing.Size(158, 50);
            this.ibtnAdmin.TabIndex = 3;
            this.ibtnAdmin.Text = "Admin";
            this.ibtnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAdmin.UseVisualStyleBackColor = true;
            this.ibtnAdmin.Click += new System.EventHandler(this.ibtnAdmin_Click);
            // 
            // ibtnPropietarios
            // 
            this.ibtnPropietarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPropietarios.FlatAppearance.BorderSize = 0;
            this.ibtnPropietarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPropietarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnPropietarios.ForeColor = System.Drawing.Color.Silver;
            this.ibtnPropietarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnPropietarios.IconColor = System.Drawing.Color.Silver;
            this.ibtnPropietarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPropietarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPropietarios.Location = new System.Drawing.Point(0, 200);
            this.ibtnPropietarios.Name = "ibtnPropietarios";
            this.ibtnPropietarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnPropietarios.Size = new System.Drawing.Size(158, 50);
            this.ibtnPropietarios.TabIndex = 2;
            this.ibtnPropietarios.Text = "Propietarios";
            this.ibtnPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPropietarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPropietarios.UseVisualStyleBackColor = true;
            this.ibtnPropietarios.Click += new System.EventHandler(this.ibtnPropietarios_Click);
            // 
            // ibtnConsorcios
            // 
            this.ibtnConsorcios.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnConsorcios.FlatAppearance.BorderSize = 0;
            this.ibtnConsorcios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnConsorcios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnConsorcios.ForeColor = System.Drawing.Color.Silver;
            this.ibtnConsorcios.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleArrowRight;
            this.ibtnConsorcios.IconColor = System.Drawing.Color.Silver;
            this.ibtnConsorcios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnConsorcios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConsorcios.Location = new System.Drawing.Point(0, 150);
            this.ibtnConsorcios.Name = "ibtnConsorcios";
            this.ibtnConsorcios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnConsorcios.Size = new System.Drawing.Size(158, 50);
            this.ibtnConsorcios.TabIndex = 1;
            this.ibtnConsorcios.Text = "Consorcios";
            this.ibtnConsorcios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConsorcios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnConsorcios.UseVisualStyleBackColor = true;
            this.ibtnConsorcios.Click += new System.EventHandler(this.ibtnConsorcios_Click);
            // 
            // ibtnRegistro
            // 
            this.ibtnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnRegistro.FlatAppearance.BorderSize = 0;
            this.ibtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRegistro.ForeColor = System.Drawing.Color.Silver;
            this.ibtnRegistro.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.ibtnRegistro.IconColor = System.Drawing.Color.Silver;
            this.ibtnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRegistro.Location = new System.Drawing.Point(0, 100);
            this.ibtnRegistro.Name = "ibtnRegistro";
            this.ibtnRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ibtnRegistro.Size = new System.Drawing.Size(158, 50);
            this.ibtnRegistro.TabIndex = 0;
            this.ibtnRegistro.Text = "Registro";
            this.ibtnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRegistro.UseVisualStyleBackColor = true;
            this.ibtnRegistro.Click += new System.EventHandler(this.ibtnRegistro_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.ipbHome);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(158, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // ipbHome
            // 
            this.ipbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipbHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbHome.IconChar = FontAwesome.Sharp.IconChar.City;
            this.ipbHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbHome.IconSize = 100;
            this.ipbHome.Location = new System.Drawing.Point(0, 0);
            this.ipbHome.Name = "ipbHome";
            this.ipbHome.Size = new System.Drawing.Size(158, 100);
            this.ipbHome.TabIndex = 0;
            this.ipbHome.TabStop = false;
            // 
            // ipbSalir
            // 
            this.ipbSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ipbSalir.ForeColor = System.Drawing.Color.Silver;
            this.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.ipbSalir.IconColor = System.Drawing.Color.Silver;
            this.ipbSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbSalir.Location = new System.Drawing.Point(652, 3);
            this.ipbSalir.Name = "ipbSalir";
            this.ipbSalir.Size = new System.Drawing.Size(32, 32);
            this.ipbSalir.TabIndex = 1;
            this.ipbSalir.TabStop = false;
            this.ipbSalir.Click += new System.EventHandler(this.ipbSalir_Click);
            this.ipbSalir.MouseLeave += new System.EventHandler(this.ipbSalir_MouseLeave);
            this.ipbSalir.MouseHover += new System.EventHandler(this.ipbSalir_MouseHover);
            // 
            // pnlMenuCentro
            // 
            this.pnlMenuCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlMenuCentro.Controls.Add(this.ipbSalir);
            this.pnlMenuCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuCentro.Location = new System.Drawing.Point(168, 0);
            this.pnlMenuCentro.Name = "pnlMenuCentro";
            this.pnlMenuCentro.Size = new System.Drawing.Size(687, 550);
            this.pnlMenuCentro.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenuCentro);
            this.Controls.Add(this.pnlPanelizquierdo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 589);
            this.MinimumSize = new System.Drawing.Size(871, 589);
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.pnlPanelizquierdo.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSalir)).EndInit();
            this.pnlMenuCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanelizquierdo;
        private FontAwesome.Sharp.IconButton ibtnRegistro;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton ibtnAdmin;
        private FontAwesome.Sharp.IconButton ibtnPropietarios;
        private FontAwesome.Sharp.IconButton ibtnConsorcios;
        private FontAwesome.Sharp.IconButton ibtnGuiaUsuario;
        private FontAwesome.Sharp.IconButton ibtnConfig;
        private FontAwesome.Sharp.IconPictureBox ipbHome;
        private FontAwesome.Sharp.IconPictureBox ipbSalir;
        private System.Windows.Forms.Panel pnlMenuCentro;
    }
}