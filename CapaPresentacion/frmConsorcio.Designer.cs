namespace CapaPresentacion
{
    partial class frmConsorcio
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
            this.lbl_BuscarConsorcio = new System.Windows.Forms.Label();
            this.pnlConsorcio = new System.Windows.Forms.Panel();
            this.btnEliminarConsorcio = new System.Windows.Forms.Button();
            this.btnEditarConsorcio = new System.Windows.Forms.Button();
            this.btnNuevoConsorcio = new System.Windows.Forms.Button();
            this.ipbExitConsorcio = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarConsorcio = new System.Windows.Forms.TextBox();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pnlConsorcioTop = new System.Windows.Forms.Panel();
            this.dgvConsorcio = new System.Windows.Forms.DataGridView();
            this.pnlConsorcio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitConsorcio)).BeginInit();
            this.pnlConsorcioTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsorcio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarConsorcio
            // 
            this.lbl_BuscarConsorcio.AutoSize = true;
            this.lbl_BuscarConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarConsorcio.ForeColor = System.Drawing.Color.Silver;
            this.lbl_BuscarConsorcio.Location = new System.Drawing.Point(13, 121);
            this.lbl_BuscarConsorcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarConsorcio.Name = "lbl_BuscarConsorcio";
            this.lbl_BuscarConsorcio.Size = new System.Drawing.Size(79, 23);
            this.lbl_BuscarConsorcio.TabIndex = 10;
            this.lbl_BuscarConsorcio.Text = "Buscar:";
            // 
            // pnlConsorcio
            // 
            this.pnlConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlConsorcio.Controls.Add(this.btnEliminarConsorcio);
            this.pnlConsorcio.Controls.Add(this.btnEditarConsorcio);
            this.pnlConsorcio.Controls.Add(this.btnNuevoConsorcio);
            this.pnlConsorcio.Location = new System.Drawing.Point(987, 42);
            this.pnlConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConsorcio.Name = "pnlConsorcio";
            this.pnlConsorcio.Size = new System.Drawing.Size(237, 709);
            this.pnlConsorcio.TabIndex = 25;
            // 
            // btnEliminarConsorcio
            // 
            this.btnEliminarConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEliminarConsorcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarConsorcio.FlatAppearance.BorderSize = 0;
            this.btnEliminarConsorcio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConsorcio.Location = new System.Drawing.Point(32, 454);
            this.btnEliminarConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarConsorcio.Name = "btnEliminarConsorcio";
            this.btnEliminarConsorcio.Size = new System.Drawing.Size(165, 60);
            this.btnEliminarConsorcio.TabIndex = 2;
            this.btnEliminarConsorcio.Text = "Eliminar";
            this.btnEliminarConsorcio.UseVisualStyleBackColor = false;
            this.btnEliminarConsorcio.Click += new System.EventHandler(this.btnEliminarConsorcio_Click);
            // 
            // btnEditarConsorcio
            // 
            this.btnEditarConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(206)))));
            this.btnEditarConsorcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarConsorcio.FlatAppearance.BorderSize = 0;
            this.btnEditarConsorcio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConsorcio.Location = new System.Drawing.Point(32, 357);
            this.btnEditarConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarConsorcio.Name = "btnEditarConsorcio";
            this.btnEditarConsorcio.Size = new System.Drawing.Size(165, 60);
            this.btnEditarConsorcio.TabIndex = 1;
            this.btnEditarConsorcio.Text = "Editar";
            this.btnEditarConsorcio.UseVisualStyleBackColor = false;
            this.btnEditarConsorcio.Click += new System.EventHandler(this.btnEditarConsorcio_Click);
            // 
            // btnNuevoConsorcio
            // 
            this.btnNuevoConsorcio.BackColor = System.Drawing.Color.White;
            this.btnNuevoConsorcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoConsorcio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoConsorcio.Location = new System.Drawing.Point(32, 242);
            this.btnNuevoConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoConsorcio.Name = "btnNuevoConsorcio";
            this.btnNuevoConsorcio.Size = new System.Drawing.Size(165, 60);
            this.btnNuevoConsorcio.TabIndex = 0;
            this.btnNuevoConsorcio.Text = "Nuevo";
            this.btnNuevoConsorcio.UseVisualStyleBackColor = false;
            this.btnNuevoConsorcio.Click += new System.EventHandler(this.btnNuevoConsorcio_Click);
            // 
            // ipbExitConsorcio
            // 
            this.ipbExitConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitConsorcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitConsorcio.ForeColor = System.Drawing.Color.LightGray;
            this.ipbExitConsorcio.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitConsorcio.IconColor = System.Drawing.Color.LightGray;
            this.ipbExitConsorcio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitConsorcio.IconSize = 35;
            this.ipbExitConsorcio.Location = new System.Drawing.Point(1180, 5);
            this.ipbExitConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitConsorcio.Name = "ipbExitConsorcio";
            this.ipbExitConsorcio.Size = new System.Drawing.Size(39, 35);
            this.ipbExitConsorcio.TabIndex = 4;
            this.ipbExitConsorcio.TabStop = false;
            this.ipbExitConsorcio.Click += new System.EventHandler(this.ipbExit_Click);
            // 
            // txtBuscarConsorcio
            // 
            this.txtBuscarConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtBuscarConsorcio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarConsorcio.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscarConsorcio.Location = new System.Drawing.Point(225, 122);
            this.txtBuscarConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarConsorcio.Name = "txtBuscarConsorcio";
            this.txtBuscarConsorcio.Size = new System.Drawing.Size(699, 24);
            this.txtBuscarConsorcio.TabIndex = 0;
            this.txtBuscarConsorcio.TextChanged += new System.EventHandler(this.txtBuscarConsorcio_TextChanged);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.Silver;
            this.pnlBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBuscar.Location = new System.Drawing.Point(225, 147);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(690, 2);
            this.pnlBuscar.TabIndex = 27;
            // 
            // pnlConsorcioTop
            // 
            this.pnlConsorcioTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlConsorcioTop.Controls.Add(this.ipbExitConsorcio);
            this.pnlConsorcioTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsorcioTop.Location = new System.Drawing.Point(0, 0);
            this.pnlConsorcioTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConsorcioTop.Name = "pnlConsorcioTop";
            this.pnlConsorcioTop.Size = new System.Drawing.Size(1224, 40);
            this.pnlConsorcioTop.TabIndex = 32;
            // 
            // dgvConsorcio
            // 
            this.dgvConsorcio.AllowUserToAddRows = false;
            this.dgvConsorcio.AllowUserToDeleteRows = false;
            this.dgvConsorcio.AllowUserToOrderColumns = true;
            this.dgvConsorcio.AllowUserToResizeRows = false;
            this.dgvConsorcio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsorcio.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsorcio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsorcio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsorcio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsorcio.EnableHeadersVisualStyles = false;
            this.dgvConsorcio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvConsorcio.Location = new System.Drawing.Point(17, 268);
            this.dgvConsorcio.Name = "dgvConsorcio";
            this.dgvConsorcio.ReadOnly = true;
            this.dgvConsorcio.RowHeadersVisible = false;
            this.dgvConsorcio.RowHeadersWidth = 62;
            this.dgvConsorcio.RowTemplate.Height = 28;
            this.dgvConsorcio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsorcio.Size = new System.Drawing.Size(922, 439);
            this.dgvConsorcio.TabIndex = 100;
            // 
            // frmConsorcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1224, 752);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsorcio);
            this.Controls.Add(this.pnlConsorcioTop);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.txtBuscarConsorcio);
            this.Controls.Add(this.pnlConsorcio);
            this.Controls.Add(this.lbl_BuscarConsorcio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1224, 752);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1224, 752);
            this.Name = "frmConsorcio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsorcio";
            this.Load += new System.EventHandler(this.frmConsorcio_Load);
            this.pnlConsorcio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitConsorcio)).EndInit();
            this.pnlConsorcioTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsorcio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BuscarConsorcio;
        private System.Windows.Forms.Panel pnlConsorcio;
        private System.Windows.Forms.Button btnEliminarConsorcio;
        private System.Windows.Forms.Button btnEditarConsorcio;
        private System.Windows.Forms.Button btnNuevoConsorcio;
        private System.Windows.Forms.TextBox txtBuscarConsorcio;
        private System.Windows.Forms.Panel pnlBuscar;
        private FontAwesome.Sharp.IconPictureBox ipbExitConsorcio;
        private System.Windows.Forms.Panel pnlConsorcioTop;
        public System.Windows.Forms.DataGridView dgvConsorcio;
    }
}