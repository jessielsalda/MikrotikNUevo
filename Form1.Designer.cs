namespace Mikrotik
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnFichas = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDataset = new System.Windows.Forms.Label();
            this.mydatagrid = new System.Windows.Forms.DataGridView();
            this.btnBGenerar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBConectar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBPrefijo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBPuerto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmboxTipo = new System.Windows.Forms.ComboBox();
            this.cmboxTiempo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFichas = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrefijo = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.MenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMensaje.Location = new System.Drawing.Point(48, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(167, 31);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.Text = "Bienvenido:";
            this.lblMensaje.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuVertical.Controls.Add(this.btnAyuda);
            this.MenuVertical.Controls.Add(this.btnFichas);
            this.MenuVertical.Controls.Add(this.btnConexion);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(145, 468);
            this.MenuVertical.TabIndex = 21;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 148);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(145, 40);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Ayuda in";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnFichas
            // 
            this.btnFichas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFichas.FlatAppearance.BorderSize = 0;
            this.btnFichas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFichas.Image = ((System.Drawing.Image)(resources.GetObject("btnFichas.Image")));
            this.btnFichas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichas.Location = new System.Drawing.Point(0, 102);
            this.btnFichas.Name = "btnFichas";
            this.btnFichas.Size = new System.Drawing.Size(145, 40);
            this.btnFichas.TabIndex = 4;
            this.btnFichas.Text = "Fichas Aut";
            this.btnFichas.UseVisualStyleBackColor = true;
            this.btnFichas.Click += new System.EventHandler(this.btnFichas_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnConexion.Image")));
            this.btnConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexion.Location = new System.Drawing.Point(3, 59);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(142, 40);
            this.btnConexion.TabIndex = 3;
            this.btnConexion.Text = "Conexión";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mikrotik";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(165, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.iconoMinimizar);
            this.panel2.Controls.Add(this.iconoCerrar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnSlide);
            this.panel2.Controls.Add(this.lblMensaje);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 56);
            this.panel2.TabIndex = 22;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = global::Mikrotik.Properties.Resources.minimize_window;
            this.iconoMinimizar.Location = new System.Drawing.Point(504, 4);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 21;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = global::Mikrotik.Properties.Resources.logging_out_2355227_960_720;
            this.iconoCerrar.Location = new System.Drawing.Point(535, 5);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 2;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(80, -25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Mikrotik.Properties.Resources.images;
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(44, 47);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.txtInformacion);
            this.panel3.Controls.Add(this.lblConsultar);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.lblDataset);
            this.panel3.Controls.Add(this.mydatagrid);
            this.panel3.Controls.Add(this.btnBGenerar);
            this.panel3.Controls.Add(this.btnBConectar);
            this.panel3.Controls.Add(this.txtBCantidad);
            this.panel3.Controls.Add(this.txtBPrefijo);
            this.panel3.Controls.Add(this.txtBContraseña);
            this.panel3.Controls.Add(this.txtBPuerto);
            this.panel3.Controls.Add(this.txtBUsuario);
            this.panel3.Controls.Add(this.txtBIP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.cmboxTipo);
            this.panel3.Controls.Add(this.cmboxTiempo);
            this.panel3.Controls.Add(this.lblTipo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblFichas);
            this.panel3.Controls.Add(this.lblCantidad);
            this.panel3.Controls.Add(this.lblPrefijo);
            this.panel3.Controls.Add(this.lblBienvenido);
            this.panel3.Controls.Add(this.lblContraseña);
            this.panel3.Controls.Add(this.lblPuerto);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.lblIp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(145, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 412);
            this.panel3.TabIndex = 23;
            // 
            // lblDataset
            // 
            this.lblDataset.AutoSize = true;
            this.lblDataset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDataset.Location = new System.Drawing.Point(11, 168);
            this.lblDataset.Name = "lblDataset";
            this.lblDataset.Size = new System.Drawing.Size(45, 13);
            this.lblDataset.TabIndex = 70;
            this.lblDataset.Text = "dataset:\r\n";
            // 
            // mydatagrid
            // 
            this.mydatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mydatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mydatagrid.BackgroundColor = System.Drawing.Color.White;
            this.mydatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydatagrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mydatagrid.Location = new System.Drawing.Point(104, 302);
            this.mydatagrid.Name = "mydatagrid";
            this.mydatagrid.Size = new System.Drawing.Size(321, 106);
            this.mydatagrid.TabIndex = 68;
            // 
            // btnBGenerar
            // 
            this.btnBGenerar.ActiveBorderThickness = 1;
            this.btnBGenerar.ActiveCornerRadius = 20;
            this.btnBGenerar.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnBGenerar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBGenerar.ActiveLineColor = System.Drawing.Color.White;
            this.btnBGenerar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBGenerar.BackgroundImage")));
            this.btnBGenerar.ButtonText = "Generar";
            this.btnBGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBGenerar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGenerar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBGenerar.IdleBorderThickness = 1;
            this.btnBGenerar.IdleCornerRadius = 20;
            this.btnBGenerar.IdleFillColor = System.Drawing.Color.White;
            this.btnBGenerar.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnBGenerar.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnBGenerar.Location = new System.Drawing.Point(320, 199);
            this.btnBGenerar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBGenerar.Name = "btnBGenerar";
            this.btnBGenerar.Size = new System.Drawing.Size(92, 35);
            this.btnBGenerar.TabIndex = 63;
            this.btnBGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBGenerar.Click += new System.EventHandler(this.btnBGenerar_Click);
            // 
            // btnBConectar
            // 
            this.btnBConectar.ActiveBorderThickness = 1;
            this.btnBConectar.ActiveCornerRadius = 20;
            this.btnBConectar.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnBConectar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBConectar.ActiveLineColor = System.Drawing.Color.White;
            this.btnBConectar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBConectar.BackgroundImage")));
            this.btnBConectar.ButtonText = "Conectar";
            this.btnBConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBConectar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBConectar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBConectar.IdleBorderThickness = 1;
            this.btnBConectar.IdleCornerRadius = 20;
            this.btnBConectar.IdleFillColor = System.Drawing.Color.White;
            this.btnBConectar.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnBConectar.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnBConectar.Location = new System.Drawing.Point(404, 50);
            this.btnBConectar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBConectar.Name = "btnBConectar";
            this.btnBConectar.Size = new System.Drawing.Size(92, 35);
            this.btnBConectar.TabIndex = 62;
            this.btnBConectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBConectar.Click += new System.EventHandler(this.btnBConectar_Click);
            // 
            // txtBCantidad
            // 
            this.txtBCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBCantidad.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBCantidad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBCantidad.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtBCantidad.HintText = "Cantidad";
            this.txtBCantidad.isPassword = false;
            this.txtBCantidad.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBCantidad.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBCantidad.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBCantidad.LineThickness = 4;
            this.txtBCantidad.Location = new System.Drawing.Point(149, 208);
            this.txtBCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBCantidad.Name = "txtBCantidad";
            this.txtBCantidad.Size = new System.Drawing.Size(150, 26);
            this.txtBCantidad.TabIndex = 61;
            this.txtBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBPrefijo
            // 
            this.txtBPrefijo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPrefijo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBPrefijo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBPrefijo.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtBPrefijo.HintText = "Prefijo";
            this.txtBPrefijo.isPassword = false;
            this.txtBPrefijo.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBPrefijo.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBPrefijo.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBPrefijo.LineThickness = 4;
            this.txtBPrefijo.Location = new System.Drawing.Point(149, 180);
            this.txtBPrefijo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBPrefijo.Name = "txtBPrefijo";
            this.txtBPrefijo.Size = new System.Drawing.Size(150, 26);
            this.txtBPrefijo.TabIndex = 60;
            this.txtBPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBContraseña.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBContraseña.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBContraseña.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtBContraseña.HintText = "Contraseña";
            this.txtBContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBContraseña.isPassword = true;
            this.txtBContraseña.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBContraseña.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBContraseña.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBContraseña.LineThickness = 4;
            this.txtBContraseña.Location = new System.Drawing.Point(149, 113);
            this.txtBContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.Size = new System.Drawing.Size(150, 26);
            this.txtBContraseña.TabIndex = 59;
            this.txtBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBPuerto
            // 
            this.txtBPuerto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPuerto.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBPuerto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBPuerto.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBPuerto.HintText = "";
            this.txtBPuerto.isPassword = false;
            this.txtBPuerto.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBPuerto.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBPuerto.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBPuerto.LineThickness = 4;
            this.txtBPuerto.Location = new System.Drawing.Point(149, 78);
            this.txtBPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBPuerto.Name = "txtBPuerto";
            this.txtBPuerto.Size = new System.Drawing.Size(150, 26);
            this.txtBPuerto.TabIndex = 58;
            this.txtBPuerto.Text = "8728";
            this.txtBPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUsuario.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBUsuario.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBUsuario.HintText = "";
            this.txtBUsuario.isPassword = false;
            this.txtBUsuario.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBUsuario.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBUsuario.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBUsuario.LineThickness = 4;
            this.txtBUsuario.Location = new System.Drawing.Point(149, 50);
            this.txtBUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(150, 26);
            this.txtBUsuario.TabIndex = 57;
            this.txtBUsuario.Text = "admin";
            this.txtBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBIP
            // 
            this.txtBIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBIP.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.txtBIP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBIP.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBIP.HintText = "";
            this.txtBIP.isPassword = false;
            this.txtBIP.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtBIP.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtBIP.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtBIP.LineThickness = 4;
            this.txtBIP.Location = new System.Drawing.Point(149, 18);
            this.txtBIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtBIP.Name = "txtBIP";
            this.txtBIP.Size = new System.Drawing.Size(150, 26);
            this.txtBIP.TabIndex = 56;
            this.txtBIP.Text = "192.168.10.1";
            this.txtBIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(24, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "-Conexión-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mikrotik.Properties.Resources.icono_PDF;
            this.pictureBox1.Location = new System.Drawing.Point(340, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmboxTipo
            // 
            this.cmboxTipo.FormattingEnabled = true;
            this.cmboxTipo.Location = new System.Drawing.Point(149, 267);
            this.cmboxTipo.Name = "cmboxTipo";
            this.cmboxTipo.Size = new System.Drawing.Size(150, 21);
            this.cmboxTipo.TabIndex = 53;
            // 
            // cmboxTiempo
            // 
            this.cmboxTiempo.FormattingEnabled = true;
            this.cmboxTiempo.Location = new System.Drawing.Point(149, 240);
            this.cmboxTiempo.Name = "cmboxTiempo";
            this.cmboxTiempo.Size = new System.Drawing.Size(150, 21);
            this.cmboxTiempo.TabIndex = 52;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipo.Location = new System.Drawing.Point(60, 267);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(45, 17);
            this.lblTipo.TabIndex = 51;
            this.lblTipo.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(60, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tiempo:";
            // 
            // lblFichas
            // 
            this.lblFichas.AutoSize = true;
            this.lblFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFichas.Location = new System.Drawing.Point(38, 146);
            this.lblFichas.Name = "lblFichas";
            this.lblFichas.Size = new System.Drawing.Size(74, 20);
            this.lblFichas.TabIndex = 44;
            this.lblFichas.Text = "-Fichas-";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCantidad.Location = new System.Drawing.Point(60, 217);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 17);
            this.lblCantidad.TabIndex = 46;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefijo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrefijo.Location = new System.Drawing.Point(60, 189);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(60, 17);
            this.lblPrefijo.TabIndex = 45;
            this.lblPrefijo.Text = "Prefijo:";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.ForeColor = System.Drawing.Color.Maroon;
            this.lblBienvenido.Location = new System.Drawing.Point(11, 286);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(101, 13);
            this.lblBienvenido.TabIndex = 43;
            this.lblBienvenido.Text = "Cantidad de fichas: ";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContraseña.Location = new System.Drawing.Point(51, 113);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 17);
            this.lblContraseña.TabIndex = 38;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPuerto.Location = new System.Drawing.Point(51, 87);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(61, 17);
            this.lblPuerto.TabIndex = 37;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuario.Location = new System.Drawing.Point(51, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 17);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIp.Location = new System.Drawing.Point(51, 30);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(27, 17);
            this.lblIp.TabIndex = 35;
            this.lblIp.Text = "IP:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(454, 208);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 71;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Location = new System.Drawing.Point(454, 247);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(62, 13);
            this.lblConsultar.TabIndex = 72;
            this.lblConsultar.Text = "Información";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(454, 267);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(100, 20);
            this.txtInformacion.TabIndex = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 468);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FasePrueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnFichas;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.ComboBox cmboxTipo;
        private System.Windows.Forms.ComboBox cmboxTiempo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFichas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrefijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBIP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBPuerto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBPrefijo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBConectar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBGenerar;
        private System.Windows.Forms.DataGridView mydatagrid;
        private System.Windows.Forms.Label lblDataset;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Button btnConsultar;
    }
}

