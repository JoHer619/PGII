
namespace RotacionInventario
{
    partial class frmCatEstados
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
            this.tbCatActivaDataGridView = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCategoriasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.vwCategoriasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter();
            this.tbCatInactivaDataGridView = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCategoriasInactivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCategoriasInactivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwCategoriasInactivasTableAdapter();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tbCategoriaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbCategoriaTableAdapter();
            this.tbCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbCatActivaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatInactivaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasInactivasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCatActivaDataGridView
            // 
            this.tbCatActivaDataGridView.AllowUserToAddRows = false;
            this.tbCatActivaDataGridView.AllowUserToDeleteRows = false;
            this.tbCatActivaDataGridView.AllowUserToResizeColumns = false;
            this.tbCatActivaDataGridView.AllowUserToResizeRows = false;
            this.tbCatActivaDataGridView.AutoGenerateColumns = false;
            this.tbCatActivaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbCatActivaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCatActivaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbCatActivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCatActivaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.descripcionCategoriaDataGridViewTextBoxColumn,
            this.estadoCategoriaDataGridViewTextBoxColumn});
            this.tbCatActivaDataGridView.DataSource = this.vwCategoriasActivasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCatActivaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbCatActivaDataGridView.EnableHeadersVisualStyles = false;
            this.tbCatActivaDataGridView.Location = new System.Drawing.Point(38, 56);
            this.tbCatActivaDataGridView.Name = "tbCatActivaDataGridView";
            this.tbCatActivaDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCatActivaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbCatActivaDataGridView.RowHeadersWidth = 62;
            this.tbCatActivaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbCatActivaDataGridView.RowTemplate.Height = 35;
            this.tbCatActivaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCatActivaDataGridView.Size = new System.Drawing.Size(670, 350);
            this.tbCatActivaDataGridView.TabIndex = 1;
            this.tbCatActivaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCatActivaDataGridView_CellContentClick);
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Visible = false;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // descripcionCategoriaDataGridViewTextBoxColumn
            // 
            this.descripcionCategoriaDataGridViewTextBoxColumn.DataPropertyName = "descripcionCategoria";
            this.descripcionCategoriaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionCategoriaDataGridViewTextBoxColumn.Name = "descripcionCategoriaDataGridViewTextBoxColumn";
            this.descripcionCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionCategoriaDataGridViewTextBoxColumn.Width = 400;
            // 
            // estadoCategoriaDataGridViewTextBoxColumn
            // 
            this.estadoCategoriaDataGridViewTextBoxColumn.DataPropertyName = "estadoCategoria";
            this.estadoCategoriaDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoCategoriaDataGridViewTextBoxColumn.Name = "estadoCategoriaDataGridViewTextBoxColumn";
            this.estadoCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoCategoriaDataGridViewTextBoxColumn.Visible = false;
            this.estadoCategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vwCategoriasActivasBindingSource
            // 
            this.vwCategoriasActivasBindingSource.DataMember = "vwCategoriasActivas";
            this.vwCategoriasActivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCategoriasActivasTableAdapter
            // 
            this.vwCategoriasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // tbCatInactivaDataGridView
            // 
            this.tbCatInactivaDataGridView.AllowUserToAddRows = false;
            this.tbCatInactivaDataGridView.AllowUserToDeleteRows = false;
            this.tbCatInactivaDataGridView.AllowUserToResizeColumns = false;
            this.tbCatInactivaDataGridView.AllowUserToResizeRows = false;
            this.tbCatInactivaDataGridView.AutoGenerateColumns = false;
            this.tbCatInactivaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbCatInactivaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCatInactivaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbCatInactivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCatInactivaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn1,
            this.nombreCategoriaDataGridViewTextBoxColumn1,
            this.descripcionCategoriaDataGridViewTextBoxColumn1,
            this.estadoCategoriaDataGridViewTextBoxColumn1});
            this.tbCatInactivaDataGridView.DataSource = this.vwCategoriasInactivasBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCatInactivaDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbCatInactivaDataGridView.EnableHeadersVisualStyles = false;
            this.tbCatInactivaDataGridView.Location = new System.Drawing.Point(42, 56);
            this.tbCatInactivaDataGridView.Name = "tbCatInactivaDataGridView";
            this.tbCatInactivaDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCatInactivaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbCatInactivaDataGridView.RowHeadersWidth = 62;
            this.tbCatInactivaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbCatInactivaDataGridView.RowTemplate.Height = 35;
            this.tbCatInactivaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCatInactivaDataGridView.Size = new System.Drawing.Size(670, 350);
            this.tbCatInactivaDataGridView.TabIndex = 2;
            this.tbCatInactivaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCatInactivaDataGridView_CellContentClick);
            // 
            // idCategoriaDataGridViewTextBoxColumn1
            // 
            this.idCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn1.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idCategoriaDataGridViewTextBoxColumn1.Name = "idCategoriaDataGridViewTextBoxColumn1";
            this.idCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn1.Visible = false;
            this.idCategoriaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn1
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreCategoriaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreCategoriaDataGridViewTextBoxColumn1.Name = "nombreCategoriaDataGridViewTextBoxColumn1";
            this.nombreCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn1.Width = 200;
            // 
            // descripcionCategoriaDataGridViewTextBoxColumn1
            // 
            this.descripcionCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "descripcionCategoria";
            this.descripcionCategoriaDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionCategoriaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.descripcionCategoriaDataGridViewTextBoxColumn1.Name = "descripcionCategoriaDataGridViewTextBoxColumn1";
            this.descripcionCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionCategoriaDataGridViewTextBoxColumn1.Width = 400;
            // 
            // estadoCategoriaDataGridViewTextBoxColumn1
            // 
            this.estadoCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "estadoCategoria";
            this.estadoCategoriaDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoCategoriaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.estadoCategoriaDataGridViewTextBoxColumn1.Name = "estadoCategoriaDataGridViewTextBoxColumn1";
            this.estadoCategoriaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoCategoriaDataGridViewTextBoxColumn1.Visible = false;
            this.estadoCategoriaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vwCategoriasInactivasBindingSource
            // 
            this.vwCategoriasInactivasBindingSource.DataMember = "vwCategoriasInactivas";
            this.vwCategoriasInactivasBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // vwCategoriasInactivasTableAdapter
            // 
            this.vwCategoriasInactivasTableAdapter.ClearBeforeFill = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCatActivaDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(64, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 440);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias activas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCatInactivaDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox2.Location = new System.Drawing.Point(884, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 440);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias inactivas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCategoria);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.btnEstado);
            this.groupBox3.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox3.Location = new System.Drawing.Point(430, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 200);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambiar estado";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(40, 80);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(200, 52);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "- - -";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCategoriaTableAdapter
            // 
            this.tbCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tbCategoriaBindingSource
            // 
            this.tbCategoriaBindingSource.DataMember = "tbCategoria";
            this.tbCategoriaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // frmCatEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCatEstados";
            this.Text = "Modificar estado";
            this.Load += new System.EventHandler(this.frmCatEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCatActivaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatInactivaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasInactivasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tbCatActivaDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource vwCategoriasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter vwCategoriasActivasTableAdapter;
        private System.Windows.Forms.DataGridView tbCatInactivaDataGridView;
        private System.Windows.Forms.BindingSource vwCategoriasInactivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwCategoriasInactivasTableAdapter vwCategoriasInactivasTableAdapter;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private BD_INVENTARIODataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource tbCategoriaBindingSource;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoriaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoriaDataGridViewTextBoxColumn;
    }
}