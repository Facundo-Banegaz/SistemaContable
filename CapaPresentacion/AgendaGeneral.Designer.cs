namespace CapaPresentacion
{
    partial class AgendaGeneral
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
            this.rtxtAgendaGeneral = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pnlAgendaGeneralTop = new System.Windows.Forms.Panel();
            this.ipbExitAgenda = new FontAwesome.Sharp.IconPictureBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.pnlAgendaGeneralTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtAgendaGeneral
            // 
            this.rtxtAgendaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rtxtAgendaGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAgendaGeneral.ForeColor = System.Drawing.Color.Silver;
            this.rtxtAgendaGeneral.Location = new System.Drawing.Point(57, 171);
            this.rtxtAgendaGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtAgendaGeneral.Name = "rtxtAgendaGeneral";
            this.rtxtAgendaGeneral.Size = new System.Drawing.Size(836, 172);
            this.rtxtAgendaGeneral.TabIndex = 1;
            this.rtxtAgendaGeneral.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(909, 578);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(222, 69);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(909, 375);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(222, 69);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // pnlAgendaGeneralTop
            // 
            this.pnlAgendaGeneralTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlAgendaGeneralTop.Controls.Add(this.ipbExitAgenda);
            this.pnlAgendaGeneralTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgendaGeneralTop.Location = new System.Drawing.Point(0, 0);
            this.pnlAgendaGeneralTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAgendaGeneralTop.Name = "pnlAgendaGeneralTop";
            this.pnlAgendaGeneralTop.Size = new System.Drawing.Size(1185, 40);
            this.pnlAgendaGeneralTop.TabIndex = 6;
            // 
            // ipbExitAgenda
            // 
            this.ipbExitAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitAgenda.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitAgenda.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitAgenda.IconColor = System.Drawing.Color.Silver;
            this.ipbExitAgenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitAgenda.IconSize = 40;
            this.ipbExitAgenda.Location = new System.Drawing.Point(1139, 0);
            this.ipbExitAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitAgenda.Name = "ipbExitAgenda";
            this.ipbExitAgenda.Size = new System.Drawing.Size(42, 40);
            this.ipbExitAgenda.TabIndex = 0;
            this.ipbExitAgenda.TabStop = false;
            this.ipbExitAgenda.Click += new System.EventHandler(this.ipbExitAgenda_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(304, 69);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 26);
            this.dtp_fecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(87, 69);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 23);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(64, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion:";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToOrderColumns = true;
            this.dgvAgenda.AllowUserToResizeRows = false;
            this.dgvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.EnableHeadersVisualStyles = false;
            this.dgvAgenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAgenda.Location = new System.Drawing.Point(56, 375);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.RowHeadersWidth = 62;
            this.dgvAgenda.RowTemplate.Height = 28;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(837, 283);
            this.dgvAgenda.TabIndex = 104;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Silver;
            this.btn_eliminar.Location = new System.Drawing.Point(909, 477);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(222, 69);
            this.btn_eliminar.TabIndex = 105;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // AgendaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1185, 672);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.pnlAgendaGeneralTop);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtxtAgendaGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgendaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaGeneral";
            this.Load += new System.EventHandler(this.AgendaGeneral_Load);
            this.pnlAgendaGeneralTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxtAgendaGeneral;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Panel pnlAgendaGeneralTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitAgenda;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btn_eliminar;
    }
}