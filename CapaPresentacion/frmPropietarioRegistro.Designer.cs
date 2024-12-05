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
            this.lblBuscarPropRegistro = new System.Windows.Forms.Label();
            this.txtBuscarPropRegistro = new System.Windows.Forms.TextBox();
            this.dgvPropietariosRegistro = new System.Windows.Forms.DataGridView();
            this.pnlBuscarPropRegistro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietariosRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPropRegistro
            // 
            this.lblBuscarPropRegistro.AutoSize = true;
            this.lblBuscarPropRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPropRegistro.ForeColor = System.Drawing.Color.Silver;
            this.lblBuscarPropRegistro.Location = new System.Drawing.Point(12, 25);
            this.lblBuscarPropRegistro.Name = "lblBuscarPropRegistro";
            this.lblBuscarPropRegistro.Size = new System.Drawing.Size(53, 17);
            this.lblBuscarPropRegistro.TabIndex = 0;
            this.lblBuscarPropRegistro.Text = "Buscar:";
            // 
            // txtBuscarPropRegistro
            // 
            this.txtBuscarPropRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtBuscarPropRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarPropRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPropRegistro.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscarPropRegistro.Location = new System.Drawing.Point(120, 22);
            this.txtBuscarPropRegistro.Name = "txtBuscarPropRegistro";
            this.txtBuscarPropRegistro.Size = new System.Drawing.Size(589, 16);
            this.txtBuscarPropRegistro.TabIndex = 1;
            // 
            // dgvPropietariosRegistro
            // 
            this.dgvPropietariosRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietariosRegistro.Location = new System.Drawing.Point(12, 67);
            this.dgvPropietariosRegistro.Name = "dgvPropietariosRegistro";
            this.dgvPropietariosRegistro.Size = new System.Drawing.Size(712, 388);
            this.dgvPropietariosRegistro.TabIndex = 2;
            // 
            // pnlBuscarPropRegistro
            // 
            this.pnlBuscarPropRegistro.BackColor = System.Drawing.Color.Silver;
            this.pnlBuscarPropRegistro.Location = new System.Drawing.Point(109, 44);
            this.pnlBuscarPropRegistro.Name = "pnlBuscarPropRegistro";
            this.pnlBuscarPropRegistro.Size = new System.Drawing.Size(600, 1);
            this.pnlBuscarPropRegistro.TabIndex = 3;
            // 
            // frmPropietarioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(736, 467);
            this.Controls.Add(this.pnlBuscarPropRegistro);
            this.Controls.Add(this.dgvPropietariosRegistro);
            this.Controls.Add(this.txtBuscarPropRegistro);
            this.Controls.Add(this.lblBuscarPropRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPropietarioRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPropietarioRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietariosRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPropRegistro;
        private System.Windows.Forms.TextBox txtBuscarPropRegistro;
        private System.Windows.Forms.DataGridView dgvPropietariosRegistro;
        private System.Windows.Forms.Panel pnlBuscarPropRegistro;
    }
}