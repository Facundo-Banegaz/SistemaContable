namespace CapaPresentacion
{
    partial class frmRegistro
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
            this.pnlRegistroTop = new System.Windows.Forms.Panel();
            this.ipbSalirRegistro = new FontAwesome.Sharp.IconPictureBox();
            this.ibtnExpensas = new FontAwesome.Sharp.IconButton();
            this.ibtnIngresos = new FontAwesome.Sharp.IconButton();
            this.ibtnEgresos = new FontAwesome.Sharp.IconButton();
            this.ibtnProp = new FontAwesome.Sharp.IconButton();
            this.cmbConsorcios = new System.Windows.Forms.ComboBox();
            this.pnlRegistroLeft = new System.Windows.Forms.Panel();
            this.ibtnComunicados = new FontAwesome.Sharp.IconButton();
            this.ibtnAgenda = new FontAwesome.Sharp.IconButton();
            this.pnlRegistroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSalirRegistro)).BeginInit();
            this.pnlRegistroLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistroTop
            // 
            this.pnlRegistroTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlRegistroTop.Controls.Add(this.ipbSalirRegistro);
            this.pnlRegistroTop.Controls.Add(this.ibtnExpensas);
            this.pnlRegistroTop.Controls.Add(this.ibtnIngresos);
            this.pnlRegistroTop.Controls.Add(this.ibtnEgresos);
            this.pnlRegistroTop.Controls.Add(this.ibtnProp);
            this.pnlRegistroTop.Controls.Add(this.cmbConsorcios);
            this.pnlRegistroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegistroTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroTop.Name = "pnlRegistroTop";
            this.pnlRegistroTop.Size = new System.Drawing.Size(871, 58);
            this.pnlRegistroTop.TabIndex = 0;
            // 
            // ipbSalirRegistro
            // 
            this.ipbSalirRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbSalirRegistro.ForeColor = System.Drawing.Color.Silver;
            this.ipbSalirRegistro.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.ipbSalirRegistro.IconColor = System.Drawing.Color.Silver;
            this.ipbSalirRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbSalirRegistro.Location = new System.Drawing.Point(820, 12);
            this.ipbSalirRegistro.Name = "ipbSalirRegistro";
            this.ipbSalirRegistro.Size = new System.Drawing.Size(32, 32);
            this.ipbSalirRegistro.TabIndex = 5;
            this.ipbSalirRegistro.TabStop = false;
            this.ipbSalirRegistro.Click += new System.EventHandler(this.ipbSalirRegistro_Click);
            // 
            // ibtnExpensas
            // 
            this.ibtnExpensas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnExpensas.FlatAppearance.BorderSize = 0;
            this.ibtnExpensas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExpensas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnExpensas.ForeColor = System.Drawing.Color.Silver;
            this.ibtnExpensas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnExpensas.IconColor = System.Drawing.Color.Black;
            this.ibtnExpensas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExpensas.Location = new System.Drawing.Point(638, 0);
            this.ibtnExpensas.Name = "ibtnExpensas";
            this.ibtnExpensas.Size = new System.Drawing.Size(117, 55);
            this.ibtnExpensas.TabIndex = 4;
            this.ibtnExpensas.Text = "Expensas";
            this.ibtnExpensas.UseVisualStyleBackColor = false;
            this.ibtnExpensas.Click += new System.EventHandler(this.ibtnExpensas_Click);
            // 
            // ibtnIngresos
            // 
            this.ibtnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnIngresos.FlatAppearance.BorderSize = 0;
            this.ibtnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnIngresos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnIngresos.ForeColor = System.Drawing.Color.Silver;
            this.ibtnIngresos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnIngresos.IconColor = System.Drawing.Color.Black;
            this.ibtnIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnIngresos.Location = new System.Drawing.Point(515, 0);
            this.ibtnIngresos.Name = "ibtnIngresos";
            this.ibtnIngresos.Size = new System.Drawing.Size(117, 55);
            this.ibtnIngresos.TabIndex = 3;
            this.ibtnIngresos.Text = "Ingresos";
            this.ibtnIngresos.UseVisualStyleBackColor = false;
            this.ibtnIngresos.Click += new System.EventHandler(this.ibtnIngresos_Click);
            // 
            // ibtnEgresos
            // 
            this.ibtnEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ibtnEgresos.FlatAppearance.BorderSize = 0;
            this.ibtnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEgresos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEgresos.ForeColor = System.Drawing.Color.Silver;
            this.ibtnEgresos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnEgresos.IconColor = System.Drawing.Color.Black;
            this.ibtnEgresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEgresos.Location = new System.Drawing.Point(392, 0);
            this.ibtnEgresos.Name = "ibtnEgresos";
            this.ibtnEgresos.Size = new System.Drawing.Size(117, 55);
            this.ibtnEgresos.TabIndex = 2;
            this.ibtnEgresos.Text = "Egresos";
            this.ibtnEgresos.UseVisualStyleBackColor = false;
            this.ibtnEgresos.Click += new System.EventHandler(this.ibtnEgresos_Click);
            // 
            // ibtnProp
            // 
            this.ibtnProp.FlatAppearance.BorderSize = 0;
            this.ibtnProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProp.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.ibtnProp.IconColor = System.Drawing.Color.Silver;
            this.ibtnProp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProp.Location = new System.Drawing.Point(309, 0);
            this.ibtnProp.Name = "ibtnProp";
            this.ibtnProp.Size = new System.Drawing.Size(77, 55);
            this.ibtnProp.TabIndex = 1;
            this.ibtnProp.UseVisualStyleBackColor = true;
            this.ibtnProp.Click += new System.EventHandler(this.ibtnProp_Click);
            // 
            // cmbConsorcios
            // 
            this.cmbConsorcios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbConsorcios.ForeColor = System.Drawing.Color.Silver;
            this.cmbConsorcios.FormattingEnabled = true;
            this.cmbConsorcios.Location = new System.Drawing.Point(12, 21);
            this.cmbConsorcios.Name = "cmbConsorcios";
            this.cmbConsorcios.Size = new System.Drawing.Size(279, 21);
            this.cmbConsorcios.TabIndex = 0;
            // 
            // pnlRegistroLeft
            // 
            this.pnlRegistroLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlRegistroLeft.Controls.Add(this.ibtnComunicados);
            this.pnlRegistroLeft.Controls.Add(this.ibtnAgenda);
            this.pnlRegistroLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegistroLeft.Location = new System.Drawing.Point(0, 58);
            this.pnlRegistroLeft.Name = "pnlRegistroLeft";
            this.pnlRegistroLeft.Size = new System.Drawing.Size(158, 531);
            this.pnlRegistroLeft.TabIndex = 1;
            // 
            // ibtnComunicados
            // 
            this.ibtnComunicados.FlatAppearance.BorderSize = 0;
            this.ibtnComunicados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnComunicados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnComunicados.ForeColor = System.Drawing.Color.Silver;
            this.ibtnComunicados.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.ibtnComunicados.IconColor = System.Drawing.Color.Silver;
            this.ibtnComunicados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnComunicados.Location = new System.Drawing.Point(-3, 115);
            this.ibtnComunicados.Name = "ibtnComunicados";
            this.ibtnComunicados.Size = new System.Drawing.Size(158, 50);
            this.ibtnComunicados.TabIndex = 1;
            this.ibtnComunicados.Text = "Comunicados";
            this.ibtnComunicados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnComunicados.UseVisualStyleBackColor = true;
            this.ibtnComunicados.Click += new System.EventHandler(this.ibtnComunicados_Click);
            // 
            // ibtnAgenda
            // 
            this.ibtnAgenda.FlatAppearance.BorderSize = 0;
            this.ibtnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAgenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAgenda.ForeColor = System.Drawing.Color.Silver;
            this.ibtnAgenda.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.ibtnAgenda.IconColor = System.Drawing.Color.Silver;
            this.ibtnAgenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgenda.Location = new System.Drawing.Point(-3, 49);
            this.ibtnAgenda.Name = "ibtnAgenda";
            this.ibtnAgenda.Size = new System.Drawing.Size(158, 50);
            this.ibtnAgenda.TabIndex = 0;
            this.ibtnAgenda.Text = "Agenda General";
            this.ibtnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgenda.UseVisualStyleBackColor = true;
            this.ibtnAgenda.Click += new System.EventHandler(this.ibtnAgenda_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(871, 589);
            this.Controls.Add(this.pnlRegistroLeft);
            this.Controls.Add(this.pnlRegistroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 589);
            this.MinimumSize = new System.Drawing.Size(871, 589);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.pnlRegistroTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbSalirRegistro)).EndInit();
            this.pnlRegistroLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroTop;
        private System.Windows.Forms.Panel pnlRegistroLeft;
        private System.Windows.Forms.ComboBox cmbConsorcios;
        private FontAwesome.Sharp.IconButton ibtnAgenda;
        private FontAwesome.Sharp.IconButton ibtnComunicados;
        private FontAwesome.Sharp.IconButton ibtnProp;
        private FontAwesome.Sharp.IconButton ibtnEgresos;
        private FontAwesome.Sharp.IconButton ibtnExpensas;
        private FontAwesome.Sharp.IconButton ibtnIngresos;
        private FontAwesome.Sharp.IconPictureBox ipbSalirRegistro;
    }
}