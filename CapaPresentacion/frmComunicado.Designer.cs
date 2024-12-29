namespace CapaPresentacion
{
    partial class frmComunicado
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
            this.lblEnviar = new System.Windows.Forms.Label();
            this.rtxtComunicado = new System.Windows.Forms.RichTextBox();
            this.btnEnviarComunicado = new System.Windows.Forms.Button();
            this.pnlComunicadoTop = new System.Windows.Forms.Panel();
            this.ipbExitComunicado = new FontAwesome.Sharp.IconPictureBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlComunicadoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitComunicado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.Silver;
            this.lblEnviar.Location = new System.Drawing.Point(18, 108);
            this.lblEnviar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(100, 23);
            this.lblEnviar.TabIndex = 1;
            this.lblEnviar.Text = "Enviar a :";
            // 
            // rtxtComunicado
            // 
            this.rtxtComunicado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rtxtComunicado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtComunicado.ForeColor = System.Drawing.Color.Silver;
            this.rtxtComunicado.Location = new System.Drawing.Point(18, 206);
            this.rtxtComunicado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtComunicado.Name = "rtxtComunicado";
            this.rtxtComunicado.Size = new System.Drawing.Size(630, 396);
            this.rtxtComunicado.TabIndex = 2;
            this.rtxtComunicado.Text = "";
            // 
            // btnEnviarComunicado
            // 
            this.btnEnviarComunicado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarComunicado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarComunicado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarComunicado.ForeColor = System.Drawing.Color.Silver;
            this.btnEnviarComunicado.Location = new System.Drawing.Point(255, 632);
            this.btnEnviarComunicado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviarComunicado.Name = "btnEnviarComunicado";
            this.btnEnviarComunicado.Size = new System.Drawing.Size(159, 71);
            this.btnEnviarComunicado.TabIndex = 3;
            this.btnEnviarComunicado.Text = "Enviar";
            this.btnEnviarComunicado.UseVisualStyleBackColor = true;
            this.btnEnviarComunicado.Click += new System.EventHandler(this.btnEnviarComunicado_Click);
            // 
            // pnlComunicadoTop
            // 
            this.pnlComunicadoTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlComunicadoTop.Controls.Add(this.ipbExitComunicado);
            this.pnlComunicadoTop.Location = new System.Drawing.Point(0, 3);
            this.pnlComunicadoTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlComunicadoTop.MaximumSize = new System.Drawing.Size(670, 48);
            this.pnlComunicadoTop.MinimumSize = new System.Drawing.Size(670, 48);
            this.pnlComunicadoTop.Name = "pnlComunicadoTop";
            this.pnlComunicadoTop.Size = new System.Drawing.Size(670, 48);
            this.pnlComunicadoTop.TabIndex = 4;
            // 
            // ipbExitComunicado
            // 
            this.ipbExitComunicado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitComunicado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitComunicado.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitComunicado.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitComunicado.IconColor = System.Drawing.Color.Silver;
            this.ipbExitComunicado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitComunicado.IconSize = 42;
            this.ipbExitComunicado.Location = new System.Drawing.Point(622, 6);
            this.ipbExitComunicado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitComunicado.Name = "ipbExitComunicado";
            this.ipbExitComunicado.Size = new System.Drawing.Size(44, 42);
            this.ipbExitComunicado.TabIndex = 0;
            this.ipbExitComunicado.TabStop = false;
            this.ipbExitComunicado.Click += new System.EventHandler(this.ipbExitComunicado_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtEnviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.ForeColor = System.Drawing.Color.Silver;
            this.txtEnviar.Location = new System.Drawing.Point(236, 105);
            this.txtEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(381, 31);
            this.txtEnviar.TabIndex = 0;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtAsunto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.ForeColor = System.Drawing.Color.Silver;
            this.txtAsunto.Location = new System.Drawing.Point(236, 156);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(381, 31);
            this.txtAsunto.TabIndex = 1;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.ForeColor = System.Drawing.Color.Silver;
            this.lblAsunto.Location = new System.Drawing.Point(18, 159);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(88, 23);
            this.lblAsunto.TabIndex = 16;
            this.lblAsunto.Text = "Asunto :";
            // 
            // txtEmisor
            // 
            this.txtEmisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtEmisor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtEmisor.Location = new System.Drawing.Point(236, 61);
            this.txtEmisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.ReadOnly = true;
            this.txtEmisor.Size = new System.Drawing.Size(381, 31);
            this.txtEmisor.TabIndex = 19;
            this.txtEmisor.Text = "steffiludemann@gmail.com";
            this.txtEmisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email Propio:";
            // 
            // frmComunicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(670, 732);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.pnlComunicadoTop);
            this.Controls.Add(this.btnEnviarComunicado);
            this.Controls.Add(this.rtxtComunicado);
            this.Controls.Add(this.lblEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComunicado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComunicado";
            this.pnlComunicadoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitComunicado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.RichTextBox rtxtComunicado;
        private System.Windows.Forms.Button btnEnviarComunicado;
        private System.Windows.Forms.Panel pnlComunicadoTop;
        private FontAwesome.Sharp.IconPictureBox ipbExitComunicado;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.Label label1;
    }
}