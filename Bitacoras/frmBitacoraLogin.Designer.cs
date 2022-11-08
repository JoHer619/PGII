
namespace RotacionInventario
{
    partial class frmBitacoraLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBitGenerallDataGridView = new System.Windows.Forms.DataGridView();
            this.idBitacoraLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBitacoraLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbBitacoraLoginTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbBitacoraLoginTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitGenerallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitacoraLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tbBitGenerallDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14F);
            this.groupBox1.Location = new System.Drawing.Point(160, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1390, 840);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora de inicio de sesión";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbBitGenerallDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbBitGenerallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbBitGenerallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitacoraLoginDataGridViewTextBoxColumn,
            this.idUsuarioLogDataGridViewTextBoxColumn,
            this.fechaLogDataGridViewTextBoxColumn,
            this.usuarioLogDataGridViewTextBoxColumn});
            this.tbBitGenerallDataGridView.DataSource = this.tbBitacoraLoginBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbBitGenerallDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbBitGenerallDataGridView.EnableHeadersVisualStyles = false;
            this.tbBitGenerallDataGridView.Location = new System.Drawing.Point(50, 60);
            this.tbBitGenerallDataGridView.Name = "tbBitGenerallDataGridView";
            this.tbBitGenerallDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbBitGenerallDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbBitGenerallDataGridView.RowHeadersWidth = 62;
            this.tbBitGenerallDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tbBitGenerallDataGridView.RowTemplate.Height = 35;
            this.tbBitGenerallDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbBitGenerallDataGridView.Size = new System.Drawing.Size(1290, 740);
            this.tbBitGenerallDataGridView.TabIndex = 0;
            // 
            // idBitacoraLoginDataGridViewTextBoxColumn
            // 
            this.idBitacoraLoginDataGridViewTextBoxColumn.DataPropertyName = "idBitacoraLogin";
            this.idBitacoraLoginDataGridViewTextBoxColumn.HeaderText = "No. de registro";
            this.idBitacoraLoginDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idBitacoraLoginDataGridViewTextBoxColumn.Name = "idBitacoraLoginDataGridViewTextBoxColumn";
            this.idBitacoraLoginDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBitacoraLoginDataGridViewTextBoxColumn.Width = 300;
            // 
            // idUsuarioLogDataGridViewTextBoxColumn
            // 
            this.idUsuarioLogDataGridViewTextBoxColumn.DataPropertyName = "idUsuarioLog";
            this.idUsuarioLogDataGridViewTextBoxColumn.HeaderText = "Id de usuario";
            this.idUsuarioLogDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsuarioLogDataGridViewTextBoxColumn.Name = "idUsuarioLogDataGridViewTextBoxColumn";
            this.idUsuarioLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioLogDataGridViewTextBoxColumn.Width = 300;
            // 
            // fechaLogDataGridViewTextBoxColumn
            // 
            this.fechaLogDataGridViewTextBoxColumn.DataPropertyName = "fechaLog";
            this.fechaLogDataGridViewTextBoxColumn.HeaderText = "Fecha de ingreso";
            this.fechaLogDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaLogDataGridViewTextBoxColumn.Name = "fechaLogDataGridViewTextBoxColumn";
            this.fechaLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaLogDataGridViewTextBoxColumn.Width = 300;
            // 
            // usuarioLogDataGridViewTextBoxColumn
            // 
            this.usuarioLogDataGridViewTextBoxColumn.DataPropertyName = "usuarioLog";
            this.usuarioLogDataGridViewTextBoxColumn.HeaderText = "Usuario de ingreso";
            this.usuarioLogDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usuarioLogDataGridViewTextBoxColumn.Name = "usuarioLogDataGridViewTextBoxColumn";
            this.usuarioLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioLogDataGridViewTextBoxColumn.Width = 300;
            // 
            // tbBitacoraLoginBindingSource
            // 
            this.tbBitacoraLoginBindingSource.DataMember = "tbBitacoraLogin";
            this.tbBitacoraLoginBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBitacoraLoginTableAdapter
            // 
            this.tbBitacoraLoginTableAdapter.ClearBeforeFill = true;
            // 
            // frmBitacoraLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "frmBitacoraLogin";
            this.Text = "Bitacora de login";
            this.Load += new System.EventHandler(this.frmBitacoraLogin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBitGenerallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBitacoraLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tbBitGenerallDataGridView;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbBitacoraLoginBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbBitacoraLoginTableAdapter tbBitacoraLoginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacoraLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogDataGridViewTextBoxColumn;
    }
}