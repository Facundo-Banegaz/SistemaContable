namespace CapaPresentacion
{
    partial class frmPropietario
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
            this.dgvPropietario = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lblConsorcio = new System.Windows.Forms.Label();
            this.txt_Unidad = new System.Windows.Forms.TextBox();
            this.lblEmailProp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPropietarioTop = new System.Windows.Forms.Panel();
            this.ipbExitPropietario = new FontAwesome.Sharp.IconPictureBox();
            this.pnlPropietarioDerecha = new System.Windows.Forms.Panel();
            this.pnlNombreConsorcio = new System.Windows.Forms.Panel();
            this.pnlNombrePropietario = new System.Windows.Forms.Panel();
            this.pnlTel = new System.Windows.Forms.Panel();
            this.pnlBuscarPropietario = new System.Windows.Forms.Panel();
            this.pnlNumUnidad = new System.Windows.Forms.Panel();
            this.pnlPorcentajeUnidad = new System.Windows.Forms.Panel();
            this.cmbConsorcioProp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).BeginInit();
            this.pnlPropietarioTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).BeginInit();
            this.pnlPropietarioDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPropietario
            // 
            this.dgvPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietario.Location = new System.Drawing.Point(15, 293);
            this.dgvPropietario.Name = "dgvPropietario";
            this.dgvPropietario.Size = new System.Drawing.Size(624, 184);
            this.dgvPropietario.TabIndex = 31;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Nuevo.Location = new System.Drawing.Point(25, 103);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(110, 39);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(206)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Editar.Location = new System.Drawing.Point(25, 230);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(110, 39);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Eliminar.Location = new System.Drawing.Point(25, 288);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 39);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(236)))), ((int)(((byte)(139)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Agregar.Location = new System.Drawing.Point(25, 168);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 39);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_Buscar.Location = new System.Drawing.Point(153, 260);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(476, 16);
            this.txt_Buscar.TabIndex = 4;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Buscar.Location = new System.Drawing.Point(12, 263);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(53, 17);
            this.lbl_Buscar.TabIndex = 32;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Silver;
            this.lblDireccion.Location = new System.Drawing.Point(12, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 17);
            this.lblDireccion.TabIndex = 40;
            this.lblDireccion.Text = "Propietario:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txt_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.ForeColor = System.Drawing.Color.Silver;
            this.txt_Direccion.Location = new System.Drawing.Point(153, 105);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(283, 16);
            this.txt_Direccion.TabIndex = 1;
            // 
            // lblConsorcio
            // 
            this.lblConsorcio.AutoSize = true;
            this.lblConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsorcio.ForeColor = System.Drawing.Color.Silver;
            this.lblConsorcio.Location = new System.Drawing.Point(12, 60);
            this.lblConsorcio.Name = "lblConsorcio";
            this.lblConsorcio.Size = new System.Drawing.Size(135, 17);
            this.lblConsorcio.TabIndex = 37;
            this.lblConsorcio.Text = "Nombre Consorcio:";
            // 
            // txt_Unidad
            // 
            this.txt_Unidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txt_Unidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Unidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unidad.ForeColor = System.Drawing.Color.Silver;
            this.txt_Unidad.Location = new System.Drawing.Point(153, 152);
            this.txt_Unidad.Name = "txt_Unidad";
            this.txt_Unidad.Size = new System.Drawing.Size(261, 14);
            this.txt_Unidad.TabIndex = 2;
            // 
            // lblEmailProp
            // 
            this.lblEmailProp.AutoSize = true;
            this.lblEmailProp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProp.ForeColor = System.Drawing.Color.Silver;
            this.lblEmailProp.Location = new System.Drawing.Point(12, 151);
            this.lblEmailProp.Name = "lblEmailProp";
            this.lblEmailProp.Size = new System.Drawing.Size(47, 17);
            this.lblEmailProp.TabIndex = 33;
            this.lblEmailProp.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(560, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 16);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(397, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Porcentaje Unidad:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(152, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 16);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "N° Unidad:";
            // 
            // pnlPropietarioTop
            // 
            this.pnlPropietarioTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlPropietarioTop.Controls.Add(this.ipbExitPropietario);
            this.pnlPropietarioTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPropietarioTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPropietarioTop.Name = "pnlPropietarioTop";
            this.pnlPropietarioTop.Size = new System.Drawing.Size(816, 26);
            this.pnlPropietarioTop.TabIndex = 32;
            // 
            // ipbExitPropietario
            // 
            this.ipbExitPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitPropietario.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitPropietario.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitPropietario.IconColor = System.Drawing.Color.Silver;
            this.ipbExitPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitPropietario.IconSize = 23;
            this.ipbExitPropietario.Location = new System.Drawing.Point(787, 3);
            this.ipbExitPropietario.Name = "ipbExitPropietario";
            this.ipbExitPropietario.Size = new System.Drawing.Size(26, 23);
            this.ipbExitPropietario.TabIndex = 0;
            this.ipbExitPropietario.TabStop = false;
            this.ipbExitPropietario.Click += new System.EventHandler(this.ipbExitPropietario_Click);
            // 
            // pnlPropietarioDerecha
            // 
            this.pnlPropietarioDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Nuevo);
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Agregar);
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Editar);
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Eliminar);
            this.pnlPropietarioDerecha.Location = new System.Drawing.Point(660, 26);
            this.pnlPropietarioDerecha.Name = "pnlPropietarioDerecha";
            this.pnlPropietarioDerecha.Size = new System.Drawing.Size(158, 461);
            this.pnlPropietarioDerecha.TabIndex = 45;
            // 
            // pnlNombreConsorcio
            // 
            this.pnlNombreConsorcio.BackColor = System.Drawing.Color.Silver;
            this.pnlNombreConsorcio.Location = new System.Drawing.Point(153, 83);
            this.pnlNombreConsorcio.Name = "pnlNombreConsorcio";
            this.pnlNombreConsorcio.Size = new System.Drawing.Size(285, 1);
            this.pnlNombreConsorcio.TabIndex = 46;
            // 
            // pnlNombrePropietario
            // 
            this.pnlNombrePropietario.BackColor = System.Drawing.Color.Silver;
            this.pnlNombrePropietario.Location = new System.Drawing.Point(153, 129);
            this.pnlNombrePropietario.Name = "pnlNombrePropietario";
            this.pnlNombrePropietario.Size = new System.Drawing.Size(285, 1);
            this.pnlNombrePropietario.TabIndex = 47;
            // 
            // pnlTel
            // 
            this.pnlTel.BackColor = System.Drawing.Color.Silver;
            this.pnlTel.Location = new System.Drawing.Point(153, 173);
            this.pnlTel.Name = "pnlTel";
            this.pnlTel.Size = new System.Drawing.Size(250, 1);
            this.pnlTel.TabIndex = 48;
            // 
            // pnlBuscarPropietario
            // 
            this.pnlBuscarPropietario.BackColor = System.Drawing.Color.Silver;
            this.pnlBuscarPropietario.Location = new System.Drawing.Point(153, 286);
            this.pnlBuscarPropietario.Name = "pnlBuscarPropietario";
            this.pnlBuscarPropietario.Size = new System.Drawing.Size(475, 1);
            this.pnlBuscarPropietario.TabIndex = 47;
            // 
            // pnlNumUnidad
            // 
            this.pnlNumUnidad.BackColor = System.Drawing.Color.Silver;
            this.pnlNumUnidad.Location = new System.Drawing.Point(152, 229);
            this.pnlNumUnidad.Name = "pnlNumUnidad";
            this.pnlNumUnidad.Size = new System.Drawing.Size(79, 1);
            this.pnlNumUnidad.TabIndex = 48;
            // 
            // pnlPorcentajeUnidad
            // 
            this.pnlPorcentajeUnidad.BackColor = System.Drawing.Color.Silver;
            this.pnlPorcentajeUnidad.Location = new System.Drawing.Point(560, 229);
            this.pnlPorcentajeUnidad.Name = "pnlPorcentajeUnidad";
            this.pnlPorcentajeUnidad.Size = new System.Drawing.Size(79, 1);
            this.pnlPorcentajeUnidad.TabIndex = 49;
            // 
            // cmbConsorcioProp
            // 
            this.cmbConsorcioProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConsorcioProp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsorcioProp.ForeColor = System.Drawing.Color.Silver;
            this.cmbConsorcioProp.FormattingEnabled = true;
            this.cmbConsorcioProp.Location = new System.Drawing.Point(154, 60);
            this.cmbConsorcioProp.Name = "cmbConsorcioProp";
            this.cmbConsorcioProp.Size = new System.Drawing.Size(284, 25);
            this.cmbConsorcioProp.TabIndex = 50;
            // 
            // frmPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.cmbConsorcioProp);
            this.Controls.Add(this.pnlPorcentajeUnidad);
            this.Controls.Add(this.pnlNumUnidad);
            this.Controls.Add(this.pnlBuscarPropietario);
            this.Controls.Add(this.pnlTel);
            this.Controls.Add(this.pnlNombrePropietario);
            this.Controls.Add(this.pnlNombreConsorcio);
            this.Controls.Add(this.pnlPropietarioDerecha);
            this.Controls.Add(this.pnlPropietarioTop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lblConsorcio);
            this.Controls.Add(this.txt_Unidad);
            this.Controls.Add(this.lblEmailProp);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.dgvPropietario);
            this.Controls.Add(this.txt_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmPropietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).EndInit();
            this.pnlPropietarioTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).EndInit();
            this.pnlPropietarioDerecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropietario;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lblConsorcio;
        private System.Windows.Forms.TextBox txt_Unidad;
        private System.Windows.Forms.Label lblEmailProp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPropietarioTop;
        private System.Windows.Forms.Panel pnlPropietarioDerecha;
        private FontAwesome.Sharp.IconPictureBox ipbExitPropietario;
        private System.Windows.Forms.Panel pnlNombreConsorcio;
        private System.Windows.Forms.Panel pnlNombrePropietario;
        private System.Windows.Forms.Panel pnlTel;
        private System.Windows.Forms.Panel pnlBuscarPropietario;
        private System.Windows.Forms.Panel pnlNumUnidad;
        private System.Windows.Forms.Panel pnlPorcentajeUnidad;
        private System.Windows.Forms.ComboBox cmbConsorcioProp;
    }
}