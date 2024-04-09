namespace Actividades_JM_Server
{
    partial class Pantalla_Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label descripciónLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Principal));
            this.Notificacion_Inicio = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer_Notificacion = new System.Windows.Forms.Timer(this.components);
            this.Timer_Tamaño = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.Timer_Reloj = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Agrega_Actividad = new System.Windows.Forms.Panel();
            this.grb_agregar = new System.Windows.Forms.GroupBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Actividades_JM_Server.DataSet1();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.horaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.descripciónTextBox = new System.Windows.Forms.TextBox();
            this.Actividades = new System.Windows.Forms.Panel();
            this.grb_actividades = new System.Windows.Forms.GroupBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet11 = new Actividades_JM_Server.DataSet1();
            tituloLabel = new System.Windows.Forms.Label();
            descripciónLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            this.panel1.SuspendLayout();
            this.Agrega_Actividad.SuspendLayout();
            this.grb_agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.Actividades.SuspendLayout();
            this.grb_actividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(12, 71);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(58, 18);
            tituloLabel.TabIndex = 24;
            tituloLabel.Text = "Titulo:";
            // 
            // descripciónLabel
            // 
            descripciónLabel.AutoSize = true;
            descripciónLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripciónLabel.Location = new System.Drawing.Point(12, 104);
            descripciónLabel.Name = "descripciónLabel";
            descripciónLabel.Size = new System.Drawing.Size(101, 18);
            descripciónLabel.TabIndex = 26;
            descripciónLabel.Text = "Descripción:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaLabel.Location = new System.Drawing.Point(12, 293);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(51, 18);
            horaLabel.TabIndex = 30;
            horaLabel.Text = "Hora:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(12, 230);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(56, 18);
            fechaLabel.TabIndex = 24;
            fechaLabel.Text = "Fecha:";
            // 
            // Notificacion_Inicio
            // 
            this.Notificacion_Inicio.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion_Inicio.Icon")));
            this.Notificacion_Inicio.Text = "Actividades JM Server";
            this.Notificacion_Inicio.Visible = true;
            this.Notificacion_Inicio.BalloonTipClicked += new System.EventHandler(this.Notificacion_Inicio_BalloonTipClicked);
            this.Notificacion_Inicio.Click += new System.EventHandler(this.Notificacion_Inicio_Click);
            // 
            // Timer_Notificacion
            // 
            this.Timer_Notificacion.Interval = 900000;
            this.Timer_Notificacion.Tick += new System.EventHandler(this.Timer_Notificacion_Tick);
            // 
            // Timer_Tamaño
            // 
            this.Timer_Tamaño.Tick += new System.EventHandler(this.Tamaño_Tick);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btn_modificar);
            this.MenuVertical.Controls.Add(this.btn_eliminar);
            this.MenuVertical.Controls.Add(this.btn_agregar);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 40);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(180, 496);
            this.MenuVertical.TabIndex = 2;
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(12, 170);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(166, 50);
            this.btn_modificar.TabIndex = 24;
            this.btn_modificar.Text = "Modificar   ";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 110);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 50);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar      ";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(12, 50);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(166, 50);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar    ";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BarraTitulo.Controls.Add(this.lbl_nombre);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(700, 40);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nombre.Location = new System.Drawing.Point(191, 3);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(308, 33);
            this.lbl_nombre.TabIndex = 19;
            this.lbl_nombre.Text = "Actividades JM Server";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(628, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 28);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = global::Actividades_JM_Server.Properties.Resources.restaurar;
            this.iconrestaurar.Location = new System.Drawing.Point(664, 6);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(26, 26);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 4;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFecha.Location = new System.Drawing.Point(6, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(345, 24);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Miercoles, 13 de febrero de 2020";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(367, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(150, 42);
            this.lblhora.TabIndex = 30;
            this.lblhora.Text = "01:01:01";
            // 
            // Timer_Reloj
            // 
            this.Timer_Reloj.Enabled = true;
            this.Timer_Reloj.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(180, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 43);
            this.panel1.TabIndex = 32;
            // 
            // Agrega_Actividad
            // 
            this.Agrega_Actividad.BackColor = System.Drawing.Color.Snow;
            this.Agrega_Actividad.Controls.Add(this.grb_agregar);
            this.Agrega_Actividad.Dock = System.Windows.Forms.DockStyle.Right;
            this.Agrega_Actividad.Location = new System.Drawing.Point(470, 40);
            this.Agrega_Actividad.Name = "Agrega_Actividad";
            this.Agrega_Actividad.Size = new System.Drawing.Size(230, 453);
            this.Agrega_Actividad.TabIndex = 33;
            this.Agrega_Actividad.Visible = false;
            // 
            // grb_agregar
            // 
            this.grb_agregar.Controls.Add(fechaLabel);
            this.grb_agregar.Controls.Add(tituloLabel);
            this.grb_agregar.Controls.Add(this.fechaDateTimePicker);
            this.grb_agregar.Controls.Add(this.tituloTextBox);
            this.grb_agregar.Controls.Add(this.btn_guardar);
            this.grb_agregar.Controls.Add(descripciónLabel);
            this.grb_agregar.Controls.Add(this.horaMaskedTextBox);
            this.grb_agregar.Controls.Add(this.descripciónTextBox);
            this.grb_agregar.Controls.Add(horaLabel);
            this.grb_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_agregar.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_agregar.Location = new System.Drawing.Point(0, 0);
            this.grb_agregar.Name = "grb_agregar";
            this.grb_agregar.Size = new System.Drawing.Size(230, 453);
            this.grb_agregar.TabIndex = 0;
            this.grb_agregar.TabStop = false;
            this.grb_agregar.Text = "Agregar Actividad";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CalendarFont = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actividadBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(15, 254);
            this.fechaDateTimePicker.MinDate = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(205, 22);
            this.fechaDateTimePicker.TabIndex = 25;
            this.fechaDateTimePicker.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(70, 68);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(150, 29);
            this.tituloTextBox.TabIndex = 25;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(3, 410);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(224, 40);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // horaMaskedTextBox
            // 
            this.horaMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.horaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Hora", true));
            this.horaMaskedTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaMaskedTextBox.Location = new System.Drawing.Point(63, 288);
            this.horaMaskedTextBox.Mask = "00:00";
            this.horaMaskedTextBox.Name = "horaMaskedTextBox";
            this.horaMaskedTextBox.Size = new System.Drawing.Size(157, 29);
            this.horaMaskedTextBox.TabIndex = 31;
            this.horaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // descripciónTextBox
            // 
            this.descripciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Descripción", true));
            this.descripciónTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripciónTextBox.Location = new System.Drawing.Point(15, 125);
            this.descripciónTextBox.Multiline = true;
            this.descripciónTextBox.Name = "descripciónTextBox";
            this.descripciónTextBox.Size = new System.Drawing.Size(205, 95);
            this.descripciónTextBox.TabIndex = 27;
            // 
            // Actividades
            // 
            this.Actividades.BackColor = System.Drawing.Color.Snow;
            this.Actividades.Controls.Add(this.grb_actividades);
            this.Actividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Actividades.Location = new System.Drawing.Point(180, 40);
            this.Actividades.Name = "Actividades";
            this.Actividades.Size = new System.Drawing.Size(290, 453);
            this.Actividades.TabIndex = 34;
            // 
            // grb_actividades
            // 
            this.grb_actividades.Controls.Add(this.Datos);
            this.grb_actividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_actividades.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Underline);
            this.grb_actividades.Location = new System.Drawing.Point(0, 0);
            this.grb_actividades.Name = "grb_actividades";
            this.grb_actividades.Size = new System.Drawing.Size(290, 453);
            this.grb_actividades.TabIndex = 22;
            this.grb_actividades.TabStop = false;
            this.grb_actividades.Text = "Lista de Actividades";
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.AutoGenerateColumns = false;
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Fecha,
            this.dataGridViewTextBoxColumn5});
            this.Datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Datos.DataSource = this.actividadBindingSource;
            this.Datos.Location = new System.Drawing.Point(17, 43);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.RowHeadersVisible = false;
            this.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Datos.Size = new System.Drawing.Size(487, 361);
            this.Datos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(700, 536);
            this.Controls.Add(this.Actividades);
            this.Controls.Add(this.Agrega_Actividad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pantalla_Principal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        ";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Agrega_Actividad.ResumeLayout(false);
            this.grb_agregar.ResumeLayout(false);
            this.grb_agregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.Actividades.ResumeLayout(false);
            this.grb_actividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Notificacion_Inicio;
        private System.Windows.Forms.Timer Timer_Notificacion;
        private System.Windows.Forms.Timer Timer_Tamaño;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer Timer_Reloj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Agrega_Actividad;
        private System.Windows.Forms.Panel Actividades;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox grb_agregar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox grb_actividades;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.MaskedTextBox horaMaskedTextBox;
        private System.Windows.Forms.TextBox descripciónTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private DataSet1 dataSet11;
    }
}

