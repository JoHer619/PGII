
namespace RotacionInventario
{
    partial class frmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.vwCategoriasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.vwProductosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.vwProductosActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter();
            this.vwCategoriasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter();
            this.tbProductoTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbProductoTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 14F);
            this.label4.Location = new System.Drawing.Point(50, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 34);
            this.label4.TabIndex = 53;
            this.label4.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F);
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 14F);
            this.label3.Location = new System.Drawing.Point(791, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 34);
            this.label3.TabIndex = 56;
            this.label3.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14F);
            this.label5.Location = new System.Drawing.Point(361, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 34);
            this.label5.TabIndex = 57;
            this.label5.Text = "Existencias";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Lato", 18F);
            this.txtNombre.Location = new System.Drawing.Point(176, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(550, 51);
            this.txtNombre.TabIndex = 61;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.vwCategoriasActivasBindingSource;
            this.cmbCategoria.DisplayMember = "nombreCategoria";
            this.cmbCategoria.Font = new System.Drawing.Font("Lato", 18F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(949, 41);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 52);
            this.cmbCategoria.TabIndex = 62;
            this.cmbCategoria.ValueMember = "idCategoria";
            // 
            // vwCategoriasActivasBindingSource
            // 
            this.vwCategoriasActivasBindingSource.DataMember = "vwCategoriasActivas";
            this.vwCategoriasActivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Lato", 18F);
            this.txtPrecio.Location = new System.Drawing.Point(176, 148);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 51);
            this.txtPrecio.TabIndex = 63;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtExistencias
            // 
            this.txtExistencias.Font = new System.Drawing.Font("Lato", 18F);
            this.txtExistencias.Location = new System.Drawing.Point(523, 148);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(120, 51);
            this.txtExistencias.TabIndex = 64;
            this.txtExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencias_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnRegistrar.Location = new System.Drawing.Point(1335, 33);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(270, 60);
            this.btnRegistrar.TabIndex = 67;
            this.btnRegistrar.Text = "&Registrar producto";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnActualizar.Location = new System.Drawing.Point(1335, 113);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(270, 60);
            this.btnActualizar.TabIndex = 68;
            this.btnActualizar.Text = "&Actualizar producto";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtSku
            // 
            this.txtSku.Font = new System.Drawing.Font("Lato", 18F);
            this.txtSku.Location = new System.Drawing.Point(949, 148);
            this.txtSku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(250, 51);
            this.txtSku.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14F);
            this.label1.Location = new System.Drawing.Point(801, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 80;
            this.label1.Text = "Código";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(322, 55);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1160, 51);
            this.txtBuscar.TabIndex = 81;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.tbProductosDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(55, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1550, 620);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repuestos y accesorios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 14F);
            this.label7.Location = new System.Drawing.Point(25, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 34);
            this.label7.TabIndex = 84;
            this.label7.Text = "Nombre del producto";
            // 
            // tbProductosDataGridView
            // 
            this.tbProductosDataGridView.AllowUserToAddRows = false;
            this.tbProductosDataGridView.AllowUserToDeleteRows = false;
            this.tbProductosDataGridView.AllowUserToResizeColumns = false;
            this.tbProductosDataGridView.AllowUserToResizeRows = false;
            this.tbProductosDataGridView.AutoGenerateColumns = false;
            this.tbProductosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbProductosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProductosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbProductosDataGridView.ColumnHeadersHeight = 40;
            this.tbProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.precioProductoDataGridViewTextBoxColumn,
            this.stockProductoDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.estadoProductoDataGridViewTextBoxColumn,
            this.Codigo});
            this.tbProductosDataGridView.DataSource = this.vwProductosActivosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProductosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbProductosDataGridView.EnableHeadersVisualStyles = false;
            this.tbProductosDataGridView.Location = new System.Drawing.Point(30, 127);
            this.tbProductosDataGridView.Name = "tbProductosDataGridView";
            this.tbProductosDataGridView.ReadOnly = true;
            this.tbProductosDataGridView.RowHeadersVisible = false;
            this.tbProductosDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.tbProductosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tbProductosDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tbProductosDataGridView.RowTemplate.Height = 35;
            this.tbProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProductosDataGridView.Size = new System.Drawing.Size(1480, 460);
            this.tbProductosDataGridView.TabIndex = 69;
            this.tbProductosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProductosDataGridView_CellContentClick);
            this.tbProductosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbProductosDataGridView_CellFormatting);
            // 
            // vwProductosActivosBindingSource
            // 
            this.vwProductosActivosBindingSource.DataMember = "vwProductosActivos";
            this.vwProductosActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.AutoSize = true;
            this.txtLimpiar.BackColor = System.Drawing.Color.White;
            this.txtLimpiar.Font = new System.Drawing.Font("Lato", 14F);
            this.txtLimpiar.Location = new System.Drawing.Point(1335, 193);
            this.txtLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(270, 60);
            this.txtLimpiar.TabIndex = 84;
            this.txtLimpiar.Text = "&Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = false;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // vwProductosActivosTableAdapter
            // 
            this.vwProductosActivosTableAdapter.ClearBeforeFill = true;
            // 
            // vwCategoriasActivasTableAdapter
            // 
            this.vwCategoriasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductoTableAdapter
            // 
            this.tbProductoTableAdapter.ClearBeforeFill = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Visible = false;
            this.idProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 710;
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            this.precioProductoDataGridViewTextBoxColumn.DataPropertyName = "precioProducto";
            this.precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            this.precioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioProductoDataGridViewTextBoxColumn.Width = 160;
            // 
            // stockProductoDataGridViewTextBoxColumn
            // 
            this.stockProductoDataGridViewTextBoxColumn.DataPropertyName = "stockProducto";
            this.stockProductoDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.stockProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockProductoDataGridViewTextBoxColumn.Name = "stockProductoDataGridViewTextBoxColumn";
            this.stockProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockProductoDataGridViewTextBoxColumn.Width = 160;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 160;
            // 
            // estadoProductoDataGridViewTextBoxColumn
            // 
            this.estadoProductoDataGridViewTextBoxColumn.DataPropertyName = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.HeaderText = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoProductoDataGridViewTextBoxColumn.Name = "estadoProductoDataGridViewTextBoxColumn";
            this.estadoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoProductoDataGridViewTextBoxColumn.Visible = false;
            this.estadoProductoDataGridViewTextBoxColumn.Width = 160;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "skuProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 260;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource tbProductoBindingSource;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwProductosActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter vwProductosActivosTableAdapter;
        private System.Windows.Forms.BindingSource vwCategoriasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter vwCategoriasActivasTableAdapter;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.DataGridView tbProductosDataGridView;
        private BD_INVENTARIODataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
    }
}