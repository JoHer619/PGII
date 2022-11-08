
namespace RotacionInventario
{
    partial class frmCompraEstado
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
            this.vwComprasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwComprasInactivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwComprasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwComprasActivasTableAdapter();
            this.vwComprasInactivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwComprasInactivasTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCompraInactivaDataGridView = new System.Windows.Forms.DataGridView();
            this.idCompraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCompraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spDetalleCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDetalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDetalleCompraTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spDetalleCompraTableAdapter();
            this.tableAdapterManager = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasInactivasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraInactivaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // vwComprasInactivasBindingSource
            // 
            this.vwComprasInactivasBindingSource.DataMember = "vwComprasInactivas";
            this.vwComprasInactivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwComprasActivasTableAdapter
            // 
            this.vwComprasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // vwComprasInactivasTableAdapter
            // 
            this.vwComprasInactivasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCompraInactivaDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(35, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 480);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compras inactivas";
            // 
            // tbCompraInactivaDataGridView
            // 
            this.tbCompraInactivaDataGridView.AllowUserToAddRows = false;
            this.tbCompraInactivaDataGridView.AllowUserToDeleteRows = false;
            this.tbCompraInactivaDataGridView.AllowUserToResizeColumns = false;
            this.tbCompraInactivaDataGridView.AllowUserToResizeRows = false;
            this.tbCompraInactivaDataGridView.AutoGenerateColumns = false;
            this.tbCompraInactivaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbCompraInactivaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCompraInactivaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbCompraInactivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCompraInactivaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompraDataGridViewTextBoxColumn1,
            this.fechaCompraDataGridViewTextBoxColumn1,
            this.totalCompraDataGridViewTextBoxColumn1,
            this.estadoCompraDataGridViewTextBoxColumn1});
            this.tbCompraInactivaDataGridView.DataSource = this.vwComprasInactivasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCompraInactivaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbCompraInactivaDataGridView.EnableHeadersVisualStyles = false;
            this.tbCompraInactivaDataGridView.Location = new System.Drawing.Point(50, 60);
            this.tbCompraInactivaDataGridView.Name = "tbCompraInactivaDataGridView";
            this.tbCompraInactivaDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCompraInactivaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbCompraInactivaDataGridView.RowHeadersWidth = 62;
            this.tbCompraInactivaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbCompraInactivaDataGridView.RowTemplate.Height = 35;
            this.tbCompraInactivaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCompraInactivaDataGridView.Size = new System.Drawing.Size(670, 380);
            this.tbCompraInactivaDataGridView.TabIndex = 1;
            this.tbCompraInactivaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCompraInactivaDataGridView_CellContentClick);
            // 
            // idCompraDataGridViewTextBoxColumn1
            // 
            this.idCompraDataGridViewTextBoxColumn1.DataPropertyName = "idCompra";
            this.idCompraDataGridViewTextBoxColumn1.HeaderText = "No. de compra";
            this.idCompraDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idCompraDataGridViewTextBoxColumn1.Name = "idCompraDataGridViewTextBoxColumn1";
            this.idCompraDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idCompraDataGridViewTextBoxColumn1.Width = 200;
            // 
            // fechaCompraDataGridViewTextBoxColumn1
            // 
            this.fechaCompraDataGridViewTextBoxColumn1.DataPropertyName = "fechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn1.HeaderText = "Fecha de compra";
            this.fechaCompraDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fechaCompraDataGridViewTextBoxColumn1.Name = "fechaCompraDataGridViewTextBoxColumn1";
            this.fechaCompraDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn1.Width = 200;
            // 
            // totalCompraDataGridViewTextBoxColumn1
            // 
            this.totalCompraDataGridViewTextBoxColumn1.DataPropertyName = "totalCompra";
            this.totalCompraDataGridViewTextBoxColumn1.HeaderText = "Costo total";
            this.totalCompraDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.totalCompraDataGridViewTextBoxColumn1.Name = "totalCompraDataGridViewTextBoxColumn1";
            this.totalCompraDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalCompraDataGridViewTextBoxColumn1.Width = 200;
            // 
            // estadoCompraDataGridViewTextBoxColumn1
            // 
            this.estadoCompraDataGridViewTextBoxColumn1.DataPropertyName = "estadoCompra";
            this.estadoCompraDataGridViewTextBoxColumn1.HeaderText = "estadoCompra";
            this.estadoCompraDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoCompraDataGridViewTextBoxColumn1.Name = "estadoCompraDataGridViewTextBoxColumn1";
            this.estadoCompraDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoCompraDataGridViewTextBoxColumn1.Visible = false;
            this.estadoCompraDataGridViewTextBoxColumn1.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spDetalleCompraDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(840, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 480);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Compras";
            this.groupBox1.UseCompatibleTextRendering = true;
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
            this.dataGridViewTextBoxColumn7});
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
            this.spDetalleCompraDataGridView.Location = new System.Drawing.Point(50, 60);
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
            this.spDetalleCompraDataGridView.Size = new System.Drawing.Size(670, 380);
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
            this.dataGridViewTextBoxColumn6.Width = 150;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // spDetalleCompraBindingSource
            // 
            this.spDetalleCompraBindingSource.DataMember = "spDetalleCompra";
            this.spDetalleCompraBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // spDetalleCompraTableAdapter
            // 
            this.spDetalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbBitacoraLoginTableAdapter = null;
            this.tableAdapterManager.tbBitacoraTableAdapter = null;
            this.tableAdapterManager.tbCategoriaTableAdapter = null;
            this.tableAdapterManager.tbCompraTableAdapter = null;
            this.tableAdapterManager.tbDetalleCompraTableAdapter = null;
            this.tableAdapterManager.tbDetalleVentaTableAdapter = null;
            this.tableAdapterManager.tbProductoTableAdapter = null;
            this.tableAdapterManager.tbRolTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.tbVentaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCompraEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCompraEstado";
            this.Text = "Compras Inactivas";
            this.Load += new System.EventHandler(this.frmCompraEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwComprasInactivasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCompraInactivaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn1;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwComprasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwComprasActivasTableAdapter vwComprasActivasTableAdapter;
        private System.Windows.Forms.BindingSource vwComprasInactivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwComprasInactivasTableAdapter vwComprasInactivasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbCompraInactivaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCompraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource spDetalleCompraBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spDetalleCompraTableAdapter spDetalleCompraTableAdapter;
        private BD_INVENTARIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spDetalleCompraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}