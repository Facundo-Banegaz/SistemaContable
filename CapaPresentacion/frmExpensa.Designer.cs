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
            this.cmbConsorcioExpensa = new System.Windows.Forms.ComboBox();
            this.btnReporteExpensa = new System.Windows.Forms.Button();
            this.btnLimpiarExpensa = new System.Windows.Forms.Button();
            this.dgvExpensaFinal = new System.Windows.Forms.DataGridView();
            this.pnlExpensaTop = new System.Windows.Forms.Panel();
            this.ipbExitExpensa = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensaFinal)).BeginInit();
            this.pnlExpensaTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitExpensa)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbConsorcioExpensa
            // 
            this.cmbConsorcioExpensa.FormattingEnabled = true;
            this.cmbConsorcioExpensa.Location = new System.Drawing.Point(12, 50);
            this.cmbConsorcioExpensa.Name = "cmbConsorcioExpensa";
            this.cmbConsorcioExpensa.Size = new System.Drawing.Size(307, 21);
            this.cmbConsorcioExpensa.TabIndex = 0;
            // 
            // btnReporteExpensa
            // 
            this.btnReporteExpensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteExpensa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteExpensa.ForeColor = System.Drawing.Color.Silver;
            this.btnReporteExpensa.Location = new System.Drawing.Point(383, 40);
            this.btnReporteExpensa.Name = "btnReporteExpensa";
            this.btnReporteExpensa.Size = new System.Drawing.Size(110, 39);
            this.btnReporteExpensa.TabIndex = 1;
            this.btnReporteExpensa.Text = "Reporte";
            this.btnReporteExpensa.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarExpensa
            // 
            this.btnLimpiarExpensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarExpensa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarExpensa.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiarExpensa.Location = new System.Drawing.Point(518, 40);
            this.btnLimpiarExpensa.Name = "btnLimpiarExpensa";
            this.btnLimpiarExpensa.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiarExpensa.TabIndex = 3;
            this.btnLimpiarExpensa.Text = "Limpiar";
            this.btnLimpiarExpensa.UseVisualStyleBackColor = true;
            // 
            // dgvExpensaFinal
            // 
            this.dgvExpensaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpensaFinal.Location = new System.Drawing.Point(12, 139);
            this.dgvExpensaFinal.Name = "dgvExpensaFinal";
            this.dgvExpensaFinal.Size = new System.Drawing.Size(745, 306);
            this.dgvExpensaFinal.TabIndex = 4;
            // 
            // pnlExpensaTop
            // 
            this.pnlExpensaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlExpensaTop.Controls.Add(this.ipbExitExpensa);
            this.pnlExpensaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpensaTop.Location = new System.Drawing.Point(0, 0);
            this.pnlExpensaTop.Name = "pnlExpensaTop";
            this.pnlExpensaTop.Size = new System.Drawing.Size(769, 26);
            this.pnlExpensaTop.TabIndex = 5;
            // 
            // ipbExitExpensa
            // 
            this.ipbExitExpensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitExpensa.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitExpensa.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitExpensa.IconColor = System.Drawing.Color.Silver;
            this.ipbExitExpensa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitExpensa.IconSize = 23;
            this.ipbExitExpensa.Location = new System.Drawing.Point(743, 3);
            this.ipbExitExpensa.Name = "ipbExitExpensa";
            this.ipbExitExpensa.Size = new System.Drawing.Size(26, 23);
            this.ipbExitExpensa.TabIndex = 0;
            this.ipbExitExpensa.TabStop = false;
            this.ipbExitExpensa.Click += new System.EventHandler(this.ipbExitExpensa_Click);
            // 
            // frmExpensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.pnlExpensaTop);
            this.Controls.Add(this.dgvExpensaFinal);
            this.Controls.Add(this.btnLimpiarExpensa);
            this.Controls.Add(this.btnReporteExpensa);
            this.Controls.Add(this.cmbConsorcioExpensa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpensa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExpensa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensaFinal)).EndInit();
            this.pnlExpensaTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitExpensa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbConsorcioExpensa;
        private System.Windows.Forms.Button btnReporteExpensa;
        private System.Windows.Forms.Button btnLimpiarExpensa;
        private System.Windows.Forms.DataGridView dgvExpensaFinal;
        private System.Windows.Forms.Panel pnlExpensaTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitExpensa;
    }
}