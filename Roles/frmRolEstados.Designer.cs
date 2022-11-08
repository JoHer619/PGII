
namespace RotacionInventario
{
    partial class frmRolEstados
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
            this.tbRolActivoDataGridView = new System.Windows.Forms.DataGridView();
            this.idRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVentasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pComprasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pProductosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pCategoriasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pUsuariosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pRolesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pBitacorasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pReportesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vwRolesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRolTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter();
            this.vwRolesActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter();
            this.tbRolInactivoDataGridView = new System.Windows.Forms.DataGridView();
            this.idRolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVentasDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pComprasDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pProductosDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pCategoriasDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pUsuariosDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pRolesDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pBitacorasDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pReportesDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vwRolesInactivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRolesInactivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwRolesInactivosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolActivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolInactivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesInactivosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRolActivoDataGridView
            // 
            this.tbRolActivoDataGridView.AllowUserToAddRows = false;
            this.tbRolActivoDataGridView.AllowUserToDeleteRows = false;
            this.tbRolActivoDataGridView.AllowUserToResizeColumns = false;
            this.tbRolActivoDataGridView.AllowUserToResizeRows = false;
            this.tbRolActivoDataGridView.AutoGenerateColumns = false;
            this.tbRolActivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbRolActivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolActivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbRolActivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbRolActivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRolDataGridViewTextBoxColumn,
            this.nombreRolDataGridViewTextBoxColumn,
            this.estadoRolDataGridViewTextBoxColumn,
            this.pVentasDataGridViewCheckBoxColumn,
            this.pComprasDataGridViewCheckBoxColumn,
            this.pProductosDataGridViewCheckBoxColumn,
            this.pCategoriasDataGridViewCheckBoxColumn,
            this.pUsuariosDataGridViewCheckBoxColumn,
            this.pRolesDataGridViewCheckBoxColumn,
            this.pBitacorasDataGridViewCheckBoxColumn,
            this.pReportesDataGridViewCheckBoxColumn});
            this.tbRolActivoDataGridView.DataSource = this.vwRolesActivosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbRolActivoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbRolActivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbRolActivoDataGridView.Location = new System.Drawing.Point(37, 50);
            this.tbRolActivoDataGridView.Name = "tbRolActivoDataGridView";
            this.tbRolActivoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolActivoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbRolActivoDataGridView.RowHeadersWidth = 62;
            this.tbRolActivoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbRolActivoDataGridView.RowTemplate.Height = 35;
            this.tbRolActivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbRolActivoDataGridView.Size = new System.Drawing.Size(570, 350);
            this.tbRolActivoDataGridView.TabIndex = 1;
            this.tbRolActivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbRolActivoDataGridView_CellContentClick);
            // 
            // idRolDataGridViewTextBoxColumn
            // 
            this.idRolDataGridViewTextBoxColumn.DataPropertyName = "idRol";
            this.idRolDataGridViewTextBoxColumn.HeaderText = "idRol";
            this.idRolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idRolDataGridViewTextBoxColumn.Name = "idRolDataGridViewTextBoxColumn";
            this.idRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRolDataGridViewTextBoxColumn.Visible = false;
            this.idRolDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreRolDataGridViewTextBoxColumn
            // 
            this.nombreRolDataGridViewTextBoxColumn.DataPropertyName = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreRolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreRolDataGridViewTextBoxColumn.Name = "nombreRolDataGridViewTextBoxColumn";
            this.nombreRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRolDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoRolDataGridViewTextBoxColumn
            // 
            this.estadoRolDataGridViewTextBoxColumn.DataPropertyName = "estadoRol";
            this.estadoRolDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoRolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoRolDataGridViewTextBoxColumn.Name = "estadoRolDataGridViewTextBoxColumn";
            this.estadoRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoRolDataGridViewTextBoxColumn.Width = 200;
            // 
            // pVentasDataGridViewCheckBoxColumn
            // 
            this.pVentasDataGridViewCheckBoxColumn.DataPropertyName = "pVentas";
            this.pVentasDataGridViewCheckBoxColumn.HeaderText = "pVentas";
            this.pVentasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pVentasDataGridViewCheckBoxColumn.Name = "pVentasDataGridViewCheckBoxColumn";
            this.pVentasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pVentasDataGridViewCheckBoxColumn.Visible = false;
            this.pVentasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pComprasDataGridViewCheckBoxColumn
            // 
            this.pComprasDataGridViewCheckBoxColumn.DataPropertyName = "pCompras";
            this.pComprasDataGridViewCheckBoxColumn.HeaderText = "pCompras";
            this.pComprasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pComprasDataGridViewCheckBoxColumn.Name = "pComprasDataGridViewCheckBoxColumn";
            this.pComprasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pComprasDataGridViewCheckBoxColumn.Visible = false;
            this.pComprasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pProductosDataGridViewCheckBoxColumn
            // 
            this.pProductosDataGridViewCheckBoxColumn.DataPropertyName = "pProductos";
            this.pProductosDataGridViewCheckBoxColumn.HeaderText = "pProductos";
            this.pProductosDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pProductosDataGridViewCheckBoxColumn.Name = "pProductosDataGridViewCheckBoxColumn";
            this.pProductosDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pProductosDataGridViewCheckBoxColumn.Visible = false;
            this.pProductosDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pCategoriasDataGridViewCheckBoxColumn
            // 
            this.pCategoriasDataGridViewCheckBoxColumn.DataPropertyName = "pCategorias";
            this.pCategoriasDataGridViewCheckBoxColumn.HeaderText = "pCategorias";
            this.pCategoriasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pCategoriasDataGridViewCheckBoxColumn.Name = "pCategoriasDataGridViewCheckBoxColumn";
            this.pCategoriasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pCategoriasDataGridViewCheckBoxColumn.Visible = false;
            this.pCategoriasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pUsuariosDataGridViewCheckBoxColumn
            // 
            this.pUsuariosDataGridViewCheckBoxColumn.DataPropertyName = "pUsuarios";
            this.pUsuariosDataGridViewCheckBoxColumn.HeaderText = "pUsuarios";
            this.pUsuariosDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pUsuariosDataGridViewCheckBoxColumn.Name = "pUsuariosDataGridViewCheckBoxColumn";
            this.pUsuariosDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pUsuariosDataGridViewCheckBoxColumn.Visible = false;
            this.pUsuariosDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pRolesDataGridViewCheckBoxColumn
            // 
            this.pRolesDataGridViewCheckBoxColumn.DataPropertyName = "pRoles";
            this.pRolesDataGridViewCheckBoxColumn.HeaderText = "pRoles";
            this.pRolesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pRolesDataGridViewCheckBoxColumn.Name = "pRolesDataGridViewCheckBoxColumn";
            this.pRolesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pRolesDataGridViewCheckBoxColumn.Visible = false;
            this.pRolesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pBitacorasDataGridViewCheckBoxColumn
            // 
            this.pBitacorasDataGridViewCheckBoxColumn.DataPropertyName = "pBitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn.HeaderText = "pBitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pBitacorasDataGridViewCheckBoxColumn.Name = "pBitacorasDataGridViewCheckBoxColumn";
            this.pBitacorasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pBitacorasDataGridViewCheckBoxColumn.Visible = false;
            this.pBitacorasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pReportesDataGridViewCheckBoxColumn
            // 
            this.pReportesDataGridViewCheckBoxColumn.DataPropertyName = "pReportes";
            this.pReportesDataGridViewCheckBoxColumn.HeaderText = "pReportes";
            this.pReportesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pReportesDataGridViewCheckBoxColumn.Name = "pReportesDataGridViewCheckBoxColumn";
            this.pReportesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pReportesDataGridViewCheckBoxColumn.Visible = false;
            this.pReportesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // vwRolesActivosBindingSource
            // 
            this.vwRolesActivosBindingSource.DataMember = "vwRolesActivos";
            this.vwRolesActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRolBindingSource
            // 
            this.tbRolBindingSource.DataMember = "tbRol";
            this.tbRolBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbRolTableAdapter
            // 
            this.tbRolTableAdapter.ClearBeforeFill = true;
            // 
            // vwRolesActivosTableAdapter
            // 
            this.vwRolesActivosTableAdapter.ClearBeforeFill = true;
            // 
            // tbRolInactivoDataGridView
            // 
            this.tbRolInactivoDataGridView.AllowUserToAddRows = false;
            this.tbRolInactivoDataGridView.AllowUserToDeleteRows = false;
            this.tbRolInactivoDataGridView.AllowUserToResizeColumns = false;
            this.tbRolInactivoDataGridView.AllowUserToResizeRows = false;
            this.tbRolInactivoDataGridView.AutoGenerateColumns = false;
            this.tbRolInactivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbRolInactivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolInactivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbRolInactivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbRolInactivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRolDataGridViewTextBoxColumn1,
            this.nombreRolDataGridViewTextBoxColumn1,
            this.estadoRolDataGridViewTextBoxColumn1,
            this.pVentasDataGridViewCheckBoxColumn1,
            this.pComprasDataGridViewCheckBoxColumn1,
            this.pProductosDataGridViewCheckBoxColumn1,
            this.pCategoriasDataGridViewCheckBoxColumn1,
            this.pUsuariosDataGridViewCheckBoxColumn1,
            this.pRolesDataGridViewCheckBoxColumn1,
            this.pBitacorasDataGridViewCheckBoxColumn1,
            this.pReportesDataGridViewCheckBoxColumn1});
            this.tbRolInactivoDataGridView.DataSource = this.vwRolesInactivosBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbRolInactivoDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbRolInactivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbRolInactivoDataGridView.Location = new System.Drawing.Point(37, 58);
            this.tbRolInactivoDataGridView.Name = "tbRolInactivoDataGridView";
            this.tbRolInactivoDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolInactivoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbRolInactivoDataGridView.RowHeadersWidth = 62;
            this.tbRolInactivoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbRolInactivoDataGridView.RowTemplate.Height = 35;
            this.tbRolInactivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbRolInactivoDataGridView.Size = new System.Drawing.Size(570, 350);
            this.tbRolInactivoDataGridView.TabIndex = 2;
            this.tbRolInactivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbRolInactivoDataGridView_CellContentClick);
            // 
            // idRolDataGridViewTextBoxColumn1
            // 
            this.idRolDataGridViewTextBoxColumn1.DataPropertyName = "idRol";
            this.idRolDataGridViewTextBoxColumn1.HeaderText = "idRol";
            this.idRolDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idRolDataGridViewTextBoxColumn1.Name = "idRolDataGridViewTextBoxColumn1";
            this.idRolDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idRolDataGridViewTextBoxColumn1.Visible = false;
            this.idRolDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreRolDataGridViewTextBoxColumn1
            // 
            this.nombreRolDataGridViewTextBoxColumn1.DataPropertyName = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreRolDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreRolDataGridViewTextBoxColumn1.Name = "nombreRolDataGridViewTextBoxColumn1";
            this.nombreRolDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreRolDataGridViewTextBoxColumn1.Width = 300;
            // 
            // estadoRolDataGridViewTextBoxColumn1
            // 
            this.estadoRolDataGridViewTextBoxColumn1.DataPropertyName = "estadoRol";
            this.estadoRolDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoRolDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoRolDataGridViewTextBoxColumn1.Name = "estadoRolDataGridViewTextBoxColumn1";
            this.estadoRolDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoRolDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pVentasDataGridViewCheckBoxColumn1
            // 
            this.pVentasDataGridViewCheckBoxColumn1.DataPropertyName = "pVentas";
            this.pVentasDataGridViewCheckBoxColumn1.HeaderText = "pVentas";
            this.pVentasDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pVentasDataGridViewCheckBoxColumn1.Name = "pVentasDataGridViewCheckBoxColumn1";
            this.pVentasDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pVentasDataGridViewCheckBoxColumn1.Visible = false;
            this.pVentasDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pComprasDataGridViewCheckBoxColumn1
            // 
            this.pComprasDataGridViewCheckBoxColumn1.DataPropertyName = "pCompras";
            this.pComprasDataGridViewCheckBoxColumn1.HeaderText = "pCompras";
            this.pComprasDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pComprasDataGridViewCheckBoxColumn1.Name = "pComprasDataGridViewCheckBoxColumn1";
            this.pComprasDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pComprasDataGridViewCheckBoxColumn1.Visible = false;
            this.pComprasDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pProductosDataGridViewCheckBoxColumn1
            // 
            this.pProductosDataGridViewCheckBoxColumn1.DataPropertyName = "pProductos";
            this.pProductosDataGridViewCheckBoxColumn1.HeaderText = "pProductos";
            this.pProductosDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pProductosDataGridViewCheckBoxColumn1.Name = "pProductosDataGridViewCheckBoxColumn1";
            this.pProductosDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pProductosDataGridViewCheckBoxColumn1.Visible = false;
            this.pProductosDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pCategoriasDataGridViewCheckBoxColumn1
            // 
            this.pCategoriasDataGridViewCheckBoxColumn1.DataPropertyName = "pCategorias";
            this.pCategoriasDataGridViewCheckBoxColumn1.HeaderText = "pCategorias";
            this.pCategoriasDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pCategoriasDataGridViewCheckBoxColumn1.Name = "pCategoriasDataGridViewCheckBoxColumn1";
            this.pCategoriasDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pCategoriasDataGridViewCheckBoxColumn1.Visible = false;
            this.pCategoriasDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pUsuariosDataGridViewCheckBoxColumn1
            // 
            this.pUsuariosDataGridViewCheckBoxColumn1.DataPropertyName = "pUsuarios";
            this.pUsuariosDataGridViewCheckBoxColumn1.HeaderText = "pUsuarios";
            this.pUsuariosDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pUsuariosDataGridViewCheckBoxColumn1.Name = "pUsuariosDataGridViewCheckBoxColumn1";
            this.pUsuariosDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pUsuariosDataGridViewCheckBoxColumn1.Visible = false;
            this.pUsuariosDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pRolesDataGridViewCheckBoxColumn1
            // 
            this.pRolesDataGridViewCheckBoxColumn1.DataPropertyName = "pRoles";
            this.pRolesDataGridViewCheckBoxColumn1.HeaderText = "pRoles";
            this.pRolesDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pRolesDataGridViewCheckBoxColumn1.Name = "pRolesDataGridViewCheckBoxColumn1";
            this.pRolesDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pRolesDataGridViewCheckBoxColumn1.Visible = false;
            this.pRolesDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pBitacorasDataGridViewCheckBoxColumn1
            // 
            this.pBitacorasDataGridViewCheckBoxColumn1.DataPropertyName = "pBitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn1.HeaderText = "pBitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pBitacorasDataGridViewCheckBoxColumn1.Name = "pBitacorasDataGridViewCheckBoxColumn1";
            this.pBitacorasDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pBitacorasDataGridViewCheckBoxColumn1.Visible = false;
            this.pBitacorasDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pReportesDataGridViewCheckBoxColumn1
            // 
            this.pReportesDataGridViewCheckBoxColumn1.DataPropertyName = "pReportes";
            this.pReportesDataGridViewCheckBoxColumn1.HeaderText = "pReportes";
            this.pReportesDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.pReportesDataGridViewCheckBoxColumn1.Name = "pReportesDataGridViewCheckBoxColumn1";
            this.pReportesDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pReportesDataGridViewCheckBoxColumn1.Visible = false;
            this.pReportesDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // vwRolesInactivosBindingSource
            // 
            this.vwRolesInactivosBindingSource.DataMember = "vwRolesInactivos";
            this.vwRolesInactivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwRolesInactivosTableAdapter
            // 
            this.vwRolesInactivosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRolActivoDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(130, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles activos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRolInactivoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(875, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles inactivos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRol);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.btnEstado);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(430, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 200);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambiar estado";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblRol.Location = new System.Drawing.Point(40, 80);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(200, 47);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "- - -";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Lato", 18F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(350, 80);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(140, 52);
            this.cmbEstado.TabIndex = 3;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Lato", 14F);
            this.btnEstado.Location = new System.Drawing.Point(530, 75);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(220, 60);
            this.btnEstado.TabIndex = 4;
            this.btnEstado.Text = "Cambiar estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // frmRolEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRolEstados";
            this.Text = "Modificar estados";
            this.Load += new System.EventHandler(this.frmRolEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRolActivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolInactivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesInactivosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tbRolActivoDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbRolBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter tbRolTableAdapter;
        private System.Windows.Forms.BindingSource vwRolesActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter vwRolesActivosTableAdapter;
        private System.Windows.Forms.DataGridView tbRolInactivoDataGridView;
        private System.Windows.Forms.BindingSource vwRolesInactivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwRolesInactivosTableAdapter vwRolesInactivosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pVentasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pComprasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pProductosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pCategoriasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pUsuariosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pRolesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pBitacorasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pReportesDataGridViewCheckBoxColumn;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn pBackupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pVentasDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pComprasDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pProductosDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pCategoriasDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pUsuariosDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pRolesDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pBitacorasDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pReportesDataGridViewCheckBoxColumn1;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn pBackupDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnEstado;
    }
}