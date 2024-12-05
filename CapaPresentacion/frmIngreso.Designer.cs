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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConsorcioIngreso = new System.Windows.Forms.Label();
            this.lblPropIngreso = new System.Windows.Forms.Label();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.dgvMontoPagado = new System.Windows.Forms.DataGridView();
            this.btnGuardarIngreso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlMontoPagado = new System.Windows.Forms.Panel();
            this.pnlIngresoTop = new System.Windows.Forms.Panel();
            this.ipbExitIngreso = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoPagado)).BeginInit();
            this.pnlIngresoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 25);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(135, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 15);
            this.textBox1.TabIndex = 3;
            // 
            // lblConsorcioIngreso
            // 
            this.lblConsorcioIngreso.AutoSize = true;
            this.lblConsorcioIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsorcioIngreso.ForeColor = System.Drawing.Color.Silver;
            this.lblConsorcioIngreso.Location = new System.Drawing.Point(21, 42);
            this.lblConsorcioIngreso.Name = "lblConsorcioIngreso";
            this.lblConsorcioIngreso.Size = new System.Drawing.Size(78, 17);
            this.lblConsorcioIngreso.TabIndex = 4;
            this.lblConsorcioIngreso.Text = "Consorcio:";
            // 
            // lblPropIngreso
            // 
            this.lblPropIngreso.AutoSize = true;
            this.lblPropIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropIngreso.ForeColor = System.Drawing.Color.Silver;
            this.lblPropIngreso.Location = new System.Drawing.Point(21, 96);
            this.lblPropIngreso.Name = "lblPropIngreso";
            this.lblPropIngreso.Size = new System.Drawing.Size(83, 17);
            this.lblPropIngreso.TabIndex = 5;
            this.lblPropIngreso.Text = "Propietario:";
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagado.ForeColor = System.Drawing.Color.Silver;
            this.lblMontoPagado.Location = new System.Drawing.Point(21, 148);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(111, 17);
            this.lblMontoPagado.TabIndex = 6;
            this.lblMontoPagado.Text = "Monto Pagado:";
            // 
            // dgvMontoPagado
            // 
            this.dgvMontoPagado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontoPagado.Location = new System.Drawing.Point(12, 240);
            this.dgvMontoPagado.Name = "dgvMontoPagado";
            this.dgvMontoPagado.Size = new System.Drawing.Size(407, 185);
            this.dgvMontoPagado.TabIndex = 7;
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngreso.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardarIngreso.Location = new System.Drawing.Point(86, 195);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(110, 39);
            this.btnGuardarIngreso.TabIndex = 8;
            this.btnGuardarIngreso.Text = "Guardar";
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Location = new System.Drawing.Point(214, 195);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // pnlMontoPagado
            // 
            this.pnlMontoPagado.BackColor = System.Drawing.Color.Silver;
            this.pnlMontoPagado.Location = new System.Drawing.Point(135, 169);
            this.pnlMontoPagado.Name = "pnlMontoPagado";
            this.pnlMontoPagado.Size = new System.Drawing.Size(170, 1);
            this.pnlMontoPagado.TabIndex = 10;
            // 
            // pnlIngresoTop
            // 
            this.pnlIngresoTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlIngresoTop.Controls.Add(this.ipbExitIngreso);
            this.pnlIngresoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIngresoTop.Location = new System.Drawing.Point(0, 0);
            this.pnlIngresoTop.Name = "pnlIngresoTop";
            this.pnlIngresoTop.Size = new System.Drawing.Size(431, 27);
            this.pnlIngresoTop.TabIndex = 11;
            // 
            // ipbExitIngreso
            // 
            this.ipbExitIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitIngreso.ForeColor = System.Drawing.Color.DarkGray;
            this.ipbExitIngreso.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitIngreso.IconColor = System.Drawing.Color.DarkGray;
            this.ipbExitIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitIngreso.IconSize = 23;
            this.ipbExitIngreso.Location = new System.Drawing.Point(404, 0);
            this.ipbExitIngreso.Name = "ipbExitIngreso";
            this.ipbExitIngreso.Size = new System.Drawing.Size(24, 23);
            this.ipbExitIngreso.TabIndex = 0;
            this.ipbExitIngreso.TabStop = false;
            this.ipbExitIngreso.Click += new System.EventHandler(this.ipbExitIngreso_Click);
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(431, 437);
            this.Controls.Add(this.pnlIngresoTop);
            this.Controls.Add(this.pnlMontoPagado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.dgvMontoPagado);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.lblPropIngreso);
            this.Controls.Add(this.lblConsorcioIngreso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngreso";
            this.Text = "frmIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoPagado)).EndInit();
            this.pnlIngresoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConsorcioIngreso;
        private System.Windows.Forms.Label lblPropIngreso;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.DataGridView dgvMontoPagado;
        private System.Windows.Forms.Button btnGuardarIngreso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlMontoPagado;
        private System.Windows.Forms.Panel pnlIngresoTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitIngreso;
    }
}