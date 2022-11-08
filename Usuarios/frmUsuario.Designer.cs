
namespace RotacionInventario
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwUsuariosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwUsuariosActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwUsuariosActivosTableAdapter();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.vwRolesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vwRolesActivosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14F);
            this.label1.Location = new System.Drawing.Point(1107, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // tbUsuariosDataGridView
            // 
            this.tbUsuariosDataGridView.AllowUserToAddRows = false;
            this.tbUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.tbUsuariosDataGridView.AllowUserToResizeColumns = false;
            this.tbUsuariosDataGridView.AllowUserToResizeRows = false;
            this.tbUsuariosDataGridView.AutoGenerateColumns = false;
            this.tbUsuariosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbUsuariosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUsuariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tbUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.contraseniaDataGridViewImageColumn,
            this.nombreRolDataGridViewTextBoxColumn,
            this.estadoUsuarioDataGridViewTextBoxColumn});
            this.tbUsuariosDataGridView.DataSource = this.vwUsuariosActivosBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbUsuariosDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.tbUsuariosDataGridView.EnableHeadersVisualStyles = false;
            this.tbUsuariosDataGridView.Location = new System.Drawing.Point(52, 61);
            this.tbUsuariosDataGridView.Name = "tbUsuariosDataGridView";
            this.tbUsuariosDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUsuariosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.tbUsuariosDataGridView.RowHeadersWidth = 62;
            this.tbUsuariosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbUsuariosDataGridView.RowTemplate.Height = 35;
            this.tbUsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbUsuariosDataGridView.Size = new System.Drawing.Size(670, 500);
            this.tbUsuariosDataGridView.TabIndex = 10;
            this.tbUsuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbUsuariosDataGridView_CellContentClick);
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
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 300;
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
            this.nombreRolDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoUsuarioDataGridViewTextBoxColumn
            // 
            this.estadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "estadoUsuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.HeaderText = "estadoUsuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoUsuarioDataGridViewTextBoxColumn.Name = "estadoUsuarioDataGridViewTextBoxColumn";
            this.estadoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoUsuarioDataGridViewTextBoxColumn.Visible = false;
            this.estadoUsuarioDataGridViewTextBoxColumn.Width = 150;
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
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Lato", 18F);
            this.txtUser.Location = new System.Drawing.Point(1112, 191);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 51);
            this.txtUser.TabIndex = 1;
            // 
            // cmbRol
            // 
            this.cmbRol.DataSource = this.vwRolesActivosBindingSource;
            this.cmbRol.DisplayMember = "nombreRol";
            this.cmbRol.Font = new System.Drawing.Font("Lato", 18F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(1112, 517);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(300, 52);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.ValueMember = "idRol";
            // 
            // vwRolesActivosBindingSource
            // 
            this.vwRolesActivosBindingSource.DataMember = "vwRolesActivos";
            this.vwRolesActivosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F);
            this.label2.Location = new System.Drawing.Point(1107, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol del usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lato", 18F);
            this.txtPassword.Location = new System.Drawing.Point(1112, 297);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 51);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 14F);
            this.label3.Location = new System.Drawing.Point(1107, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // vwRolesActivosTableAdapter
            // 
            this.vwRolesActivosTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnRegistrar.Location = new System.Drawing.Point(1113, 628);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(300, 60);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "&Registrar usuario";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUsuariosDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(227, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 600);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 14F);
            this.label4.Location = new System.Drawing.Point(1107, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Repita la contraseña";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Lato", 18F);
            this.txtPassword2.Location = new System.Drawing.Point(1112, 403);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(300, 51);
            this.txtPassword2.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnLimpiar.Location = new System.Drawing.Point(1112, 694);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(300, 60);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsuariosActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRolesActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbUsuariosDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwUsuariosActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwUsuariosActivosTableAdapter vwUsuariosActivosTableAdapter;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource vwRolesActivosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwRolesActivosTableAdapter vwRolesActivosTableAdapter;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn contraseniaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}