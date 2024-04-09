namespace Actividades_JM_Server
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label tituloLabel1;
            System.Windows.Forms.Label descripciónLabel1;
            System.Windows.Forms.Label fechaLabel1;
            System.Windows.Forms.Label horaLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label fechaLabel;
            this.dataSet1 = new Actividades_JM_Server.DataSet1();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actividadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.actividadDataGridView = new System.Windows.Forms.DataGridView();
            this.tituloTextBox1 = new System.Windows.Forms.TextBox();
            this.descripciónTextBox1 = new System.Windows.Forms.TextBox();
            this.fechaMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.horaMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            tituloLabel1 = new System.Windows.Forms.Label();
            descripciónLabel1 = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            horaLabel1 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingNavigator)).BeginInit();
            this.actividadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.dataSet1;
            // 
            // actividadBindingNavigator
            // 
            this.actividadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actividadBindingNavigator.BindingSource = this.actividadBindingSource;
            this.actividadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actividadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actividadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.actividadBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.actividadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actividadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actividadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actividadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actividadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actividadBindingNavigator.Name = "actividadBindingNavigator";
            this.actividadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actividadBindingNavigator.Size = new System.Drawing.Size(842, 25);
            this.actividadBindingNavigator.TabIndex = 0;
            this.actividadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // actividadBindingNavigatorSaveItem
            // 
            this.actividadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actividadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actividadBindingNavigatorSaveItem.Image")));
            this.actividadBindingNavigatorSaveItem.Name = "actividadBindingNavigatorSaveItem";
            this.actividadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actividadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.actividadBindingNavigatorSaveItem.Click += new System.EventHandler(this.actividadBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // actividadDataGridView
            // 
            this.actividadDataGridView.AllowUserToAddRows = false;
            this.actividadDataGridView.AllowUserToDeleteRows = false;
            this.actividadDataGridView.AutoGenerateColumns = false;
            this.actividadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actividadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.actividadDataGridView.DataSource = this.actividadBindingSource;
            this.actividadDataGridView.Location = new System.Drawing.Point(269, 53);
            this.actividadDataGridView.Name = "actividadDataGridView";
            this.actividadDataGridView.ReadOnly = true;
            this.actividadDataGridView.Size = new System.Drawing.Size(544, 315);
            this.actividadDataGridView.TabIndex = 10;
            // 
            // tituloLabel1
            // 
            tituloLabel1.AutoSize = true;
            tituloLabel1.Location = new System.Drawing.Point(13, 326);
            tituloLabel1.Name = "tituloLabel1";
            tituloLabel1.Size = new System.Drawing.Size(36, 13);
            tituloLabel1.TabIndex = 10;
            tituloLabel1.Text = "Titulo:";
            // 
            // tituloTextBox1
            // 
            this.tituloTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Titulo", true));
            this.tituloTextBox1.Location = new System.Drawing.Point(85, 323);
            this.tituloTextBox1.Name = "tituloTextBox1";
            this.tituloTextBox1.Size = new System.Drawing.Size(178, 20);
            this.tituloTextBox1.TabIndex = 11;
            // 
            // descripciónLabel1
            // 
            descripciónLabel1.AutoSize = true;
            descripciónLabel1.Location = new System.Drawing.Point(13, 352);
            descripciónLabel1.Name = "descripciónLabel1";
            descripciónLabel1.Size = new System.Drawing.Size(66, 13);
            descripciónLabel1.TabIndex = 12;
            descripciónLabel1.Text = "Descripción:";
            // 
            // descripciónTextBox1
            // 
            this.descripciónTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Descripción", true));
            this.descripciónTextBox1.Location = new System.Drawing.Point(85, 349);
            this.descripciónTextBox1.Name = "descripciónTextBox1";
            this.descripciónTextBox1.Size = new System.Drawing.Size(178, 20);
            this.descripciónTextBox1.TabIndex = 13;
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.Location = new System.Drawing.Point(13, 381);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(40, 13);
            fechaLabel1.TabIndex = 14;
            fechaLabel1.Text = "Fecha:";
            // 
            // fechaMonthCalendar
            // 
            this.fechaMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.actividadBindingSource, "Fecha", true));
            this.fechaMonthCalendar.Location = new System.Drawing.Point(85, 381);
            this.fechaMonthCalendar.Name = "fechaMonthCalendar";
            this.fechaMonthCalendar.TabIndex = 15;
            // 
            // horaLabel1
            // 
            horaLabel1.AutoSize = true;
            horaLabel1.Location = new System.Drawing.Point(13, 551);
            horaLabel1.Name = "horaLabel1";
            horaLabel1.Size = new System.Drawing.Size(33, 13);
            horaLabel1.TabIndex = 16;
            horaLabel1.Text = "Hora:";
            // 
            // horaMaskedTextBox1
            // 
            this.horaMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actividadBindingSource, "Hora", true));
            this.horaMaskedTextBox1.Location = new System.Drawing.Point(85, 548);
            this.horaMaskedTextBox1.Name = "horaMaskedTextBox1";
            this.horaMaskedTextBox1.Size = new System.Drawing.Size(178, 20);
            this.horaMaskedTextBox1.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Hora";
            dataGridViewCellStyle14.Format = "t";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn8.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(493, 464);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 17;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actividadBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(539, 460);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 641);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(tituloLabel1);
            this.Controls.Add(this.tituloTextBox1);
            this.Controls.Add(descripciónLabel1);
            this.Controls.Add(this.descripciónTextBox1);
            this.Controls.Add(fechaLabel1);
            this.Controls.Add(this.fechaMonthCalendar);
            this.Controls.Add(horaLabel1);
            this.Controls.Add(this.horaMaskedTextBox1);
            this.Controls.Add(this.actividadDataGridView);
            this.Controls.Add(this.actividadBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingNavigator)).EndInit();
            this.actividadBindingNavigator.ResumeLayout(false);
            this.actividadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private System.Windows.Forms.BindingNavigator actividadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton actividadBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView actividadDataGridView;
        private System.Windows.Forms.TextBox tituloTextBox1;
        private System.Windows.Forms.TextBox descripciónTextBox1;
        private System.Windows.Forms.MonthCalendar fechaMonthCalendar;
        private System.Windows.Forms.MaskedTextBox horaMaskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}