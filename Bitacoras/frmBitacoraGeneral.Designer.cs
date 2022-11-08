
namespace RotacionInventario
{
    partial class frmBitacoraGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbBitGenerallDataGridView = new System.Windows.Forms.DataGridView();
            this.idBitacoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbBitacoraTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbBitacoraTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitGenerallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBitGenerallDataGridView
            // 
            this.tbBitGenerallDataGridView.AllowUserToAddRows = false;
            this.tbBitGenerallDataGridView.AllowUserToDeleteRows = false;
            this.tbBitGenerallDataGridView.AllowUserToResizeColumns = false;
            this.tbBitGenerallDataGridView.AllowUserToResizeRows = false;
            this.tbBitGenerallDataGridView.AutoGenerateColumns = false;
            this.tbBitGenerallDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbBitGenerallDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbBitGenerallDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbBitGenerallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBitGenerallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitacoraDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn,
            this.idDatoDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn});
            this.tbBitGenerallDataGridView.DataSource = this.tbBitacoraBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbBitGenerallDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbBitGenerallDataGridView.EnableHeadersVisualStyles = false;
            this.tbBitGenerallDataGridView.Location = new System.Drawing.Point(50, 60);
            this.tbBitGenerallDataGridView.Name = "tbBitGenerallDataGridView";
            this.tbBitGenerallDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbBitGenerallDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbBitGenerallDataGridView.RowHeadersWidth = 62;
            this.tbBitGenerallDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbBitGenerallDataGridView.RowTemplate.Height = 35;
            this.tbBitGenerallDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbBitGenerallDataGridView.Size = new System.Drawing.Size(1490, 740);
            this.tbBitGenerallDataGridView.TabIndex = 0;
            // 
            // idBitacoraDataGridViewTextBoxColumn
            // 
            this.idBitacoraDataGridViewTextBoxColumn.DataPropertyName = "idBitacora";
            this.idBitacoraDataGridViewTextBoxColumn.HeaderText = "No. de registro";
            this.idBitacoraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idBitacoraDataGridViewTextBoxColumn.Name = "idBitacoraDataGridViewTextBoxColumn";
            this.idBitacoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBitacoraDataGridViewTextBoxColumn.Width = 200;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 200;
            // 
            // tablaDataGridViewTextBoxColumn
            // 
            this.tablaDataGridViewTextBoxColumn.DataPropertyName = "tabla";
            this.tablaDataGridViewTextBoxColumn.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tablaDataGridViewTextBoxColumn.Name = "tablaDataGridViewTextBoxColumn";
            this.tablaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tablaDataGridViewTextBoxColumn.Width = 200;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "Accion";
            this.accionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            this.accionDataGridViewTextBoxColumn.Width = 200;
            // 
            // idDatoDataGridViewTextBoxColumn
            // 
            this.idDatoDataGridViewTextBoxColumn.DataPropertyName = "idDato";
            this.idDatoDataGridViewTextBoxColumn.HeaderText = "No. del dato";
            this.idDatoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDatoDataGridViewTextBoxColumn.Name = "idDatoDataGridViewTextBoxColumn";
            this.idDatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDatoDataGridViewTextBoxColumn.Width = 200;
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            this.datoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datoDataGridViewTextBoxColumn.Width = 200;
            // 
            // tbBitacoraBindingSource
            // 
            this.tbBitacoraBindingSource.DataMember = "tbBitacora";
            this.tbBitacoraBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBitacoraTableAdapter
            // 
            this.tbBitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbBitGenerallDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(40, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1590, 840);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora de cambios";
            // 
            // frmBitacoraGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "frmBitacoraGeneral";
            this.Text = "Bitacora general";
            this.Load += new System.EventHandler(this.frmBitacoraGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBitGenerallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbBitGenerallDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbBitacoraBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbBitacoraTableAdapter tbBitacoraTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
    }
}