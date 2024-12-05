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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.rtxtAgendaGeneral = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pnlAgendaGeneralTop = new System.Windows.Forms.Panel();
            this.ipbExitAgenda = new FontAwesome.Sharp.IconPictureBox();
            this.pnlAgendaGeneralTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(70, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // rtxtAgendaGeneral
            // 
            this.rtxtAgendaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rtxtAgendaGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAgendaGeneral.ForeColor = System.Drawing.Color.Silver;
            this.rtxtAgendaGeneral.Location = new System.Drawing.Point(70, 226);
            this.rtxtAgendaGeneral.Name = "rtxtAgendaGeneral";
            this.rtxtAgendaGeneral.Size = new System.Drawing.Size(248, 158);
            this.rtxtAgendaGeneral.TabIndex = 1;
            this.rtxtAgendaGeneral.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(333, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 45);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(67, 401);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 17);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "fecha:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(333, 301);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 45);
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
            this.pnlAgendaGeneralTop.Name = "pnlAgendaGeneralTop";
            this.pnlAgendaGeneralTop.Size = new System.Drawing.Size(431, 26);
            this.pnlAgendaGeneralTop.TabIndex = 6;
            // 
            // ipbExitAgenda
            // 
            this.ipbExitAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitAgenda.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitAgenda.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitAgenda.IconColor = System.Drawing.Color.Silver;
            this.ipbExitAgenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitAgenda.IconSize = 26;
            this.ipbExitAgenda.Location = new System.Drawing.Point(403, 0);
            this.ipbExitAgenda.Name = "ipbExitAgenda";
            this.ipbExitAgenda.Size = new System.Drawing.Size(28, 26);
            this.ipbExitAgenda.TabIndex = 0;
            this.ipbExitAgenda.TabStop = false;
            this.ipbExitAgenda.Click += new System.EventHandler(this.ipbExitAgenda_Click);
            // 
            // AgendaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(431, 437);
            this.Controls.Add(this.pnlAgendaGeneralTop);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtxtAgendaGeneral);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaGeneral";
            this.Load += new System.EventHandler(this.AgendaGeneral_Load);
            this.pnlAgendaGeneralTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox rtxtAgendaGeneral;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Panel pnlAgendaGeneralTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitAgenda;
    }
}