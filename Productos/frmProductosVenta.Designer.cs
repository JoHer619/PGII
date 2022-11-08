
namespace RotacionInventario
{
    partial class frmProductosVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tbProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.vwProductosExistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwProductosExistenciaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwProductosExistenciaTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosExistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.tbProductosDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(40, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1450, 800);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escriba el nombre del producto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnCerrar.Location = new System.Drawing.Point(1140, 70);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 50);
            this.btnCerrar.TabIndex = 82;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Lato", 18F);
            this.txtBuscar.Location = new System.Drawing.Point(44, 75);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1060, 51);
            this.txtBuscar.TabIndex = 81;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tbProductosDataGridView
            // 
            this.tbProductosDataGridView.AllowUserToAddRows = false;
            this.tbProductosDataGridView.AllowUserToDeleteRows = false;
            this.tbProductosDataGridView.AllowUserToResizeColumns = false;
            this.tbProductosDataGridView.AllowUserToResizeRows = false;
            this.tbProductosDataGridView.AutoGenerateColumns = false;
            this.tbProductosDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.skuProductoDataGridViewTextBoxColumn,
            this.addProducto});
            this.tbProductosDataGridView.DataSource = this.vwProductosExistenciaBindingSource;
            this.tbProductosDataGridView.EnableHeadersVisualStyles = false;
            this.tbProductosDataGridView.Location = new System.Drawing.Point(45, 160);
            this.tbProductosDataGridView.Name = "tbProductosDataGridView";
            this.tbProductosDataGridView.ReadOnly = true;
            this.tbProductosDataGridView.RowHeadersVisible = false;
            this.tbProductosDataGridView.RowHeadersWidth = 62;
            this.tbProductosDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.tbProductosDataGridView.RowTemplate.Height = 35;
            this.tbProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProductosDataGridView.Size = new System.Drawing.Size(1350, 600);
            this.tbProductosDataGridView.TabIndex = 69;
            this.tbProductosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProductosDataGridView_CellContentClick);
            this.tbProductosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbProductosDataGridView_CellFormatting);
            // 
            // vwProductosExistenciaBindingSource
            // 
            this.vwProductosExistenciaBindingSource.DataMember = "vwProductosExistencia";
            this.vwProductosExistenciaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwProductosExistenciaTableAdapter
            // 
            this.vwProductosExistenciaTableAdapter.ClearBeforeFill = true;
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
            this.nombreProductoDataGridViewTextBoxColumn.Width = 590;
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            this.precioProductoDataGridViewTextBoxColumn.DataPropertyName = "precioProducto";
            this.precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            this.precioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioProductoDataGridViewTextBoxColumn.Width = 120;
            // 
            // stockProductoDataGridViewTextBoxColumn
            // 
            this.stockProductoDataGridViewTextBoxColumn.DataPropertyName = "stockProducto";
            this.stockProductoDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.stockProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockProductoDataGridViewTextBoxColumn.Name = "stockProductoDataGridViewTextBoxColumn";
            this.stockProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 140;
            // 
            // estadoProductoDataGridViewTextBoxColumn
            // 
            this.estadoProductoDataGridViewTextBoxColumn.DataPropertyName = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.HeaderText = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoProductoDataGridViewTextBoxColumn.Name = "estadoProductoDataGridViewTextBoxColumn";
            this.estadoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoProductoDataGridViewTextBoxColumn.Visible = false;
            this.estadoProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // skuProductoDataGridViewTextBoxColumn
            // 
            this.skuProductoDataGridViewTextBoxColumn.DataPropertyName = "skuProducto";
            this.skuProductoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.skuProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skuProductoDataGridViewTextBoxColumn.Name = "skuProductoDataGridViewTextBoxColumn";
            this.skuProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.skuProductoDataGridViewTextBoxColumn.Width = 195;
            // 
            // addProducto
            // 
            this.addProducto.HeaderText = "Agregar";
            this.addProducto.Image = ((System.Drawing.Image)(resources.GetObject("addProducto.Image")));
            this.addProducto.MinimumWidth = 8;
            this.addProducto.Name = "addProducto";
            this.addProducto.ReadOnly = true;
            this.addProducto.Width = 130;
            // 
            // frmProductosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 894);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProductosVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de productos";
            this.Load += new System.EventHandler(this.frmProductosVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosExistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView tbProductosDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwProductosExistenciaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwProductosExistenciaTableAdapter vwProductosExistenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn addProducto;
    }
}