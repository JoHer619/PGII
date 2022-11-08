
namespace RotacionInventario
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.vwVentasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetalleVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbDetalleVentaTableAdapter();
            this.tbVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbVentaTableAdapter();
            this.spDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDetalleVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter();
            this.tableAdapterManager = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager();
            this.vwVentasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwVentasActivasBindingSource
            // 
            this.vwVentasActivasBindingSource.DataMember = "vwVentasActivas";
            this.vwVentasActivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVentaBindingSource
            // 
            this.tbVentaBindingSource.DataMember = "tbVenta";
            this.tbVentaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbDetalleVentaBindingSource
            // 
            this.tbDetalleVentaBindingSource.DataMember = "tbDetalleVenta";
            this.tbDetalleVentaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbDetalleVentaTableAdapter
            // 
            this.tbDetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // tbVentaTableAdapter
            // 
            this.tbVentaTableAdapter.ClearBeforeFill = true;
            // 
            // spDetalleVentaBindingSource
            // 
            this.spDetalleVentaBindingSource.DataMember = "spDetalleVenta";
            this.spDetalleVentaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // spDetalleVentaTableAdapter
            // 
            this.spDetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbBitacoraLoginTableAdapter = null;
            this.tableAdapterManager.tbBitacoraTableAdapter = null;
            this.tableAdapterManager.tbCategoriaTableAdapter = null;
            this.tableAdapterManager.tbCompraTableAdapter = null;
            this.tableAdapterManager.tbDetalleCompraTableAdapter = null;
            this.tableAdapterManager.tbDetalleVentaTableAdapter = this.tbDetalleVentaTableAdapter;
            this.tableAdapterManager.tbProductoTableAdapter = null;
            this.tableAdapterManager.tbRolTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVentaTableAdapter = this.tbVentaTableAdapter;
            this.tableAdapterManager.UpdateOrder = RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwVentasActivasTableAdapter
            // 
            this.vwVentasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.tbProductosDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(50, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1550, 480);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos agregados";
            // 
            // tbProductosDataGridView
            // 
            this.tbProductosDataGridView.AllowUserToAddRows = false;
            this.tbProductosDataGridView.AllowUserToDeleteRows = false;
            this.tbProductosDataGridView.AllowUserToResizeColumns = false;
            this.tbProductosDataGridView.AllowUserToResizeRows = false;
            this.tbProductosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProductosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.idProducto,
            this.nombreProducto,
            this.cantidadProducto,
            this.precioProducto,
            this.descuentoProducto,
            this.subtotalProducto,
            this.deleteProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProductosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbProductosDataGridView.EnableHeadersVisualStyles = false;
            this.tbProductosDataGridView.Location = new System.Drawing.Point(30, 50);
            this.tbProductosDataGridView.Name = "tbProductosDataGridView";
            this.tbProductosDataGridView.ReadOnly = true;
            this.tbProductosDataGridView.RowHeadersVisible = false;
            this.tbProductosDataGridView.RowHeadersWidth = 62;
            this.tbProductosDataGridView.RowTemplate.Height = 35;
            this.tbProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProductosDataGridView.Size = new System.Drawing.Size(1480, 400);
            this.tbProductosDataGridView.TabIndex = 70;
            this.tbProductosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProductosDataGridView_CellContentClick);
            // 
            // idProduct
            // 
            this.idProduct.HeaderText = "Id Producto";
            this.idProduct.MinimumWidth = 8;
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            this.idProduct.Visible = false;
            this.idProduct.Width = 150;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Codigo";
            this.idProducto.MinimumWidth = 8;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 200;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MinimumWidth = 8;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 600;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.MinimumWidth = 8;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            this.cantidadProducto.Width = 135;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.MinimumWidth = 8;
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 135;
            // 
            // descuentoProducto
            // 
            this.descuentoProducto.HeaderText = "Descuento";
            this.descuentoProducto.MinimumWidth = 8;
            this.descuentoProducto.Name = "descuentoProducto";
            this.descuentoProducto.ReadOnly = true;
            this.descuentoProducto.Width = 135;
            // 
            // subtotalProducto
            // 
            this.subtotalProducto.HeaderText = "Subtotal";
            this.subtotalProducto.MinimumWidth = 8;
            this.subtotalProducto.Name = "subtotalProducto";
            this.subtotalProducto.ReadOnly = true;
            this.subtotalProducto.Width = 135;
            // 
            // deleteProducto
            // 
            this.deleteProducto.HeaderText = "Quitar";
            this.deleteProducto.Image = ((System.Drawing.Image)(resources.GetObject("deleteProducto.Image")));
            this.deleteProducto.MinimumWidth = 8;
            this.deleteProducto.Name = "deleteProducto";
            this.deleteProducto.ReadOnly = true;
            this.deleteProducto.Width = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 340);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.txtPrecio.Location = new System.Drawing.Point(137, 270);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(73, 30);
            this.txtPrecio.TabIndex = 87;
            this.txtPrecio.Text = "- - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 14F);
            this.label6.Location = new System.Drawing.Point(400, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 34);
            this.label6.TabIndex = 86;
            this.label6.Text = "Existencia";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.lblStock.Location = new System.Drawing.Point(546, 90);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 29);
            this.lblStock.TabIndex = 85;
            this.lblStock.Text = "- - -";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Lato", 18F);
            this.txtDescuento.Location = new System.Drawing.Point(406, 270);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 51);
            this.txtDescuento.TabIndex = 84;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.ValueChanged += new System.EventHandler(this.txtDescuento_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14F);
            this.label5.Location = new System.Drawing.Point(250, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 34);
            this.label5.TabIndex = 82;
            this.label5.Text = "Descuento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.lblCodigo.Location = new System.Drawing.Point(136, 90);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(220, 34);
            this.lblCodigo.TabIndex = 80;
            this.lblCodigo.Text = "- - -";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 14F);
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 34);
            this.label4.TabIndex = 79;
            this.label4.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F);
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.lblNombre.Location = new System.Drawing.Point(145, 180);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(600, 29);
            this.lblNombre.TabIndex = 75;
            this.lblNombre.Text = "- - -";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 14F);
            this.label3.Location = new System.Drawing.Point(23, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Lato", 18F);
            this.txtCantidad.Location = new System.Drawing.Point(684, 270);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 51);
            this.txtCantidad.TabIndex = 77;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14F);
            this.label1.Location = new System.Drawing.Point(550, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Font = new System.Drawing.Font("Lato", 14F);
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 50;
            this.btnProductos.Location = new System.Drawing.Point(54, 56);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(240, 60);
            this.btnProductos.TabIndex = 74;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Lato", 14F);
            this.btnAgregarProducto.Location = new System.Drawing.Point(54, 149);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(240, 60);
            this.btnAgregarProducto.TabIndex = 68;
            this.btnAgregarProducto.Text = "&Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.AutoSize = true;
            this.txtLimpiar.Font = new System.Drawing.Font("Lato", 14F);
            this.txtLimpiar.Location = new System.Drawing.Point(54, 240);
            this.txtLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(240, 60);
            this.txtLimpiar.TabIndex = 86;
            this.txtLimpiar.Text = "&Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProductos);
            this.groupBox4.Controls.Add(this.txtLimpiar);
            this.groupBox4.Controls.Add(this.btnAgregarProducto);
            this.groupBox4.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox4.Location = new System.Drawing.Point(920, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 340);
            this.groupBox4.TabIndex = 87;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Productos";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.AutoSize = true;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Lato", 14F);
            this.btnRegistrarVenta.Location = new System.Drawing.Point(51, 222);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(209, 60);
            this.btnRegistrarVenta.TabIndex = 69;
            this.btnRegistrarVenta.Text = "&Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 16F);
            this.label8.Location = new System.Drawing.Point(53, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 39);
            this.label8.TabIndex = 71;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(53, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 39);
            this.label7.TabIndex = 79;
            this.label7.Text = "Q";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Location = new System.Drawing.Point(104, 121);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 39);
            this.lblTotal.TabIndex = 72;
            this.lblTotal.Text = "00.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRegistrarVenta);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(1300, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 340);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar venta";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmVenta";
            this.Text = "Registrar ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbDetalleVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbDetalleVentaTableAdapter tbDetalleVentaTableAdapter;
        private System.Windows.Forms.BindingSource tbVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbVentaTableAdapter tbVentaTableAdapter;
        private System.Windows.Forms.BindingSource spDetalleVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter spDetalleVentaTableAdapter;
        private BD_INVENTARIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vwVentasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter vwVentasActivasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtDescuento;
        public System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView tbProductosDataGridView;
        private System.Windows.Forms.Button txtLimpiar;
        public System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalProducto;
        private System.Windows.Forms.DataGridViewImageColumn deleteProducto;
    }
}