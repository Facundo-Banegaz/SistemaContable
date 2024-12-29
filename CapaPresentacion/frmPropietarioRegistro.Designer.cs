namespace CapaPresentacion
{
    partial class frmPropietarioRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropietarioRegistro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuscarPropRegistro = new System.Windows.Forms.Label();
            this.txtBuscarPropRegistro = new System.Windows.Forms.TextBox();
            this.pnlBuscarPropRegistro = new System.Windows.Forms.Panel();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgvPropietariosRegistro = new System.Windows.Forms.DataGridView();
            this.pnlPropietarioTop = new System.Windows.Forms.Panel();
            this.ipbExitPropietario = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietariosRegistro)).BeginInit();
            this.pnlPropietarioTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPropRegistro
            // 
            this.lblBuscarPropRegistro.AutoSize = true;
            this.lblBuscarPropRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPropRegistro.ForeColor = System.Drawing.Color.Silver;
            this.lblBuscarPropRegistro.Location = new System.Drawing.Point(24, 93);
            this.lblBuscarPropRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPropRegistro.Name = "lblBuscarPropRegistro";
            this.lblBuscarPropRegistro.Size = new System.Drawing.Size(79, 23);
            this.lblBuscarPropRegistro.TabIndex = 0;
            this.lblBuscarPropRegistro.Text = "Buscar:";
            // 
            // txtBuscarPropRegistro
            // 
            this.txtBuscarPropRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtBuscarPropRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarPropRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPropRegistro.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscarPropRegistro.Location = new System.Drawing.Point(186, 89);
            this.txtBuscarPropRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarPropRegistro.Name = "txtBuscarPropRegistro";
            this.txtBuscarPropRegistro.Size = new System.Drawing.Size(884, 24);
            this.txtBuscarPropRegistro.TabIndex = 0;
            // 
            // pnlBuscarPropRegistro
            // 
            this.pnlBuscarPropRegistro.BackColor = System.Drawing.Color.Silver;
            this.pnlBuscarPropRegistro.Location = new System.Drawing.Point(170, 123);
            this.pnlBuscarPropRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBuscarPropRegistro.Name = "pnlBuscarPropRegistro";
            this.pnlBuscarPropRegistro.Size = new System.Drawing.Size(900, 2);
            this.pnlBuscarPropRegistro.TabIndex = 3;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_resultado.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(181, 180);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 25);
            this.lbl_resultado.TabIndex = 90;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(698, 180);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 25);
            this.lbl_total.TabIndex = 89;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_buscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1139, 74);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(226, 80);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(1139, 165);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(226, 80);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dgvPropietariosRegistro
            // 
            this.dgvPropietariosRegistro.AllowUserToAddRows = false;
            this.dgvPropietariosRegistro.AllowUserToDeleteRows = false;
            this.dgvPropietariosRegistro.AllowUserToOrderColumns = true;
            this.dgvPropietariosRegistro.AllowUserToResizeRows = false;
            this.dgvPropietariosRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropietariosRegistro.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPropietariosRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPropietariosRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropietariosRegistro.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPropietariosRegistro.EnableHeadersVisualStyles = false;
            this.dgvPropietariosRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPropietariosRegistro.Location = new System.Drawing.Point(22, 517);
            this.dgvPropietariosRegistro.Name = "dgvPropietariosRegistro";
            this.dgvPropietariosRegistro.ReadOnly = true;
            this.dgvPropietariosRegistro.RowHeadersVisible = false;
            this.dgvPropietariosRegistro.RowHeadersWidth = 62;
            this.dgvPropietariosRegistro.RowTemplate.Height = 28;
            this.dgvPropietariosRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropietariosRegistro.Size = new System.Drawing.Size(1330, 380);
            this.dgvPropietariosRegistro.TabIndex = 93;
            // 
            // pnlPropietarioTop
            // 
            this.pnlPropietarioTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlPropietarioTop.Controls.Add(this.ipbExitPropietario);
            this.pnlPropietarioTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPropietarioTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPropietarioTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPropietarioTop.Name = "pnlPropietarioTop";
            this.pnlPropietarioTop.Size = new System.Drawing.Size(1377, 40);
            this.pnlPropietarioTop.TabIndex = 94;
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
            this.ipbExitPropietario.Location = new System.Drawing.Point(1334, 5);
            this.ipbExitPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitPropietario.Name = "ipbExitPropietario";
            this.ipbExitPropietario.Size = new System.Drawing.Size(39, 35);
            this.ipbExitPropietario.TabIndex = 0;
            this.ipbExitPropietario.TabStop = false;
            this.ipbExitPropietario.Click += new System.EventHandler(this.ipbExitPropietario_Click);
            // 
            // frmPropietarioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1377, 919);
            this.Controls.Add(this.pnlPropietarioTop);
            this.Controls.Add(this.dgvPropietariosRegistro);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.pnlBuscarPropRegistro);
            this.Controls.Add(this.txtBuscarPropRegistro);
            this.Controls.Add(this.lblBuscarPropRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPropietarioRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPropietarioRegistro";
            this.Load += new System.EventHandler(this.frmPropietarioRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietariosRegistro)).EndInit();
            this.pnlPropietarioTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPropRegistro;
        private System.Windows.Forms.TextBox txtBuscarPropRegistro;
        private System.Windows.Forms.Panel pnlBuscarPropRegistro;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.DataGridView dgvPropietariosRegistro;
        private System.Windows.Forms.Panel pnlPropietarioTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitPropietario;
    }
}