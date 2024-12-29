namespace CapaPresentacion
{
    partial class frmIngreso
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboConsorcio = new System.Windows.Forms.ComboBox();
            this.cboPropietario = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblConsorcioIngreso = new System.Windows.Forms.Label();
            this.lblPropIngreso = new System.Windows.Forms.Label();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.btnGuardarIngreso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlMontoPagado = new System.Windows.Forms.Panel();
            this.pnlIngresoTop = new System.Windows.Forms.Panel();
            this.ipbExitIngreso = new FontAwesome.Sharp.IconPictureBox();
            this.dgvMontoPagado = new System.Windows.Forms.DataGridView();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlIngresoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoPagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConsorcio
            // 
            this.cboConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboConsorcio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsorcio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsorcio.ForeColor = System.Drawing.Color.Silver;
            this.cboConsorcio.FormattingEnabled = true;
            this.cboConsorcio.Location = new System.Drawing.Point(233, 65);
            this.cboConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConsorcio.Name = "cboConsorcio";
            this.cboConsorcio.Size = new System.Drawing.Size(382, 29);
            this.cboConsorcio.TabIndex = 0;
            // 
            // cboPropietario
            // 
            this.cboPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropietario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPropietario.ForeColor = System.Drawing.Color.Silver;
            this.cboPropietario.FormattingEnabled = true;
            this.cboPropietario.Location = new System.Drawing.Point(233, 140);
            this.cboPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPropietario.Name = "cboPropietario";
            this.cboPropietario.Size = new System.Drawing.Size(382, 29);
            this.cboPropietario.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Silver;
            this.txtMonto.Location = new System.Drawing.Point(321, 228);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(236, 23);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblConsorcioIngreso
            // 
            this.lblConsorcioIngreso.AutoSize = true;
            this.lblConsorcioIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsorcioIngreso.ForeColor = System.Drawing.Color.Silver;
            this.lblConsorcioIngreso.Location = new System.Drawing.Point(32, 65);
            this.lblConsorcioIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsorcioIngreso.Name = "lblConsorcioIngreso";
            this.lblConsorcioIngreso.Size = new System.Drawing.Size(112, 23);
            this.lblConsorcioIngreso.TabIndex = 4;
            this.lblConsorcioIngreso.Text = "Consorcio:";
            // 
            // lblPropIngreso
            // 
            this.lblPropIngreso.AutoSize = true;
            this.lblPropIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropIngreso.ForeColor = System.Drawing.Color.Silver;
            this.lblPropIngreso.Location = new System.Drawing.Point(32, 148);
            this.lblPropIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropIngreso.Name = "lblPropIngreso";
            this.lblPropIngreso.Size = new System.Drawing.Size(119, 23);
            this.lblPropIngreso.TabIndex = 5;
            this.lblPropIngreso.Text = "Propietario:";
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagado.ForeColor = System.Drawing.Color.Silver;
            this.lblMontoPagado.Location = new System.Drawing.Point(32, 228);
            this.lblMontoPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(163, 23);
            this.lblMontoPagado.TabIndex = 6;
            this.lblMontoPagado.Text = "Monto Pagado:";
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngreso.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardarIngreso.Location = new System.Drawing.Point(129, 300);
            this.btnGuardarIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(165, 60);
            this.btnGuardarIngreso.TabIndex = 3;
            this.btnGuardarIngreso.Text = "Guardar";
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            this.btnGuardarIngreso.Click += new System.EventHandler(this.btnGuardarIngreso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Location = new System.Drawing.Point(321, 300);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 60);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlMontoPagado
            // 
            this.pnlMontoPagado.BackColor = System.Drawing.Color.Silver;
            this.pnlMontoPagado.Location = new System.Drawing.Point(321, 260);
            this.pnlMontoPagado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMontoPagado.Name = "pnlMontoPagado";
            this.pnlMontoPagado.Size = new System.Drawing.Size(255, 2);
            this.pnlMontoPagado.TabIndex = 10;
            // 
            // pnlIngresoTop
            // 
            this.pnlIngresoTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlIngresoTop.Controls.Add(this.ipbExitIngreso);
            this.pnlIngresoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIngresoTop.Location = new System.Drawing.Point(0, 0);
            this.pnlIngresoTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIngresoTop.Name = "pnlIngresoTop";
            this.pnlIngresoTop.Size = new System.Drawing.Size(646, 42);
            this.pnlIngresoTop.TabIndex = 11;
            // 
            // ipbExitIngreso
            // 
            this.ipbExitIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitIngreso.ForeColor = System.Drawing.Color.DarkGray;
            this.ipbExitIngreso.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitIngreso.IconColor = System.Drawing.Color.DarkGray;
            this.ipbExitIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitIngreso.IconSize = 35;
            this.ipbExitIngreso.Location = new System.Drawing.Point(610, 5);
            this.ipbExitIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitIngreso.Name = "ipbExitIngreso";
            this.ipbExitIngreso.Size = new System.Drawing.Size(36, 35);
            this.ipbExitIngreso.TabIndex = 0;
            this.ipbExitIngreso.TabStop = false;
            this.ipbExitIngreso.Click += new System.EventHandler(this.ipbExitIngreso_Click);
            // 
            // dgvMontoPagado
            // 
            this.dgvMontoPagado.AllowUserToAddRows = false;
            this.dgvMontoPagado.AllowUserToDeleteRows = false;
            this.dgvMontoPagado.AllowUserToOrderColumns = true;
            this.dgvMontoPagado.AllowUserToResizeRows = false;
            this.dgvMontoPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMontoPagado.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMontoPagado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMontoPagado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMontoPagado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMontoPagado.EnableHeadersVisualStyles = false;
            this.dgvMontoPagado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvMontoPagado.Location = new System.Drawing.Point(24, 383);
            this.dgvMontoPagado.Name = "dgvMontoPagado";
            this.dgvMontoPagado.ReadOnly = true;
            this.dgvMontoPagado.RowHeadersVisible = false;
            this.dgvMontoPagado.RowHeadersWidth = 62;
            this.dgvMontoPagado.RowTemplate.Height = 28;
            this.dgvMontoPagado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMontoPagado.Size = new System.Drawing.Size(591, 267);
            this.dgvMontoPagado.TabIndex = 6;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(646, 672);
            this.Controls.Add(this.dgvMontoPagado);
            this.Controls.Add(this.pnlIngresoTop);
            this.Controls.Add(this.pnlMontoPagado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.lblPropIngreso);
            this.Controls.Add(this.lblConsorcioIngreso);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cboPropietario);
            this.Controls.Add(this.cboConsorcio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngreso";
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            this.pnlIngresoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoPagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConsorcio;
        private System.Windows.Forms.ComboBox cboPropietario;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblConsorcioIngreso;
        private System.Windows.Forms.Label lblPropIngreso;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.Button btnGuardarIngreso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlMontoPagado;
        private System.Windows.Forms.Panel pnlIngresoTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitIngreso;
        public System.Windows.Forms.DataGridView dgvMontoPagado;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}