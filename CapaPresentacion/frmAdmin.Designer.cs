namespace CapaPresentacion
{
    partial class frmAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoAdmin = new System.Windows.Forms.Button();
            this.btnEditarAdmin = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBuscarAdmin = new System.Windows.Forms.Label();
            this.txtBuscarAdmin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipbExitAdmin = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plBuscarAdmin = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoAdmin
            // 
            this.btnNuevoAdmin.BackColor = System.Drawing.Color.White;
            this.btnNuevoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoAdmin.Location = new System.Drawing.Point(44, 254);
            this.btnNuevoAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoAdmin.Name = "btnNuevoAdmin";
            this.btnNuevoAdmin.Size = new System.Drawing.Size(165, 60);
            this.btnNuevoAdmin.TabIndex = 0;
            this.btnNuevoAdmin.Text = "Nuevo";
            this.btnNuevoAdmin.UseVisualStyleBackColor = false;
            this.btnNuevoAdmin.Click += new System.EventHandler(this.btnNuevoAdmin_Click);
            // 
            // btnEditarAdmin
            // 
            this.btnEditarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(206)))));
            this.btnEditarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditarAdmin.Location = new System.Drawing.Point(44, 365);
            this.btnEditarAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarAdmin.Name = "btnEditarAdmin";
            this.btnEditarAdmin.Size = new System.Drawing.Size(165, 60);
            this.btnEditarAdmin.TabIndex = 1;
            this.btnEditarAdmin.Text = "Editar";
            this.btnEditarAdmin.UseVisualStyleBackColor = false;
            this.btnEditarAdmin.Click += new System.EventHandler(this.btnEditarAdmin_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(44, 469);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBuscarAdmin
            // 
            this.lblBuscarAdmin.AutoSize = true;
            this.lblBuscarAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAdmin.ForeColor = System.Drawing.Color.Silver;
            this.lblBuscarAdmin.Location = new System.Drawing.Point(34, 124);
            this.lblBuscarAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAdmin.Name = "lblBuscarAdmin";
            this.lblBuscarAdmin.Size = new System.Drawing.Size(79, 23);
            this.lblBuscarAdmin.TabIndex = 52;
            this.lblBuscarAdmin.Text = "Buscar:";
            // 
            // txtBuscarAdmin
            // 
            this.txtBuscarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtBuscarAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAdmin.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscarAdmin.Location = new System.Drawing.Point(247, 109);
            this.txtBuscarAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarAdmin.Name = "txtBuscarAdmin";
            this.txtBuscarAdmin.Size = new System.Drawing.Size(702, 24);
            this.txtBuscarAdmin.TabIndex = 0;
            this.txtBuscarAdmin.TextChanged += new System.EventHandler(this.txtBuscarAdmin_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.ipbExitAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 40);
            this.panel1.TabIndex = 53;
            // 
            // ipbExitAdmin
            // 
            this.ipbExitAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitAdmin.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitAdmin.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitAdmin.IconColor = System.Drawing.Color.Silver;
            this.ipbExitAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitAdmin.IconSize = 35;
            this.ipbExitAdmin.Location = new System.Drawing.Point(1181, 5);
            this.ipbExitAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitAdmin.Name = "ipbExitAdmin";
            this.ipbExitAdmin.Size = new System.Drawing.Size(39, 35);
            this.ipbExitAdmin.TabIndex = 0;
            this.ipbExitAdmin.TabStop = false;
            this.ipbExitAdmin.Click += new System.EventHandler(this.ipbExitAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditarAdmin);
            this.panel2.Controls.Add(this.btnNuevoAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(987, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 712);
            this.panel2.TabIndex = 54;
            // 
            // plBuscarAdmin
            // 
            this.plBuscarAdmin.BackColor = System.Drawing.Color.Silver;
            this.plBuscarAdmin.Location = new System.Drawing.Point(247, 149);
            this.plBuscarAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plBuscarAdmin.Name = "plBuscarAdmin";
            this.plBuscarAdmin.Size = new System.Drawing.Size(705, 2);
            this.plBuscarAdmin.TabIndex = 57;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToOrderColumns = true;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdmin.EnableHeadersVisualStyles = false;
            this.dgvAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAdmin.Location = new System.Drawing.Point(38, 282);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidth = 62;
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(914, 418);
            this.dgvAdmin.TabIndex = 101;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1224, 752);
            this.ControlBox = false;
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.plBuscarAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBuscarAdmin);
            this.Controls.Add(this.txtBuscarAdmin);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1224, 752);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1224, 752);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoAdmin;
        private System.Windows.Forms.Button btnEditarAdmin;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscarAdmin;
        private System.Windows.Forms.TextBox txtBuscarAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel plBuscarAdmin;
        private FontAwesome.Sharp.IconPictureBox ipbExitAdmin;
        public System.Windows.Forms.DataGridView dgvAdmin;
    }
}