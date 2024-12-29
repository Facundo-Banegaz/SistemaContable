namespace CapaPresentacion
{
    partial class frmExpensa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpensa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboExpensas = new System.Windows.Forms.ComboBox();
            this.btnReporteExpensa = new System.Windows.Forms.Button();
            this.pnlExpensaTop = new System.Windows.Forms.Panel();
            this.ipbExitExpensa = new FontAwesome.Sharp.IconPictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgvExpensa = new System.Windows.Forms.DataGridView();
            this.pnlExpensaTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitExpensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensa)).BeginInit();
            this.SuspendLayout();
            // 
            // cboExpensas
            // 
            this.cboExpensas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboExpensas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpensas.FormattingEnabled = true;
            this.cboExpensas.Location = new System.Drawing.Point(61, 83);
            this.cboExpensas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboExpensas.Name = "cboExpensas";
            this.cboExpensas.Size = new System.Drawing.Size(458, 28);
            this.cboExpensas.TabIndex = 0;
            // 
            // btnReporteExpensa
            // 
            this.btnReporteExpensa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteExpensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteExpensa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteExpensa.ForeColor = System.Drawing.Color.Silver;
            this.btnReporteExpensa.Location = new System.Drawing.Point(1034, 64);
            this.btnReporteExpensa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporteExpensa.Name = "btnReporteExpensa";
            this.btnReporteExpensa.Size = new System.Drawing.Size(184, 60);
            this.btnReporteExpensa.TabIndex = 3;
            this.btnReporteExpensa.Text = "Reporte";
            this.btnReporteExpensa.UseVisualStyleBackColor = true;
            this.btnReporteExpensa.Click += new System.EventHandler(this.btnReporteExpensa_Click);
            // 
            // pnlExpensaTop
            // 
            this.pnlExpensaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlExpensaTop.Controls.Add(this.ipbExitExpensa);
            this.pnlExpensaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpensaTop.Location = new System.Drawing.Point(0, 0);
            this.pnlExpensaTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlExpensaTop.Name = "pnlExpensaTop";
            this.pnlExpensaTop.Size = new System.Drawing.Size(1293, 40);
            this.pnlExpensaTop.TabIndex = 5;
            // 
            // ipbExitExpensa
            // 
            this.ipbExitExpensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitExpensa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitExpensa.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitExpensa.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitExpensa.IconColor = System.Drawing.Color.Silver;
            this.ipbExitExpensa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitExpensa.IconSize = 35;
            this.ipbExitExpensa.Location = new System.Drawing.Point(1254, 5);
            this.ipbExitExpensa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitExpensa.Name = "ipbExitExpensa";
            this.ipbExitExpensa.Size = new System.Drawing.Size(39, 35);
            this.ipbExitExpensa.TabIndex = 0;
            this.ipbExitExpensa.TabStop = false;
            this.ipbExitExpensa.Click += new System.EventHandler(this.ipbExitExpensa_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_buscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(696, 64);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(194, 60);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgvExpensa
            // 
            this.dgvExpensa.AllowUserToAddRows = false;
            this.dgvExpensa.AllowUserToDeleteRows = false;
            this.dgvExpensa.AllowUserToOrderColumns = true;
            this.dgvExpensa.AllowUserToResizeRows = false;
            this.dgvExpensa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpensa.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpensa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpensa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpensa.EnableHeadersVisualStyles = false;
            this.dgvExpensa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvExpensa.Location = new System.Drawing.Point(61, 239);
            this.dgvExpensa.Name = "dgvExpensa";
            this.dgvExpensa.ReadOnly = true;
            this.dgvExpensa.RowHeadersVisible = false;
            this.dgvExpensa.RowHeadersWidth = 62;
            this.dgvExpensa.RowTemplate.Height = 28;
            this.dgvExpensa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpensa.Size = new System.Drawing.Size(1157, 471);
            this.dgvExpensa.TabIndex = 1;
            // 
            // frmExpensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1293, 722);
            this.Controls.Add(this.dgvExpensa);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.pnlExpensaTop);
            this.Controls.Add(this.btnReporteExpensa);
            this.Controls.Add(this.cboExpensas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExpensa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExpensa";
            this.Load += new System.EventHandler(this.frmExpensa_Load);
            this.pnlExpensaTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitExpensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboExpensas;
        private System.Windows.Forms.Button btnReporteExpensa;
        private System.Windows.Forms.Panel pnlExpensaTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitExpensa;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.DataGridView dgvExpensa;
    }
}