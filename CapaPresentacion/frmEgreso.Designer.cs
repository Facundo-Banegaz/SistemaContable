namespace CapaPresentacion
{
    partial class frmEgreso
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
            this.components = new System.ComponentModel.Container();
            this.pnlEgresoTop = new System.Windows.Forms.Panel();
            this.ipbExitEgreso = new FontAwesome.Sharp.IconPictureBox();
            this.cboConsorcio = new System.Windows.Forms.ComboBox();
            this.pnlEgresoRight = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lblTotalTotalEgreso = new System.Windows.Forms.Label();
            this.lblTotalEgreso = new System.Windows.Forms.Label();
            this.btnLimpiarEgreso = new System.Windows.Forms.Button();
            this.btnAgregarEgreso = new System.Windows.Forms.Button();
            this.lblSueldoEncargado = new System.Windows.Forms.Label();
            this.lblF31 = new System.Windows.Forms.Label();
            this.lblDGRT = new System.Windows.Forms.Label();
            this.lblfateryh = new System.Windows.Forms.Label();
            this.lblSeracarh = new System.Windows.Forms.Label();
            this.lblSuterh = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblLuz = new System.Windows.Forms.Label();
            this.lblAgua = new System.Windows.Forms.Label();
            this.txtSueldoEncargado = new System.Windows.Forms.TextBox();
            this.txtSeracarh = new System.Windows.Forms.TextBox();
            this.txtFateryh = new System.Windows.Forms.TextBox();
            this.txtDGRT = new System.Windows.Forms.TextBox();
            this.txtAportesF931 = new System.Windows.Forms.TextBox();
            this.txtSuterh = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtEdet = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.lblGastosBanc = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblHonorariosAdmin = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtcontador = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_gastos_varios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fumigacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remitos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_limpieza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEgresoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitEgreso)).BeginInit();
            this.pnlEgresoRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEgresoTop
            // 
            this.pnlEgresoTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.pnlEgresoTop.Controls.Add(this.ipbExitEgreso);
            this.pnlEgresoTop.Controls.Add(this.cboConsorcio);
            this.pnlEgresoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEgresoTop.Location = new System.Drawing.Point(0, 0);
            this.pnlEgresoTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEgresoTop.Name = "pnlEgresoTop";
            this.pnlEgresoTop.Size = new System.Drawing.Size(1218, 42);
            this.pnlEgresoTop.TabIndex = 0;
            // 
            // ipbExitEgreso
            // 
            this.ipbExitEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.ipbExitEgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbExitEgreso.ForeColor = System.Drawing.Color.Silver;
            this.ipbExitEgreso.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ipbExitEgreso.IconColor = System.Drawing.Color.Silver;
            this.ipbExitEgreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbExitEgreso.IconSize = 37;
            this.ipbExitEgreso.Location = new System.Drawing.Point(1174, 5);
            this.ipbExitEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipbExitEgreso.Name = "ipbExitEgreso";
            this.ipbExitEgreso.Size = new System.Drawing.Size(44, 37);
            this.ipbExitEgreso.TabIndex = 4;
            this.ipbExitEgreso.TabStop = false;
            this.ipbExitEgreso.Click += new System.EventHandler(this.ipbExitEgreso_Click);
            // 
            // cboConsorcio
            // 
            this.cboConsorcio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboConsorcio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsorcio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsorcio.ForeColor = System.Drawing.Color.Silver;
            this.cboConsorcio.FormattingEnabled = true;
            this.cboConsorcio.Location = new System.Drawing.Point(0, 5);
            this.cboConsorcio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConsorcio.Name = "cboConsorcio";
            this.cboConsorcio.Size = new System.Drawing.Size(310, 31);
            this.cboConsorcio.TabIndex = 0;
            // 
            // pnlEgresoRight
            // 
            this.pnlEgresoRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlEgresoRight.Controls.Add(this.lbl_total);
            this.pnlEgresoRight.Controls.Add(this.lblTotalTotalEgreso);
            this.pnlEgresoRight.Controls.Add(this.lblTotalEgreso);
            this.pnlEgresoRight.Controls.Add(this.btnLimpiarEgreso);
            this.pnlEgresoRight.Controls.Add(this.btnAgregarEgreso);
            this.pnlEgresoRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEgresoRight.Location = new System.Drawing.Point(955, 42);
            this.pnlEgresoRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEgresoRight.Name = "pnlEgresoRight";
            this.pnlEgresoRight.Size = new System.Drawing.Size(263, 760);
            this.pnlEgresoRight.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Silver;
            this.lbl_total.Location = new System.Drawing.Point(13, 628);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 23);
            this.lbl_total.TabIndex = 4;
            // 
            // lblTotalTotalEgreso
            // 
            this.lblTotalTotalEgreso.AutoSize = true;
            this.lblTotalTotalEgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTotalEgreso.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalTotalEgreso.Location = new System.Drawing.Point(78, 561);
            this.lblTotalTotalEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTotalEgreso.Name = "lblTotalTotalEgreso";
            this.lblTotalTotalEgreso.Size = new System.Drawing.Size(57, 23);
            this.lblTotalTotalEgreso.TabIndex = 3;
            this.lblTotalTotalEgreso.Text = "Total";
            // 
            // lblTotalEgreso
            // 
            this.lblTotalEgreso.AutoSize = true;
            this.lblTotalEgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEgreso.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalEgreso.Location = new System.Drawing.Point(44, 510);
            this.lblTotalEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEgreso.Name = "lblTotalEgreso";
            this.lblTotalEgreso.Size = new System.Drawing.Size(132, 23);
            this.lblTotalEgreso.TabIndex = 2;
            this.lblTotalEgreso.Text = "Total Egreso:";
            // 
            // btnLimpiarEgreso
            // 
            this.btnLimpiarEgreso.BackColor = System.Drawing.Color.White;
            this.btnLimpiarEgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEgreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarEgreso.Location = new System.Drawing.Point(33, 285);
            this.btnLimpiarEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarEgreso.Name = "btnLimpiarEgreso";
            this.btnLimpiarEgreso.Size = new System.Drawing.Size(165, 60);
            this.btnLimpiarEgreso.TabIndex = 1;
            this.btnLimpiarEgreso.Text = "Limpiar";
            this.btnLimpiarEgreso.UseVisualStyleBackColor = false;
            this.btnLimpiarEgreso.Click += new System.EventHandler(this.btnLimpiarEgreso_Click);
            // 
            // btnAgregarEgreso
            // 
            this.btnAgregarEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(236)))), ((int)(((byte)(139)))));
            this.btnAgregarEgreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEgreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarEgreso.Location = new System.Drawing.Point(33, 185);
            this.btnAgregarEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarEgreso.Name = "btnAgregarEgreso";
            this.btnAgregarEgreso.Size = new System.Drawing.Size(165, 60);
            this.btnAgregarEgreso.TabIndex = 0;
            this.btnAgregarEgreso.Text = "Agregar";
            this.btnAgregarEgreso.UseVisualStyleBackColor = false;
            this.btnAgregarEgreso.Click += new System.EventHandler(this.btnAgregarEgreso_Click);
            // 
            // lblSueldoEncargado
            // 
            this.lblSueldoEncargado.AutoSize = true;
            this.lblSueldoEncargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoEncargado.ForeColor = System.Drawing.Color.Silver;
            this.lblSueldoEncargado.Location = new System.Drawing.Point(18, 125);
            this.lblSueldoEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldoEncargado.Name = "lblSueldoEncargado";
            this.lblSueldoEncargado.Size = new System.Drawing.Size(198, 23);
            this.lblSueldoEncargado.TabIndex = 5;
            this.lblSueldoEncargado.Text = "Sueldo Encargado:";
            // 
            // lblF31
            // 
            this.lblF31.AutoSize = true;
            this.lblF31.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF31.ForeColor = System.Drawing.Color.Silver;
            this.lblF31.Location = new System.Drawing.Point(18, 178);
            this.lblF31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblF31.Name = "lblF31";
            this.lblF31.Size = new System.Drawing.Size(140, 23);
            this.lblF31.TabIndex = 6;
            this.lblF31.Text = "Aportes F931:";
            // 
            // lblDGRT
            // 
            this.lblDGRT.AutoSize = true;
            this.lblDGRT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGRT.ForeColor = System.Drawing.Color.Silver;
            this.lblDGRT.Location = new System.Drawing.Point(18, 226);
            this.lblDGRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDGRT.Name = "lblDGRT";
            this.lblDGRT.Size = new System.Drawing.Size(67, 23);
            this.lblDGRT.TabIndex = 7;
            this.lblDGRT.Text = "DGRT:";
            // 
            // lblfateryh
            // 
            this.lblfateryh.AutoSize = true;
            this.lblfateryh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfateryh.ForeColor = System.Drawing.Color.Silver;
            this.lblfateryh.Location = new System.Drawing.Point(18, 278);
            this.lblfateryh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfateryh.Name = "lblfateryh";
            this.lblfateryh.Size = new System.Drawing.Size(88, 23);
            this.lblfateryh.TabIndex = 8;
            this.lblfateryh.Text = "Fateryh:";
            // 
            // lblSeracarh
            // 
            this.lblSeracarh.AutoSize = true;
            this.lblSeracarh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeracarh.ForeColor = System.Drawing.Color.Silver;
            this.lblSeracarh.Location = new System.Drawing.Point(18, 328);
            this.lblSeracarh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeracarh.Name = "lblSeracarh";
            this.lblSeracarh.Size = new System.Drawing.Size(103, 23);
            this.lblSeracarh.TabIndex = 9;
            this.lblSeracarh.Text = "Seracarh:";
            // 
            // lblSuterh
            // 
            this.lblSuterh.AutoSize = true;
            this.lblSuterh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuterh.ForeColor = System.Drawing.Color.Silver;
            this.lblSuterh.Location = new System.Drawing.Point(18, 389);
            this.lblSuterh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuterh.Name = "lblSuterh";
            this.lblSuterh.Size = new System.Drawing.Size(75, 23);
            this.lblSuterh.TabIndex = 10;
            this.lblSuterh.Text = "Suterh:";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.Color.Silver;
            this.lblSeguro.Location = new System.Drawing.Point(18, 445);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(185, 23);
            this.lblSeguro.TabIndex = 11;
            this.lblSeguro.Text = "Seguro Consorcio:";
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.ForeColor = System.Drawing.Color.Silver;
            this.lblLuz.Location = new System.Drawing.Point(18, 502);
            this.lblLuz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(45, 23);
            this.lblLuz.TabIndex = 12;
            this.lblLuz.Text = "Luz:";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.ForeColor = System.Drawing.Color.Silver;
            this.lblAgua.Location = new System.Drawing.Point(18, 562);
            this.lblAgua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(69, 23);
            this.lblAgua.TabIndex = 13;
            this.lblAgua.Text = "Agua:";
            // 
            // txtSueldoEncargado
            // 
            this.txtSueldoEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtSueldoEncargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoEncargado.ForeColor = System.Drawing.Color.Silver;
            this.txtSueldoEncargado.Location = new System.Drawing.Point(282, 120);
            this.txtSueldoEncargado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSueldoEncargado.Name = "txtSueldoEncargado";
            this.txtSueldoEncargado.Size = new System.Drawing.Size(182, 31);
            this.txtSueldoEncargado.TabIndex = 0;
            this.txtSueldoEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoEncargado_KeyPress);
            // 
            // txtSeracarh
            // 
            this.txtSeracarh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtSeracarh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeracarh.ForeColor = System.Drawing.Color.Silver;
            this.txtSeracarh.Location = new System.Drawing.Point(282, 323);
            this.txtSeracarh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeracarh.Name = "txtSeracarh";
            this.txtSeracarh.Size = new System.Drawing.Size(182, 31);
            this.txtSeracarh.TabIndex = 4;
            this.txtSeracarh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeracarh_KeyPress);
            // 
            // txtFateryh
            // 
            this.txtFateryh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtFateryh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFateryh.ForeColor = System.Drawing.Color.Silver;
            this.txtFateryh.Location = new System.Drawing.Point(282, 274);
            this.txtFateryh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFateryh.Name = "txtFateryh";
            this.txtFateryh.Size = new System.Drawing.Size(182, 31);
            this.txtFateryh.TabIndex = 3;
            this.txtFateryh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFateryh_KeyPress);
            // 
            // txtDGRT
            // 
            this.txtDGRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtDGRT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGRT.ForeColor = System.Drawing.Color.Silver;
            this.txtDGRT.Location = new System.Drawing.Point(282, 226);
            this.txtDGRT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDGRT.Name = "txtDGRT";
            this.txtDGRT.Size = new System.Drawing.Size(182, 31);
            this.txtDGRT.TabIndex = 2;
            this.txtDGRT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGRT_KeyPress);
            // 
            // txtAportesF931
            // 
            this.txtAportesF931.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtAportesF931.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAportesF931.ForeColor = System.Drawing.Color.Silver;
            this.txtAportesF931.Location = new System.Drawing.Point(282, 174);
            this.txtAportesF931.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAportesF931.Name = "txtAportesF931";
            this.txtAportesF931.Size = new System.Drawing.Size(182, 31);
            this.txtAportesF931.TabIndex = 1;
            this.txtAportesF931.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAportesF931_KeyPress);
            // 
            // txtSuterh
            // 
            this.txtSuterh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtSuterh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuterh.ForeColor = System.Drawing.Color.Silver;
            this.txtSuterh.Location = new System.Drawing.Point(282, 385);
            this.txtSuterh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSuterh.Name = "txtSuterh";
            this.txtSuterh.Size = new System.Drawing.Size(182, 31);
            this.txtSuterh.TabIndex = 5;
            this.txtSuterh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuterh_KeyPress);
            // 
            // txtSeguro
            // 
            this.txtSeguro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtSeguro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.ForeColor = System.Drawing.Color.Silver;
            this.txtSeguro.Location = new System.Drawing.Point(282, 445);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(182, 31);
            this.txtSeguro.TabIndex = 6;
            this.txtSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeguro_KeyPress);
            // 
            // txtEdet
            // 
            this.txtEdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtEdet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdet.ForeColor = System.Drawing.Color.Silver;
            this.txtEdet.Location = new System.Drawing.Point(282, 502);
            this.txtEdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdet.Name = "txtEdet";
            this.txtEdet.Size = new System.Drawing.Size(182, 31);
            this.txtEdet.TabIndex = 7;
            this.txtEdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdet_KeyPress);
            // 
            // txtAgua
            // 
            this.txtAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtAgua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgua.ForeColor = System.Drawing.Color.Silver;
            this.txtAgua.Location = new System.Drawing.Point(282, 562);
            this.txtAgua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(182, 31);
            this.txtAgua.TabIndex = 8;
            this.txtAgua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgua_KeyPress);
            // 
            // lblGastosBanc
            // 
            this.lblGastosBanc.AutoSize = true;
            this.lblGastosBanc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosBanc.ForeColor = System.Drawing.Color.Silver;
            this.lblGastosBanc.Location = new System.Drawing.Point(18, 626);
            this.lblGastosBanc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosBanc.Name = "lblGastosBanc";
            this.lblGastosBanc.Size = new System.Drawing.Size(182, 23);
            this.lblGastosBanc.TabIndex = 23;
            this.lblGastosBanc.Text = "Gastos Bancarios:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Silver;
            this.lblContador.Location = new System.Drawing.Point(18, 678);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(110, 23);
            this.lblContador.TabIndex = 24;
            this.lblContador.Text = "Contador:";
            // 
            // lblHonorariosAdmin
            // 
            this.lblHonorariosAdmin.AutoSize = true;
            this.lblHonorariosAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonorariosAdmin.ForeColor = System.Drawing.Color.Silver;
            this.lblHonorariosAdmin.Location = new System.Drawing.Point(18, 734);
            this.lblHonorariosAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHonorariosAdmin.Name = "lblHonorariosAdmin";
            this.lblHonorariosAdmin.Size = new System.Drawing.Size(78, 23);
            this.lblHonorariosAdmin.TabIndex = 25;
            this.lblHonorariosAdmin.Text = "Admin:";
            // 
            // txtGastos
            // 
            this.txtGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtGastos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastos.ForeColor = System.Drawing.Color.Silver;
            this.txtGastos.Location = new System.Drawing.Point(282, 615);
            this.txtGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(182, 31);
            this.txtGastos.TabIndex = 9;
            this.txtGastos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGastos_KeyPress);
            // 
            // txtAdmin
            // 
            this.txtAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.Color.Silver;
            this.txtAdmin.Location = new System.Drawing.Point(282, 726);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(182, 31);
            this.txtAdmin.TabIndex = 11;
            // 
            // txtcontador
            // 
            this.txtcontador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtcontador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontador.ForeColor = System.Drawing.Color.Silver;
            this.txtcontador.Location = new System.Drawing.Point(282, 670);
            this.txtcontador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontador.Name = "txtcontador";
            this.txtcontador.Size = new System.Drawing.Size(182, 31);
            this.txtcontador.TabIndex = 10;
            this.txtcontador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontador_KeyPress);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(479, 118);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(330, 26);
            this.dtp_fecha.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(615, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(577, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.Silver;
            this.txt_descripcion.Location = new System.Drawing.Point(482, 457);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(330, 300);
            this.txt_descripcion.TabIndex = 17;
            // 
            // txt_gastos_varios
            // 
            this.txt_gastos_varios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_gastos_varios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gastos_varios.ForeColor = System.Drawing.Color.Silver;
            this.txt_gastos_varios.Location = new System.Drawing.Point(743, 174);
            this.txt_gastos_varios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gastos_varios.Name = "txt_gastos_varios";
            this.txt_gastos_varios.Size = new System.Drawing.Size(182, 31);
            this.txt_gastos_varios.TabIndex = 13;
            this.txt_gastos_varios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gastos_varios_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(505, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gastos Varios:";
            // 
            // txt_fumigacion
            // 
            this.txt_fumigacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_fumigacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fumigacion.ForeColor = System.Drawing.Color.Silver;
            this.txt_fumigacion.Location = new System.Drawing.Point(743, 223);
            this.txt_fumigacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fumigacion.Name = "txt_fumigacion";
            this.txt_fumigacion.Size = new System.Drawing.Size(182, 31);
            this.txt_fumigacion.TabIndex = 14;
            this.txt_fumigacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fumigacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(472, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gastos Fumigacion:";
            // 
            // txt_remitos
            // 
            this.txt_remitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_remitos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remitos.ForeColor = System.Drawing.Color.Silver;
            this.txt_remitos.Location = new System.Drawing.Point(743, 270);
            this.txt_remitos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_remitos.Name = "txt_remitos";
            this.txt_remitos.Size = new System.Drawing.Size(182, 31);
            this.txt_remitos.TabIndex = 15;
            this.txt_remitos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_remitos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(538, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Remitos:";
            // 
            // txt_limpieza
            // 
            this.txt_limpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_limpieza.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limpieza.ForeColor = System.Drawing.Color.Silver;
            this.txt_limpieza.Location = new System.Drawing.Point(743, 323);
            this.txt_limpieza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_limpieza.Name = "txt_limpieza";
            this.txt_limpieza.Size = new System.Drawing.Size(182, 31);
            this.txt_limpieza.TabIndex = 16;
            this.txt_limpieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limpieza_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(538, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Limpieza:";
            // 
            // frmEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1218, 802);
            this.Controls.Add(this.txt_limpieza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_remitos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fumigacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_gastos_varios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txtcontador);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.txtGastos);
            this.Controls.Add(this.lblHonorariosAdmin);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblGastosBanc);
            this.Controls.Add(this.txtAgua);
            this.Controls.Add(this.txtEdet);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtSuterh);
            this.Controls.Add(this.txtAportesF931);
            this.Controls.Add(this.txtDGRT);
            this.Controls.Add(this.txtFateryh);
            this.Controls.Add(this.txtSeracarh);
            this.Controls.Add(this.txtSueldoEncargado);
            this.Controls.Add(this.lblAgua);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.lblSuterh);
            this.Controls.Add(this.lblSeracarh);
            this.Controls.Add(this.lblfateryh);
            this.Controls.Add(this.lblDGRT);
            this.Controls.Add(this.lblF31);
            this.Controls.Add(this.lblSueldoEncargado);
            this.Controls.Add(this.pnlEgresoRight);
            this.Controls.Add(this.pnlEgresoTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEgreso";
            this.Load += new System.EventHandler(this.frmEgreso_Load);
            this.pnlEgresoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbExitEgreso)).EndInit();
            this.pnlEgresoRight.ResumeLayout(false);
            this.pnlEgresoRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEgresoTop;
        private System.Windows.Forms.Panel pnlEgresoRight;
        private System.Windows.Forms.ComboBox cboConsorcio;
        private System.Windows.Forms.Label lblSueldoEncargado;
        private System.Windows.Forms.Label lblF31;
        private System.Windows.Forms.Label lblDGRT;
        private System.Windows.Forms.Label lblfateryh;
        private System.Windows.Forms.Label lblSeracarh;
        private System.Windows.Forms.Label lblSuterh;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.TextBox txtSueldoEncargado;
        private System.Windows.Forms.TextBox txtSeracarh;
        private System.Windows.Forms.TextBox txtFateryh;
        private System.Windows.Forms.TextBox txtDGRT;
        private System.Windows.Forms.TextBox txtAportesF931;
        private System.Windows.Forms.TextBox txtSuterh;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtEdet;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.Label lblGastosBanc;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblHonorariosAdmin;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtcontador;
        private System.Windows.Forms.Button btnLimpiarEgreso;
        private System.Windows.Forms.Button btnAgregarEgreso;
        private FontAwesome.Sharp.IconPictureBox ipbExitEgreso;
        private System.Windows.Forms.Label lblTotalEgreso;
        private System.Windows.Forms.Label lblTotalTotalEgreso;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gastos_varios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fumigacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remitos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_limpieza;
        private System.Windows.Forms.Label label6;
    }
}