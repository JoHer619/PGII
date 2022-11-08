
namespace RotacionInventario
{
    partial class frmVerVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVentasDataGridView = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwVentasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.spDetalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVenta = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.tbDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetalleVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbDetalleVentaTableAdapter();
            this.tbVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbVentaTableAdapter();
            this.tableAdapterManager = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager();
            this.vwVentasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter();
            this.spDetalleVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVentasDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(30, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de ventas";
            // 
            // tbVentasDataGridView
            // 
            this.tbVentasDataGridView.AllowUserToAddRows = false;
            this.tbVentasDataGridView.AllowUserToDeleteRows = false;
            this.tbVentasDataGridView.AllowUserToResizeColumns = false;
            this.tbVentasDataGridView.AllowUserToResizeRows = false;
            this.tbVentasDataGridView.AutoGenerateColumns = false;
            this.tbVentasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbVentasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVentasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tbVentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVentasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn2,
            this.fechaVentaDataGridViewTextBoxColumn1,
            this.totalVentaDataGridViewTextBoxColumn1,
            this.estadoVentaDataGridViewTextBoxColumn1});
            this.tbVentasDataGridView.DataSource = this.vwVentasActivasBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbVentasDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.tbVentasDataGridView.EnableHeadersVisualStyles = false;
            this.tbVentasDataGridView.Location = new System.Drawing.Point(40, 50);
            this.tbVentasDataGridView.Name = "tbVentasDataGridView";
            this.tbVentasDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVentasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tbVentasDataGridView.RowHeadersWidth = 62;
            this.tbVentasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbVentasDataGridView.RowTemplate.Height = 35;
            this.tbVentasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbVentasDataGridView.Size = new System.Drawing.Size(570, 500);
            this.tbVentasDataGridView.TabIndex = 2;
            this.tbVentasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbVentasDataGridView_CellContentClick);
            // 
            // idVentaDataGridViewTextBoxColumn2
            // 
            this.idVentaDataGridViewTextBoxColumn2.DataPropertyName = "idVenta";
            this.idVentaDataGridViewTextBoxColumn2.HeaderText = "No. de venta";
            this.idVentaDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.idVentaDataGridViewTextBoxColumn2.Name = "idVentaDataGridViewTextBoxColumn2";
            this.idVentaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn2.Width = 150;
            // 
            // fechaVentaDataGridViewTextBoxColumn1
            // 
            this.fechaVentaDataGridViewTextBoxColumn1.DataPropertyName = "fechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn1.HeaderText = "Fecha de venta";
            this.fechaVentaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fechaVentaDataGridViewTextBoxColumn1.Name = "fechaVentaDataGridViewTextBoxColumn1";
            this.fechaVentaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn1.Width = 200;
            // 
            // totalVentaDataGridViewTextBoxColumn1
            // 
            this.totalVentaDataGridViewTextBoxColumn1.DataPropertyName = "totalVenta";
            this.totalVentaDataGridViewTextBoxColumn1.HeaderText = "Total de venta";
            this.totalVentaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.totalVentaDataGridViewTextBoxColumn1.Name = "totalVentaDataGridViewTextBoxColumn1";
            this.totalVentaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalVentaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // estadoVentaDataGridViewTextBoxColumn1
            // 
            this.estadoVentaDataGridViewTextBoxColumn1.DataPropertyName = "estadoVenta";
            this.estadoVentaDataGridViewTextBoxColumn1.HeaderText = "estadoVenta";
            this.estadoVentaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoVentaDataGridViewTextBoxColumn1.Name = "estadoVentaDataGridViewTextBoxColumn1";
            this.estadoVentaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoVentaDataGridViewTextBoxColumn1.Visible = false;
            this.estadoVentaDataGridViewTextBoxColumn1.Width = 150;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spDetalleVentaDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(720, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 580);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de venta";
            // 
            // spDetalleVentaDataGridView
            // 
            this.spDetalleVentaDataGridView.AllowUserToAddRows = false;
            this.spDetalleVentaDataGridView.AllowUserToDeleteRows = false;
            this.spDetalleVentaDataGridView.AllowUserToResizeColumns = false;
            this.spDetalleVentaDataGridView.AllowUserToResizeRows = false;
            this.spDetalleVentaDataGridView.AutoGenerateColumns = false;
            this.spDetalleVentaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.spDetalleVentaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleVentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.spDetalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spDetalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idProducto});
            this.spDetalleVentaDataGridView.DataSource = this.spDetalleVentaBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.spDetalleVentaDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.spDetalleVentaDataGridView.EnableHeadersVisualStyles = false;
            this.spDetalleVentaDataGridView.Location = new System.Drawing.Point(40, 50);
            this.spDetalleVentaDataGridView.Name = "spDetalleVentaDataGridView";
            this.spDetalleVentaDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleVentaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.spDetalleVentaDataGridView.RowHeadersWidth = 62;
            this.spDetalleVentaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.spDetalleVentaDataGridView.RowTemplate.Height = 35;
            this.spDetalleVentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.spDetalleVentaDataGridView.Size = new System.Drawing.Size(870, 500);
            this.spDetalleVentaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalleVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDetalleVenta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombreProducto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cantidadProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precioProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "descuentoProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subtotalVenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idVenta";
            this.dataGridViewTextBoxColumn5.HeaderText = "idVenta";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 8;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 150;
            // 
            // spDetalleVentaBindingSource
            // 
            this.spDetalleVentaBindingSource.DataMember = "spDetalleVenta";
            this.spDetalleVentaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVenta);
            this.groupBox3.Controls.Add(this.btnEstado);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(380, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambiar estado";
            // 
            // lblVenta
            // 
            this.lblVenta.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblVenta.Location = new System.Drawing.Point(36, 53);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(200, 42);
            this.lblVenta.TabIndex = 0;
            this.lblVenta.Text = "- - -";
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Lato", 14F);
            this.btnEstado.Location = new System.Drawing.Point(537, 44);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(220, 60);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "Cambiar estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
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
            // tbVentaBindingSource
            // 
            this.tbVentaBindingSource.DataMember = "tbVenta";
            this.tbVentaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbVentaTableAdapter
            // 
            this.tbVentaTableAdapter.ClearBeforeFill = true;
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
            // spDetalleVentaTableAdapter
            // 
            this.spDetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVerVentas";
            this.Text = "Inhabilitar Ventas";
            this.Load += new System.EventHandler(this.frmVerVentas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbVentasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbVentasDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbDetalleVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbDetalleVentaTableAdapter tbDetalleVentaTableAdapter;
        private System.Windows.Forms.BindingSource tbVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbVentaTableAdapter tbVentaTableAdapter;
        private BD_INVENTARIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vwVentasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter vwVentasActivasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.DataGridView spDetalleVentaDataGridView;
        private System.Windows.Forms.BindingSource spDetalleVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter spDetalleVentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
    }
}