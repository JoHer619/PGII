
namespace RotacionInventario.Reportes
{
    partial class frmProdComprado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdComprados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.spProductosMasCompradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spProductosMasCompradosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spProductosMasCompradosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasCompradosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdComprados
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProdComprados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProdComprados.Legends.Add(legend3);
            this.chartProdComprados.Location = new System.Drawing.Point(12, 12);
            this.chartProdComprados.Name = "chartProdComprados";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProdComprados.Series.Add(series3);
            this.chartProdComprados.Size = new System.Drawing.Size(1632, 890);
            this.chartProdComprados.TabIndex = 0;
            this.chartProdComprados.Text = "chart1";
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spProductosMasCompradosBindingSource
            // 
            this.spProductosMasCompradosBindingSource.DataMember = "spProductosMasComprados";
            this.spProductosMasCompradosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // spProductosMasCompradosTableAdapter
            // 
            this.spProductosMasCompradosTableAdapter.ClearBeforeFill = true;
            // 
            // frmProdComprado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.chartProdComprados);
            this.Name = "frmProdComprado";
            this.Text = "Productos más comprados";
            this.Load += new System.EventHandler(this.frmProdComprado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasCompradosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdComprados;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource spProductosMasCompradosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spProductosMasCompradosTableAdapter spProductosMasCompradosTableAdapter;
    }
}