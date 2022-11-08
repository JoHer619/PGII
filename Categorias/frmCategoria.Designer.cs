
namespace RotacionInventario
{
    partial class frmCategoria
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
            this.tbCategoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCategoriasActivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCategoriaTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbCategoriaTableAdapter();
            this.vwCategoriasActivasTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCategoriasDataGridView
            // 
            this.tbCategoriasDataGridView.AllowUserToAddRows = false;
            this.tbCategoriasDataGridView.AllowUserToDeleteRows = false;
            this.tbCategoriasDataGridView.AllowUserToResizeColumns = false;
            this.tbCategoriasDataGridView.AllowUserToResizeRows = false;
            this.tbCategoriasDataGridView.AutoGenerateColumns = false;
            this.tbCategoriasDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbCategoriasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCategoriasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbCategoriasDataGridView.ColumnHeadersHeight = 40;
            this.tbCategoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.descripcionCategoriaDataGridViewTextBoxColumn,
            this.estadoCategoriaDataGridViewTextBoxColumn});
            this.tbCategoriasDataGridView.DataSource = this.vwCategoriasActivasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCategoriasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbCategoriasDataGridView.EnableHeadersVisualStyles = false;
            this.tbCategoriasDataGridView.Location = new System.Drawing.Point(60, 56);
            this.tbCategoriasDataGridView.Name = "tbCategoriasDataGridView";
            this.tbCategoriasDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCategoriasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbCategoriasDataGridView.RowHeadersWidth = 62;
            this.tbCategoriasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbCategoriasDataGridView.RowTemplate.Height = 35;
            this.tbCategoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCategoriasDataGridView.Size = new System.Drawing.Size(870, 400);
            this.tbCategoriasDataGridView.TabIndex = 0;
            this.tbCategoriasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCategoriasDataGridView_CellContentClick);
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
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 300;
            // 
            // descripcionCategoriaDataGridViewTextBoxColumn
            // 
            this.descripcionCategoriaDataGridViewTextBoxColumn.DataPropertyName = "descripcionCategoria";
            this.descripcionCategoriaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionCategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionCategoriaDataGridViewTextBoxColumn.Name = "descripcionCategoriaDataGridViewTextBoxColumn";
            this.descripcionCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionCategoriaDataGridViewTextBoxColumn.Width = 500;
            // 
            // estadoCategoriaDataGridViewTextBoxColumn
            // 
            this.estadoCategoriaDataGridViewTextBoxColumn.DataPropertyName = "estadoCategoria";
            this.estadoCategoriaDataGridViewTextBoxColumn.HeaderText = "estadoCategoria";
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
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Lato", 18F);
            this.txtNombre.Location = new System.Drawing.Point(1189, 206);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 51);
            this.txtNombre.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F);
            this.label2.Location = new System.Drawing.Point(1183, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Font = new System.Drawing.Font("Lato", 18F);
            this.rtbDescripcion.Location = new System.Drawing.Point(1189, 316);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(300, 80);
            this.rtbDescripcion.TabIndex = 77;
            this.rtbDescripcion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 14F);
            this.label6.Location = new System.Drawing.Point(1183, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 34);
            this.label6.TabIndex = 76;
            this.label6.Text = "Descripcion";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnActualizar.Location = new System.Drawing.Point(1189, 539);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(300, 60);
            this.btnActualizar.TabIndex = 79;
            this.btnActualizar.Text = "&Actualizar categoria";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnRegistrar.Location = new System.Drawing.Point(1189, 469);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(300, 60);
            this.btnRegistrar.TabIndex = 78;
            this.btnRegistrar.Text = "&Registrar categoria";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbCategoriaBindingSource
            // 
            this.tbCategoriaBindingSource.DataMember = "tbCategoria";
            this.tbCategoriaBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbCategoriaTableAdapter
            // 
            this.tbCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // vwCategoriasActivasTableAdapter
            // 
            this.vwCategoriasActivasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbCategoriasDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(130, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 500);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Lato", 14F);
            this.btnLimpiar.Location = new System.Drawing.Point(1189, 607);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(300, 60);
            this.btnLimpiar.TabIndex = 81;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 724);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "frmCategoria";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriasActivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbCategoriasDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbCategoriaBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource vwCategoriasActivasBindingSource;
        private BD_INVENTARIODataSetTableAdapters.vwCategoriasActivasTableAdapter vwCategoriasActivasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpiar;
    }
}