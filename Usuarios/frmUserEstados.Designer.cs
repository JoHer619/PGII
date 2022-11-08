
namespace RotacionInventario
{
    partial class frmUserEstados
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
            this.tbUserActivoDataGridView = new System.Windows.Forms.DataGridView();
            this.vwUsuariosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwUsuariosActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwUsuariosActivosTableAdapter();
            this.tbUserInactivoDataGridView = new System.Windows.Forms.DataGridView();
            this.vwUsuariosInactivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwUsuariosInactivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwUsuariosInactivosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter();
            this.idUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreRolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserActivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserInactivoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosInactivosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserActivoDataGridView
            // 
            this.tbUserActivoDataGridView.AllowUserToAddRows = false;
            this.tbUserActivoDataGridView.AllowUserToDeleteRows = false;
            this.tbUserActivoDataGridView.AllowUserToResizeColumns = false;
            this.tbUserActivoDataGridView.AllowUserToResizeRows = false;
            this.tbUserActivoDataGridView.AutoGenerateColumns = false;
            this.tbUserActivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserActivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUserActivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbUserActivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUserActivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.contraseniaDataGridViewImageColumn,
            this.nombreRolDataGridViewTextBoxColumn,
            this.estadoUsuarioDataGridViewTextBoxColumn});
            this.tbUserActivoDataGridView.DataSource = this.vwUsuariosActivosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbUserActivoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbUserActivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbUserActivoDataGridView.Location = new System.Drawing.Point(43, 58);
            this.tbUserActivoDataGridView.Name = "tbUserActivoDataGridView";
            this.tbUserActivoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUserActivoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbUserActivoDataGridView.RowHeadersWidth = 62;
            this.tbUserActivoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbUserActivoDataGridView.RowTemplate.Height = 35;
            this.tbUserActivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbUserActivoDataGridView.Size = new System.Drawing.Size(570, 350);
            this.tbUserActivoDataGridView.TabIndex = 1;
            this.tbUserActivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbUserActivoDataGridView_CellContentClick);
            // 
            // vwUsuariosActivosBindingSource
            // 
            this.vwUsuariosActivosBindingSource.DataMember = "vwUsuariosActivos";
            this.vwUsuariosActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwUsuariosActivosTableAdapter
            // 
            this.vwUsuariosActivosTableAdapter.ClearBeforeFill = true;
            // 
            // tbUserInactivoDataGridView
            // 
            this.tbUserInactivoDataGridView.AllowUserToAddRows = false;
            this.tbUserInactivoDataGridView.AllowUserToDeleteRows = false;
            this.tbUserInactivoDataGridView.AllowUserToResizeColumns = false;
            this.tbUserInactivoDataGridView.AllowUserToResizeRows = false;
            this.tbUserInactivoDataGridView.AutoGenerateColumns = false;
            this.tbUserInactivoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserInactivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUserInactivoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbUserInactivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUserInactivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn1,
            this.nombreUsuarioDataGridViewTextBoxColumn1,
            this.contraseniaDataGridViewImageColumn1,
            this.nombreRolDataGridViewTextBoxColumn1,
            this.estadoUsuarioDataGridViewTextBoxColumn1});
            this.tbUserInactivoDataGridView.DataSource = this.vwUsuariosInactivosBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbUserInactivoDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbUserInactivoDataGridView.EnableHeadersVisualStyles = false;
            this.tbUserInactivoDataGridView.Location = new System.Drawing.Point(47, 58);
            this.tbUserInactivoDataGridView.Name = "tbUserInactivoDataGridView";
            this.tbUserInactivoDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUserInactivoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbUserInactivoDataGridView.RowHeadersWidth = 62;
            this.tbUserInactivoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbUserInactivoDataGridView.RowTemplate.Height = 35;
            this.tbUserInactivoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbUserInactivoDataGridView.Size = new System.Drawing.Size(570, 350);
            this.tbUserInactivoDataGridView.TabIndex = 2;
            this.tbUserInactivoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbUserInactivoDataGridView_CellContentClick);
            // 
            // vwUsuariosInactivosBindingSource
            // 
            this.vwUsuariosInactivosBindingSource.DataMember = "vwUsuariosInactivos";
            this.vwUsuariosInactivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwUsuariosInactivosTableAdapter
            // 
            this.vwUsuariosInactivosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUserActivoDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(184, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 430);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios activos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUserInactivoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(927, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 430);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios inactivos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUser);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.btnEstado);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(430, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 200);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambiar estado";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(40, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(200, 47);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "- - -";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn1
            // 
            this.idUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idUsuarioDataGridViewTextBoxColumn1.Name = "idUsuarioDataGridViewTextBoxColumn1";
            this.idUsuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn1.Visible = false;
            this.idUsuarioDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn1
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreUsuarioDataGridViewTextBoxColumn1.Name = "nombreUsuarioDataGridViewTextBoxColumn1";
            this.nombreUsuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn1.Width = 250;
            // 
            // contraseniaDataGridViewImageColumn1
            // 
            this.contraseniaDataGridViewImageColumn1.DataPropertyName = "contrasenia";
            this.contraseniaDataGridViewImageColumn1.HeaderText = "contrasenia";
            this.contraseniaDataGridViewImageColumn1.MinimumWidth = 8;
            this.contraseniaDataGridViewImageColumn1.Name = "contraseniaDataGridViewImageColumn1";
            this.contraseniaDataGridViewImageColumn1.ReadOnly = true;
            this.contraseniaDataGridViewImageColumn1.Visible = false;
            this.contraseniaDataGridViewImageColumn1.Width = 150;
            // 
            // nombreRolDataGridViewTextBoxColumn1
            // 
            this.nombreRolDataGridViewTextBoxColumn1.DataPropertyName = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn1.HeaderText = "Rol";
            this.nombreRolDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreRolDataGridViewTextBoxColumn1.Name = "nombreRolDataGridViewTextBoxColumn1";
            this.nombreRolDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreRolDataGridViewTextBoxColumn1.Width = 250;
            // 
            // estadoUsuarioDataGridViewTextBoxColumn1
            // 
            this.estadoUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "estadoUsuario";
            this.estadoUsuarioDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoUsuarioDataGridViewTextBoxColumn1.Name = "estadoUsuarioDataGridViewTextBoxColumn1";
            this.estadoUsuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoUsuarioDataGridViewTextBoxColumn1.Visible = false;
            this.estadoUsuarioDataGridViewTextBoxColumn1.Width = 150;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 250;
            // 
            // contraseniaDataGridViewImageColumn
            // 
            this.contraseniaDataGridViewImageColumn.DataPropertyName = "contrasenia";
            this.contraseniaDataGridViewImageColumn.HeaderText = "contrasenia";
            this.contraseniaDataGridViewImageColumn.MinimumWidth = 8;
            this.contraseniaDataGridViewImageColumn.Name = "contraseniaDataGridViewImageColumn";
            this.contraseniaDataGridViewImageColumn.ReadOnly = true;
            this.contraseniaDataGridViewImageColumn.Visible = false;
            this.contraseniaDataGridViewImageColumn.Width = 150;
            // 
            // nombreRolDataGridViewTextBoxColumn
            // 
            this.nombreRolDataGridViewTextBoxColumn.DataPropertyName = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.nombreRolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreRolDataGridViewTextBoxColumn.Name = "nombreRolDataGridViewTextBoxColumn";
            this.nombreRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRolDataGridViewTextBoxColumn.Width = 250;
            // 
            // estadoUsuarioDataGridViewTextBoxColumn
            // 
            this.estadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "estadoUsuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoUsuarioDataGridViewTextBoxColumn.Name = "estadoUsuarioDataGridViewTextBoxColumn";
            this.estadoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoUsuarioDataGridViewTextBoxColumn.Visible = false;
            this.estadoUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmUserEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserEstados";
            this.Text = "Modificar estados";
            this.Load += new System.EventHandler(this.frmUserEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUserActivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserInactivoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosInactivosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tbUserActivoDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwUsuariosActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwUsuariosActivosTableAdapter vwUsuariosActivosTableAdapter;
        private System.Windows.Forms.DataGridView tbUserInactivoDataGridView;
        private System.Windows.Forms.BindingSource vwUsuariosInactivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwUsuariosInactivosTableAdapter vwUsuariosInactivosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn contraseniaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn contraseniaDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn1;
    }
}