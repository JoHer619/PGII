
namespace RotacionInventario
{
    partial class frmRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRolesDataGridView = new System.Windows.Forms.DataGridView();
            this.vwRolesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRolTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.chbProductos = new System.Windows.Forms.CheckBox();
            this.chbReportes = new System.Windows.Forms.CheckBox();
            this.chbBitacoras = new System.Windows.Forms.CheckBox();
            this.chbRoles = new System.Windows.Forms.CheckBox();
            this.chbUsuarios = new System.Windows.Forms.CheckBox();
            this.chbCategorias = new System.Windows.Forms.CheckBox();
            this.chbCompras = new System.Windows.Forms.CheckBox();
            this.chbVentas = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.vwRolesActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbRolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14F);
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbRolesDataGridView
            // 
            this.tbRolesDataGridView.AllowUserToAddRows = false;
            this.tbRolesDataGridView.AllowUserToDeleteRows = false;
            this.tbRolesDataGridView.AllowUserToResizeColumns = false;
            this.tbRolesDataGridView.AllowUserToResizeRows = false;
            this.tbRolesDataGridView.AutoGenerateColumns = false;
            this.tbRolesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbRolesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbRolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbRolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tbRolesDataGridView.DataSource = this.vwRolesActivosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbRolesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbRolesDataGridView.EnableHeadersVisualStyles = false;
            this.tbRolesDataGridView.Location = new System.Drawing.Point(33, 61);
            this.tbRolesDataGridView.Name = "tbRolesDataGridView";
            this.tbRolesDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbRolesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbRolesDataGridView.RowHeadersWidth = 62;
            this.tbRolesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbRolesDataGridView.RowTemplate.Height = 35;
            this.tbRolesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbRolesDataGridView.Size = new System.Drawing.Size(1470, 450);
            this.tbRolesDataGridView.TabIndex = 1;
            this.tbRolesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbRolesDataGridView_CellContentClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLimpiar);
            this.groupBox1.Controls.Add(this.chbProductos);
            this.groupBox1.Controls.Add(this.chbReportes);
            this.groupBox1.Controls.Add(this.chbBitacoras);
            this.groupBox1.Controls.Add(this.chbRoles);
            this.groupBox1.Controls.Add(this.chbUsuarios);
            this.groupBox1.Controls.Add(this.chbCategorias);
            this.groupBox1.Controls.Add(this.chbCompras);
            this.groupBox1.Controls.Add(this.chbVentas);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(566, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1032, 214);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos de rol";
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.AutoSize = true;
            this.txtLimpiar.Font = new System.Drawing.Font("Lato", 14F);
            this.txtLimpiar.Location = new System.Drawing.Point(839, 54);
            this.txtLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(150, 60);
            this.txtLimpiar.TabIndex = 72;
            this.txtLimpiar.Text = "&Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // chbProductos
            // 
            this.chbProductos.AutoSize = true;
            this.chbProductos.Font = new System.Drawing.Font("Lato", 14F);
            this.chbProductos.Location = new System.Drawing.Point(244, 66);
            this.chbProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbProductos.Name = "chbProductos";
            this.chbProductos.Size = new System.Drawing.Size(166, 38);
            this.chbProductos.TabIndex = 0;
            this.chbProductos.Text = "Productos";
            this.chbProductos.UseVisualStyleBackColor = true;
            // 
            // chbReportes
            // 
            this.chbReportes.AutoSize = true;
            this.chbReportes.Font = new System.Drawing.Font("Lato", 14F);
            this.chbReportes.Location = new System.Drawing.Point(636, 129);
            this.chbReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbReportes.Name = "chbReportes";
            this.chbReportes.Size = new System.Drawing.Size(152, 38);
            this.chbReportes.TabIndex = 7;
            this.chbReportes.Text = "Reportes";
            this.chbReportes.UseVisualStyleBackColor = true;
            // 
            // chbBitacoras
            // 
            this.chbBitacoras.AutoSize = true;
            this.chbBitacoras.Font = new System.Drawing.Font("Lato", 14F);
            this.chbBitacoras.Location = new System.Drawing.Point(636, 66);
            this.chbBitacoras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbBitacoras.Name = "chbBitacoras";
            this.chbBitacoras.Size = new System.Drawing.Size(155, 38);
            this.chbBitacoras.TabIndex = 6;
            this.chbBitacoras.Text = "Bitacoras";
            this.chbBitacoras.UseVisualStyleBackColor = true;
            // 
            // chbRoles
            // 
            this.chbRoles.AutoSize = true;
            this.chbRoles.Font = new System.Drawing.Font("Lato", 14F);
            this.chbRoles.Location = new System.Drawing.Point(450, 129);
            this.chbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbRoles.Name = "chbRoles";
            this.chbRoles.Size = new System.Drawing.Size(108, 38);
            this.chbRoles.TabIndex = 5;
            this.chbRoles.Text = "Roles";
            this.chbRoles.UseVisualStyleBackColor = true;
            // 
            // chbUsuarios
            // 
            this.chbUsuarios.AutoSize = true;
            this.chbUsuarios.Font = new System.Drawing.Font("Lato", 14F);
            this.chbUsuarios.Location = new System.Drawing.Point(450, 66);
            this.chbUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbUsuarios.Name = "chbUsuarios";
            this.chbUsuarios.Size = new System.Drawing.Size(148, 38);
            this.chbUsuarios.TabIndex = 4;
            this.chbUsuarios.Text = "Usuarios";
            this.chbUsuarios.UseVisualStyleBackColor = true;
            // 
            // chbCategorias
            // 
            this.chbCategorias.AutoSize = true;
            this.chbCategorias.Font = new System.Drawing.Font("Lato", 14F);
            this.chbCategorias.Location = new System.Drawing.Point(244, 129);
            this.chbCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbCategorias.Name = "chbCategorias";
            this.chbCategorias.Size = new System.Drawing.Size(173, 38);
            this.chbCategorias.TabIndex = 3;
            this.chbCategorias.Text = "Categorias";
            this.chbCategorias.UseVisualStyleBackColor = true;
            // 
            // chbCompras
            // 
            this.chbCompras.AutoSize = true;
            this.chbCompras.Font = new System.Drawing.Font("Lato", 14F);
            this.chbCompras.Location = new System.Drawing.Point(55, 129);
            this.chbCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbCompras.Name = "chbCompras";
            this.chbCompras.Size = new System.Drawing.Size(151, 38);
            this.chbCompras.TabIndex = 1;
            this.chbCompras.Text = "Compras";
            this.chbCompras.UseVisualStyleBackColor = true;
            // 
            // chbVentas
            // 
            this.chbVentas.AutoSize = true;
            this.chbVentas.Font = new System.Drawing.Font("Lato", 14F);
            this.chbVentas.Location = new System.Drawing.Point(55, 66);
            this.chbVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbVentas.Name = "chbVentas";
            this.chbVentas.Size = new System.Drawing.Size(125, 38);
            this.chbVentas.TabIndex = 0;
            this.chbVentas.Text = "Ventas";
            this.chbVentas.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnRegistrar.Location = new System.Drawing.Point(68, 198);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(180, 60);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "&Registrar rol";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnActualizar.Location = new System.Drawing.Point(281, 198);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(186, 60);
            this.btnActualizar.TabIndex = 69;
            this.btnActualizar.Text = "&Actualizar rol";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Lato", 18F);
            this.txtNombre.Location = new System.Drawing.Point(68, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(399, 51);
            this.txtNombre.TabIndex = 70;
            // 
            // vwRolesActivosTableAdapter
            // 
            this.vwRolesActivosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRolesDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(68, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1530, 550);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos por rol";
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
            this.nombreRolDataGridViewTextBoxColumn.Width = 200;
            // 
            // estadoRolDataGridViewTextBoxColumn
            // 
            this.estadoRolDataGridViewTextBoxColumn.DataPropertyName = "estadoRol";
            this.estadoRolDataGridViewTextBoxColumn.HeaderText = "estadoRol";
            this.estadoRolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoRolDataGridViewTextBoxColumn.Name = "estadoRolDataGridViewTextBoxColumn";
            this.estadoRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoRolDataGridViewTextBoxColumn.Visible = false;
            this.estadoRolDataGridViewTextBoxColumn.Width = 90;
            // 
            // pVentasDataGridViewCheckBoxColumn
            // 
            this.pVentasDataGridViewCheckBoxColumn.DataPropertyName = "pVentas";
            this.pVentasDataGridViewCheckBoxColumn.HeaderText = "Ventas";
            this.pVentasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pVentasDataGridViewCheckBoxColumn.Name = "pVentasDataGridViewCheckBoxColumn";
            this.pVentasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pVentasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pComprasDataGridViewCheckBoxColumn
            // 
            this.pComprasDataGridViewCheckBoxColumn.DataPropertyName = "pCompras";
            this.pComprasDataGridViewCheckBoxColumn.HeaderText = "Compras";
            this.pComprasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pComprasDataGridViewCheckBoxColumn.Name = "pComprasDataGridViewCheckBoxColumn";
            this.pComprasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pComprasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pProductosDataGridViewCheckBoxColumn
            // 
            this.pProductosDataGridViewCheckBoxColumn.DataPropertyName = "pProductos";
            this.pProductosDataGridViewCheckBoxColumn.HeaderText = "Productos";
            this.pProductosDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pProductosDataGridViewCheckBoxColumn.Name = "pProductosDataGridViewCheckBoxColumn";
            this.pProductosDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pProductosDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pCategoriasDataGridViewCheckBoxColumn
            // 
            this.pCategoriasDataGridViewCheckBoxColumn.DataPropertyName = "pCategorias";
            this.pCategoriasDataGridViewCheckBoxColumn.HeaderText = "Categorias";
            this.pCategoriasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pCategoriasDataGridViewCheckBoxColumn.Name = "pCategoriasDataGridViewCheckBoxColumn";
            this.pCategoriasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pCategoriasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pUsuariosDataGridViewCheckBoxColumn
            // 
            this.pUsuariosDataGridViewCheckBoxColumn.DataPropertyName = "pUsuarios";
            this.pUsuariosDataGridViewCheckBoxColumn.HeaderText = "Usuarios";
            this.pUsuariosDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pUsuariosDataGridViewCheckBoxColumn.Name = "pUsuariosDataGridViewCheckBoxColumn";
            this.pUsuariosDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pUsuariosDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pRolesDataGridViewCheckBoxColumn
            // 
            this.pRolesDataGridViewCheckBoxColumn.DataPropertyName = "pRoles";
            this.pRolesDataGridViewCheckBoxColumn.HeaderText = "Roles";
            this.pRolesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pRolesDataGridViewCheckBoxColumn.Name = "pRolesDataGridViewCheckBoxColumn";
            this.pRolesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pRolesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pBitacorasDataGridViewCheckBoxColumn
            // 
            this.pBitacorasDataGridViewCheckBoxColumn.DataPropertyName = "pBitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn.HeaderText = "Bitacoras";
            this.pBitacorasDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pBitacorasDataGridViewCheckBoxColumn.Name = "pBitacorasDataGridViewCheckBoxColumn";
            this.pBitacorasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pBitacorasDataGridViewCheckBoxColumn.Width = 150;
            // 
            // pReportesDataGridViewCheckBoxColumn
            // 
            this.pReportesDataGridViewCheckBoxColumn.DataPropertyName = "pReportes";
            this.pReportesDataGridViewCheckBoxColumn.HeaderText = "Reportes";
            this.pReportesDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.pReportesDataGridViewCheckBoxColumn.Name = "pReportesDataGridViewCheckBoxColumn";
            this.pReportesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pReportesDataGridViewCheckBoxColumn.Width = 150;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRol";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.frmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbRolesDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbRolBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter tbRolTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbProductos;
        private System.Windows.Forms.CheckBox chbReportes;
        private System.Windows.Forms.CheckBox chbBitacoras;
        private System.Windows.Forms.CheckBox chbRoles;
        private System.Windows.Forms.CheckBox chbUsuarios;
        private System.Windows.Forms.CheckBox chbCategorias;
        private System.Windows.Forms.CheckBox chbCompras;
        private System.Windows.Forms.CheckBox chbVentas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.BindingSource vwRolesActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter vwRolesActivosTableAdapter;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn pBackupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtLimpiar;
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
    }
}