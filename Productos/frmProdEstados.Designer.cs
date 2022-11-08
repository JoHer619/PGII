
namespace RotacionInventario
{
    partial class frmProdEstados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProducto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbProdActivoDataGridView = new System.Windows.Forms.DataGridView();
            this.vwProductosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProdInactivoDataGridView = new System.Windows.Forms.DataGridView();
            this.vwProductosInactivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter();
            this.vwProductosInactivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwProductosInactivosTableAdapter();
            this.tbProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductoTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbProductoTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdActivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdInactivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosInactivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(29, 70);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(277, 47);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "- - -";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.btnEstado);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(363, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Lato", 18F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(365, 70);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(140, 52);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEstado.Location = new System.Drawing.Point(548, 70);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(240, 60);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "Cambiar estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbProdActivoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(39, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1550, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos activos";
            // 
            // tbProdActivoDataGridView
            // 
            this.tbProdActivoDataGridView.AllowUserToAddRows = false;
            this.tbProdActivoDataGridView.AllowUserToDeleteRows = false;
            this.tbProdActivoDataGridView.AllowUserToResizeColumns = false;
            this.tbProdActivoDataGridView.AllowUserToResizeRows = false;
            this.tbProdActivoDataGridView.AutoGenerateColumns = false;
            this.tbProdActivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbProdActivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProdActivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbProdActivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdActivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.precioProductoDataGridViewTextBoxColumn,
            this.stockProductoDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.estadoProductoDataGridViewTextBoxColumn,
            this.skuProducto});
            this.tbProdActivoDataGridView.DataSource = this.vwProductosActivosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProdActivoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbProdActivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbProdActivoDataGridView.Location = new System.Drawing.Point(42, 51);
            this.tbProdActivoDataGridView.Name = "tbProdActivoDataGridView";
            this.tbProdActivoDataGridView.ReadOnly = true;
            this.tbProdActivoDataGridView.RowHeadersVisible = false;
            this.tbProdActivoDataGridView.RowHeadersWidth = 62;
            this.tbProdActivoDataGridView.RowTemplate.Height = 35;
            this.tbProdActivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProdActivoDataGridView.Size = new System.Drawing.Size(1480, 250);
            this.tbProdActivoDataGridView.TabIndex = 4;
            this.tbProdActivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProdActivoDataGridView_CellContentClick);
            // 
            // vwProductosActivosBindingSource
            // 
            this.vwProductosActivosBindingSource.DataMember = "vwProductosActivos";
            this.vwProductosActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbProdInactivoDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(39, 600);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1550, 330);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos inactivos";
            // 
            // tbProdInactivoDataGridView
            // 
            this.tbProdInactivoDataGridView.AllowUserToAddRows = false;
            this.tbProdInactivoDataGridView.AllowUserToDeleteRows = false;
            this.tbProdInactivoDataGridView.AllowUserToResizeColumns = false;
            this.tbProdInactivoDataGridView.AllowUserToResizeRows = false;
            this.tbProdInactivoDataGridView.AutoGenerateColumns = false;
            this.tbProdInactivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbProdInactivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProdInactivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbProdInactivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdInactivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn1,
            this.nombreProductoDataGridViewTextBoxColumn1,
            this.precioProductoDataGridViewTextBoxColumn1,
            this.stockProductoDataGridViewTextBoxColumn1,
            this.nombreCategoriaDataGridViewTextBoxColumn1,
            this.estadoProductoDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.tbProdInactivoDataGridView.DataSource = this.vwProductosInactivosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProdInactivoDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.tbProdInactivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbProdInactivoDataGridView.Location = new System.Drawing.Point(42, 54);
            this.tbProdInactivoDataGridView.Name = "tbProdInactivoDataGridView";
            this.tbProdInactivoDataGridView.ReadOnly = true;
            this.tbProdInactivoDataGridView.RowHeadersVisible = false;
            this.tbProdInactivoDataGridView.RowHeadersWidth = 62;
            this.tbProdInactivoDataGridView.RowTemplate.Height = 35;
            this.tbProdInactivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProdInactivoDataGridView.Size = new System.Drawing.Size(1480, 250);
            this.tbProdInactivoDataGridView.TabIndex = 5;
            this.tbProdInactivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProdInactivoDataGridView_CellContentClick);
            // 
            // vwProductosInactivosBindingSource
            // 
            this.vwProductosInactivosBindingSource.DataMember = "vwProductosInactivos";
            this.vwProductosInactivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwProductosActivosTableAdapter
            // 
            this.vwProductosActivosTableAdapter.ClearBeforeFill = true;
            // 
            // vwProductosInactivosTableAdapter
            // 
            this.vwProductosInactivosTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductoBindingSource
            // 
            this.tbProductoBindingSource.DataMember = "tbProducto";
            this.tbProductoBindingSource.DataSource = this.bD_INVENTARIODataSet;
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
            this.estadoProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // skuProducto
            // 
            this.skuProducto.DataPropertyName = "skuProducto";
            this.skuProducto.HeaderText = "Codigo";
            this.skuProducto.MinimumWidth = 8;
            this.skuProducto.Name = "skuProducto";
            this.skuProducto.ReadOnly = true;
            this.skuProducto.Width = 260;
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            this.idProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn1.Visible = false;
            this.idProductoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreProductoDataGridViewTextBoxColumn1
            // 
            this.nombreProductoDataGridViewTextBoxColumn1.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.nombreProductoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreProductoDataGridViewTextBoxColumn1.Name = "nombreProductoDataGridViewTextBoxColumn1";
            this.nombreProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn1.Width = 710;
            // 
            // precioProductoDataGridViewTextBoxColumn1
            // 
            this.precioProductoDataGridViewTextBoxColumn1.DataPropertyName = "precioProducto";
            this.precioProductoDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioProductoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.precioProductoDataGridViewTextBoxColumn1.Name = "precioProductoDataGridViewTextBoxColumn1";
            this.precioProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.precioProductoDataGridViewTextBoxColumn1.Width = 160;
            // 
            // stockProductoDataGridViewTextBoxColumn1
            // 
            this.stockProductoDataGridViewTextBoxColumn1.DataPropertyName = "stockProducto";
            this.stockProductoDataGridViewTextBoxColumn1.HeaderText = "Existencia";
            this.stockProductoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.stockProductoDataGridViewTextBoxColumn1.Name = "stockProductoDataGridViewTextBoxColumn1";
            this.stockProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stockProductoDataGridViewTextBoxColumn1.Width = 160;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn1
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.nombreCategoriaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreCategoriaDataGridViewTextBoxColumn1.Name = "nombreCategoriaDataGridViewTextBoxColumn1";
            this.nombreCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn1.Width = 160;
            // 
            // estadoProductoDataGridViewTextBoxColumn1
            // 
            this.estadoProductoDataGridViewTextBoxColumn1.DataPropertyName = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn1.HeaderText = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoProductoDataGridViewTextBoxColumn1.Name = "estadoProductoDataGridViewTextBoxColumn1";
            this.estadoProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoProductoDataGridViewTextBoxColumn1.Visible = false;
            this.estadoProductoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "skuProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // frmProdEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProdEstados";
            this.Text = "Modificar estado";
            this.Load += new System.EventHandler(this.frmProdEstados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProdActivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbProdInactivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosInactivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbProdActivoDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwProductosActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter vwProductosActivosTableAdapter;
        private System.Windows.Forms.DataGridView tbProdInactivoDataGridView;
        private System.Windows.Forms.BindingSource vwProductosInactivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwProductosInactivosTableAdapter vwProductosInactivosTableAdapter;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.BindingSource tbProductoBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbProductoTableAdapter tbProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}