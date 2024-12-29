namespace CapaPresentacion
{
    partial class frmUnidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPropietarioDerecha = new System.Windows.Forms.Panel();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pnlPropietarioTop = new System.Windows.Forms.Panel();
            this.ipbExitPropietario = new FontAwesome.Sharp.IconPictureBox();
            this.dgvUnididades = new System.Windows.Forms.DataGridView();
            this.pnlBuscarPropietario = new System.Windows.Forms.Panel();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pnlPropietarioDerecha.SuspendLayout();
            this.pnlPropietarioTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnididades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPropietarioDerecha
            // 
            this.pnlPropietarioDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Nuevo);
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Editar);
            this.pnlPropietarioDerecha.Controls.Add(this.btn_Eliminar);
            this.pnlPropietarioDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPropietarioDerecha.Location = new System.Drawing.Point(987, 0);
            this.pnlPropietarioDerecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPropietarioDerecha.Name = "pnlPropietarioDerecha";
            this.pnlPropietarioDerecha.Size = new System.Drawing.Size(237, 752);
            this.pnlPropietarioDerecha.TabIndex = 60;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Nuevo.Location = new System.Drawing.Point(38, 244);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(165, 60);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(206)))));
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Editar.Location = new System.Drawing.Point(38, 354);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(165, 60);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Eliminar.Location = new System.Drawing.Point(38, 443);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(165, 60);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // pnlPropietarioTop
            // 
            this.pnlPropietarioTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlPropietarioTop.Controls.Add(this.ipbExitPropietario);
            this.pnlPropietarioTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPropietarioTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPropietarioTop.Name = "pnlPropietarioTop";
            this.pnlPropietarioTop.Size = new System.Drawing.Size(1224, 40);
            this.pnlPropietarioTop.TabIndex = 61;
            // 
            // ipbExitPropietario
            // 
            this.ipbExitPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitPropietario.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitPropietario.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitPropietario.IconColor = System.Drawing.Color.Silver;
            this.ipbExitPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitPropietario.IconSize = 35;
            this.ipbExitPropietario.Location = new System.Drawing.Point(1180, 5);
            this.ipbExitPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitPropietario.Name = "ipbExitPropietario";
            this.ipbExitPropietario.Size = new System.Drawing.Size(39, 35);
            this.ipbExitPropietario.TabIndex = 0;
            this.ipbExitPropietario.TabStop = false;
            this.ipbExitPropietario.Click += new System.EventHandler(this.ipbExitPropietario_Click);
            // 
            // dgvUnididades
            // 
            this.dgvUnididades.AllowUserToAddRows = false;
            this.dgvUnididades.AllowUserToDeleteRows = false;
            this.dgvUnididades.AllowUserToOrderColumns = true;
            this.dgvUnididades.AllowUserToResizeRows = false;
            this.dgvUnididades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnididades.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnididades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnididades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnididades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnididades.EnableHeadersVisualStyles = false;
            this.dgvUnididades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvUnididades.Location = new System.Drawing.Point(12, 277);
            this.dgvUnididades.Name = "dgvUnididades";
            this.dgvUnididades.ReadOnly = true;
            this.dgvUnididades.RowHeadersVisible = false;
            this.dgvUnididades.RowHeadersWidth = 62;
            this.dgvUnididades.RowTemplate.Height = 28;
            this.dgvUnididades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnididades.Size = new System.Drawing.Size(922, 439);
            this.dgvUnididades.TabIndex = 103;
            // 
            // pnlBuscarPropietario
            // 
            this.pnlBuscarPropietario.BackColor = System.Drawing.Color.Silver;
            this.pnlBuscarPropietario.Location = new System.Drawing.Point(222, 199);
            this.pnlBuscarPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBuscarPropietario.Name = "pnlBuscarPropietario";
            this.pnlBuscarPropietario.Size = new System.Drawing.Size(712, 2);
            this.pnlBuscarPropietario.TabIndex = 102;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Buscar.Location = new System.Drawing.Point(10, 164);
            this.lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(79, 23);
            this.lbl_Buscar.TabIndex = 101;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_Buscar.Location = new System.Drawing.Point(222, 159);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(714, 24);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // frmUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1224, 752);
            this.Controls.Add(this.dgvUnididades);
            this.Controls.Add(this.pnlBuscarPropietario);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.pnlPropietarioTop);
            this.Controls.Add(this.pnlPropietarioDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUnidad";
            this.Load += new System.EventHandler(this.frmUnidad_Load);
            this.pnlPropietarioDerecha.ResumeLayout(false);
            this.pnlPropietarioTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnididades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPropietarioDerecha;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Panel pnlPropietarioTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitPropietario;
        public System.Windows.Forms.DataGridView dgvUnididades;
        private System.Windows.Forms.Panel pnlBuscarPropietario;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
    }
}