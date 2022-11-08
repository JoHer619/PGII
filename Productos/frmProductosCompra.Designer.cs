
namespace RotacionInventario
{
    partial class frmProductosCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosCompra));
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwProductosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tbProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProducto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwProductosActivosBindingSource
            // 
            this.vwProductosActivosBindingSource.DataMember = "vwProductosActivos";
            this.vwProductosActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwProductosActivosTableAdapter
            // 
            this.vwProductosActivosTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.TabIndex = 84;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Codigo,
            this.addProducto});
            this.tbProductosDataGridView.DataSource = this.vwProductosActivosBindingSource;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 590;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "precioProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stockProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Existencia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombreCategoria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estadoProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "estadoProducto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "skuProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 195;
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
            // frmProductosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 894);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProductosCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de productos";
            this.Load += new System.EventHandler(this.frmVerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosActivosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwProductosActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwProductosActivosTableAdapter vwProductosActivosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView tbProductosDataGridView;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewImageColumn addProducto;
    }
}