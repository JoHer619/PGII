
namespace RotacionInventario
{
    partial class frmVentaEstado
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
            this.vwVentasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwVentasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter();
            this.tbVentaInactivaDataGridView = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwVentasInactivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwVentasInactivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwVentasInactivasTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spDetalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDetalleVentaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter();
            this.tableAdapterManager = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaInactivaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasInactivasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).BeginInit();
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
            // vwVentasActivasTableAdapter
            // 
            this.vwVentasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // tbVentaInactivaDataGridView
            // 
            this.tbVentaInactivaDataGridView.AllowUserToAddRows = false;
            this.tbVentaInactivaDataGridView.AllowUserToDeleteRows = false;
            this.tbVentaInactivaDataGridView.AllowUserToResizeColumns = false;
            this.tbVentaInactivaDataGridView.AllowUserToResizeRows = false;
            this.tbVentaInactivaDataGridView.AutoGenerateColumns = false;
            this.tbVentaInactivaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbVentaInactivaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVentaInactivaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbVentaInactivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVentaInactivaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn1,
            this.fechaVentaDataGridViewTextBoxColumn1,
            this.totalVentaDataGridViewTextBoxColumn1,
            this.estadoVentaDataGridViewTextBoxColumn1});
            this.tbVentaInactivaDataGridView.DataSource = this.vwVentasInactivasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbVentaInactivaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbVentaInactivaDataGridView.EnableHeadersVisualStyles = false;
            this.tbVentaInactivaDataGridView.Location = new System.Drawing.Point(43, 59);
            this.tbVentaInactivaDataGridView.Name = "tbVentaInactivaDataGridView";
            this.tbVentaInactivaDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbVentaInactivaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbVentaInactivaDataGridView.RowHeadersWidth = 62;
            this.tbVentaInactivaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbVentaInactivaDataGridView.RowTemplate.Height = 35;
            this.tbVentaInactivaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbVentaInactivaDataGridView.Size = new System.Drawing.Size(670, 350);
            this.tbVentaInactivaDataGridView.TabIndex = 1;
            this.tbVentaInactivaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbVentaInactivaDataGridView_CellContentClick);
            // 
            // idVentaDataGridViewTextBoxColumn1
            // 
            this.idVentaDataGridViewTextBoxColumn1.DataPropertyName = "idVenta";
            this.idVentaDataGridViewTextBoxColumn1.HeaderText = "No. de venta";
            this.idVentaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idVentaDataGridViewTextBoxColumn1.Name = "idVentaDataGridViewTextBoxColumn1";
            this.idVentaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn1.Width = 200;
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
            this.totalVentaDataGridViewTextBoxColumn1.HeaderText = "Total venta";
            this.totalVentaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.totalVentaDataGridViewTextBoxColumn1.Name = "totalVentaDataGridViewTextBoxColumn1";
            this.totalVentaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalVentaDataGridViewTextBoxColumn1.Width = 200;
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
            // vwVentasInactivasBindingSource
            // 
            this.vwVentasInactivasBindingSource.DataMember = "vwVentasInactivas";
            this.vwVentasInactivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwVentasInactivasTableAdapter
            // 
            this.vwVentasInactivasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVentaInactivaDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(23, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 430);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas inactivas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spDetalleVentaDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(796, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 430);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Ventas ";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleVentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.spDetalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spDetalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.spDetalleVentaDataGridView.DataSource = this.spDetalleVentaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.spDetalleVentaDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.spDetalleVentaDataGridView.EnableHeadersVisualStyles = false;
            this.spDetalleVentaDataGridView.Location = new System.Drawing.Point(20, 68);
            this.spDetalleVentaDataGridView.Name = "spDetalleVentaDataGridView";
            this.spDetalleVentaDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spDetalleVentaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.spDetalleVentaDataGridView.RowHeadersWidth = 62;
            this.spDetalleVentaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.spDetalleVentaDataGridView.RowTemplate.Height = 35;
            this.spDetalleVentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.spDetalleVentaDataGridView.Size = new System.Drawing.Size(711, 262);
            this.spDetalleVentaDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "descuentoProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "descuentoProducto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn8.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 150;
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
            // frmVentaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmVentaEstado";
            this.Text = "Ventas Inactivas";
            this.Load += new System.EventHandler(this.frmVentaEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVentaInactivaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwVentasInactivasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwVentasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwVentasActivasTableAdapter vwVentasActivasTableAdapter;
        private System.Windows.Forms.DataGridView tbVentaInactivaDataGridView;
        private System.Windows.Forms.BindingSource vwVentasInactivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwVentasInactivasTableAdapter vwVentasInactivasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource spDetalleVentaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spDetalleVentaTableAdapter spDetalleVentaTableAdapter;
        private BD_INVENTARIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spDetalleVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}