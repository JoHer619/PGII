
namespace RotacionInventario
{
    partial class frmVerCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.idCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwComprasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.spDetalleCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDetalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.tbDetalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDetalleCompraTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbDetalleCompraTableAdapter();
            this.tbCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCompraTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbCompraTableAdapter();
            this.vwComprasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwComprasActivasTableAdapter();
            this.tableAdapterManager = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager();
            this.spDetalleCompraTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spDetalleCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbComprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComprasDataGridView
            // 
            this.tbComprasDataGridView.AllowUserToAddRows = false;
            this.tbComprasDataGridView.AllowUserToDeleteRows = false;
            this.tbComprasDataGridView.AllowUserToResizeColumns = false;
            this.tbComprasDataGridView.AllowUserToResizeRows = false;
            this.tbComprasDataGridView.AutoGenerateColumns = false;
            this.tbComprasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbComprasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbComprasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbComprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompraDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.totalCompraDataGridViewTextBoxColumn,
            this.estadoCompraDataGridViewTextBoxColumn});
            this.tbComprasDataGridView.DataSource = this.vwComprasActivasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbComprasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbComprasDataGridView.EnableHeadersVisualStyles = false;
            this.tbComprasDataGridView.Location = new System.Drawing.Point(40, 50);
            this.tbComprasDataGridView.Name = "tbComprasDataGridView";
            this.tbComprasDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbComprasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbComprasDataGridView.RowHeadersWidth = 62;
            this.tbComprasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbComprasDataGridView.RowTemplate.Height = 35;
            this.tbComprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbComprasDataGridView.Size = new System.Drawing.Size(570, 500);
            this.tbComprasDataGridView.TabIndex = 0;
            this.tbComprasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbComprasDataGridView_CellContentClick);
            // 
            // idCompraDataGridViewTextBoxColumn
            // 
            this.idCompraDataGridViewTextBoxColumn.DataPropertyName = "idCompra";
            this.idCompraDataGridViewTextBoxColumn.HeaderText = "No. de compra";
            this.idCompraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCompraDataGridViewTextBoxColumn.Name = "idCompraDataGridViewTextBoxColumn";
            this.idCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "fechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha de compra";
            this.fechaCompraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalCompraDataGridViewTextBoxColumn
            // 
            this.totalCompraDataGridViewTextBoxColumn.DataPropertyName = "totalCompra";
            this.totalCompraDataGridViewTextBoxColumn.HeaderText = "Costo total";
            this.totalCompraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalCompraDataGridViewTextBoxColumn.Name = "totalCompraDataGridViewTextBoxColumn";
            this.totalCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoCompraDataGridViewTextBoxColumn
            // 
            this.estadoCompraDataGridViewTextBoxColumn.DataPropertyName = "estadoCompra";
            this.estadoCompraDataGridViewTextBoxColumn.HeaderText = "estadoCompra";
            this.estadoCompraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoCompraDataGridViewTextBoxColumn.Name = "estadoCompraDataGridViewTextBoxColumn";
            this.estadoCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoCompraDataGridViewTextBoxColumn.Visible = false;
            this.estadoCompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // vwComprasActivasBindingSource
            // 
            this.vwComprasActivasBindingSource.DataMember = "vwComprasActivas";
            this.vwComprasActivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbComprasDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(64, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 580);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de compras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spDetalleCompraDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(792, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 580);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de compra";
            // 
            // spDetalleCompraDataGridView
            // 
            this.spDetalleCompraDataGridView.AllowUserToAddRows = false;
            this.spDetalleCompraDataGridView.AllowUserToDeleteRows = false;
            this.spDetalleCompraDataGridView.AllowUserToResizeColumns = false;
            this.spDetalleCompraDataGridView.AllowUserToResizeRows = false;
            this.spDetalleCompraDataGridView.AutoGenerateColumns = false;
            this.spDetalleCompraDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.spDetalleCompraDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleCompraDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.spDetalleCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spDetalleCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idProducto});
            this.spDetalleCompraDataGridView.DataSource = this.spDetalleCompraBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.spDetalleCompraDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.spDetalleCompraDataGridView.EnableHeadersVisualStyles = false;
            this.spDetalleCompraDataGridView.Location = new System.Drawing.Point(40, 50);
            this.spDetalleCompraDataGridView.Name = "spDetalleCompraDataGridView";
            this.spDetalleCompraDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleCompraDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.spDetalleCompraDataGridView.RowHeadersWidth = 62;
            this.spDetalleCompraDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.spDetalleCompraDataGridView.RowTemplate.Height = 35;
            this.spDetalleCompraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.spDetalleCompraDataGridView.Size = new System.Drawing.Size(720, 500);
            this.spDetalleCompraDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalleCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDetalleCompra";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subtotalCompra";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "idCompra";
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
            // spDetalleCompraBindingSource
            // 
            this.spDetalleCompraBindingSource.DataMember = "spDetalleCompra";
            this.spDetalleCompraBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCompra);
            this.groupBox3.Controls.Add(this.btnEstado);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(380, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 150);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambiar estado";
            // 
            // lblCompra
            // 
            this.lblCompra.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblCompra.Location = new System.Drawing.Point(28, 62);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(200, 42);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "- - -";
            this.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Lato", 14F);
            this.btnEstado.Location = new System.Drawing.Point(536, 53);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(220, 60);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "Cambiar estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // tbDetalleCompraBindingSource
            // 
            this.tbDetalleCompraBindingSource.DataMember = "tbDetalleCompra";
            this.tbDetalleCompraBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbDetalleCompraTableAdapter
            // 
            this.tbDetalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // tbCompraBindingSource
            // 
            this.tbCompraBindingSource.DataMember = "tbCompra";
            this.tbCompraBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbCompraTableAdapter
            // 
            this.tbCompraTableAdapter.ClearBeforeFill = true;
            // 
            // vwComprasActivasTableAdapter
            // 
            this.vwComprasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbBitacoraLoginTableAdapter = null;
            this.tableAdapterManager.tbBitacoraTableAdapter = null;
            this.tableAdapterManager.tbCategoriaTableAdapter = null;
            this.tableAdapterManager.tbCompraTableAdapter = this.tbCompraTableAdapter;
            this.tableAdapterManager.tbDetalleCompraTableAdapter = this.tbDetalleCompraTableAdapter;
            this.tableAdapterManager.tbDetalleVentaTableAdapter = null;
            this.tableAdapterManager.tbProductoTableAdapter = null;
            this.tableAdapterManager.tbRolTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVentaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spDetalleCompraTableAdapter
            // 
            this.spDetalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // frmVerCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVerCompras";
            this.Text = "Inhabilitar Compra";
            this.Load += new System.EventHandler(this.frmVerCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbComprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbDetalleCompraBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbDetalleCompraTableAdapter tbDetalleCompraTableAdapter;
        private System.Windows.Forms.BindingSource tbCompraBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbCompraTableAdapter tbCompraTableAdapter;
        private System.Windows.Forms.DataGridView tbComprasDataGridView;
        private System.Windows.Forms.BindingSource vwComprasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwComprasActivasTableAdapter vwComprasActivasTableAdapter;
        private BD_INVENTARIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView spDetalleCompraDataGridView;
        private System.Windows.Forms.BindingSource spDetalleCompraBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spDetalleCompraTableAdapter spDetalleCompraTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
    }
}